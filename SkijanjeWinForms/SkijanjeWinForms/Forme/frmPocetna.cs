using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Windows;

namespace UI.Forme
{
    public partial class frmPocetna : Form
    {
        skijanje_dbContext db;

        public frmPocetna()
        {
            InitializeComponent();
             db = new skijanje_dbContext();

        }

        public void frmPocetna_Load(object sender, EventArgs e)
        {
            var instruktori = db.Instruktors.ToList();

            var cbInstruktor = instruktori.Select(x => new InstruktorModel
            {
                Id = x.Id,
                ImePrezime = x.Ime + ' ' + x.Prezime
            }).ToList();

            
            cbInstruktori.DisplayMember = "ImePrezime";

            cbInstruktori.DataSource = cbInstruktor;

            cbInstruktori.SelectedIndex = -1;

            dtpPocetak.Value = DateTime.Today;

            dtpKraj.Value = DateTime.Today.AddDays(6);

            RefreshDataGrid();

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {     
            RefreshDataGrid();
        }

        private void btnDodajInstrukciju_Click(object sender, EventArgs e)
        {       
            frmInstrukcija frm = new frmInstrukcija();
            frm.FormClosing += new FormClosingEventHandler(InstrukcijaFormClosing);
            frm.ShowDialog();            
        }

        private void InstrukcijaFormClosing(object sender, FormClosingEventArgs e)
        {
            if(dgvInstrukcije.DataSource!=null)
            {
                RefreshDataGrid();
            }
        }

        private void InstrukcijaEditFormClosing(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void dgvInstrukcije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if(dgvInstrukcije.DataSource!=null)
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    if (senderGrid.Columns[e.ColumnIndex] == dgvInstrukcije.Columns["dgvBtnDetalji"])
                    {
                        DataGridViewRow row = dgvInstrukcije.Rows[e.RowIndex];

                        var Id = (int)row.Cells[4].Value; 

                        frmInstrukcijaDetalji frm = new frmInstrukcijaDetalji(Id);

                        frm.Show();
                    }
                    else if (senderGrid.Columns[e.ColumnIndex] == dgvInstrukcije.Columns["dgvBtnPromijeni"])
                    {
                        DataGridViewRow row = dgvInstrukcije.Rows[e.RowIndex];

                        var instrukcijaId = (int)row.Cells[4].Value; 

                        var instruktorId = int.Parse(row.Cells[11].Value.ToString());

                        frmInstrukcijaEdit frm = new frmInstrukcijaEdit(instrukcijaId, instruktorId);
                        frm.FormClosing += new FormClosingEventHandler(InstrukcijaEditFormClosing);

                        frm.Show();

                    }
                    else if (senderGrid.Columns[e.ColumnIndex] == dgvInstrukcije.Columns["dgvBtnUcenici"])
                    {
                        DataGridViewRow row = dgvInstrukcije.Rows[e.RowIndex];

                        var instrukcijaId = (int)row.Cells[4].Value; 

                        frmInstrukcijaUcenik frm = new frmInstrukcijaUcenik(instrukcijaId);
                        frm.FormClosing += new FormClosingEventHandler(InstrukcijaEditFormClosing);

                        frm.Show();
                    }
                    else if (senderGrid.Columns[e.ColumnIndex] == dgvInstrukcije.Columns["dgvBtnObrisi"])
                    {
                        DialogResult dialogResult = MessageBox.Show("Jeste sigurni da želite obrisati taj zapis?", "Potvrda brisanja", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            var identifikator = new NpgsqlParameter("identifikator", NpgsqlTypes.NpgsqlDbType.Integer);

                            DataGridViewRow row = dgvInstrukcije.Rows[e.RowIndex];

                            var instrukcijaId = (int)row.Cells[4].Value; 

                            identifikator.Value = instrukcijaId;

                            try
                            {
                                db.Database.ExecuteSqlRaw("select * from fn_Instrukcija_delete(@identifikator)", identifikator);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Trenutno nije moguće obrisati podatke!", "Greška");
                            }


                            RefreshDataGrid();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                }
            }

        }

        private void RefreshDataGrid()
        {
            dgvInstrukcije.DataSource = null;

            var p = dtpPocetak.Value.Date;

            var k = dtpKraj.Value.Date;

            var imePrezime = cbInstruktori.Text.Split(" ");


            var pocetak = new NpgsqlParameter("pocetak", NpgsqlTypes.NpgsqlDbType.Date);

            var kraj = new NpgsqlParameter("kraj", NpgsqlTypes.NpgsqlDbType.Date);

            var ime = new NpgsqlParameter("ime", NpgsqlTypes.NpgsqlDbType.Varchar);

            var prezime = new NpgsqlParameter("prezime", NpgsqlTypes.NpgsqlDbType.Varchar);



            pocetak.Value = p;
            kraj.Value = k;

            if (!string.IsNullOrEmpty(imePrezime[0]) && !string.IsNullOrEmpty(imePrezime[1]))
            {
                ime.Value = imePrezime[0];
                prezime.Value = imePrezime[1];
            }
            else
            {
                ime.Value = string.Empty;
                prezime.Value = string.Empty;
            }

            try
            {
                var instrukcije = db.InstrukcijaPocetnaModels.FromSqlRaw("select * from fn_Instruktor_select_by_ime_prezime_datum(@ime,@prezime,@pocetak,@kraj)", ime, prezime, pocetak, kraj).ToList();
                dgvInstrukcije.DataSource = instrukcije;
                dgvInstrukcije.Columns["id"].Visible = false;
                dgvInstrukcije.Columns["InstruktorId"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Trenutno nije moguće dohvatiti podatke!","Greška");
            }
            
        }
    }
}
