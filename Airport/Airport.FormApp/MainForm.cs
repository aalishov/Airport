using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport.FormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPilotForm_Click(object sender, EventArgs e)
        {
            PilotsForm pilotsForm = new PilotsForm();
            pilotsForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAircraft_Click(object sender, EventArgs e)
        {
            AircraftsForm aircraftsForm= new AircraftsForm();
            aircraftsForm.ShowDialog();
        }
    }
}
