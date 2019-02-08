using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D7_U1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labelCount.Text = "Skaits: ";
            buttonAdd.Click += ButtonAdd_Click;
            buttonClear.Click += ButtonClear_Click;
            buttonSubtract.Click += ButtonSubtract_Click;
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            inputNumber.Text = (int.Parse(inputNumber.Text) - 1).ToString();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            inputNumber.Text = "1";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            inputNumber.Text = (int.Parse(inputNumber.Text)+ 1).ToString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Notīrīt_Click(object sender, EventArgs e)
        {

        }
    }
}
