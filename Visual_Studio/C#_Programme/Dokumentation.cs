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

                stringChange = txtboxChange.Text;


            Properties.Settings.Default.Name = txtboxName.Text;
            Properties.Settings.Default.Pfad = txtboxPfad.Text.Trim();
            Properties.Settings.Default.Version = txtboxVersion.Text.Trim();
            Properties.Settings.Default.Save();

            reader = (Pfad + Properties.Settings.Default.Pfad + ".txt");

            if (Properties.Settings.Default.Pfad != "") {

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

                    label5.Visible = true;
                }
                else if (stringNameDatei != "" && boolHeaderZähler == false)
                {

                    boolHeaderZähler = true;

                    sw.WriteLine("============================================================================");
                    sw.WriteLine("");
                    sw.WriteLine(@"///" + Properties.Settings.Default.Pfad);
                    sw.WriteLine(@"///" + Properties.Settings.Default.Name);
                    sw.WriteLine(@"///" + txtUhrzeit);
                    sw.WriteLine(@"///" + "Version 1.0" );              
                    sw.WriteLine("");
                    sw.WriteLine("============================================================================");
                    sw.WriteLine("");

                    sw.WriteLine("Änderungen: " + txtboxChange.Text);

                    sw.Close();

                    label5.Visible = true;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdStart_Click(object sender, EventArgs e)
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

        //public void Leser()
        //{

        //    string[] tmpData;

        //    StreamReader sr = new StreamReader(reader);

        //    while (sr.Peek() > -1)
        //    {

        //    }
        //}

    }
}
