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
using Windows.UI.Xaml.Controls;

namespace UI.Forme
{
    public partial class frmInstrukcija : Form
    {
        skijanje_dbContext db;
        public frmInstrukcija()
        {
            InitializeComponent();
            db = new skijanje_dbContext();
        }

        private void btnDodajInstruktora_Click(object sender, EventArgs e)
        {
            frmInstruktor frm = new frmInstruktor();
            frm.FormClosing += new FormClosingEventHandler(InstruktorFormClosing);
            frm.ShowDialog();
        }

        private void InstruktorFormClosing(object sender, FormClosingEventArgs e)
        {
            PopulateComboBox();
        }

        private void btnDodajInstrukciju_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                var datum_odr = new NpgsqlParameter("datum_odr", NpgsqlTypes.NpgsqlDbType.Date);
                var termin = new NpgsqlParameter("termin", NpgsqlTypes.NpgsqlDbType.Time);
                var broj_cas = new NpgsqlParameter("broj_cas", NpgsqlTypes.NpgsqlDbType.Integer);
                var biljeske = new NpgsqlParameter("biljeske", NpgsqlTypes.NpgsqlDbType.Text);
                var instruktorId = new NpgsqlParameter("instruktorId", NpgsqlTypes.NpgsqlDbType.Integer);

                var d = dtpDatum.Value.Date;
                var t = dtvTermin.Value.TimeOfDay;
                var c = nudBrCas.Value;
                var b = rtbBiljeske.Text;

                datum_odr.Value = d;
                termin.Value = t;
                broj_cas.Value = c;
                biljeske.Value = b;

                var selectedItem = cbInstruktori.SelectedItem as InstruktorModel;

                instruktorId.Value = selectedItem.Id;

                try
                {
                    db.Database.ExecuteSqlRaw("select * from fn_Instrukcija_insert(@datum_odr,@termin,@broj_cas,@biljeske,@instruktorId)", datum_odr, termin, broj_cas, biljeske, instruktorId);

                    MessageBox.Show("Instrukcija je uspješno dodana!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Trenutno nije moguće dodati instrukciju!", "Greška");
                }

                this.Close();
            }
            
        }

        private void frmInstrukcija_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        void PopulateComboBox()
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
            if(nudBrCas.Value <= 0)
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

        private void cbInstruktori_Validating(object sender, CancelEventArgs e)
        {
            if(cbInstruktori.SelectedIndex <= -1)
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

        private void rtbBiljeske_Validating(object sender, CancelEventArgs e)
        {
            if(rtbBiljeske.Text == String.Empty)
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
    }
}
