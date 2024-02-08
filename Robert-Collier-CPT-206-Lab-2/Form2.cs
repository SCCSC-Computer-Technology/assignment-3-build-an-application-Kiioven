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
    public partial class stateInfoForm : Form
    {
        public stateInfoForm()
        {
            InitializeComponent();
        }

        private void stateInfoForm_Load(object sender, EventArgs e)
        {
            string state = Form1.statestring;
            var info = from State in State_infoDataSet
                       where State.StateID
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void thirdcityTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void jobsTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
