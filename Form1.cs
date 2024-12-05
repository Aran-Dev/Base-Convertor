using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System;


namespace projectttttt
{
    public partial class Form1 : Form
    {

        static bool IsLetterOrDigit(char c)
        { 
            return char.IsLetter(c) || char.IsDigit(c); 
        }     
        
        int a, i = 0, t = 0, k, len = 0;
        int num, result = 0;
        int[] b = new int[10];
        string[] c = new string[10];



        public Form1()
        {
            InitializeComponent();
        }

        private void to2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, i = 0, t = 0;
            a = int.Parse(textBox1.Text);
            label1.Text = "";
            while (a != 0)
            {
                b[i] = a % 2;
                a = a / 2;
                t++;
                i++;
            }

            for (int j = t - 1; j >= 0; j--)
            {
                label1.Text += b[j].ToString();

            }

           }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0, t = 0, a;
            a = int.Parse(textBox1.Text);
            label1.Text = "";
            while (a != 0)
            {
                b[i] = a % 8;
                a = a / 8;
                t++;
                i++;
            }

            for (int j = t - 1; j >= 0; j--)
            {
                label1.Text += b[j].ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] c = new string[10];
            int a, i = 0, t = 0;
            a = int.Parse(textBox1.Text);
            label1.Text = "";
            while (a > 0)
            {
                k = a % 16;
                if (k < 10)
                {
                    c[i] = k.ToString();

                }

                else
                {
                    c[i] = ((char)(k - 10 + 'A')).ToString();
                }

                a = a / 16;
                i++;
                t++;
            }

            for (int j = t-1; j >= 0; j--)
            {
                label1.Text += c[j].ToString();
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string s, h;
            int t = 0, n = 0;
            s = textBox1.Text;
            for (int i = s.Length -1;i >= 0;i--)
            {
                h = s.Substring(i, 1);
                int a = int.Parse(h);
                n = n + (a * (int)Math.Pow(2, t));
                t++;
            }

            label1.Text = n.ToString();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            string s, h;
            int t = 0, n = 0;
            s = textBox1.Text;
            for (int i = s.Length -1;i>=0;i--)

            {
                h = s.Substring(i, 1);
                int a = int.Parse(h);
                n = n + (a * (int)Math.Pow(8, t));
                t++;
            }

            label1.Text = n.ToString();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string s, h;
            int n = 0;
            int t = 0;
            s = textBox1.Text;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                h = s.Substring(i, 1);

                int k = 0; 

                if (char.IsLetter(h[0]))
                {
                    switch (h[0])
                    {
                        case 'A':
                            k = 10;
                            break;
                        case 'B':
                            k = 11;
                            break;
                        case 'C':
                            k = 12;
                            break;
                        case 'D':
                            k = 13;
                            break;
                        case 'E':
                            k = 14;
                            break;
                        case 'F':
                            k = 15;
                            break;
                        
                    }
                }
                else
                {
                    k = int.Parse(h); 
                }

                n += k * (int)Math.Pow(16, t);
                t++;
            }

            label1.Text = n.ToString();    
                  
                           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s;
            int t = 0;
            string h;
            string[] b = new string[20];
            label1.Text = "";
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = "0";
            }

            s = textBox1.Text;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                h = s.Substring(i, 1);
                int k = int.Parse(h);
                int w = 0;  
                while (k != 0)
                {
                    b[t] = (k % 2).ToString();
                    k = k / 2;
                    t++;
                    w++;
                }


                if (w == 1)
                {
                    while (w <= 2)
                    {
                        b[t] = "0";
                        t++;
                        w++;
                    }
                }

                if (w == 2)
                {
                    while (w < 3)
                    {
                        b[t] = "0";
                        t++;
                        w++;
                    }
                }

                                               
            }
            for (int i = t - 1; i >= 0; i--)
            {
                label1.Text += b[i];
            }
                                              
                    
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s;
            int t = 0;
            string h;
            string[] b = new string[20];
            label1.Text = "";

            
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = "0";
            }

            s = textBox1.Text;  

            for (int i = s.Length - 1; i >= 0; i--)
            {
                h = s.Substring(i, 1);
                int k = 0;  

                
                if (char.IsLetter(h[0]))
                {
                    switch (h[0])
                    {
                        case 'A' :
                            k = 10;
                            break;
                        case 'B' :
                            k = 11;
                            break;
                        case 'C':
                            k = 12;
                            break;
                        case 'D':
                            k = 13;
                            break;
                        case 'E':
                            k = 14;
                            break;
                        case 'F':
                            k = 15;
                            break;


                    }
                }
                else
                {
                    k = int.Parse(h);  
                }

                int w = 0;

                
                while (k != 0)
                {
                    b[t] = (k % 2).ToString();
                    k = k / 2;
                    t++;
                    w++;
                }
                if (w == 1)
                {
                    while (w <= 3)
                    {
                        b[t] = "0";
                        t++;
                        w++;
                    }
                }

                if (w == 2)
                {
                    while (w <= 3)
                    {
                        b[t] = "0";
                        t++;
                        w++;
                    }
                }

                if (w == 3)
                {
                    while (w <= 3)
                    {
                        b[t] = "0";
                        t++;
                        w++;
                    }
                }
            }
                      
            for (int i = t - 1; i >= 0; i--)
            {
                label1.Text += b[i];
            }
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
           // button1.BackColor = Color.Gray;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            //button2.BackColor = Color.Gray;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            //button3.BackColor = Color.Gray;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            //button4.BackColor = Color.Gray;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
           // button5.BackColor = Color.Gray;
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            //button6.BackColor = Color.Gray;
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            //button7.BackColor = Color.Gray;
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
           // button8.BackColor = Color.Gray;
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
           // button9.BackColor = Color.Gray;
        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
           // button11.BackColor = Color.Gray;
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
           // button10.BackColor = Color.Gray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.BackColor = Color.White;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
           // button2.BackColor = Color.White;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
           // button3.BackColor = Color.White;

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            //button4.BackColor = Color.White;

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            //button5.BackColor = Color.White;

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            //button6.BackColor = Color.White;

        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            //button7.BackColor = Color.White;

        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
           // button8.BackColor = Color.White;

        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
           // button9.BackColor = Color.White;

        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            //button11.BackColor = Color.White;

        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            //button10.BackColor = Color.White;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "This button converts the base from 10 to 2");
            toolTip1.SetToolTip(button2, "This button converts the base from 10 to 8");
            toolTip1.SetToolTip(button3, "This button converts the base from 10 to 16");
            toolTip1.SetToolTip(button4, "This button converts the base from 2 to 10");
            toolTip1.SetToolTip(button5, "This button converts the base from 8 to 10");
            toolTip1.SetToolTip(button6, "This button converts the base from 16 to 10");
            toolTip1.SetToolTip(button7, "This button converts the base from 8 to 2");
            toolTip1.SetToolTip(button8, "This button converts the base from 16 to 2");
            toolTip1.SetToolTip(button9, "This button converts the base from 2 to 8");
            toolTip1.SetToolTip(button10, "This button converts the base from 2 to 16");
            toolTip1.SetToolTip(button11, "This button converts the base from 8 to 16");
            toolTip1.SetToolTip(button12, "This button converts the base from 8 to 16");
            toolTip1.SetToolTip(button13, "This button converts the base from 16 to 8");
                       
       }

        private void button12_MouseMove(object sender, MouseEventArgs e)
        {
            //button12.BackColor = Color.Gray;
        }

        private void button13_MouseMove(object sender, MouseEventArgs e)
        {
            //button13.BackColor = Color.Gray;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            //button12.BackColor = Color.White;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            //button13.BackColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[] d = new int[10]; 
            string s, h;
            int n = 0, z = 0;
            s = textBox1.Text;
            label1.Text = "";

            
            for (int i = s.Length - 1; i >= 0; i -= 3)
            {
                int f = 0;
                n = 0;
                for (int g = 0; g < 3; g++)
                {
                    if (i - g >= 0)
                    {
                        h = s.Substring(i - g, 1);
                        int a = int.Parse(h);
                        n += a * (int)Math.Pow(2, f);
                        f++;
                    }
                }

                d[z] = n; 
                z++;
            }
            for (int i = z-1;i>=0;i--)
            {
                label1.Text += d[i].ToString() + " ";
            } 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            char[] d = new char[10];
            string s = textBox1.Text;
            label1.Text = "";
            int z = 0;

            for (int i = s.Length - 1; i >= 0; i -= 4)
            {
                int n = 0;
                int f = 0;

                for (int g = 0; g <= 3; g++)
                {
                    if (i - g >= 0)
                    {
                        int a = int.Parse(s.Substring(i - g, 1));
                        n += a * (int)Math.Pow(2, f);
                        f++;
                    }
                }

                if (n >= 10 && n <= 15)
                {
                    switch (n)
                    {
                        case 10:
                            d[z] = 'A';
                            break;
                        case 11:
                            d[z] = 'B';
                            break;
                        case 12:
                            d[z] = 'C';
                            break;
                        case 13:
                            d[z] = 'D';
                            break;
                        case 14:
                            d[z] = 'E';
                            break;
                        case 15:
                            d[z] = 'F';
                            break;
                    }
                }
                else
                {
                    
                    d[z] = n.ToString()[0];
                }
                z++;
            }

            for (int i = z - 1; i >= 0; i--)
            {
                label1.Text += d[i] + " ";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string s, h;
            int n = 0;
            string[] c = new string[10];
            int a, i = 0, t = 0;
            s = textBox1.Text;
            label1.Text = "";

            
            for (int j = s.Length - 1; j >= 0; j--)
            {
                h = s.Substring(j, 1);
                a = int.Parse(h);
                n = n + (a * (int)Math.Pow(8, t));
                t++;
            }
            t = 0;
            while (n > 0)
            {
                int k = n % 16;

                if (k < 10)
                {
                    c[i] = k.ToString();
                }
                else
                {
                    c[i] = ((char)(k - 10 + 'A')).ToString();
                }
                n = n / 16;
                i++;
                t++;
            }
            for (int j = t - 1; j >= 0; j--)
            {
                label1.Text += c[j];
            }
         
                   
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string s, h;
            int n = 0;
            int t = 0;
            s = textBox1.Text;

            
            for (int i = s.Length - 1; i >= 0; i--)
            {
                h = s.Substring(i, 1);

                int k = 0; 

                if (char.IsLetter(h[0]))
                {
                    switch (h[0])
                    {
                        case 'A':
                            k = 10;
                            break;
                        case 'B':
                            k = 11;
                            break;
                        case 'C':
                            k = 12;
                            break;
                        case 'D':
                            k = 13;
                            break;
                        case 'E':
                            k = 14;
                            break;
                        case 'F':
                            k = 15;
                            break;
                        
                    }
                }
                else
                {
                    k = int.Parse(h); 
                }
                n += k * (int)Math.Pow(16, t); 
                t++;
            }
            int w = 0, q = 0;
            int a = n;
            int[] b = new int[20]; 

            label1.Text = "";
            while (a != 0)
            {
                b[q] = a % 8;
                a = a / 8;
                q++;
                w++;
            }

            for (int j = q - 1; j >= 0; j--)
            {
                label1.Text += b[j].ToString(); 
            }
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        
    }
   
}
