using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarciaFinalProj
{
    public partial class FormName : Form {

        int num;

        public FormName() {
            InitializeComponent();
            num = 0;
        }

        private void buttonSubmit_Click(object sender, EventArgs e) {
            {
                FormMain fMain = new FormMain();
                if (tbnameReliefCenter.Text != "")
                {
                    string name = tbnameReliefCenter.Text;
                    fMain.NameProperty = name + " Relief Center";
                    fMain.ShowDialog();
                    string lnameReliefCenter = string.Format(name);

                    lnameReliefCenter = name;
                    tbnameReliefCenter.Text = "";
                    Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a name.", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                num++;
            }
        }
    }
}
