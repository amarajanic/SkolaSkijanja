namespace UI.Forme
{
    partial class frmInstrukcijaUcenik
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
            this.dgvUcenici = new System.Windows.Forms.DataGridView();
            this.dtnDodajUcenika = new System.Windows.Forms.Button();
            this.btnUceniciUInstrukciji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUcenici
            // 
            this.dgvUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenici.Location = new System.Drawing.Point(12, 12);
            this.dgvUcenici.Name = "dgvUcenici";
            this.dgvUcenici.RowTemplate.Height = 25;
            this.dgvUcenici.Size = new System.Drawing.Size(582, 199);
            this.dgvUcenici.TabIndex = 0;
            this.dgvUcenici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUcenici_CellContentClick);
            // 
            // dtnDodajUcenika
            // 
            this.dtnDodajUcenika.Location = new System.Drawing.Point(492, 245);
            this.dtnDodajUcenika.Name = "dtnDodajUcenika";
            this.dtnDodajUcenika.Size = new System.Drawing.Size(102, 42);
            this.dtnDodajUcenika.TabIndex = 1;
            this.dtnDodajUcenika.Text = "Dodaj novog učenika";
            this.dtnDodajUcenika.UseVisualStyleBackColor = true;
            this.dtnDodajUcenika.Click += new System.EventHandler(this.dtnDodajUcenika_Click);
            // 
            // btnUceniciUInstrukciji
            // 
            this.btnUceniciUInstrukciji.Location = new System.Drawing.Point(383, 245);
            this.btnUceniciUInstrukciji.Name = "btnUceniciUInstrukciji";
            this.btnUceniciUInstrukciji.Size = new System.Drawing.Size(103, 42);
            this.btnUceniciUInstrukciji.TabIndex = 2;
            this.btnUceniciUInstrukciji.Text = "Učenici u instrukciji";
            this.btnUceniciUInstrukciji.UseVisualStyleBackColor = true;
            this.btnUceniciUInstrukciji.Click += new System.EventHandler(this.btnDostupniUc_Click);
            // 
            // frmInstrukcijaUcenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 314);
            this.Controls.Add(this.btnUceniciUInstrukciji);
            this.Controls.Add(this.dtnDodajUcenika);
            this.Controls.Add(this.dgvUcenici);
            this.Name = "frmInstrukcijaUcenik";
            this.Text = "frmInstrukcijaUcenik";
            this.Load += new System.EventHandler(this.frmInstrukcijaUcenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUcenici;
        private System.Windows.Forms.Button dtnDodajUcenika;
        private System.Windows.Forms.Button btnUceniciUInstrukciji;
    }
}