using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robert_Collier_CPT_206_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'state_infoDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.state_infoDataSet.Table1);
            // TODO: This line of code loads data into the 'state_infoDataSet.Table1' table. You can move, or remove it, as needed.



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string statestring;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void stateInfobtn_Click(object sender, EventArgs e)
        {
            object statestring = comboBox1.SelectedItem;
            string state = Convert.ToString(statestring);
            stateInfoForm form2 = new stateInfoForm();
            form2.ShowDialog();

        }

        private void stateSearchSortbtn_Click(object sender, EventArgs e)
        {
            stateSortSearchForm newsortForm = new stateSortSearchForm();
            newsortForm.ShowDialog();
        }
    }
}
