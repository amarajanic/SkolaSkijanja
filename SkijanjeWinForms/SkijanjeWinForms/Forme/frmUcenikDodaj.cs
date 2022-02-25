using DataAccess;
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
    public partial class frmUcenikDodaj : Form
    {
        skijanje_dbContext db;
        public frmUcenikDodaj()
        {
            InitializeComponent();
            db = new skijanje_dbContext();
        }

        private void frmUcenikDodaj_Load(object sender, EventArgs e)
        {
            cbSpol.Items.AddRange(new string[] { "Muško", "Žensko" });

            cbSpol.SelectedIndex = -1;

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            var ime = new NpgsqlParameter("ime", NpgsqlTypes.NpgsqlDbType.Varchar);
            var prezime = new NpgsqlParameter("prezime", NpgsqlTypes.NpgsqlDbType.Varchar);
            var dat_rodj = new NpgsqlParameter("dat_rodj", NpgsqlTypes.NpgsqlDbType.Date);
            var spol = new NpgsqlParameter("spol", NpgsqlTypes.NpgsqlDbType.Varchar);
            var kontakt_tel = new NpgsqlParameter("kontakt_tel", NpgsqlTypes.NpgsqlDbType.Varchar);

            var i = tbIme.Text;
            var p = tbPrezime.Text;
            var dr = dtpDatRodj.Value.Date;
            var s = cbSpol.SelectedItem.ToString();
            var t = tbTelefon.Text;

            ime.Value = i;
            prezime.Value = p;
            dat_rodj.Value = dr;
            spol.Value = s;
            kontakt_tel.Value = t;

            try
            {
                db.Database.ExecuteSqlRaw("select * from fn_Ucenik_insert(@ime,@prezime,@dat_rodj,@spol,@kontakt_tel)", ime, prezime, dat_rodj, spol, kontakt_tel);

                MessageBox.Show("Uspješno ste dodali novog učenika!");
            }
            catch (Exception)
            {
                MessageBox.Show("Trenutno nije moguće spasiti učenika!","Greška");
            }
           
            this.Close();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            tbIme.Text = String.Empty;
            tbPrezime.Text = String.Empty;
            dtpDatRodj.Value = DateTime.Now;
            cbSpol.SelectedIndex = -1;
            tbTelefon.Text = String.Empty;
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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
            if (tbPrezime.Text == String.Empty)
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
            if (dtpDatRodj.Value.Date >= DateTime.Now)
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
            if (cbSpol.SelectedIndex < 0)
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
                epKontaktTel.SetError(tbTelefon, "Polje telefon ne može biti prazno");
            }
            else
            {
                e.Cancel = false;
                epKontaktTel.SetError(tbTelefon, "");
            }
        }
    }
}
