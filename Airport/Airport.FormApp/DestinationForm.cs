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
    public partial class DestinationForm : Form
    {
        private DestinationsService destinationsService;
        private int fromAirportId = 0;
        private int toAirportId = 0;
        private int aircrafttId = 0;
        public DestinationForm()
        {
            InitializeComponent();
            destinationsService = new DestinationsService();
        }

        private void DestinationForm_Load(object sender, EventArgs e)
        {
            listBoxFrom.Items.Clear();
            listBoxFrom.Enabled = true;
            listBoxTo.Items.Clear();
            listBoxTo.Enabled = true;
            listBoxAircraft.Items.Clear();
            listBoxAircraft.Enabled = true;

            labelStepInfo.Text = "Step 1 - Select destination start point";
            List<string> fromAirports = destinationsService.GetFromAirports();
            fromAirports.ForEach(x => listBoxFrom.Items.Add(x));
            btnCreate.Enabled=false;
        }

        private void listBoxFrom_DoubleClick(object sender, EventArgs e)
        {
            labelStepInfo.Text = "Step 2 - Select destination end point";
            fromAirportId = int.Parse(listBoxFrom.Text.Split(" - ").FirstOrDefault());
            List<string> toAirports = destinationsService.GetToAirports(fromAirportId);
            toAirports.ForEach(x => listBoxTo.Items.Add(x));
            listBoxFrom.Enabled = false;
        }

        private void listBoxTo_DoubleClick(object sender, EventArgs e)
        {
            labelStepInfo.Text = "Step 3 - Select aircraft";
            toAirportId = int.Parse(listBoxTo.Text.Split(" - ").FirstOrDefault());
            List<string> aircrafts = destinationsService.GetAircrafts();
            aircrafts.ForEach(x => listBoxAircraft.Items.Add(x));
            listBoxTo.Enabled = false;
        }


        private void listBoxAircraft_DoubleClick(object sender, EventArgs e)
        {
            labelStepInfo.Text = "Step 4 - select date, enter price and tickets count";
            aircrafttId = int.Parse(listBoxAircraft.Text.Split(" - ").FirstOrDefault());
            listBoxAircraft.Enabled = false;
            btnCreate.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime fligthDate = dateTimePicker1.Value;
                int ticketsCount = int.Parse(txtTicketsCount.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                string result = destinationsService.CreateDestination(fromAirportId, toAirportId, fligthDate, aircrafttId, price, ticketsCount);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DestinationForm_Load(sender,e);
        }
    }
}
