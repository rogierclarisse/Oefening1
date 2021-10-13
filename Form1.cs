using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oefening1;

namespace Oefening1
{
    public partial class Form1 : Form
    {
        Stapel<int> intStapel = new Stapel<int>();
        Stapel<string> stringStapel = new Stapel<string>();
        //Stapel<bool> booleanStapel = new Stapel<bool>();
       
        Stapel<Student> studentStapel = new Stapel<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tbIntegers_ValueChanged(object sender, EventArgs e)
        {
            int integer = int.Parse(tbIntegers.Text);
        }

        private void btVoegToe1_Click(object sender, EventArgs e)
        {
            int integer = int.Parse(tbIntegers.Text);
            intStapel.Toevoegen(integer);
            tbStack.Text = intStapel.ToString();
        }

        private void btVoegToe2_Click(object sender, EventArgs e)
        {
            string str = tbStrings.Text;
            stringStapel.Toevoegen(str);
            tbStack.Text = stringStapel.ToString();
        }

        //private void btVoegToe3_Click(object sender, EventArgs e)
        //{
        //    bool boolean = bool.Parse(tbBooleans.Text);
        //    booleanStapel.Toevoegen(boolean);
        //    tbStack.Text = booleanStapel.ToString();
        //}

        private void btVoegToe3_Click(object sender, EventArgs e)
        {
            String naam = tbStudent.Text;
            Student student = new Student(naam);
            studentStapel.Toevoegen(student);
            tbStack.Text = studentStapel.ToString();
        }

        private void btVerwijder1_Click(object sender, EventArgs e)
        {
            intStapel.Verwijderen();
            tbStack.Text = intStapel.ToString();

        }

        private void btVerwijder2_Click(object sender, EventArgs e)
        {
            stringStapel.Verwijderen();
            tbStack.Text = stringStapel.ToString();
        }

        private void btVerwijder3_Click(object sender, EventArgs e)
        {
            studentStapel.Verwijderen();
            tbStack.Text = studentStapel.ToString();
        }

      
        private void btMaakLeeg1_Click(object sender, EventArgs e)
        {
            intStapel.Leegmaken();
            tbStack.Text = intStapel.ToString();

        }

        private void btMaakLeeg2_Click(object sender, EventArgs e)
        {
            stringStapel.Leegmaken();
            tbStack.Text = stringStapel.ToString();
        }

        private void btMaakLeeg3_Click(object sender, EventArgs e)
        {
            studentStapel.Leegmaken();
            tbStack.Text = studentStapel.ToString();
        }

        

        private void btPrintString1_Click(object sender, EventArgs e)
        {
            tbStack.Text = intStapel.ToString();
        }

        private void btPrintString2_Click(object sender, EventArgs e)
        {
            tbStack.Text = stringStapel.ToString();
        }

        private void btPrintString3_Click(object sender, EventArgs e)
        {
            tbStack.Text = studentStapel.ToString();
        }
        private void btSearchStack1_Click(object sender, EventArgs e)
        {
            int zoekterm = int.Parse(tbSearch1.Text);

            if(intStapel.IsAanwezig(zoekterm) == true)
            {
                MessageBox.Show("De zoekterm \"" + zoekterm.ToString()+ "\" is aanwezig in de stack");
            }
            else
            {
                MessageBox.Show("De zoekterm \"" + zoekterm.ToString() + "\" is niet aanwezig in de stack");
            }
        }

        private void btSearchStack2_Click(object sender, EventArgs e)
        {
            string zoekterm = tbSearch1.Text;

            if (stringStapel.IsAanwezig(zoekterm) == true)
            {
                MessageBox.Show("De zoekterm \"" + zoekterm.ToString() + "\" is aanwezig in de stack");
            }
            else
            {
                MessageBox.Show("De zoekterm \"" + zoekterm.ToString() + "\" is niet aanwezig in de stack");
            }
        }

        private void btSearchStack3_Click(object sender, EventArgs e)
        {
            //string zoekterm = tbSearch1.Text;

            //if(studentStapel.IsAanwezig(zoekterm) == true)
            //{
            //    MessageBox.Show("De zoekterm \"" + zoekterm.ToString() + "\" is aanwezig in de stack");
            //}
            //else
            //{
            //    MessageBox.Show("De zoekterm \"" + zoekterm.ToString() + "\" is niet aanwezig in de stack");
            //}
        
        }

        //private void btSearchStack3_Click(object sender, EventArgs e)
        //{
        //    bool zoekterm = bool.Parse(tbSearch1.Text);

        //    if (booleanStapel.IsAanwezig(zoekterm) == true)
        //    {
        //        MessageBox.Show("De zoekterm \"" + zoekterm.ToString() + "\" is aanwezig in de stack");
        //    }
        //    else
        //    {
        //        MessageBox.Show("De zoekterm \"" + zoekterm.ToString() + "\" is niet aanwezig in de stack");
        //    }
        //}

        private void btCopy1_Click(object sender, EventArgs e)
        {
            tbCopy.Text = intStapel.Copy();
        }

        private void btCopy2_Click(object sender, EventArgs e)
        {
            tbCopy.Text = stringStapel.Copy();
        }

        private void btCopy3_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
