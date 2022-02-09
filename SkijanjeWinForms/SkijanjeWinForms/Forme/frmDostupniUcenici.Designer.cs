namespace UI.Forme
{
    partial class frmDostupniUcenici
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
            this.btnNoviUcenik = new System.Windows.Forms.Button();
            this.dgvDostupniUcenici = new System.Windows.Forms.DataGridView();
            this.dgvBtnOdaberi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniUcenici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNoviUcenik
            // 
            this.btnNoviUcenik.Location = new System.Drawing.Point(615, 272);
            this.btnNoviUcenik.Name = "btnNoviUcenik";
            this.btnNoviUcenik.Size = new System.Drawing.Size(88, 23);
            this.btnNoviUcenik.TabIndex = 0;
            this.btnNoviUcenik.Text = "Novi učenik";
            this.btnNoviUcenik.UseVisualStyleBackColor = true;
            this.btnNoviUcenik.Click += new System.EventHandler(this.btnNoviUcenik_Click);
            // 
            // dgvDostupniUcenici
            // 
            this.dgvDostupniUcenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDostupniUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostupniUcenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBtnOdaberi});
            this.dgvDostupniUcenici.Location = new System.Drawing.Point(12, 12);
            this.dgvDostupniUcenici.Name = "dgvDostupniUcenici";
            this.dgvDostupniUcenici.RowTemplate.Height = 25;
            this.dgvDostupniUcenici.Size = new System.Drawing.Size(691, 242);
            this.dgvDostupniUcenici.TabIndex = 1;
            this.dgvDostupniUcenici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDostupniUcenici_CellContentClick);
            // 
            // dgvBtnOdaberi
            // 
            this.dgvBtnOdaberi.HeaderText = "Odaberi";
            this.dgvBtnOdaberi.Name = "dgvBtnOdaberi";
            // 
            // frmDostupniUcenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 307);
            this.Controls.Add(this.dgvDostupniUcenici);
            this.Controls.Add(this.btnNoviUcenik);
            this.Name = "frmDostupniUcenici";
            this.Text = "frmDostupniUcenici";
            this.Load += new System.EventHandler(this.frmDostupniUcenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniUcenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoviUcenik;
        private System.Windows.Forms.DataGridView dgvDostupniUcenici;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnOdaberi;
    }
}