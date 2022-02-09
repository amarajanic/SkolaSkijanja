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
    public partial class frmInstrukcijaDetalji : Form
    {
        skijanje_dbContext db;
        private int id;


        public frmInstrukcijaDetalji(int id)
        {
            InitializeComponent();
            db = new skijanje_dbContext();
            this.id = id;

        }

        private void frmInstrukcijaDetalji_Load(object sender, EventArgs e)
        {
           var identifikator = new NpgsqlParameter("identifikator", NpgsqlTypes.NpgsqlDbType.Integer);

           identifikator.Value = id;

           var instrukcija = db.InstrukcijaModels.FromSqlRaw("select * from fn_Instrukcija_select_by_id(@identifikator)", identifikator).ToList().First();

   

           tbImePrezime.Text = instrukcija.Ime + " " + instrukcija.Prezime;
           tbDatum.Text = instrukcija.Dat_Odr.ToString();
           tbVrijeme.Text = instrukcija.Termin.ToString();
           tbBrojCas.Text = instrukcija.Br_Cas.ToString();
           tbBrojUcen.Text = instrukcija.Br_Ucen.ToString();
           rtbBiljeske.Text = instrukcija.Biljeske;

            var ucenici = db.UcenikModels.FromSqlRaw("select * from fn_Unenik_select_by_instrukcija_id(@identifikator)", identifikator).ToList();

            dgvUcenici.DataSource = ucenici;

            dgvUcenici.Columns["id"].Visible = false;

        }
    }
}
