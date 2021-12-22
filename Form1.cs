using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }
        double op1,op2;
        string operation = "";
        bool chk = false;
        private void clear_Click(object sender, EventArgs e)
        {
            op1 =op2= 0;
            operation = "";
            chk = false;
            result.Text = "";
        }

        private void mod_Click(object sender, EventArgs e)
        {
            if (chk && result.Text != "")
            {
                operation = "mod";
                op1 = double.Parse(result.Text);
                result.Text = "";
            }
            
        }

        private void per_Click(object sender, EventArgs e)
        {
            if (result.Text!="")
            {
                //operation = "%";
                op1 = double.Parse(result.Text);
                result.Text = (op1 / 100).ToString();
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (chk && result.Text != "")
            {
                operation = "/";
                op1 = double.Parse(result.Text);
                result.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!chk) { result.Text = "7"; chk = true; }
            else { result.Text += "7"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!chk) { result.Text = "8"; chk = true; }
            else { result.Text += "8"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!chk) { result.Text = "9"; chk = true; }
            else { result.Text += "9"; }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (chk && result.Text != "") 
            {
                operation = "*";
                op1 = double.Parse(result.Text);
                result.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!chk) { result.Text = "4"; chk = true; }
            else { result.Text += "4"; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!chk) { result.Text = "5"; chk = true; }
            else { result.Text += "5"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!chk) { result.Text = "6"; chk = true; }
            else { result.Text += "6"; }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (chk && result.Text != "")
            {
                operation = "-";
                op1 = double.Parse(result.Text);
                result.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!chk) { result.Text = "1"; chk = true; }
            else { result.Text += "1"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!chk) { result.Text = "3"; chk = true; }
            else { result.Text += "3"; }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (chk && result.Text!="")
            {
                operation = "+";
                op1 = double.Parse(result.Text);
                result.Text = "";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!chk) { result.Text = "0"; chk = true; }
            else { result.Text += "0"; }
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains(".")==false) 
            {
                if (result.Text == "") { result.Text= "0.";chk = true; } 
                else { result.Text += "."; } }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (result.Text!="") {result.Text= result.Text.Remove(result.Text.Length - 1);
                if (operation == "" && result.Text!="") { op1 = double.Parse(result.Text); }
                else if(operation!="" && result.Text != "") { op2 = double.Parse(result.Text); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!chk) { result.Text = "2"; chk = true; }
            else { result.Text += "2"; }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (chk) {
                op2=double.Parse(result.Text);
                switch (operation)
                {
                   case "+":
                        result.Text = (op1 + op2).ToString();
                        break;
                    case "-":
                        result.Text = (op1 - op2).ToString();
                        break;
                    case "*":
                        result.Text = (op1 * op2).ToString();
                        break;
                    case "/":
                        result.Text = (op1 /op2).ToString();
                        break;
                    case "mod":
                        result.Text = (op1%op2).ToString();
                        break;
                        
                }
                operation = "";
                op1 = double.Parse(result.Text);
            }
        }
    }
}
