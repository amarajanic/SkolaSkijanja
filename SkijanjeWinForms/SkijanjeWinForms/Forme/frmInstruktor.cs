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

            db.Database.ExecuteSqlRaw("select * from fn_Instruktor_insert(@ime,@prezime,@dat_rodj,@spol,@kontakt_tel,@skij_isk,@biografija,@cv)", ime, prezime, dat_rodj, spol, kontakt_tel, skij_isk, biografija, cv);


            MessageBox.Show("Uspješno ste dodali novog instruktora!");

            this.Close();



        }

        private void frmInstruktor_Load(object sender, EventArgs e)
        {
            cbSpol.Items.AddRange(new string[] { "Muško", "Žensko" });

            cbSpol.SelectedIndex = -1;
        }
    }
}
