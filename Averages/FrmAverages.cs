using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Averages
{
    public partial class FrmAverages : Form
    {
        public FrmAverages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mark1;
            int mark2;
            int mark3;
            double average;

            mark1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter a mark", "Averages", "0"));
            mark2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter a mark", "Averages", "0"));
            mark3 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter a mark", "Averages", "0"));

            average = (double)(mark1 + mark2 + mark3) / 3;

            MessageBox.Show("Average: " + average.ToString());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name;
            double hours;
            double rateOfPay;
            double grossPay;
            double taxes;
            double netPay;

            name = Microsoft.VisualBasic.Interaction
                .InputBox("Please enter your name", "Net Pay", "Name");
            hours = double.Parse(Microsoft.VisualBasic.Interaction
                .InputBox("Please enter your hours", "New Pay", "0"));
            rateOfPay = double.Parse(Microsoft.VisualBasic.Interaction
                .InputBox("Please enter your rate of pay", "New Pay", "0"));

            grossPay = hours * rateOfPay;
            taxes = grossPay * 0.2;
            netPay = grossPay - taxes;

            MessageBox.Show(name + ", Your new pay is " + netPay.ToString("c"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int gallonsInTank;
            int gallonsRemaining;
            int barrelsNeeded;

            gallonsInTank = int.Parse(Microsoft.VisualBasic.Interaction
                .InputBox("Please the number of gallons in the tank", "Barrels", "0"));
            barrelsNeeded = gallonsInTank / 42;
            gallonsRemaining = gallonsInTank % 42;
            
            MessageBox.Show("Youe need " + barrelsNeeded.ToString() +
                " barrel(s) and " + gallonsRemaining.ToString() + " gallon(s) remain.");



        }
    }
}
