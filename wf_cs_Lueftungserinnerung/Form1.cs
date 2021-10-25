using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_cs_Lueftungserinnerung
{
    public partial class Form1 : Form
    {
        Timer t1 = new Timer(); // Timer anlegen
        Timer t2 = new Timer(); // Timer anlegen
        public Form1()

        
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Timer t1 = new Timer(); // Timer anlegen
            int iFensterOeffnen = Int16.Parse(comboBoxFensterOeffnen.Text);
            iFensterOeffnen = iFensterOeffnen * 60 * 1000;
            //comboBoxFensterOeffnen.Text = iFensterOeffnen.ToString();
            t1.Stop();
            t1.Interval = iFensterOeffnen; // Intervall festlegen, hier 100 ms
            t1.Tick += new EventHandler(t1_Tick); // Eventhandler ezeugen der beim Timerablauf aufgerufen wird
            t2.Tick += new EventHandler(t2_Tick); // Eventhandler ezeugen der beim Timerablauf aufgerufen wird
            t1.Start(); // Timer starten
            MessageBox.Show("Der Timer wurde gestartet.", "Timer gestartet", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            buttonStart.Enabled = false;
            WindowState = FormWindowState.Minimized;
        }

        void t1_Tick(object sender, EventArgs e)
        {
            // dieser Code wird ausgeführt, wenn der Timer abgelaufen ist
            t1.Stop();
            MessageBox.Show("Bitte das Fenster zum Lüften öffnen.", "Fenster öffnen", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            //t1.Start();
            int iFensterSchliessen = Int16.Parse(comboBoxFensterSchließen.Text);
            iFensterSchliessen = iFensterSchliessen * 60 * 1000;
            //comboBoxFensterOeffnen.Text = iFensterOeffnen.ToString();
            t2.Stop();
            t2.Interval = iFensterSchliessen; // Intervall festlegen, hier 100 ms
            t2.Start(); // Timer starten
        }

        void t2_Tick(object sender, EventArgs e)
        {
            // dieser Code wird ausgeführt, wenn der Timer abgelaufen ist
            t2.Stop();
            MessageBox.Show("Bitte das Fenster wieder schließen.", "Fenster schließen", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            t1.Start();
        }
    }
}
