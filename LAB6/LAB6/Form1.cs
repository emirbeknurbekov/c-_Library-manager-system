using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                listBox1.Items.Add("Record" + i.ToString());
                // Items property to store a collection of strings,
                // the Add function adds an object in this case a string
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] sArayItems = {"Excellent", "Good", "Satisfactory", "Unsatisfactory"};
            // array of strings
            listBox1.Items.Clear(); // clear the Items property
            for (int i = 0; i < sArayItems.GetLength(0); i++) // view the array
            {
                // Add an item to the listbox collection
                listBox1.Items.Add(sArayItems[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // the Insert function will add a string by index
            // if the list is empty, the string data will cause an error
            listBox1.Items.Insert(1, "Added string");
            listBox1.Items.Insert(4, "Added line2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new object[] {"Excellent", "Good", "Satisfactory", "Unsatisfactory"});
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i < 21; i++)
            {
                listBox1.Items.Add("Straw" + i.ToString());
            }
            // Views can be selected as a group of rows or just one SelectionMode.One
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.SetSelected(0, true); // select line one
            listBox1.SetSelected(1, true); // select line two
            listBox1.SetSelected(2, true); // select line three
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            listBox1.Items.Clear();
            for (int i = 1; i < 21; i++)
            {
                listBox1.Items.Add("Straw" + i.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.UseTabStops = true;
            for (int i = 1; i < 20; i++)
            {
                listBox1.Items.Add("Option  t" + i.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                MessageBox.Show(listBox1.SelectedItem.ToString(), "Getting the string value");
            // or so
            MessageBox.Show(listBox1.Text, "");
            // the selected line is placed into the Text property
            if (listBox1.SelectedIndex != -1)
                MessageBox.Show(listBox1.SelectedIndex.ToString(), "Getting the string index");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                MessageBox.Show(listBox1.Items[i].ToString() + "");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString(), "Getting string value");
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We clicked on the component with the mouse");
        }
    }
}
