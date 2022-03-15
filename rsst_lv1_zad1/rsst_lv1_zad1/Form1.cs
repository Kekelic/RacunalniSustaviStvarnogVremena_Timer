using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rsst_lv1_zad1
{
    public partial class Form1 : Form
    {
        private StreamReader citac = new StreamReader("value.txt");
        private System.Timers.Timer t;

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
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
                string line = citac.ReadLine();
                if (line != null)
                {                 
                    int criticalValue = Int32.Parse(richTextBox2.Text);
                    int readValue = Int32.Parse(line);
                    checkCriticalValue(criticalValue, readValue);
                }
                    
                else
                {
                    t.Stop();
                    MessageBox.Show("Provjera gotova, nema vrijednosti vecih od kriticne.");
                    button1.Enabled = true;
                }
               
            });
        }

        private void Form1_FormClosing(object sender,FormClosingEventArgs e)
        {
            citac.Close();//Zatvaranje čitača datoteke r
        }


        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            checkInputValue(richTextBox2.Text);
        }

        public void checkInputValue(string value)
        {
            if (!int.TryParse(value, out int i))
            {
                button1.Enabled = false;
                label1.Text = "Niste unijeli broj ili je prazno polje";
                return;
            }
            label1.Text = "Kritična vrijednost";
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Start();
            button2.Enabled = true;
            button2.Text = "Stop";
        }

        public bool checkCriticalValue(int criticalValue, int readValue)
        {
            button1.Enabled = false;        
            richTextBox1.Text = readValue.ToString();
            Application.DoEvents();
            if (readValue > criticalValue)
            {
                t.Stop();
                button2.Text = "";
                button2.Enabled = false;
                MessageBox.Show(readValue.ToString() + " je veci od kriticne vrijednosti, prekidam program.");
                return false;
            }
            
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Stop")
            {
                t.Stop();
                button2.Text = "Start";               
            }
            else
            {
                t.Start();
                button2.Text = "Stop";             
            }
        }
    }
}
