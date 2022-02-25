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
    public partial class frmInstrukcijaUcenik : Form
    {
        skijanje_dbContext db;
        private int instrukcijaId;
        public frmInstrukcijaUcenik(int id)
        {
            InitializeComponent();
            db = new skijanje_dbContext();
            instrukcijaId = id;
        }

        private void frmInstrukcijaUcenik_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void dtnDodajUcenika_Click(object sender, EventArgs e)
        {
            frmDostupniUcenici frm = new frmDostupniUcenici(instrukcijaId);
            frm.FormClosing += new FormClosingEventHandler(UcenikDodajFormClosing);
            frm.Show();
        }

        private void UcenikDodajFormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dgvUcenici.DataSource = null;

            var identifikator = new NpgsqlParameter("identifikator", NpgsqlTypes.NpgsqlDbType.Integer);

            identifikator.Value = instrukcijaId;

            try
            {
                var ucenici = db.UcenikModels.FromSqlRaw("select * from fn_Ucenik_select_by_instrukcija_id(@identifikator)", identifikator).ToList();

                dgvUcenici.DataSource = ucenici;

                dgvUcenici.Columns["id"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Trenutno nije moguće preuzeti učenike!", "Greška");
            }

           
        }
    }
}
