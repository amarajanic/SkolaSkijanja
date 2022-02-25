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
using Windows.UI.Xaml.Controls;

namespace UI.Forme
{
    public partial class frmInstrukcijaEdit : Form
    {
        skijanje_dbContext db;
        private int instrukcijaId;
        private int instruktorId;

        public frmInstrukcijaEdit(int instrukcijaId, int instruktorId)
        {
            InitializeComponent();
            db = new skijanje_dbContext();
            this.instrukcijaId = instrukcijaId;
            this.instruktorId = instruktorId;
        }

        private void frmInstrukcijaEdit_Load(object sender, EventArgs e)
        {
            var instruktori = db.Instruktors.ToList();

            var instrukcija = new InstrukcijaModel();

            var cbInstruktor = instruktori.Select(x => new InstruktorModel
            {
                Id = x.Id,
                ImePrezime = x.Ime + ' ' + x.Prezime
            }).ToList();


            var instrukcija_id = new NpgsqlParameter("instrukcija_id", NpgsqlTypes.NpgsqlDbType.Integer);

            instrukcija_id.Value = instrukcijaId;

            try
            {
                instrukcija = db.InstrukcijaModels.FromSqlRaw("select * from fn_Instrukcija_select_by_id(@instrukcija_id)", instrukcija_id).ToList().First();
                dtpDatum.Text = instrukcija.Dat_Odr.ToString();
                dtvTermin.Text = instrukcija.Termin.ToString();
                nudBrCas.Text = instrukcija.Br_Cas.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Trenutno nije moguće preuzeti instrukcije!","Greška");
            }
       
            var selectedInstruktor = db.Instruktors.Where(x => x.Id == instruktorId).ToList();

            var instruktorModel = selectedInstruktor.Select(x => new InstruktorModel
            {
                Id = x.Id,
                ImePrezime = x.Ime + " " + x.Prezime
            }).First();
      
           
            cbInstruktori.DataSource = cbInstruktor;
            cbInstruktori.DisplayMember = "ImePrezime";
           
            if (cbInstruktori.SelectedItem as InstruktorModel != instruktorModel)
            {
               cbInstruktori.SelectedText = null;
               cbInstruktori.Text = instruktorModel.ImePrezime;
            }
                    
            rtbBiljeske.Text = instrukcija.Biljeske;
        }

        private void btnDodajInstrukciju_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var identifikator = new NpgsqlParameter("identifikator", NpgsqlTypes.NpgsqlDbType.Integer);
                var d = new NpgsqlParameter("d", NpgsqlTypes.NpgsqlDbType.Date);
                var t = new NpgsqlParameter("t", NpgsqlTypes.NpgsqlDbType.Time);
                var bc = new NpgsqlParameter("bc", NpgsqlTypes.NpgsqlDbType.Integer);
                var b = new NpgsqlParameter("b", NpgsqlTypes.NpgsqlDbType.Text);
                var instruktor_id = new NpgsqlParameter("instruktor_id", NpgsqlTypes.NpgsqlDbType.Integer);

                identifikator.Value = instrukcijaId;
                d.Value = dtpDatum.Value.Date;
                t.Value = dtvTermin.Value.TimeOfDay;
                bc.Value = nudBrCas.Value;
                b.Value = rtbBiljeske.Text;

                var imePrezime = cbInstruktori.Text.Split(" ");

                instruktor_id.Value = db.Instruktors.Where(x => x.Ime == imePrezime[0] && x.Prezime == imePrezime[1]).Select(x => x.Id).ToList().First();
                try
                {
                    db.Database.ExecuteSqlRaw("select * from fn_Instrukcija_update(@identifikator,@d,@t,@bc,@b,@instruktor_id)", identifikator, d, t, bc, b, instruktor_id);
                    MessageBox.Show("Instrukcija je uspješno uređena!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Trenutno nije moguće urediti instrukciju!", "Greška");
                }

                this.Close();
            }
           

        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            dtpDatum.Value = DateTime.Today;
            dtvTermin.Value = DateTime.Now;
            nudBrCas.Value = 0;
            rtbBiljeske.Text = String.Empty;
            cbInstruktori.SelectedIndex = -1;
        }

        private void nudBrCas_Validating(object sender, CancelEventArgs e)
        {
            if (nudBrCas.Value <= 0)
            {
                e.Cancel = true;
                nudBrCas.Focus();
                epBrojCas.SetError(nudBrCas, "Broj časova ne može biti manji ili jednak 0");
            }
            else
            {
                e.Cancel = false;
                epBrojCas.SetError(nudBrCas, "");
            }
        }

        private void rtbBiljeske_Validating(object sender, CancelEventArgs e)
        {
            if (rtbBiljeske.Text == String.Empty)
            {
                e.Cancel = true;
                rtbBiljeske.Focus();
                epBiljeske.SetError(rtbBiljeske, "Polje bilješke ne može ostati prazno");
            }
            else
            {
                e.Cancel = false;
                epBiljeske.SetError(rtbBiljeske, "");

            }
        }

        private void cbInstruktori_Validating(object sender, CancelEventArgs e)
        {
            if (cbInstruktori.SelectedIndex <= -1)
            {
                e.Cancel = true;
                cbInstruktori.Focus();
                epInstruktor.SetError(cbInstruktori, "Morate odabrati instruktora");
            }
            else
            {
                e.Cancel = false;
                epInstruktor.SetError(cbInstruktori, "");
            }
        }
    }
}
