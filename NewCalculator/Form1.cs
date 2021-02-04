using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculator
{
    public partial class Calculator : Form
    {
        double first, second, answer;
        string function;
        Class1 head;
        Class1 current;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            allofit.Text = "";
            head = new Class1();
            head = null;
            current = head;
            this.KeyPreview = true;

            solvebtn.Focus();
            solvebtn.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 9;
        }

        /*private void addbtn_Click(object sender, EventArgs e)
        {
            AddtoList("+");
            PrintList();
            display.Text = "";
        } */

        private void subbtn_Click(object sender, EventArgs e)
        {
            AddtoList("-");
            PrintList();
            display.Text = "";
        }

        private void multbtn_Click(object sender, EventArgs e)
        {
            AddtoList("*");
            PrintList();
            display.Text = "";
        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            AddtoList("/");
            PrintList();
            display.Text = "";
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void clearallbtn_Click(object sender, EventArgs e)
        {
            display.Text = "";
            first = second = answer = 0;
            allofit.Text = "";
            function = "";
            head = null;
            current = null;
        }

        private void solvebtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(display.Text, out second))
            {
                if (function == "+")
                {
                    answer = first + second;
                }
                else if (function == "-")
                {
                    answer = first - second;
                }
                else if (function == "*")
                {
                    answer = first * second;
                }
                else if (function == "/")
                {
                    answer = first / second;
                }
                else
                {
                    display.Text = "ERROR";
                }
                display.Text = "" + answer;
                allofit.Text = allofit.Text + second + "=";
            }
            else
            {
                display.Text = "ERROR";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 0;
        }

        private void decbtn_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }

        private void Calculator_Load_1(object sender, EventArgs e)
        {
            allofit.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + 1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + 2;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + 3;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + 4;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + 5;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + 6;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + 7;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + 8;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + 9;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + 0;
        }

        private void clearbtn_Click_1(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void addbtn_Click_1(object sender, EventArgs e)
        {
            AddtoList("+");
            PrintList();
            display.Text = "";
        }

        private void subbtn_Click_1(object sender, EventArgs e)
        {
            AddtoList("-");
            PrintList();
            display.Text = "";
        }

        private void multbtn_Click_1(object sender, EventArgs e)
        {
            AddtoList("*");
            PrintList();
            display.Text = "";
        }

        private void divbtn_Click_1(object sender, EventArgs e)
        {
            AddtoList("/");
            PrintList();
            display.Text = "";
        }

        private void decbtn_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }

        private void clearallbtn_Click_1(object sender, EventArgs e)
        {
            display.Text = "";
            first = second = answer = 0;
            allofit.Text = "";
            function = "";
            head = null;
            current = null;
        }

        private void AddtoList(string s)
        {
            if(Double.TryParse(display.Text, out first))
            {
                if (head == null)
                {
                    head = new Class1();
                    current = head;
                    current.number = first;
                    current.n = true;

                    current.next = new Class1();
                    current = current.next;
                    current.symbol = s;
                    current.n = false;
                    current.next = null;

                }
                else
                {
                    current.next = new Class1();
                    current = current.next;
                    current.number = first;
                    current.n = true;
                 
                    current.next = new Class1();
                    current = current.next;
                    current.symbol = s;
                    current.n = false;
                    current.next = null;
                    
                }
                
                
            }
            else
            {
                allofit.Text = "ERROR";
                display.Text = "";
            }
            //current.number = x;
            //current.n = true;
            //current.s = false;
            //current = current.next;
            //current = new Class1();
            //current.symbol = "s";
            //current.s = true;
            //current.n = false;
            //current = current.next;
            //current = new Class1();
        }

        private void PrintList()
        {
            Class1 print = head;
            string temp = "";
            while(print != null)
            {
                if (print.n)
                {
                    temp = temp + print.number;
                }
                else
                {
                    temp = temp + print.symbol;
                }
                print = print.next;
            }
            allofit.Text = temp;
        }

        private double Calculate()
        {
            Multiply();
            Divide();
            Add();
            Subtract();
            return head.number;
        }

        private void Multiply()
        {
            Class1 m = head;
            Class1 temp;
            while(m.next != null)
            {
                if(m.next.symbol == "*")
                {
                    double answer = m.number * m.next.next.number;
                    temp = m.next.next.next;
                    m.next = temp;
                    m.number = answer;
                }
                else
                {
                    m = m.next;
                }
            }
        }

        private void Divide()
        {
            Class1 d = head;
            Class1 temp;
            while (d.next != null)
            {
                if (d.next.symbol == "/")
                {
                    double answer = d.number / d.next.next.number;
                    temp = d.next.next.next;
                    d.next = temp;
                    d.number = answer;
                }
                else
                {
                    d = d.next;
                }
            }
        }

        private void solvebtn_Click_1(object sender, EventArgs e)
        {
            AddtoList("=");
            PrintList();
            display.Clear();
            double answer = Calculate();
            display.Text = "" + answer;
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            char p = e.KeyChar;
            if(p == '1'||p == '2'||p == '3'||p == '4'||p == '5'||p =='6'||p == '7'||p == '8'||p == '9'||p == '0')
            {
                if(display.Text == "ERROR")
                {
                    display.Clear();
                }
                display.Text = display.Text + p;
                
            }
            else if (p == '+' || p == '-' || p == '*' || p == '/' || p == '.')
            {
                string s = "" + p;
                AddtoList(s);
                PrintList();
                display.Clear();
            }
            else if (p == (char)Keys.Enter)
            {
                AddtoList("=");
                PrintList();
                display.Clear();
                double answer = Calculate();
                display.Text = "" + answer;
            }
            /*switch(e.KeyChar)
            {
                case '1':
                    if (display.Text == "ERROR")
                    {
                        display.Clear();
                    }
                    display.Text = display.Text + 1;
                    break;
                case '2':
                    if (display.Text == "ERROR")
                    {
                        display.Clear();
                    }
                    display.Text = display.Text + 2;
                    break;
            } */
        }

        private void Add()
        {
            Class1 a = head;
            Class1 temp;
            while (a.next!= null)
            {
                if (a.next.symbol == "+")
                {
                    double answer = a.number + a.next.next.number;
                    temp = a.next.next.next;
                    a.next = temp;
                    a.number = answer;
                }
                else
                {
                    a = a.next;
                }
            }
        }
        private void Subtract()
        {
            Class1 s = head;
            Class1 temp;
            while (s.next != null)
            {
                if (s.next.symbol == "-")
                {
                    double answer = s.number - s.next.next.number;
                    temp = s.next.next.next;
                    s.next = temp;
                    s.number = answer;
                }
                else
                {
                    s = s.next;
                }
            }
        }
    }
}
