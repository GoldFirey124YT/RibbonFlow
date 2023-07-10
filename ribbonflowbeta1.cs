using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RibbonFlow
{
    public partial class Form1 : Form
    {
        private int _identificationNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new tweet
            string tweet = textBox1.Text;

            // Display the tweet in the listbox
            listBox1.Items.Add($"{_identificationNumber}: {tweet}");

            // Clear the text box
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the recipient identification number from the user
            int recipientIdentificationNumber = int.Parse(textBox2.Text);

            // Create a new direct message
            string directMessage = textBox3.Text;

            // Display the direct message in the listbox
            listBox1.Items.Add($"{_identificationNumber}: To {recipientIdentificationNumber}: {directMessage}");

            // Clear the text boxes
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Display the user's profile
            listBox1.Items.Add($"Your identification number is {_identificationNumber}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the background color of the form to black
            this.BackColor = Color.Black;

            // Set the text color of the labels and textboxes to white
            label1.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;
            listBox1.ForeColor = Color.White;

            // Get the identification number from the user
            _identificationNumber = int.Parse(textBox2.Text);
        }
    }
}
