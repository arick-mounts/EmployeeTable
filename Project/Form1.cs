using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {

        /*
         * This program initilizes a table of employee objects, and allows the user to sort by their choice of attributes
         * C# @ TCC
         * 
         * Arick Mounts
         * 
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.personalDataSet.Employee);

        }

        private void SortByPrice_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.FillByHourlyPay(this.personalDataSet.Employee);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.employeeTableAdapter.FillByHourlyPayDesc(this.personalDataSet.Employee);
        }
    }
}
