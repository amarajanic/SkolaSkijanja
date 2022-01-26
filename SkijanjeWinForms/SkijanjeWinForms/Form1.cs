using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkijanjeWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skijanje_dbContext db = new skijanje_dbContext();

            var data = db.Instruktors.ToList();

            db.SaveChanges();

            comboBox1.DataSource = data;

            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "Prezime";

            dataGridView2.DataSource = data;
    


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void genericDropDown1_Load(object sender, EventArgs e)
        {

        }
    }
}
