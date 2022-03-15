using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rsst_lv1
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer t;

        public Form1()
        {
            InitializeComponent();
            //Kreiranje timer-a s periodom od 1000 ms
            t = new System.Timers.Timer(1000);
            //Dodavanje događaja timer-u; izvršava se periodno
            t.Elapsed += new System.Timers.ElapsedEventHandler(vrijeme);
        }

        private void vrijeme(object s, EventArgs e)
        {
            //Metoda Invoke izvršava delegata na niti koja je vlasnik
            //rukovatelja kontrola (uobičajeno, glavna nit)
            //MethodInvoker je delegat koji može izvršiti bilo koju
            //metodu koja ne vraća ništa i nema parametre
            Invoke((MethodInvoker)delegate //Anonimna metoda
            {
                lbl_vrijeme.Text = DateTime.Now.ToLongTimeString();
                if(lbl_vrijeme.Text == richTextBox1.Text)
                {
                    t.Stop();
                    btn_start_stop.Text = "Pokreni";
                    Console.Beep();
                    MessageBox.Show("Alarm!");
                }
            });
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_stop_Click(object sender, EventArgs e)
        {
            if (t.Enabled == false)
            {
                //Pokretanje timer-a.
                t.Start(); //Odgovara: t.Enabled = true;
                btn_start_stop.Text = "Zaustavi";

            }
            else
            {
                //Zaustavljanje timer-a
                t.Stop(); //Odgovara: t.Enabled = false;
                btn_start_stop.Text = "Pokreni";
                Console.Beep();
                MessageBox.Show("Alarm!");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            checkInputValue(richTextBox1.Text);
        }

        public void checkInputValue(string value)
        {
            if (value == string.Empty)
            {
                btn_start_stop.Enabled = false;          
                return;
            }         
            btn_start_stop.Enabled = true;
        }

    }
}
