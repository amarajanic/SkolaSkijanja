namespace UI.Forme
{
    partial class frmInstrukcija
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
            this.components = new System.ComponentModel.Container();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtvTermin = new System.Windows.Forms.DateTimePicker();
            this.rtbBiljeske = new System.Windows.Forms.RichTextBox();
            this.lblDatOdr = new System.Windows.Forms.Label();
            this.lblTermin = new System.Windows.Forms.Label();
            this.lblBrojCas = new System.Windows.Forms.Label();
            this.lblBiljeske = new System.Windows.Forms.Label();
            this.cbInstruktori = new System.Windows.Forms.ComboBox();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.btnDodajInstruktora = new System.Windows.Forms.Button();
            this.btnDodajInstrukciju = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.nudBrCas = new System.Windows.Forms.NumericUpDown();
            this.epBrojCas = new System.Windows.Forms.ErrorProvider(this.components);
            this.epInstruktor = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBiljeske = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrCas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojCas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInstruktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBiljeske)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(124, 15);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(99, 23);
            this.dtpDatum.TabIndex = 0;
            // 
            // dtvTermin
            // 
            this.dtvTermin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtvTermin.Location = new System.Drawing.Point(125, 53);
            this.dtvTermin.Name = "dtvTermin";
            this.dtvTermin.ShowUpDown = true;
            this.dtvTermin.Size = new System.Drawing.Size(99, 23);
            this.dtvTermin.TabIndex = 1;
            // 
            // rtbBiljeske
            // 
            this.rtbBiljeske.Location = new System.Drawing.Point(124, 138);
            this.rtbBiljeske.Name = "rtbBiljeske";
            this.rtbBiljeske.Size = new System.Drawing.Size(357, 96);
            this.rtbBiljeske.TabIndex = 3;
            this.rtbBiljeske.Text = "";
            this.rtbBiljeske.Validating += new System.ComponentModel.CancelEventHandler(this.rtbBiljeske_Validating);
            // 
            // lblDatOdr
            // 
            this.lblDatOdr.AutoSize = true;
            this.lblDatOdr.Location = new System.Drawing.Point(12, 21);
            this.lblDatOdr.Name = "lblDatOdr";
            this.lblDatOdr.Size = new System.Drawing.Size(106, 15);
            this.lblDatOdr.TabIndex = 4;
            this.lblDatOdr.Text = "Datum održavanja:";
            // 
            // lblTermin
            // 
            this.lblTermin.AutoSize = true;
            this.lblTermin.Location = new System.Drawing.Point(12, 58);
            this.lblTermin.Name = "lblTermin";
            this.lblTermin.Size = new System.Drawing.Size(110, 15);
            this.lblTermin.TabIndex = 5;
            this.lblTermin.Text = "Vrijeme održavanja:";
            // 
            // lblBrojCas
            // 
            this.lblBrojCas.AutoSize = true;
            this.lblBrojCas.Location = new System.Drawing.Point(12, 98);
            this.lblBrojCas.Name = "lblBrojCas";
            this.lblBrojCas.Size = new System.Drawing.Size(70, 15);
            this.lblBrojCas.TabIndex = 6;
            this.lblBrojCas.Text = "Broj časova:";
            // 
            // lblBiljeske
            // 
            this.lblBiljeske.AutoSize = true;
            this.lblBiljeske.Location = new System.Drawing.Point(12, 138);
            this.lblBiljeske.Name = "lblBiljeske";
            this.lblBiljeske.Size = new System.Drawing.Size(49, 15);
            this.lblBiljeske.TabIndex = 7;
            this.lblBiljeske.Text = "Bilješke:";
            // 
            // cbInstruktori
            // 
            this.cbInstruktori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstruktori.FormattingEnabled = true;
            this.cbInstruktori.Location = new System.Drawing.Point(360, 17);
            this.cbInstruktori.Name = "cbInstruktori";
            this.cbInstruktori.Size = new System.Drawing.Size(121, 23);
            this.cbInstruktori.TabIndex = 8;
            this.cbInstruktori.Validating += new System.ComponentModel.CancelEventHandler(this.cbInstruktori_Validating);
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Location = new System.Drawing.Point(242, 20);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(112, 15);
            this.lblInstruktor.TabIndex = 9;
            this.lblInstruktor.Text = "Odaberi instruktora:";
            // 
            // btnDodajInstruktora
            // 
            this.btnDodajInstruktora.Location = new System.Drawing.Point(360, 94);
            this.btnDodajInstruktora.Name = "btnDodajInstruktora";
            this.btnDodajInstruktora.Size = new System.Drawing.Size(121, 23);
            this.btnDodajInstruktora.TabIndex = 10;
            this.btnDodajInstruktora.Text = "Dodaj Instruktora";
            this.btnDodajInstruktora.UseVisualStyleBackColor = true;
            this.btnDodajInstruktora.Click += new System.EventHandler(this.btnDodajInstruktora_Click);
            // 
            // btnDodajInstrukciju
            // 
            this.btnDodajInstrukciju.Location = new System.Drawing.Point(406, 250);
            this.btnDodajInstrukciju.Name = "btnDodajInstrukciju";
            this.btnDodajInstrukciju.Size = new System.Drawing.Size(75, 23);
            this.btnDodajInstrukciju.TabIndex = 11;
            this.btnDodajInstrukciju.Text = "Spasi";
            this.btnDodajInstrukciju.UseVisualStyleBackColor = true;
            this.btnDodajInstrukciju.Click += new System.EventHandler(this.btnDodajInstrukciju_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(300, 250);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 12;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // nudBrCas
            // 
            this.nudBrCas.Location = new System.Drawing.Point(124, 96);
            this.nudBrCas.Name = "nudBrCas";
            this.nudBrCas.Size = new System.Drawing.Size(100, 23);
            this.nudBrCas.TabIndex = 13;
            this.nudBrCas.Validating += new System.ComponentModel.CancelEventHandler(this.nudBrCas_Validating);
            // 
            // epBrojCas
            // 
            this.epBrojCas.ContainerControl = this;
            // 
            // epInstruktor
            // 
            this.epInstruktor.ContainerControl = this;
            // 
            // epBiljeske
            // 
            this.epBiljeske.ContainerControl = this;
            // 
            // frmInstrukcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 305);
            this.Controls.Add(this.nudBrCas);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnDodajInstrukciju);
            this.Controls.Add(this.btnDodajInstruktora);
            this.Controls.Add(this.lblInstruktor);
            this.Controls.Add(this.cbInstruktori);
            this.Controls.Add(this.lblBiljeske);
            this.Controls.Add(this.lblBrojCas);
            this.Controls.Add(this.lblTermin);
            this.Controls.Add(this.lblDatOdr);
            this.Controls.Add(this.rtbBiljeske);
            this.Controls.Add(this.dtvTermin);
            this.Controls.Add(this.dtpDatum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInstrukcija";
            this.Text = "frmInstrukcija";
            this.Load += new System.EventHandler(this.frmInstrukcija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrCas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojCas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInstruktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBiljeske)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker dtvTermin;
        private System.Windows.Forms.RichTextBox rtbBiljeske;
        private System.Windows.Forms.Label lblDatOdr;
        private System.Windows.Forms.Label lblTermin;
        private System.Windows.Forms.Label lblBrojCas;
        private System.Windows.Forms.Label lblBiljeske;
        private System.Windows.Forms.ComboBox cbInstruktori;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.Button btnDodajInstruktora;
        private System.Windows.Forms.Button btnDodajInstrukciju;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.NumericUpDown nudBrCas;
        private System.Windows.Forms.ErrorProvider epBrojCas;
        private System.Windows.Forms.ErrorProvider epInstruktor;
        private System.Windows.Forms.ErrorProvider epBiljeske;
    }
}