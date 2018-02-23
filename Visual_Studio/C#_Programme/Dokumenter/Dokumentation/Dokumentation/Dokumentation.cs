using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dokumentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///Initialisierung der Dateitypen, welche Global gebraucht werden

        string reader;

        string stringChange;

        public string Pfad = @"C:\Users\stefa\Documents\GitHub\SteveGitHubOrdner\Dokumentation\";

        string stringNameDatei = "text.txt";

        //Properties.Settings.Default.Name = stringName ;
        //Properties.Settings.Default.Pfad = stringNameDatei ;
        //Properties.Settings.Default.Version = intVersion ;
        //Properties.Settings.Default.Save();

        StreamReader StreamLeser;

        private Button cmdStart;
        private Button cmdCommit;
        private Label label1;
        private TextBox txtboxChange;
        private TextBox txtboxVersion;
        private TextBox txtboxPfad;
        private TextBox txtboxName;
        private Label label2;
        private Label label4;
        private Label txtName;
        private Label txtErfolg;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox txtboxReader;
        bool boolHeaderZähler = false;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPfad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCommit_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdStart_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdCommit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxChange = new System.Windows.Forms.TextBox();
            this.txtboxVersion = new System.Windows.Forms.TextBox();
            this.txtboxPfad = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtErfolg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtboxReader = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(159, 204);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click_1);
            // 
            // cmdCommit
            // 
            this.cmdCommit.Location = new System.Drawing.Point(285, 290);
            this.cmdCommit.Name = "cmdCommit";
            this.cmdCommit.Size = new System.Drawing.Size(75, 23);
            this.cmdCommit.TabIndex = 1;
            this.cmdCommit.Text = "Commit";
            this.cmdCommit.UseVisualStyleBackColor = true;
            this.cmdCommit.Visible = false;
            this.cmdCommit.Click += new System.EventHandler(this.cmdCommit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dokumentationstool";
            this.label1.Visible = false;
            // 
            // txtboxChange
            // 
            this.txtboxChange.Location = new System.Drawing.Point(19, 241);
            this.txtboxChange.Multiline = true;
            this.txtboxChange.Name = "txtboxChange";
            this.txtboxChange.Size = new System.Drawing.Size(232, 107);
            this.txtboxChange.TabIndex = 3;
            this.txtboxChange.Visible = false;
            // 
            // txtboxVersion
            // 
            this.txtboxVersion.Location = new System.Drawing.Point(285, 174);
            this.txtboxVersion.Name = "txtboxVersion";
            this.txtboxVersion.Size = new System.Drawing.Size(100, 20);
            this.txtboxVersion.TabIndex = 4;
            this.txtboxVersion.Visible = false;
            // 
            // txtboxPfad
            // 
            this.txtboxPfad.Location = new System.Drawing.Point(19, 86);
            this.txtboxPfad.Name = "txtboxPfad";
            this.txtboxPfad.Size = new System.Drawing.Size(100, 20);
            this.txtboxPfad.TabIndex = 5;
            this.txtboxPfad.Visible = false;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(19, 174);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(134, 20);
            this.txtboxName.TabIndex = 6;
            this.txtboxName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Version";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dateiname";
            this.label4.Visible = false;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(16, 158);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(49, 13);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "Benutzer";
            this.txtName.Visible = false;
            // 
            // txtErfolg
            // 
            this.txtErfolg.AutoSize = true;
            this.txtErfolg.Location = new System.Drawing.Point(302, 241);
            this.txtErfolg.Name = "txtErfolg";
            this.txtErfolg.Size = new System.Drawing.Size(57, 13);
            this.txtErfolg.TabIndex = 10;
            this.txtErfolg.Text = "Erfolgreich";
            this.txtErfolg.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Änderungen:";
            this.label6.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Visible = false;
            // 
            // txtboxReader
            // 
            this.txtboxReader.Location = new System.Drawing.Point(285, 349);
            this.txtboxReader.Multiline = true;
            this.txtboxReader.Name = "txtboxReader";
            this.txtboxReader.Size = new System.Drawing.Size(277, 138);
            this.txtboxReader.TabIndex = 13;
            this.txtboxReader.Visible = false;
            this.txtboxReader.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(583, 499);
            this.Controls.Add(this.txtboxReader);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtErfolg);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.txtboxPfad);
            this.Controls.Add(this.txtboxVersion);
            this.Controls.Add(this.txtboxChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCommit);
            this.Controls.Add(this.cmdStart);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmdStart_Click_1(object sender, EventArgs e)
        {
            //Alles andere Visible machen

            cmdStart.Visible = false;

            label4.Visible = true;
            cmdCommit.Visible = true;
            txtboxChange.Visible = true;
            txtboxName.Visible = true;
            txtboxPfad.Visible = true;
            txtboxVersion.Visible = true;
            txtName.Visible = true;
            label1.Visible = true;
            label2.Visible = true;

            txtboxName.Text = Properties.Settings.Default.Name;
            txtboxPfad.Text = Properties.Settings.Default.Pfad;
            txtboxVersion.Text = Properties.Settings.Default.Version;
            Properties.Settings.Default.Save();
        }

        private void cmdCommit_Click_1(object sender, EventArgs e)
        {
            stringChange = txtboxChange.Text;


            Properties.Settings.Default.Name = txtboxName.Text;
            Properties.Settings.Default.Pfad = txtboxPfad.Text.Trim();
            Properties.Settings.Default.Version = txtboxVersion.Text.Trim();
            Properties.Settings.Default.Save();

            reader = (Pfad + Properties.Settings.Default.Pfad + ".txt");

            if (Properties.Settings.Default.Pfad != "")
            {

                StreamWriter sw = new StreamWriter((Pfad + Properties.Settings.Default.Pfad + ".txt"), true);

                dateTimePicker1.Value = DateTime.Now;
                string txtUhrzeit = Convert.ToString(DateTime.Now.ToString());



                if (boolHeaderZähler == true && stringNameDatei != "")
                {
                    sw.WriteLine();
                    sw.WriteLine("============================================================================");
                    sw.WriteLine();
                    sw.WriteLine();
                    sw.WriteLine("============================================================================");
                    sw.WriteLine();

                    sw.WriteLine("Änderungen: " + txtboxChange.Text);
                    sw.WriteLine();
                    sw.WriteLine("Von       : " + Properties.Settings.Default.Name);
                    sw.WriteLine("Version   : " + Properties.Settings.Default.Version);
                    sw.WriteLine("Am        : " + txtUhrzeit);
                    sw.Close();

                    txtErfolg.Visible = true;

                    //StreamReader wir hier getestet

                    StreamReader sr = new StreamReader(Pfad + Properties.Settings.Default.Pfad + ".txt");
                    string[] tmpData;
                    bool successful = false;
                    int baba = 0;

                    while (sr.Peek() > -1)
                    {
                        tmpData = getLoginDataExtract(sr.ReadLine());
                        if (baba == 1200)
                        {
                            successful = true;
                            break;
                        }
                        else if (stringNameDatei != "" && boolHeaderZähler == false)
                            baba++;
                        {


                        }
                    }
                else if (stringNameDatei != "" && boolHeaderZähler == false)
                    {

                        boolHeaderZähler = true;

                        sw.WriteLine("============================================================================");
                        sw.WriteLine("");
                        sw.WriteLine(@"///" + Properties.Settings.Default.Pfad);
                        sw.WriteLine(@"///" + Properties.Settings.Default.Name);
                        sw.WriteLine(@"///" + txtUhrzeit);
                        sw.WriteLine(@"///" + "Version 1.0");
                        sw.WriteLine("");
                        sw.WriteLine("============================================================================");
                        sw.WriteLine("");

                        sw.WriteLine("Änderungen: " + txtboxChange.Text);

                        sw.Close();

                        txtErfolg.Visible = true;
                    }
                    else
                    {
                        txtboxPfad.Text = "Wählen Sie einen Namen für das File!";
                    }
                }
                else
                {
                    txtboxPfad.Text = "Wählen Sie einen Namen für das File!";
                }
            }

            private void textBox1_TextChanged_1(object sender, EventArgs e)
            {

            }

            //public void Leser()
            //{

            //    string[] tmpData;

            //    StreamReader sr = new StreamReader(reader);

            //    while (sr.Peek() > -1)
            //    {

            //    }
            //}

        }
        private string[] getLoginDataExtract(string data)
        {
            char[] splitChars = { ',' };
            return data.Split(splitChars);
        }
    }
}
