using ACM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class Pedometer : Form
    {
        public Pedometer()
        {
            InitializeComponent();
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pedometer_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click_1(object sender, EventArgs e)
        {

            var customer = new Customer();

            try
            {
                var result = customer.CalculatePercentOfGoalSteps(this.GoalTextBox.Text, this.StepsTextBox.Text);
                ResultLabel.Text = $"You reached {result} % of your goal!";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Your entry was not valid: " + ex.Message);
                ResultLabel.Text = string.Empty;
                // Throw - this will send it back up the call chain. Good way to move it up to the global exeption handler
            }

        }
    }
}
