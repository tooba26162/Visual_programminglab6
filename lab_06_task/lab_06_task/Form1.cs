using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_06_task
{
    public partial class Form1 : Form
    {
        private List<string> itemsList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            if (!string.IsNullOrEmpty(item))
            {
                itemsList.Add(item);
                textBox1.Clear();
                MessageBox.Show("Item added!");
            }
            else
            {
                MessageBox.Show("Please enter a valid item.");
            }
        }

        private void DisplayItems_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string item in itemsList)
            {
                listBox1.Items.Add(item);
            }

        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            if (itemsList.Contains(item))
            {
                itemsList.Remove(item);
                MessageBox.Show("Item removed!");
            }
            else
            {
                MessageBox.Show("Item not found.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
