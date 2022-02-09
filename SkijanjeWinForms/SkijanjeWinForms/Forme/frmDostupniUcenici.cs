using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forme
{
    public partial class frmDostupniUcenici : Form
    {
        skijanje_dbContext db;
        int instrukcijaId;
        List<UcenikModel> uceniciSvi;
        public frmDostupniUcenici(int id)
        {
            InitializeComponent();
            db = new skijanje_dbContext();
            instrukcijaId = id;
            uceniciSvi = new List<UcenikModel>();
        }

        private void btnNoviUcenik_Click(object sender, EventArgs e)
        {
            frmUcenikDodaj frm = new frmUcenikDodaj();
            frm.FormClosing += new FormClosingEventHandler(UcenikDodajFormClosing);
            frm.Show();
        }

        private void UcenikDodajFormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvDostupniUcenici.DataSource != null)
            {
                RefreshGrid();             
            }


        }

        private void frmDostupniUcenici_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        void RefreshGrid()
        {
            var list = db.Uceniks.ToList();

            uceniciSvi = list.Select(x => new UcenikModel()
            {
                Id = x.Id,
                Ime = x.Ime,
                Prezime = x.Prezime,
                Dat_Rodj = x.DatRodj,
                Kontakt_Tel = x.KontaktTel,
                Spol = x.Spol
            }).ToList();

            var identifikator = new NpgsqlParameter("identifikator", NpgsqlTypes.NpgsqlDbType.Integer);

            identifikator.Value = instrukcijaId;

            var ucenici = db.UcenikModels.FromSqlRaw("select * from fn_Ucenik_select_by_instrukcija_id(@identifikator)", identifikator).ToList();


            for (int i = 0; i < ucenici.Count; i++)
            {
                for (int j = 0; j < uceniciSvi.Count; j++)
                {
                    if (uceniciSvi[j].Id == ucenici[i].Id)
                    {
                        uceniciSvi.RemoveAt(j);
                    }
                }
            }

            dgvDostupniUcenici.DataSource = uceniciSvi;
            dgvDostupniUcenici.Columns["id"].Visible = false;

        }

        private void dgvDostupniUcenici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;


            if (dgvDostupniUcenici.DataSource != null)
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    if (senderGrid.Columns[e.ColumnIndex] == dgvDostupniUcenici.Columns["dgvBtnOdaberi"])
                    {
                        DataGridViewRow row = dgvDostupniUcenici.Rows[e.RowIndex];

                        var ucenikId = (int)row.Cells[1].Value; //za sada

                        var ucenik_id = new NpgsqlParameter("ucenik_id", NpgsqlTypes.NpgsqlDbType.Integer);
                        var instrukcija_id = new NpgsqlParameter("instrukcija_id", NpgsqlTypes.NpgsqlDbType.Integer);

                        ucenik_id.Value = ucenikId;
                        instrukcija_id.Value = instrukcijaId;


                        db.Database.ExecuteSqlRaw("select * from fn_Ucenik_instrukcija_insert(@ucenik_id,@instrukcija_id)", ucenik_id, instrukcija_id);


                        RefreshGrid();

                    }
                }
            }
        }
    }
}
