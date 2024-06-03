using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS162_PopulationDatabaseFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);

        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sortPop_Button_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPop(populationDBDataSet.City);
        }

        private void sortPopDESC_Button_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPopDESC(populationDBDataSet.City);
        }

        private void sortCity_Button_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByCity(populationDBDataSet.City);
        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            cityTableAdapter.Fill(populationDBDataSet.City);
        }
        private void getTotal_Button_Click(object sender, EventArgs e)
        {
            double? total = cityTableAdapter.GetTotalPop();
            MessageBox.Show($"Total Population Is {total}.");
        }

        private void getAverage_Button_Click(object sender, EventArgs e)
        {
            double? avg = cityTableAdapter.GetAveragePop();
            MessageBox.Show($"Average Population Is {avg}.");
        }

        private void getHighest_Button_Click(object sender, EventArgs e)
        {
            double? highest = cityTableAdapter.GetMaxPop();
            MessageBox.Show($"Highest Population Is {highest}.");
        }

        private void getLowest_Button_Click(object sender, EventArgs e)
        {
            double? lowest = cityTableAdapter.GetLowestPop();
            MessageBox.Show($"Lowest Population Is {lowest}.");
        }
    }
}
