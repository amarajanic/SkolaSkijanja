using DataAccess;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forme
{
    public partial class frmInstruktor : Form
    {
        byte[] bufferCv;
        skijanje_dbContext db;
        public frmInstruktor()
        {
            InitializeComponent();
            db = new skijanje_dbContext();
        }

        private void btnCvUpload_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            tbFileName.Text = dialog.SafeFileName;

            bufferCv = File.ReadAllBytes(dialog.FileName);
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var ime = new NpgsqlParameter("ime", NpgsqlTypes.NpgsqlDbType.Varchar);
                var prezime = new NpgsqlParameter("prezime", NpgsqlTypes.NpgsqlDbType.Varchar);
                var dat_rodj = new NpgsqlParameter("dat_rodj", NpgsqlTypes.NpgsqlDbType.Date);
                var spol = new NpgsqlParameter("spol", NpgsqlTypes.NpgsqlDbType.Varchar);
                var kontakt_tel = new NpgsqlParameter("kontakt_tel", NpgsqlTypes.NpgsqlDbType.Varchar);
                var skij_isk = new NpgsqlParameter("skij_isk", NpgsqlTypes.NpgsqlDbType.Date);
                var biografija = new NpgsqlParameter("biografija", NpgsqlTypes.NpgsqlDbType.Text);
                var cv = new NpgsqlParameter("cv", NpgsqlTypes.NpgsqlDbType.Bytea);

                var i = tbIme.Text;
                var p = tbPrezime.Text;
                var dr = dtpDatRodj.Value.Date;
                var s = cbSpol.SelectedItem.ToString();
                var t = tbTelefon.Text;
                var isk = dtpIskustvo.Value.Date;
                var b = rtbBiografija.Text;
                var c = bufferCv;

                ime.Value = i;
                prezime.Value = p;
                dat_rodj.Value = dr;
                spol.Value = s;
                kontakt_tel.Value = t;
                skij_isk.Value = isk;
                biografija.Value = b;
                cv.Value = c;

                try
                {
                    db.Database.ExecuteSqlRaw("select * from fn_Instruktor_insert(@ime,@prezime,@dat_rodj,@spol,@kontakt_tel,@skij_isk,@biografija,@cv)", ime, prezime, dat_rodj, spol, kontakt_tel, skij_isk, biografija, cv);

                    MessageBox.Show("Uspješno ste dodali novog instruktora!");
                }
                catch (Exception)
                {

                    MessageBox.Show("Trenutno nije moguće spasiti instruktora!", "Greška");
                }

                this.Close();
            }
            
        }

        private void frmInstruktor_Load(object sender, EventArgs e)
        {
            cbSpol.Items.AddRange(new string[] { "Muško", "Žensko" });

            cbSpol.SelectedIndex = -1;
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            tbIme.Text = String.Empty;
            tbPrezime.Text = String.Empty;
            dtpDatRodj.Value = DateTime.Now;
            cbSpol.SelectedIndex = -1;
            tbTelefon.Text = String.Empty;
            dtpIskustvo.Value = DateTime.Now;
            tbFileName.Text = String.Empty;
            rtbBiografija.Text = String.Empty;
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text == String.Empty)
            {
                e.Cancel = true;
                tbIme.Focus();
                epIme.SetError(tbIme, "Polje ime ne može biti prazno");
            }
            else
            {
                e.Cancel = false;
                epIme.SetError(tbIme, "");
            }
        }

        private void tbPrezime_Validating(object sender, CancelEventArgs e)
        {
            if(tbPrezime.Text == String.Empty)
            {
                e.Cancel = true;
                tbPrezime.Focus();
                epPrezime.SetError(tbPrezime, "Polje prezime ne može biti prazno");
            }
            else
            {
                e.Cancel = false;
                epPrezime.SetError(tbPrezime, "");
            }
        }

        private void dtpDatRodj_Validating(object sender, CancelEventArgs e)
        {
            if(dtpDatRodj.Value.Date >= DateTime.Now)
            {
                e.Cancel = true;
                dtpDatRodj.Focus();
                epDatumRodj.SetError(dtpDatRodj, "Instruktor mora imati barem 18 godina");
            }
            else
            {
                e.Cancel = false;
                epDatumRodj.SetError(dtpDatRodj, "");
            }
        }

        private void cbSpol_Validating(object sender, CancelEventArgs e)
        {
            if(cbSpol.SelectedIndex < 0)
            {
                e.Cancel = true;
                cbSpol.Focus();
                epSpol.SetError(cbSpol, "Morate odabrati spol");
            }
            else
            {
                e.Cancel = false;
                epSpol.SetError(cbSpol, "");
            }
        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (tbTelefon.Text == String.Empty)
            {
                e.Cancel = true;
                tbTelefon.Focus();
                epTelefon.SetError(tbTelefon, "Polje telefon ne može biti prazno");
            }
            else
            {
                e.Cancel = false;
                epTelefon.SetError(tbTelefon, "");
            }
        }

        private void dtpIskustvo_Validating(object sender, CancelEventArgs e)
        {
            if (dtpIskustvo.Value.Date >= DateTime.Now)
            {
                e.Cancel = true;
                dtpIskustvo.Focus();
                epIskustvo.SetError(dtpIskustvo, "Nepravilan datum");
            }
            else
            {
                e.Cancel = false;
                epIskustvo.SetError(dtpIskustvo, "");
            }
        }

        private void tbFileName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFileName.Text == String.Empty)
            {
                e.Cancel = true;
                tbFileName.Focus();
                epCV.SetError(tbFileName, "Morate izvršiti upload CV-ja");
            }
            else
            {
                e.Cancel = false;
                epCV.SetError(tbFileName, "");
            }
        }

        private void rtbBiografija_Validating(object sender, CancelEventArgs e)
        {
            if (rtbBiografija.Text == String.Empty)
            {
                e.Cancel = true;
                rtbBiografija.Focus();
                epBiografija.SetError(rtbBiografija, "Polje biografija ne može biti prazno");
            }
            else
            {
                e.Cancel = false;
                epBiografija.SetError(rtbBiografija, "");
            }
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
