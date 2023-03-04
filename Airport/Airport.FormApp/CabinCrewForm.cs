using Airport.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Airport.FormApp
{
    public partial class CabinCrewForm : Form
    {
        AircraftsService aircraftsService;
        PilotsService pilotsService;

        int currentAircraftPage = 1;
        int totalAircraftPage = 1;


        int currentPilotsPage = 1;
        int totalPilotsPage = 1;

        public CabinCrewForm()
        {
            InitializeComponent();
            aircraftsService = new AircraftsService();
            pilotsService = new PilotsService();
        }

        private void CabinCrewForm_Load(object sender, EventArgs e)
        {
            comboBoxCrewCount.SelectedIndex = 0;
            comboBoxCrewCount.Enabled = false;

            listBoxAircrafts.Items.Clear();
            listBoxPilots.Items.Clear();
            listBoxCabinCrew.Items.Clear();
            labelAircraft.Text = "-";

            totalAircraftPage = aircraftsService.GetAircraftWithoutCrewPagesCount();
            labelAircraftPage.Text = $"{currentAircraftPage} / {totalAircraftPage}";
            btnAircraftNext.Enabled = true;
            btnAircraftPrevious.Enabled = true;

            totalPilotsPage = pilotsService.GetPilotsPagesCount();
            labelPilotsPage.Text = $"{currentPilotsPage} / {totalPilotsPage}";
            btnPilotsNext.Enabled = false;
            btnPilotsPrevious.Enabled = false;

            listBoxAircrafts.Enabled = true;
            listBoxPilots.Enabled = false;
            listBoxCabinCrew.Enabled = false;
            button1.Enabled = false;



            List<string> aircrafts = aircraftsService.GetAircraftsInfoWithoutCrew();
            aircrafts.ForEach(a => listBoxAircrafts.Items.Add(a));

            List<string> pilots = pilotsService.GetPilotsBasicInfo();
            pilots.ForEach(p => listBoxPilots.Items.Add(p));
        }

        private void listBoxAircrafts_DoubleClick(object sender, EventArgs e)
        {
            comboBoxCrewCount.Enabled = true;

            listBoxAircrafts.Enabled = false;
            listBoxPilots.Enabled = true;
            label1.Text = "Step 2 - select pilots";

            labelAircraft.Text = listBoxAircrafts.Text;

            btnAircraftNext.Enabled = false;
            btnAircraftPrevious.Enabled = false;

            btnPilotsNext.Enabled = true;
            btnPilotsPrevious.Enabled = true;
        }

        private void listBoxPilots_DoubleClick(object sender, EventArgs e)
        {

            string pilot = listBoxPilots.Text;
            string pilotId = pilot.Split(" - ").FirstOrDefault();
            foreach (var item in listBoxCabinCrew.Items)
            {
                string id = item.ToString().Split(" - ").FirstOrDefault();
                if (pilotId == id)
                {
                    MessageBox.Show("This pilot is already selected");
                    return;
                }
            }
            listBoxCabinCrew.Items.Add(pilot);

            if (listBoxCabinCrew.Items.Count >= int.Parse(comboBoxCrewCount.Text))
            {
                listBoxPilots.Enabled = false;
                button1.Enabled = true;

                btnPilotsNext.Enabled = false;
                btnPilotsPrevious.Enabled = false;

                label1.Text = "Step 3 - Confirm data";
                comboBoxCrewCount.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aircraft = int.Parse(labelAircraft.Text.Split(" - ").FirstOrDefault());
            List<int> pilots = new List<int>();
            foreach (var item in listBoxCabinCrew.Items)
            {
                int puliotId = int.Parse(item.ToString().Split(" - ").FirstOrDefault());
                pilots.Add(puliotId);
            }
            string result = aircraftsService.AddCabinCrew(aircraft, pilots);
            MessageBox.Show(result);

            this.CabinCrewForm_Load(sender, e);
        }

        private void btnAircraftPrevious_Click(object sender, EventArgs e)
        {
            if (currentAircraftPage > 1)
            {
                currentAircraftPage--;
                labelAircraftPage.Text = $"{currentAircraftPage} / {totalAircraftPage}";
                listBoxAircrafts.Items.Clear();

                List<string> aircrafts = aircraftsService.GetAircraftsInfoWithoutCrew(currentAircraftPage);
                aircrafts.ForEach(a => listBoxAircrafts.Items.Add(a));
            }
        }

        private void btnAircraftNext_Click(object sender, EventArgs e)
        {
            if (currentAircraftPage < totalAircraftPage)
            {
                currentAircraftPage++;
                labelAircraftPage.Text = $"{currentAircraftPage} / {totalAircraftPage}";
                listBoxAircrafts.Items.Clear();

                List<string> aircrafts = aircraftsService.GetAircraftsInfoWithoutCrew(currentAircraftPage);
                aircrafts.ForEach(a => listBoxAircrafts.Items.Add(a));
            }
        }

        private void btnPilotsPrevious_Click(object sender, EventArgs e)
        {
            if (currentPilotsPage > 1)
            {
                currentPilotsPage--;
                labelPilotsPage.Text = $"{currentPilotsPage} / {totalPilotsPage}";
                listBoxPilots.Items.Clear();

                List<string> pilots = pilotsService.GetPilotsBasicInfo(currentPilotsPage);
                pilots.ForEach(p => listBoxPilots.Items.Add(p));
            }
        }

        private void btnPilotsNext_Click(object sender, EventArgs e)
        {
            if (currentPilotsPage < totalPilotsPage)
            {
                currentPilotsPage++;
                labelPilotsPage.Text = $"{currentPilotsPage} / {totalPilotsPage}";
                listBoxPilots.Items.Clear();

                List<string> pilots = pilotsService.GetPilotsBasicInfo(currentPilotsPage);
                pilots.ForEach(p => listBoxPilots.Items.Add(p));
            }
        }

        private void comboBoxCrewCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCabinCrew.Items.Clear();
        }
    }
}
