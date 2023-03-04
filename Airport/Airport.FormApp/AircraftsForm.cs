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
        int currentPage = 1;
        int totalPage = 0;
        int itemsPerPage = 10;
        string order = "A-Z";
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

            comboBoxCondtion.SelectedIndex = 0;

            totalPage = service.GetAircraftPagesCount(itemsPerPage);
            List<string> aircrafts = service.GetAircraftsInfo(order, currentPage, itemsPerPage);
            aircrafts.ForEach(x=>listBox1.Items.Add(x));

            comboBoxItemsPerPage.SelectedIndex = 1;
            comboBoxOrder.SelectedIndex = 0;
            labelPageInfo.Text = $"{currentPage} / {totalPage}";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string manufacturer=comboBoxManufacturer.Text;
            string model=comboBoxModel.Text;
            int year = int.Parse(comboBoxYear.Text);
            int hours=int.Parse(txtHours.Text);
            string condition=comboBoxCondtion.Text;
            string type=comboBoxType.Text;

            string result = null;
            //try
            //{
               result = service.CreateAircraft(manufacturer, model, year, hours, condition, type);
            //}
            //catch (Exception ex)
            //{
            //    result= ex.Message;
            //}
            MessageBox.Show(result);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage>1)
            {
                currentPage--;
                labelPageInfo.Text = $"{currentPage} / {totalPage}";
                listBox1.Items.Clear();
                List<string> aircrafts = service.GetAircraftsInfo(order, currentPage, itemsPerPage);
                aircrafts.ForEach(x => listBox1.Items.Add(x));
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage)
            {
                currentPage++;
                labelPageInfo.Text = $"{currentPage} / {totalPage}";
                listBox1.Items.Clear();
                List<string> aircrafts = service.GetAircraftsInfo(order, currentPage, itemsPerPage);
                aircrafts.ForEach(x => listBox1.Items.Add(x));
            }
        }

        private void comboBoxItemsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemsPerPage = int.Parse(comboBoxItemsPerPage.Text);
            totalPage = service.GetAircraftPagesCount(itemsPerPage);
            currentPage = 1;
            labelPageInfo.Text = $"{currentPage} / {totalPage}";
            listBox1.Items.Clear();
            List<string> aircrafts = service.GetAircraftsInfo(order, currentPage, itemsPerPage);
            aircrafts.ForEach(x => listBox1.Items.Add(x));
        }

        private void comboBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            order = comboBoxOrder.Text;
            currentPage = 1;
            labelPageInfo.Text = $"{currentPage} / {totalPage}";
            listBox1.Items.Clear();
            List<string> aircrafts = service.GetAircraftsInfo(order, currentPage, itemsPerPage);
            aircrafts.ForEach(x => listBox1.Items.Add(x));
        }
    }
}
