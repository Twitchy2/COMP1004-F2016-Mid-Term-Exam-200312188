using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam_200312188
{

    public partial class GenerateNameForm : Form
    {

        private Random _rnd;
        public GenerateNameForm()
        {

            InitializeComponent();
            _rnd = new Random();
        }
        /// <summary>
        /// Should take the two list boxes and choose a random string 
        /// and put it where it needs to be
        /// </summary>
        /// <returns></returns>
        private void GenerateName()
        {


            //This should hopeuflly take the random and make it important
            _rnd = new Random();
            //finds a random INDEX via the random in ITEMS
            int randomNumber = _rnd.Next(FirstNameListBox.Items.Count);
            //SELECTS THAT
            FirstNameListBox.Select();
            //SETS THE SELECTED INDEX AS THE SELECTED ITEM
            FirstNameListBox.SelectedItem = FirstNameListBox.Items[randomNumber];
            //Prints
            textBox1.Text = FirstNameListBox.SelectedItem.ToString();


            //This should do the same but for the last name
            _rnd = new Random();
            int rando = _rnd.Next(listBox1.Items.Count);
            listBox1.Select();
            listBox1.SelectedItem = listBox1.Items[rando];
            LastNameTextBox.Text = listBox1.SelectedItem.ToString();
            
            
        }
        /// <summary>
        /// calls generateName in order to populate the two text boxes
        /// Also sets the first and last name property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //calls method and sets name as the text boxes
            GenerateName();
            Program.character.lastName = LastNameTextBox.Text;
            Program.character.FirstName = textBox1.Text;
        }
        /// <summary>
        /// calls generateName in order to populate the two text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateName();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm AbilityForm = new AbilityGeneratorForm();
            AbilityForm.Show();
            this.Hide();
            
        }
        /// <summary>
        /// Changes the firstName if you select it yourself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = FirstNameListBox.SelectedItem.ToString();
            Program.character.FirstName = textBox1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LastNameTextBox.Text = listBox1.SelectedItem.ToString();
            Program.character.lastName = LastNameTextBox.Text;
        }
    }
}
