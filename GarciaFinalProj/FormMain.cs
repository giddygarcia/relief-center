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
    public partial class FormMain : Form {
        ReliefCenter reliefcenter = new ReliefCenter("");

        public string NameProperty {
            set
            {
                lnameReliefCenter.Text = value;
            }
        }

        public FormMain() { 
            InitializeComponent();
            //following 2 lines disable donating & releasing in absence of goods
            buttonDonate.Enabled = false;
            buttonRelease.Enabled = false;
        }

        //unfortunate misclick
        private void addgoodNametb_TextChanged(object sender, EventArgs e)
        {}

        private void buttonAdd_Click(object sender, EventArgs e) {
            string nameOfGood = addgoodNametb.Text.ToUpper();
            int rateOfGood = int.Parse(addgoodRatetb.Text);
            string unitOfGood = addgoodUnitcb.Text.ToLower();
            // ^ ToUpper for easy identification & ToLower for uniformity of unit

            //add custom units in addition to set dropdown
            addgoodUnitcb.Items.Add(unitOfGood);

            if (string.IsNullOrEmpty(addgoodNametb.Text) || string.IsNullOrEmpty(addgoodRatetb.Text) || string.IsNullOrEmpty(addgoodUnitcb.Text))
            {
                rtbMain.Text += Environment.NewLine + "Invalid Input.\n";
                MessageBox.Show("Please fill empty values.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                if (reliefcenter.FindGood(nameOfGood) == null)
                    donateNamecb.Items.Add(nameOfGood);

                rtbMain.Text += Environment.NewLine + reliefcenter.AddNewGood(nameOfGood, rateOfGood, unitOfGood);
                buttonDonate.Enabled = true;
                buttonRelease.Enabled = true;
            }
            addgoodNametb.Text = null;
            addgoodRatetb.Text = null;
            addgoodUnitcb.Text = null;
        }

        private void buttonDonate_Click(object sender, EventArgs e) {
            int quantity;

            if (string.IsNullOrEmpty(donateNamecb.Text) || string.IsNullOrEmpty(donateQuantitytb.Text))
            {
                rtbMain.Text += Environment.NewLine + "Invalid Input.\n";
                MessageBox.Show("Please fill empty values.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                quantity = int.Parse(donateQuantitytb.Text);
                rtbMain.Text += Environment.NewLine + reliefcenter.RecieveGoods(donateNamecb.Text, quantity);
            }
        }

        private void buttonRelease_Click(object sender, EventArgs e) {
            int amount = int.Parse(releaseAmounttb.Text);
            rtbMain.Text += Environment.NewLine + reliefcenter.ReleasePacks(amount);
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            rtbMain.Text = null;
        }

        private void buttonPrint_Click(object sender, EventArgs e) {
            rtbMain.Text += Environment.NewLine + reliefcenter.PrintInventory();
        }

        private void rtbMain_TextChanged(object sender, EventArgs e) {
            rtbMain.SelectionStart = rtbMain.Text.Length;
            rtbMain.ScrollToCaret();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.ExitThread();
            else if (dialog == DialogResult.No)
                e.Cancel = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}