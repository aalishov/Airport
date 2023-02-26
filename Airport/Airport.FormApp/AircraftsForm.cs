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
    public partial class AircraftsForm : Form
    {
        AircraftsService service;
        public AircraftsForm()
        {
            InitializeComponent();
            service = new AircraftsService();
        }

        private void AircraftsForm_Load(object sender, EventArgs e)
        {
            List<string> manufacturers = service.GetManufacturersName();


            manufacturers.ForEach(x => comboBoxManufacturer.Items.Add(x));
            comboBoxManufacturer.SelectedIndex = 0;

            List<string> models = service.GetManufacturesModels(comboBoxManufacturer.Text);
            models.ForEach(x => comboBoxModel.Items.Add(x));
            comboBoxModel.SelectedIndex = 0;

            List<int> years = Enumerable.Range(1980, 42).ToList();
            years.ForEach(x => comboBoxYear.Items.Add(x));
            comboBoxYear.SelectedIndex = comboBoxYear.Items.Count / 2;
        }

        private void comboBoxManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModel.Items.Clear();
            List<string> models = service.GetManufacturesModels(comboBoxManufacturer.Text);
            models.ForEach(x => comboBoxModel.Items.Add(x));
            comboBoxModel.SelectedIndex = 0;
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxType.Items.Clear();
            string type = service.GetModelType(comboBoxManufacturer.Text, comboBoxModel.Text);
            comboBoxType.Text = type;

        }

        private void comboBoxModel_TextChanged(object sender, EventArgs e)
        {
            comboBoxType.Items.Clear();
            string type = service.GetModelType(comboBoxManufacturer.Text, comboBoxModel.Text);
            if (string.IsNullOrWhiteSpace(type))
            {
                List<string> allTypes = service.GetAllModelType();
                allTypes.ForEach(x => comboBoxType.Items.Add(x));
            }
            else
            {
                comboBoxType.Text = type;
            }
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
