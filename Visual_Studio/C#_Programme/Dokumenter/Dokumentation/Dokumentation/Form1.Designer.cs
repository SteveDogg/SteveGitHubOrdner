namespace Dokumentation
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
            this.txtboxPfad = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxVersion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdCommit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmdStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxPfad
            // 
            this.txtboxPfad.Location = new System.Drawing.Point(12, 54);
            this.txtboxPfad.Name = "txtboxPfad";
            this.txtboxPfad.Size = new System.Drawing.Size(291, 20);
            this.txtboxPfad.TabIndex = 1;
            this.txtboxPfad.Visible = false;
            this.txtboxPfad.TextChanged += new System.EventHandler(this.txtboxPfad_TextChanged);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(12, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(52, 13);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Schreiber";
            this.txtName.Visible = false;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(12, 107);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(81, 20);
            this.txtboxName.TabIndex = 3;
            this.txtboxName.Visible = false;
            this.txtboxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Änderung";
            this.label1.Visible = false;
            // 
            // txtboxChange
            // 
            this.txtboxChange.Location = new System.Drawing.Point(12, 165);
            this.txtboxChange.Multiline = true;
            this.txtboxChange.Name = "txtboxChange";
            this.txtboxChange.Size = new System.Drawing.Size(291, 109);
            this.txtboxChange.TabIndex = 5;
            this.txtboxChange.Visible = false;
            this.txtboxChange.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Version";
            this.label2.Visible = false;
            // 
            // txtboxVersion
            // 
            this.txtboxVersion.Location = new System.Drawing.Point(117, 107);
            this.txtboxVersion.Name = "txtboxVersion";
            this.txtboxVersion.Size = new System.Drawing.Size(40, 20);
            this.txtboxVersion.TabIndex = 7;
            this.txtboxVersion.Text = "1.0";
            this.txtboxVersion.Visible = false;
            this.txtboxVersion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dokumentationsprogramm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dateiname";
            this.label4.Visible = false;
            // 
            // cmdCommit
            // 
            this.cmdCommit.Location = new System.Drawing.Point(326, 251);
            this.cmdCommit.Name = "cmdCommit";
            this.cmdCommit.Size = new System.Drawing.Size(75, 23);
            this.cmdCommit.TabIndex = 10;
            this.cmdCommit.Text = "Commit";
            this.cmdCommit.UseVisualStyleBackColor = true;
            this.cmdCommit.Visible = false;
            this.cmdCommit.Click += new System.EventHandler(this.cmdCommit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Visible = false;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(162, 133);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 12;
            this.cmdStart.Text = "Starte Doku";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Worked!";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 286);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmdCommit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtboxPfad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxPfad;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdCommit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label label5;
    }
}

