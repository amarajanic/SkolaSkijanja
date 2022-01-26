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


            db.Database.ExecuteSqlRaw("select * from fn_Ucenik_insert(@ime,@prezime,@dat_rodj,@spol,@kontakt_tel)", ime, prezime, dat_rodj, spol, kontakt_tel);


            MessageBox.Show("Uspješno ste dodali novog učenika!");

            this.Close();
        }
    }
}
