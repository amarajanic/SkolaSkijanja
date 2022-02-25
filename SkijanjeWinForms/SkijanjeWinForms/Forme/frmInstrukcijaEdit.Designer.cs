namespace UI.Forme
{
    partial class frmInstrukcijaEdit
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
            this.nudBrCas = new System.Windows.Forms.NumericUpDown();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnDodajInstrukciju = new System.Windows.Forms.Button();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.cbInstruktori = new System.Windows.Forms.ComboBox();
            this.lblBiljeske = new System.Windows.Forms.Label();
            this.lblBrojCas = new System.Windows.Forms.Label();
            this.lblTermin = new System.Windows.Forms.Label();
            this.lblDatOdr = new System.Windows.Forms.Label();
            this.rtbBiljeske = new System.Windows.Forms.RichTextBox();
            this.dtvTermin = new System.Windows.Forms.DateTimePicker();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.epBrojCas = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBiljeske = new System.Windows.Forms.ErrorProvider(this.components);
            this.epInstruktor = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrCas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojCas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBiljeske)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInstruktor)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBrCas
            // 
            this.nudBrCas.Location = new System.Drawing.Point(123, 93);
            this.nudBrCas.Name = "nudBrCas";
            this.nudBrCas.Size = new System.Drawing.Size(100, 23);
            this.nudBrCas.TabIndex = 26;
            this.nudBrCas.Validating += new System.ComponentModel.CancelEventHandler(this.nudBrCas_Validating);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(299, 247);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 25;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnDodajInstrukciju
            // 
            this.btnDodajInstrukciju.Location = new System.Drawing.Point(405, 247);
            this.btnDodajInstrukciju.Name = "btnDodajInstrukciju";
            this.btnDodajInstrukciju.Size = new System.Drawing.Size(75, 23);
            this.btnDodajInstrukciju.TabIndex = 24;
            this.btnDodajInstrukciju.Text = "Spasi";
            this.btnDodajInstrukciju.UseVisualStyleBackColor = true;
            this.btnDodajInstrukciju.Click += new System.EventHandler(this.btnDodajInstrukciju_Click);
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Location = new System.Drawing.Point(241, 17);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(112, 15);
            this.lblInstruktor.TabIndex = 22;
            this.lblInstruktor.Text = "Odaberi instruktora:";
            // 
            // cbInstruktori
            // 
            this.cbInstruktori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstruktori.FormattingEnabled = true;
            this.cbInstruktori.Location = new System.Drawing.Point(359, 14);
            this.cbInstruktori.Name = "cbInstruktori";
            this.cbInstruktori.Size = new System.Drawing.Size(121, 23);
            this.cbInstruktori.TabIndex = 21;
            this.cbInstruktori.Validating += new System.ComponentModel.CancelEventHandler(this.cbInstruktori_Validating);
            // 
            // lblBiljeske
            // 
            this.lblBiljeske.AutoSize = true;
            this.lblBiljeske.Location = new System.Drawing.Point(11, 135);
            this.lblBiljeske.Name = "lblBiljeske";
            this.lblBiljeske.Size = new System.Drawing.Size(49, 15);
            this.lblBiljeske.TabIndex = 20;
            this.lblBiljeske.Text = "Bilješke:";
            // 
            // lblBrojCas
            // 
            this.lblBrojCas.AutoSize = true;
            this.lblBrojCas.Location = new System.Drawing.Point(11, 95);
            this.lblBrojCas.Name = "lblBrojCas";
            this.lblBrojCas.Size = new System.Drawing.Size(70, 15);
            this.lblBrojCas.TabIndex = 19;
            this.lblBrojCas.Text = "Broj časova:";
            // 
            // lblTermin
            // 
            this.lblTermin.AutoSize = true;
            this.lblTermin.Location = new System.Drawing.Point(11, 55);
            this.lblTermin.Name = "lblTermin";
            this.lblTermin.Size = new System.Drawing.Size(110, 15);
            this.lblTermin.TabIndex = 18;
            this.lblTermin.Text = "Vrijeme održavanja:";
            // 
            // lblDatOdr
            // 
            this.lblDatOdr.AutoSize = true;
            this.lblDatOdr.Location = new System.Drawing.Point(11, 18);
            this.lblDatOdr.Name = "lblDatOdr";
            this.lblDatOdr.Size = new System.Drawing.Size(106, 15);
            this.lblDatOdr.TabIndex = 17;
            this.lblDatOdr.Text = "Datum održavanja:";
            // 
            // rtbBiljeske
            // 
            this.rtbBiljeske.Location = new System.Drawing.Point(123, 135);
            this.rtbBiljeske.Name = "rtbBiljeske";
            this.rtbBiljeske.Size = new System.Drawing.Size(357, 96);
            this.rtbBiljeske.TabIndex = 16;
            this.rtbBiljeske.Text = "";
            this.rtbBiljeske.Validating += new System.ComponentModel.CancelEventHandler(this.rtbBiljeske_Validating);
            // 
            // dtvTermin
            // 
            this.dtvTermin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtvTermin.Location = new System.Drawing.Point(124, 50);
            this.dtvTermin.Name = "dtvTermin";
            this.dtvTermin.ShowUpDown = true;
            this.dtvTermin.Size = new System.Drawing.Size(99, 23);
            this.dtvTermin.TabIndex = 15;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(123, 12);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(99, 23);
            this.dtpDatum.TabIndex = 14;
            // 
            // epBrojCas
            // 
            this.epBrojCas.ContainerControl = this;
            // 
            // epBiljeske
            // 
            this.epBiljeske.ContainerControl = this;
            // 
            // epInstruktor
            // 
            this.epInstruktor.ContainerControl = this;
            // 
            // frmInstrukcijaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 285);
            this.Controls.Add(this.nudBrCas);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnDodajInstrukciju);
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
            this.Name = "frmInstrukcijaEdit";
            this.Text = "frmInstrukcijaEdit";
            this.Load += new System.EventHandler(this.frmInstrukcijaEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrCas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojCas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBiljeske)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInstruktor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudBrCas;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnDodajInstrukciju;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.ComboBox cbInstruktori;
        private System.Windows.Forms.Label lblBiljeske;
        private System.Windows.Forms.Label lblBrojCas;
        private System.Windows.Forms.Label lblTermin;
        private System.Windows.Forms.Label lblDatOdr;
        private System.Windows.Forms.RichTextBox rtbBiljeske;
        private System.Windows.Forms.DateTimePicker dtvTermin;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ErrorProvider epBrojCas;
        private System.Windows.Forms.ErrorProvider epBiljeske;
        private System.Windows.Forms.ErrorProvider epInstruktor;
    }
}