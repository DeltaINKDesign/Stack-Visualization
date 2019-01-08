using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Stos_Csharp
{

    public partial class Form1 : Form
    {
        Stack<TextBox> st = new Stack<TextBox>(10);
        //List<int> numbers = new List<int>();
        int[] tablicaY;

        public Form1()
        {
            InitializeComponent();
            tablicaY = new int[10]; //tablica koordynatow wysokosci

            for(int i = 0; i <10; i++) //oblicza wysokosc dla danego textboxa
            {

                tablicaY[i]= 380 + 20 * (-i * 2);
            }
            
        }
        

        
        



        private void button1_Click(object sender, EventArgs e) //PUSH
        {
            TextBox tb = new TextBox();


            if (st.Count<10)
            {
                
                tb.Visible = true;
                if (textBox1.Text != "")
                {
                    tb.Text = textBox1.Text;
                }
                else
                {
                    tb.Text = "0";
                }
                tb.Left = 30;
                tb.Top = 0;
                for (int wys = 15; wys <= tablicaY[st.Count]; wys++)
                {
                    tb.Top += 1;
                    Thread.Sleep(2);
                    this.panel1.Controls.Add(tb);
                }
                st.Push(tb);
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Osiągnięto maksymalną liczbę textboxów!");
            }


            
           

        }



        private void button2_Click(object sender, EventArgs e) //POP
        {
            if (st.Count > 0)
            {
                TextBox wyciagnieta = st.Pop();
                
                for(int lewo = 30; lewo <= 220; lewo++)
                {
                    wyciagnieta.Left +=1;
                    Thread.Sleep(2);
                }
                MessageBox.Show("Wyciągnięto ze stosu: " + wyciagnieta.Text);
                this.panel1.Controls.Remove(wyciagnieta);
            }
            else
            {
                MessageBox.Show("Stos jest pusty!");
            }
            
        }

        private void button3_Click(object sender, EventArgs e) //CLEAR
        {
            if (st.Count > 0)
            {
                for (int j = st.Count; j > 0; j--)
                {

                    TextBox wyciagnieta = st.Pop();
                    for (int lewo = 30; lewo <= 220; lewo++)
                    {
                        wyciagnieta.Left += 1;
                        Thread.Sleep(2);
                    }
                    this.panel1.Controls.Remove(wyciagnieta);
                    
                }
                MessageBox.Show("Usunięto wszystkie textboxy");


            }
            else
            {
                MessageBox.Show("Stos jest pusty!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}