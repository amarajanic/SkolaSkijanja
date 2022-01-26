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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

    
 

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            

            var p = dtpPocetak.Value.Date;

            var k = dtpKraj.Value.Date;

            var imePrezime = cbInstruktori.Text.Split(" ");




            var pocetak = new NpgsqlParameter("pocetak", NpgsqlTypes.NpgsqlDbType.Date);

            var kraj = new NpgsqlParameter("kraj", NpgsqlTypes.NpgsqlDbType.Date);

            var ime = new NpgsqlParameter("ime", NpgsqlTypes.NpgsqlDbType.Varchar);

            var prezime = new NpgsqlParameter("prezime", NpgsqlTypes.NpgsqlDbType.Varchar);



            pocetak.Value = p;

            kraj.Value = k;


            ime.Value = imePrezime[0];
            prezime.Value = imePrezime[1];




            var instrukcije = db.InstrukcijaPocetnaModels.FromSqlRaw("select * from fn_Instruktor_ime_prezime_datum(@ime,@prezime,@pocetak,@kraj)",ime,prezime,pocetak,kraj).ToList();

            dgvInstrukcije.DataSource = instrukcije;

            dgvInstrukcije.Columns["id"].Visible = false;
            dgvInstrukcije.Columns["InstruktorId"].Visible = false;

           
           
            DataGridViewColumn akcija = new DataGridViewColumn();

            //akcija.

            //dgvInstrukcije.Columns.Add("Action", "Action");










        }

        private void btnDodajInstrukciju_Click(object sender, EventArgs e)
        {
            frmInstrukcija frm = new frmInstrukcija();
            frm.ShowDialog();
        }

        private void cbInstruktori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvInstrukcije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex>=0)
            {
                if (senderGrid.Columns[e.ColumnIndex] == dgvInstrukcije.Columns["dgvBtnDetalji"])
                {
                    DataGridViewRow row = dgvInstrukcije.Rows[e.RowIndex];

                    var Id = (int)row.Cells[3].Value; //za sada

                    frmInstrukcijaDetalji frm = new frmInstrukcijaDetalji(Id);

                    frm.Show();
                }
                else if (senderGrid.Columns[e.ColumnIndex] == dgvInstrukcije.Columns["dgvBtnPromijeni"])
                {
                    DataGridViewRow row = dgvInstrukcije.Rows[e.RowIndex];

                    var instrukcijaId = (int)row.Cells[3].Value; //za sada

                    var instruktorId = int.Parse(row.Cells[10].Value.ToString());

                    frmInstrukcijaEdit frm = new frmInstrukcijaEdit(instrukcijaId,instruktorId);

                    frm.Show();



                    MessageBox.Show("Test");
                }
                else if(senderGrid.Columns[e.ColumnIndex] == dgvInstrukcije.Columns["dgvBtnUcenici"])
                {
                    DataGridViewRow row = dgvInstrukcije.Rows[e.RowIndex];

                    var instrukcijaId = (int)row.Cells[3].Value; //za sada

                    frmInstrukcijaUcenik frm = new frmInstrukcijaUcenik(instrukcijaId);

                    frm.Show();
                }

              
            }

           
        }
    }
}
