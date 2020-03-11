using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D7_U2_Calc
{
    public partial class Form1 : Form
    {
        string enterNumber = "";
        string operation = "";
        bool isOperatonClicked = false;

        public Form1()
        {
            InitializeComponent();
            button_0.Click += Button_0_Click;
            button_1.Click += Button_1_Click;
            button_2.Click += Button_2_Click;
            button_3.Click += Button_3_Click;
            button_4.Click += Button_4_Click;
            button_5.Click += Button_5_Click;
            button_6.Click += Button_6_Click;
            button_7.Click += Button_7_Click;
            button_8.Click += Button_8_Click;
            button_9.Click += Button_9_Click;
            buttonSubtract.Click += ButtonSubtract_Click;
            buttonMultiply.Click += ButtonMultiply_Click;
            buttonDivid.Click += ButtonDivid_Click;
            buttonEq.Click += ButtonEq_Click;
            buttonClear.Click += ButtonClear_Click;

        }

        private void number_clicked(int num)
        {
            if (isOperatonClicked)
            {
                inputNumber.Text = "";
                isOperatonClicked = false;
            }

            if (inputNumber.Text == "0")
            {
                inputNumber.Text = "";
            }
            inputNumber.Text += num.ToString();
        }

        private void operation_cliced(string op)
        {




            // 1. saglabat esosos skaitli enteredNumber
            enterNumber = inputNumber.Text;

            // 2. izveleta darbiba jasaglaba ka "operation"

            operation = op;
            // 3. spiezot ciparu pec darbibas - jasak jauna ievade

            isOperatonClicked = true;


        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            inputNumber.Text = "0";
        }

        private void ButtonEq_Click(object sender, EventArgs e)
        {
            operation_cliced("=");
        }

        private void ButtonDivid_Click(object sender, EventArgs e)
        {

            operation_cliced("/");
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            operation_cliced("*");
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            operation_cliced("-");
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            number_clicked(9);
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            number_clicked(8);
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            number_clicked(7);
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            number_clicked(6);
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            number_clicked(5);
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            number_clicked(4);
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            number_clicked(3);
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            number_clicked(2);
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            number_clicked(1);
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            number_clicked(0);
        }
    }
}
