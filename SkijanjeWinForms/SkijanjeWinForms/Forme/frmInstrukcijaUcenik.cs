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
            var identifikator = new NpgsqlParameter("identifikator", NpgsqlTypes.NpgsqlDbType.Integer);

            identifikator.Value = instrukcijaId;

            //var ucenici = db.UcenikModels.FromSqlRaw("select * from fn_Unenik_select_by_instrukcija_id(@identifikator)", identifikator).ToList();

            var uceniciEnt = db.Uceniks.ToList();
            var ucenici = uceniciEnt.Select(x => new UcenikModel
            {
                Id = x.Id,
                Ime = x.Ime,
                Prezime = x.Prezime,
                Dat_Rodj = x.DatRodj,
                Kontakt_Tel = x.KontaktTel,
                Spol = x.Spol
            }).ToList();
       

            dgvUcenici.DataSource = ucenici;

            dgvUcenici.Columns["id"].Visible = false;
        }

        private void dtnDodajUcenika_Click(object sender, EventArgs e)
        {
            frmUcenikDodaj frm = new frmUcenikDodaj();
            frm.Show();
        }

        private void btnDostupniUc_Click(object sender, EventArgs e)
        {

        }

        private void dgvUcenici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
