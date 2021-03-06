namespace UI.Forme
{
    partial class frmPocetna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInstrukcije = new System.Windows.Forms.DataGridView();
            this.dgvBtnDetalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBtnPromijeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBtnUcenici = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBtnObrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.cbInstruktori = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnDodajInstrukciju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrukcije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInstrukcije
            // 
            this.dgvInstrukcije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInstrukcije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInstrukcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrukcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBtnDetalji,
            this.dgvBtnPromijeni,
            this.dgvBtnUcenici,
            this.dgvBtnObrisi});
            this.dgvInstrukcije.Location = new System.Drawing.Point(12, 170);
            this.dgvInstrukcije.Name = "dgvInstrukcije";
            this.dgvInstrukcije.RowTemplate.Height = 25;
            this.dgvInstrukcije.Size = new System.Drawing.Size(776, 268);
            this.dgvInstrukcije.TabIndex = 0;
            this.dgvInstrukcije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstrukcije_CellContentClick);
            // 
            // dgvBtnDetalji
            // 
            this.dgvBtnDetalji.HeaderText = "Detalji";
            this.dgvBtnDetalji.Name = "dgvBtnDetalji";
            // 
            // dgvBtnPromijeni
            // 
            this.dgvBtnPromijeni.HeaderText = "Promijeni";
            this.dgvBtnPromijeni.Name = "dgvBtnPromijeni";
            // 
            // dgvBtnUcenici
            // 
            this.dgvBtnUcenici.HeaderText = "Učenici";
            this.dgvBtnUcenici.Name = "dgvBtnUcenici";
            this.dgvBtnUcenici.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBtnUcenici.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvBtnObrisi
            // 
            this.dgvBtnObrisi.HeaderText = "Obriši";
            this.dgvBtnObrisi.Name = "dgvBtnObrisi";
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(156, 108);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(136, 23);
            this.dtpPocetak.TabIndex = 1;
            // 
            // dtpKraj
            // 
            this.dtpKraj.Location = new System.Drawing.Point(310, 109);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(136, 23);
            this.dtpKraj.TabIndex = 2;
            // 
            // cbInstruktori
            // 
            this.cbInstruktori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstruktori.FormattingEnabled = true;
            this.cbInstruktori.Location = new System.Drawing.Point(12, 109);
            this.cbInstruktori.Name = "cbInstruktori";
            this.cbInstruktori.Size = new System.Drawing.Size(121, 23);
            this.cbInstruktori.TabIndex = 3;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(478, 108);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnDodajInstrukciju
            // 
            this.btnDodajInstrukciju.Location = new System.Drawing.Point(665, 108);
            this.btnDodajInstrukciju.Name = "btnDodajInstrukciju";
            this.btnDodajInstrukciju.Size = new System.Drawing.Size(123, 23);
            this.btnDodajInstrukciju.TabIndex = 5;
            this.btnDodajInstrukciju.Text = "Dodaj Instrukciju";
            this.btnDodajInstrukciju.UseVisualStyleBackColor = true;
            this.btnDodajInstrukciju.Click += new System.EventHandler(this.btnDodajInstrukciju_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajInstrukciju);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.cbInstruktori);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.dgvInstrukcije);
            this.Name = "frmPocetna";
            this.Text = "frmPocetna";
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrukcije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstrukcije;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.ComboBox cbInstruktori;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnDodajInstrukciju;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnDetalji;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnPromijeni;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnUcenici;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnObrisi;
    }
}