using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCalculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_BMI_Page_Click(object sender, EventArgs e)
        {

        }

        private void btn_Macro_Page_Click(object sender, EventArgs e)
        {
            BMI_pic.Visible = false;
            btn_BMI_result.Visible = false;
        }
    }
}
