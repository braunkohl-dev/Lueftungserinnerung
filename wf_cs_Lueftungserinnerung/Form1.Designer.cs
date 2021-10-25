namespace wf_cs_Lueftungserinnerung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxFensterOeffnen = new System.Windows.Forms.ComboBox();
            this.labelFensterOeffnen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFensterSchließen = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxFensterOeffnen
            // 
            this.comboBoxFensterOeffnen.FormattingEnabled = true;
            this.comboBoxFensterOeffnen.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120"});
            this.comboBoxFensterOeffnen.Location = new System.Drawing.Point(167, 149);
            this.comboBoxFensterOeffnen.Name = "comboBoxFensterOeffnen";
            this.comboBoxFensterOeffnen.Size = new System.Drawing.Size(97, 24);
            this.comboBoxFensterOeffnen.TabIndex = 0;
            this.comboBoxFensterOeffnen.Text = "60";
            // 
            // labelFensterOeffnen
            // 
            this.labelFensterOeffnen.AutoSize = true;
            this.labelFensterOeffnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFensterOeffnen.Location = new System.Drawing.Point(12, 150);
            this.labelFensterOeffnen.Name = "labelFensterOeffnen";
            this.labelFensterOeffnen.Size = new System.Drawing.Size(129, 18);
            this.labelFensterOeffnen.TabIndex = 1;
            this.labelFensterOeffnen.Text = "Fenster öffnen alle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minuten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(840, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minuten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fenster schließen nach";
            // 
            // comboBoxFensterSchließen
            // 
            this.comboBoxFensterSchließen.FormattingEnabled = true;
            this.comboBoxFensterSchließen.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.comboBoxFensterSchließen.Location = new System.Drawing.Point(719, 147);
            this.comboBoxFensterSchließen.Name = "comboBoxFensterSchließen";
            this.comboBoxFensterSchließen.Size = new System.Drawing.Size(97, 24);
            this.comboBoxFensterSchließen.TabIndex = 3;
            this.comboBoxFensterSchließen.Text = "5";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 187);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(341, 37);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Erinnerung starten";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(541, 187);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(359, 37);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Programm beenden";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(753, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tragen Sie bitte ein wann Sie an die Öffnung des Fensters und wann Sie an die Sch" +
    "ließung erinnert werden wollen.";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(956, 269);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFensterSchließen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFensterOeffnen);
            this.Controls.Add(this.comboBoxFensterOeffnen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lüftungserinnerung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFensterOeffnen;
        private System.Windows.Forms.Label labelFensterOeffnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFensterSchließen;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label5;
    }
}

