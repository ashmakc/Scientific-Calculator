using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        double op1, op2 ,result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numplus_Click(object sender, EventArgs e)
        {

            if (t.Text=="")
            {
            }
            else
            {
                op1 = Convert.ToDouble(t.Text);
                opr = "+";
                t.Clear();
                
            }
        }

        private void num19_Click(object sender, EventArgs e)
        {
            string str = t.Text;
            int n = str.Length;
            t.Text = (str.Substring(0, n - 1));
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (t.Text.Contains("."))
            {
                t.Text = t.Text;
            }
            else {
                t.Text = t.Text + "0.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {
            t.Text += "0";
        }

        private void num3_Click(object sender, EventArgs e){

            if (t.Text == (" "))
            { }
            else
            {
                op1 = Convert.ToDouble(t.Text);
                opr = "%";
                t.Clear();


            } 
        }

        private void num6_Click(object sender, EventArgs e)
        {
            t.Text += "1";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            t.Text += "2";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            t.Text += "3";
        }

        private void num10_Click(object sender, EventArgs e)
        {

            if (t.Text==(""))
            {
            }
            else
            {
                op1 = Convert.ToDouble(t.Text);
                opr = "-";
                t.Clear();
               

            }

        }

        private void num11_Click(object sender, EventArgs e)
        {
            t.Text += "4";
        }

        private void num12_Click(object sender, EventArgs e)
        {
            t.Text += "5";
        }

        private void num13_Click(object sender, EventArgs e)
        {
            t.Text += "6";
        }

        private void num14_Click(object sender, EventArgs e)
        {

            if (t.Text==(" "))
            {
            }
            else
            {
                op1 = Convert.ToDouble(t.Text);
                opr = "*";
                t.Clear();

            }
        }

        private void num15_Click(object sender, EventArgs e)
        {

            if (t.Text==(" "))
            {}
            else
            {
                op1 = Convert.ToDouble(t.Text);
                opr = "/";
                t.Clear();

            }
        }

        private void num16_Click(object sender, EventArgs e)
        {
            t.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            t.Text += "8";
        }

        private void num18_Click(object sender, EventArgs e)
        {
            t.Text += "9";
        }

        private void num20_Click(object sender, EventArgs e)
        {

            t.Clear();
        }

        private void num4_Click(object sender, EventArgs e)
        {
            t.Text = Convert.ToString(System.Math.Exp((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(t.Text))));  

       
        }

        private void num36_Click(object sender, EventArgs e)
        {
            t.Enabled = false;
           // textBox1.Text = "";
            num1.Enabled = false;
            num2.Enabled = false;
            num3.Enabled = false;
            numans.Enabled = false;
            num6.Enabled = false;
            num7.Enabled = false;
            num8.Enabled = false;
            numplus.Enabled = false;
            numminus.Enabled = false;
            num11.Enabled = false;
            num12.Enabled = false;
            num13.Enabled = false;
            nummult.Enabled = false;
            numdiv.Enabled = false;
            num16.Enabled = false;
            eight.Enabled = false;
            num18.Enabled = false;
            num31.Enabled = false;
            num32.Enabled = false;
            num33.Enabled = false;
            num34.Enabled = false;
            numln.Enabled = false;
            num26.Enabled = false;
            num27.Enabled = false;
            num28.Enabled = false;
            num29.Enabled = false;
            numdel.Enabled = false;
            numac.Enabled = false;
            num25.Enabled = false;
            num26.Enabled = false;
            num27.Enabled = false;
            num28.Enabled = false;
            num29.Enabled = false;
            num30.Enabled = false;
            num21.Enabled = false;
            num22.Enabled = false;
            num23.Enabled = false;
            num24.Enabled = false;
            numeq.Enabled =false;

        }
        string opr;

        private void numeq_Click(object sender, EventArgs e)
        {

         
            op2 = Convert.ToDouble(t.Text);
            
            switch (opr)
            { 
                case "+":
         
                   result = op1 + op2;
                    t.Text = Convert.ToString(result);
                    break;

                case "-":
                   
                    result = op1 - op2;
                    t.Text = Convert.ToString(result);
                    break;

                case "*":
                    
                    result = op1 * op2;
                    t.Text = Convert.ToString(result);
                    break;

                case "/":
                   
                    if (op2 == 0)
                    {
                        t.Text = "0.0";
                        break;
                    }
                    else { 
                     
                    result=op1 / op2;
                    t.Text = Convert.ToString(result);
                    break;
                    }
                case "%":
                    
                    result = op1 % op2;
                    t.Text = Convert.ToString(result);
                    break;


            }
        }

        private void num37_Click(object sender, EventArgs e)
        {

            t.Enabled = true;
          //  textBox1.Text = "";
            num1.Enabled = true;
            num2.Enabled = true;
            num3.Enabled = true;
            numans.Enabled = true;
            num6.Enabled = true;
            num7.Enabled = true;
            num8.Enabled = true;
            numdel.Enabled = true;
            numac.Enabled = true;
            numplus.Enabled = true;
            numminus.Enabled = true;
            num11.Enabled = true;
            num12.Enabled = true;
            num13.Enabled = true;
            nummult.Enabled = true;
            numdiv.Enabled = true;
            num16.Enabled = true;
            eight.Enabled = true;
            num18.Enabled = true;
            numeq.Enabled = true;
            num21.Enabled = true;
            num22.Enabled = true;
            num23.Enabled = true;
            num24.Enabled = true;
            num25.Enabled = true;
            num26.Enabled = true;
            num27.Enabled = true;
            num28.Enabled = true;
            num29.Enabled = true;
            num30.Enabled = true;
            num31.Enabled = true;
            num32.Enabled = true;
            num33.Enabled = true;
            num34.Enabled = true;
            numln.Enabled = true; 

        }

        private void num21_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(t.Text) * Convert.ToDouble(t.Text);
            t.Text = Convert.ToString(result);
        }

        private void num29_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(t.Text) * Convert.ToDouble(t.Text) * Convert.ToDouble(t.Text);
            t.Text = Convert.ToString(result);
        }

        private void num31_Click(object sender, EventArgs e)
        {
            t.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(t.Text))));

        }

        private void num25_Click(object sender, EventArgs e)
        {
            
            int var = 1;
            for(int i=1;i<=Convert.ToInt16(t.Text);i++)
            {
                var = i * var;

            }
            t.Text = Convert.ToString(var);
        }

        private void num35_Click(object sender, EventArgs e)
        {
            result = System.Math.Log(Convert.ToDouble(t.Text));

            t.Text = Convert.ToString(result);
        }

        private void num34_Click(object sender, EventArgs e)
        {
            result = System.Math.Log10(Convert.ToDouble(t.Text));

            t.Text = Convert.ToString(result);
        }

        private void num30_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(t.Text);
            result = Math.Pow(op1,(1.0/3.0));
            t.Text = Convert.ToString(result);

        }

        private void num22_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(t.Text);
            result = Math.Sqrt(op1);
            t.Text = Convert.ToString(result);
        }

        private void num23_Click(object sender, EventArgs e)
        {
            t.Text += "(";
        }

        private void num24_Click(object sender, EventArgs e)
        {
            t.Text += ")";
        }

        private void num32_Click(object sender, EventArgs e)
        {
            t.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(t.Text))));
        }

        private void num33_Click(object sender, EventArgs e)
        {
            t.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(t.Text))));
        }

        private void num26_Click(object sender, EventArgs e)
        {
            t.Text = Convert.ToString(System.Math.Sinh((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(t.Text))));
        }

        private void num27_Click(object sender, EventArgs e)
        {
            t.Text = Convert.ToString(System.Math.Cosh((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(t.Text))));
        }

        private void num28_Click(object sender, EventArgs e)
        {
            t.Text = Convert.ToString(System.Math.Tanh((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(t.Text))));
        }
    }
}
