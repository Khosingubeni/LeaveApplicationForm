using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveApplicationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void resetData()
        {
            namesTxb.Text = "";
            reasonsRichTxb.Text = "";
            leavetypeCmbx.SelectedIndex = -1;
            fromDate.Value = DateTime.Now;
            toDate.Value = DateTime.Now;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if(fromDate.Value <= toDate.Value && namesTxb.Text.Length > 0 && leavetypeCmbx.SelectedIndex != -1 && reasonsRichTxb.Text.Length > 0)
            {
                MessageBox.Show("Leave Application Successful");
                resetData();
            }

            else
            {
                MessageBox.Show(" Full Names Not Provided" + "\n Leave Type Not Selected" + "\n Reasons Not Stated");
            }
        }
    }
}
