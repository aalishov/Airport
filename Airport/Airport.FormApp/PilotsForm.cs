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
    public partial class PilotsForm : Form
    {
        private PilotsService service;
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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int age = int.Parse(comboAge.SelectedItem.ToString());
            double rating = double.Parse(comboRating.SelectedItem.ToString());
            string result = service.CreatePilot(firstName, lastName, age, rating);

            MessageBox.Show(result);
            ClearAddGroupBox();
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
    }
}
