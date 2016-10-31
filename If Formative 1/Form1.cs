// By: Manuel Muncaster
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_Formative_1
{
    public partial class Form1 : Form
    {
        int inputNumber;
        int divideNumber;

        public Form1()
        {
            InitializeComponent();
            signOutputLabel.Visible = false;
            divideOutputLabel.Visible = false;

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            inputNumber = Convert.ToInt16(inputTextbox.Text);

            divideNumber = inputNumber % 7;

            if (inputNumber > 0) 
            {
                signOutputLabel.Visible = true;
                signOutputLabel.Text = inputNumber + " is a positve number";
            }

            else if (inputNumber < 0)
            {
                signOutputLabel.Visible = true;
                signOutputLabel.Text = inputNumber + " is a negative number";
            }

            if (divideNumber == 0)
            {
                divideOutputLabel.Visible = true;
                divideOutputLabel.Text = inputNumber + " is divisible by 7";
            }

            else if (divideNumber != 0)
            {
                divideOutputLabel.Visible = true;
                divideOutputLabel.Text = inputNumber + " is not divsible by 7";
            }
        }
    }
}
