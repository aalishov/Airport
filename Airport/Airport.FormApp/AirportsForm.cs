using Airport.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Airport.FormApp
{
    public partial class AirportsForm : Form
    {
        private AirportsService service;
        private int currentPage = 1;
        private int totalPage = 1;
        private string searchByCountry = "";
        public AirportsForm()
        {
            InitializeComponent();
            service = new AirportsService();

            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //Set datagrid visual style
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AirportsForm_Load(object sender, EventArgs e)
        {
            radioInsert.Checked = true;

            UpdateGrid("", currentPage);
            totalPage = service.AirportsTotalPage();
            labelPageInfo.Text = $"{currentPage} / {totalPage}";
        }

        private void UpdateGrid(string country, int page, int count = 10)
        {
            List<Models.Airport> airports = service.GetAirports(country, page, count);
            dataGridView1.Rows.Clear();
            foreach (var airport in airports)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = airport.Id;
                row.Cells[1].Value = airport.Country.Length > 15 ? airport.Country.Substring(0, 15) : airport.Country;
                row.Cells[2].Value = airport.Name.Length > 30 ? airport.Name.Substring(0, 30) : airport.Name;

                this.dataGridView1.Rows.Add(row);
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                UpdateGrid(searchByCountry, currentPage);
                labelPageInfo.Text = $"{currentPage} / {totalPage}";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage)
            {
                currentPage++;
                UpdateGrid(searchByCountry, currentPage);
                labelPageInfo.Text = $"{currentPage} / {totalPage}";
            }
        }

        private void radioInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInsert.Checked)
            {
                txtCountry.Enabled = true;
                txtName.Enabled = true;
                labelId.Text = "-";
                txtCountry.Text = "";
                txtName.Text = "";
            }
        }

        private void radioUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUpdate.Checked)
            {
                txtCountry.Enabled = true;
                txtName.Enabled = true;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    labelId.Text = dataGridView1.SelectedCells[0].Value.ToString();
                    txtCountry.Text = dataGridView1.SelectedCells[1].Value.ToString();
                    txtName.Text = dataGridView1.SelectedCells[2].Value.ToString();
                }
            }
        }

        private void radioDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDelete.Checked)
            {
                txtCountry.Enabled = false;
                txtName.Enabled = false;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    labelId.Text = dataGridView1.SelectedCells[0].Value.ToString();
                    txtCountry.Text = dataGridView1.SelectedCells[1].Value.ToString();
                    txtName.Text = dataGridView1.SelectedCells[2].Value.ToString();
                }
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (radioInsert.Checked)
            {
                radioInsert_CheckedChanged(sender, e);
            }
            else if (radioUpdate.Checked)
            {
                radioUpdate_CheckedChanged(sender, e);
            }
            else if (radioDelete.Checked)
            {
                radioDelete_CheckedChanged(sender, e);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (radioInsert.Checked)
            {
                string name = txtName.Text;
                string countryName = txtCountry.Text;
                string result = service.CreateAirport(name, countryName);
                MessageBox.Show(result);

                totalPage = service.AirportsTotalPage(searchByCountry);
                currentPage=totalPage;
                UpdateGrid("", currentPage);
                labelPageInfo.Text = $"{currentPage} / {totalPage}";

                txtCountry.Text = "";
                txtName.Text = "";
            }
            else if (radioUpdate.Checked)
            {
                int id = int.Parse(labelId.Text);
                string name = txtName.Text;
                string countryName = txtCountry.Text;
                string result = service.UpdateAirport(id,name, countryName);
                MessageBox.Show(result);

                UpdateGrid(searchByCountry, currentPage);
            }
            else if (radioDelete.Checked)
            {
                int id = int.Parse(labelId.Text);
                string result = service.DeleteAirport(id);
                MessageBox.Show(result);
                totalPage = service.AirportsTotalPage(searchByCountry);
                UpdateGrid(searchByCountry, currentPage);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchByCountry=txtSearch.Text;
            totalPage = service.AirportsTotalPage(searchByCountry);
            currentPage = 1;
            labelPageInfo.Text = $"{currentPage} / {totalPage}";
            UpdateGrid(searchByCountry, currentPage);
        }
    }
}
