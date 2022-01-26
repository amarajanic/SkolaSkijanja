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
            this.dgvDostupniUcenici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniUcenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDostupniUcenici
            // 
            this.dgvDostupniUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostupniUcenici.Location = new System.Drawing.Point(12, 95);
            this.dgvDostupniUcenici.Name = "dgvDostupniUcenici";
            this.dgvDostupniUcenici.RowTemplate.Height = 25;
            this.dgvDostupniUcenici.Size = new System.Drawing.Size(776, 343);
            this.dgvDostupniUcenici.TabIndex = 0;
            // 
            // frmDostupniUcenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDostupniUcenici);
            this.Name = "frmDostupniUcenici";
            this.Text = "frmDostupniUcenici";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniUcenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDostupniUcenici;
    }
}