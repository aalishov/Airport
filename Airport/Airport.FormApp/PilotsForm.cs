using Airport.Models;
using Airport.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Airport.FormApp
{
    public partial class PilotsForm : Form
    {
        private PilotsService service;
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int totalPages = 0;
        private int currentPilotId = 0;
        public PilotsForm()
        {
            InitializeComponent();
            service = new PilotsService();
        }
        private void PilotsForm_Load(object sender, EventArgs e)
        {
            List<int> age = (Enumerable.Range(18, 48).ToList());
            age.ForEach(x => comboAge.Items.Add(x));
            for (double i = 0.0; i <= 10.0; i += 0.2)
            {
                comboRating.Items.Add($"{i:f1}");
            }
            comboAge.SelectedIndex = 0;
            comboRating.SelectedIndex = 0;
            comboBoxItemsPerPage.SelectedIndex = 0;
            //List<string> pilots = service.GetPilotsBasicInfo();
            //pilots.ForEach(x => listBoxPilots.Items.Add(x));
            labelPageInfo.Text = $"{currentPage} / {totalPages}";
            radioAdd.Checked = true;
            checkBoxDelete.Visible= false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                int age = int.Parse(comboAge.SelectedItem.ToString());
                double rating = double.Parse(comboRating.SelectedItem.ToString());
                string result = service.CreatePilot(firstName, lastName, age, rating);

                MessageBox.Show(result);
                ClearAddGroupBox();
            }
            else if (btnAdd.Text == "Update")
            {
                if (checkBoxDelete.Checked)
                {
                    MessageBox.Show(service.DeletePilotById(currentPilotId));
                }
                else
                {
                    double rating = double.Parse(comboRating.Text);
                    MessageBox.Show(service.UpdatePilotRating(currentPilotId, rating));
                }
                ClearAddGroupBox();
            }
        }

        private void ClearAddGroupBox()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            comboAge.SelectedIndex = 0;
            comboRating.SelectedIndex = 0;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboRating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAdd_Click(object sender, EventArgs e)
        {
            ClearAddGroupBox();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage <= 1) { return; }
            listBoxPilots.Items.Clear();
            List<string> list = service.GetPilotsBasicInfo(--currentPage, itemsPerPage);
            list.ForEach(p => listBoxPilots.Items.Add(p));
            labelPageInfo.Text = $"{currentPage} / {totalPages}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage >= totalPages) { return; }
            listBoxPilots.Items.Clear();
            List<string> list = service.GetPilotsBasicInfo(++currentPage, itemsPerPage);
            list.ForEach(p => listBoxPilots.Items.Add(p));
            labelPageInfo.Text = $"{currentPage} / {totalPages}";
        }

        private void comboBoxItemsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemsPerPage = int.Parse(comboBoxItemsPerPage.Text);
            totalPages = service.GetPilotsPagesCount(itemsPerPage);

            listBoxPilots.Items.Clear();
            List<string> list = service.GetPilotsBasicInfo(1, itemsPerPage);
            list.ForEach(p => listBoxPilots.Items.Add(p));
            labelPageInfo.Text = $"{currentPage} / {totalPages}";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAdd.Checked)
            {
                btnAdd.Text = "Add";
                listBoxPilots.Enabled = false;
                txtFirstName.Enabled = !false;
                txtLastName.Enabled = !false;
                comboAge.Enabled = !false;
                checkBoxDelete.Visible = false;
                ClearAddGroupBox();
                AddInputOnOff(true);
            }
            else
            {
                btnAdd.Text = "Update";
                checkBoxDelete.Visible = true;
                listBoxPilots.Enabled = true;
                AddInputOnOff(false);
            }
        }

        private void AddInputOnOff(bool isActive)
        {
            txtFirstName.Enabled = isActive;
            txtLastName.Enabled = isActive;
            comboAge.Enabled = isActive;
        }

        private void listBoxPilots_DoubleClick(object sender, EventArgs e)
        {
            string pilotInfo = listBoxPilots.Text;
            currentPilotId = int.Parse(pilotInfo.Split(' ').First());
            Pilot pilot = service.GetPilotById(currentPilotId);
            if (pilot != null)
            {
                txtFirstName.Text = pilot.FirstName;
                txtLastName.Text = pilot.LastName;
                comboAge.Text = pilot.Age.ToString();
                comboRating.Text = pilot.Rating.ToString();
            }
        }

        private void checkBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDelete.Checked)
            {
                checkBoxDelete.ForeColor = Color.Red;
                btnAdd.ForeColor=Color.Red;
            }
            else
            {
                checkBoxDelete.ForeColor = Color.Black;
                btnAdd.ForeColor = Color.Black;
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            string result=service.GetStatistics();
            string fileName = $"file-{DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss-ff")}.txt";
            File.WriteAllText(fileName, result);

            Process.Start("notepad.exe",fileName);

            //aalishov@souvl-velingrad.com
        }
    }
}
