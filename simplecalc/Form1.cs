using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplecalc
{
    public partial class Form1 : Form
    {
        Double val = 0;
        string txt = "";
        bool opr_prs = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num7_Click(object sender, EventArgs e)
        { 

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if((output.Text == "0")||(opr_prs))
            {
                output.Clear();
            }
            Button button = (Button)sender;
            output.Text = output.Text + button.Text;
            opr_prs = false;
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void op_Add(object sender, EventArgs e)
        {

        }

        private void op_Prs(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txt = button.Text;
            //if(val >= 0)
            //val = Double.Parse(output.Text);
            try
            {
                val = Double.Parse(output.Text);
            }
            catch(System.FormatException)
            {
                val = 0;
            }
            opr_prs = true;
        }

        private void op_res(object sender, EventArgs e)
        {
            try {
                switch (txt)
                {
                    case "+":
                        output.Text = (val + Double.Parse(output.Text)).ToString();
                        break;
                    case "-":
                        output.Text = (val - Double.Parse(output.Text)).ToString();
                        break;
                    case "*":
                        output.Text = (val * Double.Parse(output.Text)).ToString();
                        break;
                    case "/":
                        output.Text = (val / Double.Parse(output.Text)).ToString();
                        break;
                    default:
                        break;
                }
                opr_prs = false;
            }
            catch(System.FormatException)
            {

            }
            
        }

        private void c_prs(object sender, EventArgs e)
        {
            output.Clear();
            val = 0;
        }
    }
}
