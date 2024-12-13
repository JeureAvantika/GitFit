using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Weight Loss" && comboBox3.SelectedItem == "Male")
            {
                if (comboBox1.SelectedItem == "Beginner")
                {
                    this.Hide();
                    malefirstpage obj6 = new malefirstpage();
                    obj6.ShowDialog();
                    obj6 = null;
                    this.Show();

                }
            }
               if (comboBox2.SelectedItem == "Weight Loss" && comboBox3.SelectedItem == "Male")
                {
                    if (comboBox1.SelectedItem == "Intermediate")
                    {
                        this.Hide();
                        malesecondpage obj6 = new malesecondpage();
                        obj6.ShowDialog();
                        obj6 = null;
                        this.Show();

                    }
                }

                if (comboBox2.SelectedItem == "Weight Loss" && comboBox3.SelectedItem == "Male")
                {
                    if (comboBox1.SelectedItem == "Advanced")
                    {
                        this.Hide();
                        malethirdpage obj6 = new malethirdpage();
                        obj6.ShowDialog();
                        obj6 = null;
                        this.Show();

                    }
                }
           if (comboBox2.SelectedItem == "Weight Loss" && comboBox3.SelectedItem == "Female")
                {
                    if (comboBox1.SelectedItem == "Beginner")
                    {
                        this.Hide();
                        Femalefirstpage obj6 = new Femalefirstpage();
                        obj6.ShowDialog();
                        obj6 = null;
                        this.Show();

                    }
                }

                if (comboBox2.SelectedItem == "Weight Loss" && comboBox3.SelectedItem == "Female")
                {
                    if (comboBox1.SelectedItem == "Intermediate")
                    {
                        this.Hide();
                        Femalesecondpage obj6 = new Femalesecondpage();
                        obj6.ShowDialog();
                        obj6 = null;
                        this.Show();

                    }
                }
               
                if (comboBox2.SelectedItem == "Weight Loss" && comboBox3.SelectedItem == "Female")
                {
                    if (comboBox1.SelectedItem == "Advanced")
                    {
                        this.Hide();
                        Femalethirdpage obj6 = new Femalethirdpage();
                        obj6.ShowDialog();
                        obj6 = null;
                        this.Show();

                    }
                }


            

           
                if (comboBox2.SelectedItem=="Weight Gain"&&comboBox3.SelectedItem=="Male")
                {
                   if (comboBox1.SelectedItem=="Beginner")
                   {
                    this.Hide();
                    MaleWtGainBeg obj7 = new MaleWtGainBeg();
                    obj7.ShowDialog();
                    obj7 = null;
                    this.Show();
                   }

                }

                if (comboBox2.SelectedItem == "Weight Gain"&&comboBox3.SelectedItem=="Male")// && radioButton1.Checked)
                {

                    if (comboBox1.SelectedItem == "Intermediate")
                    {
                    this.Hide();
                    MaleWtGainInter obj8 = new MaleWtGainInter();
                    obj8.ShowDialog();
                    obj8 = null;
                    this.Show();
                    }
                }
                if (comboBox2.SelectedItem=="Weight Gain"&&comboBox3.SelectedItem=="Male")
                {

                    if (comboBox1.SelectedItem == "Advanced")
                    {
                    this.Hide();
                    MaleWtGainAdv obj9 = new MaleWtGainAdv();
                    obj9.ShowDialog();
                    obj9 = null;
                    this.Show();

                }
            }
                if (comboBox2.SelectedItem == "Weight Gain" && comboBox3.SelectedItem == "Female")
                {

                    if (comboBox1.SelectedItem == "Beginner")
                    {
                        this.Hide();
                        FemaleWtGainAdv obj9 = new FemaleWtGainAdv();
                        obj9.ShowDialog();
                        obj9 = null;
                        this.Show();

                    }
                }

                if (comboBox2.SelectedItem == "Weight Gain" && comboBox3.SelectedItem == "Female")
                {
                 
                    if (comboBox1.SelectedItem == "Intermediate")
                {
                    this.Hide();
                    FemaleWtGainInter obj12 = new FemaleWtGainInter();
                    obj12.ShowDialog();
                    obj12 = null;
                    this.Show();

                }
                }

             if (comboBox2.SelectedItem == "Weight Gain" && comboBox3.SelectedItem == "Female")
                {
                 
                    if (comboBox1.SelectedItem == "Advanced")
                {
                    this.Hide();
                    FemaleWtGainAdv obj12 = new FemaleWtGainAdv();
                    obj12.ShowDialog();
                    obj12 = null;
                    this.Show();

                }
                }
                
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

