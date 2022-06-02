using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;


namespace Budgeting
{
    public partial class Form1 : Form
    {
        List<Event> transactions = new List<Event>();
        List<string> categories = new List<string>();
        List<Button> buttons = new List<Button>();
        int idx = 0;
        int button_amount;
        bool done = false;
        
        
        public Form1()
        {
            InitializeComponent();
            buttons.Add(cat1);
            buttons.Add(cat2);
            buttons.Add(cat3);
            buttons.Add(cat4);
            buttons.Add(cat5);
            buttons.Add(cat6);
            buttons.Add(cat7);
            buttons.Add(cat8);
            buttons.Add(cat9);
            buttons.Add(cat10);
            buttons.Add(cat11);
            buttons.Add(cat12);
            buttons.Add(cat13);
            buttons.Add(cat14);
            buttons.Add(cat15);
            buttons.Add(cat16);
            buttons.Add(cat17);
            buttons.Add(cat18);
        }
        private void add()
        {
            //Check to see if the string is already in the list
            if (categories.Contains(category_input.Text))
            {
                MessageBox.Show("\'" +category_input.Text + "\'" + " is already in the list", "Naming conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                category_input.Text = "";
                return;
            }

            //otherwise, add it to the list
            categories.Add(category_input.Text);
            category_box.Items.Add(category_input.Text);
            category_input.Text = "";
        }
        private void process()
        {
            for(int i = 0; i < categories.Count; i++)
            {
                buttons[i].Text = categories[i];
                buttons[i].Visible = true;
            }
            string display_text = transactions[idx].getSource() + "\n" + transactions[idx].getDate() + "\n" + "$" + transactions[idx].getAmount() + "\n" + transactions[idx].getType();
            trans_display.Text = display_text;
            
        }
        private void parse_file(String filename)
        {
            if (filename.Contains(".csv") == false)
            {
                MessageBox.Show("Invalid file type...need .csv extension", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] rows;
            TextFieldParser textFieldParser = new TextFieldParser(@filename);
            textFieldParser.TextFieldType = FieldType.Delimited;
            textFieldParser.SetDelimiters(",");
            
            //Parse through CSV to get the information
            while (!textFieldParser.EndOfData)
            {
               rows = textFieldParser.ReadFields();
               if (rows[0] == "Account Number")
                {
                    continue;
                }
                else
                {
                    Event newEvent = new Event(rows[1], Convert.ToDouble(rows[2]), rows[4]);
                    transactions.Add(newEvent);
                }
                
            }
            for(int i = 0; i < transactions.Count;i++ )
            {
                transactions[i].setType();
            }
            
        }
       

        

       

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExplorer = new OpenFileDialog();
            if(fileExplorer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String filename = fileExplorer.FileName;
                parse_file(filename); //Line 74
                string complete_message = transactions.Count.ToString() + " transactions processed";
                MessageBox.Show(complete_message, "Processing Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                categorize_button.Visible = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Make category functionality visible
            category_input.Visible = true;
            add_category_button.Visible = true;
            category_box.Visible = true;
            button1.Visible = true;
        }

        private void category_input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                add();
            }
        }

        private void category_input_MouseClick(object sender, MouseEventArgs e)
        {
            category_input.Text = "";
        }

        private void add_category_button_MouseClick(object sender, MouseEventArgs e)
        {
            add();
        }

        private void button1_Click_1(object sender, EventArgs e) //done button click
        {
            
            category_input.Text = "";
            cat_trans.Visible = true;
            
        }

        private void cat_trans_Click(object sender, EventArgs e)
        {
            button_amount = category_box.Items.Count;
            trans_display.Visible = true;
            status_label.Visible = true;
            next_button.Visible = true;
            process();
            
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if(idx >= transactions.Count)//Add yes/no functionality to this
            {
                MessageBox.Show("All transactions have been categorized!", "Processing Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            idx++;
            process();
            
        }

        
        private void cat1_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat1.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat2_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat2.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat3_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat3.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat4_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat4.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat5_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat5.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat6_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat6.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat7_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat7.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat8_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat8.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat9_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat9.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat10_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat10.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat11_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat11.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat12_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat12.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat13_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat13.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat14_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat14.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat15_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat15.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat16_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat16.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat17_Click(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat17.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cat18_Click_1(object sender, EventArgs e)
        {
            transactions[idx].setCategory(cat18.Text);
            MessageBox.Show("Transaction categorized! Click 'next' to proceed", "Transaction Categorized!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
