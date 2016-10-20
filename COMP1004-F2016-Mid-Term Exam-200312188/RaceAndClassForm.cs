using COMP1004_F2016_Mid_Term_Exam_200312188.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam_200312188
{
    public partial class RaceAndClassForm : Form
    {
        /// <summary>
        /// Basic important information which should be here
        /// Made by: Logan Sikora Beder
        /// Mid Term Exam C# 2016
        /// october 20th, 2016
        /// </summary>
        public AbilityGeneratorForm previousForm;
        private string _selectedRace;


        public RaceAndClassForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //First part of the program
            Character character = Program.character;

            character.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }
        /// <summary>
        /// This should store the Race Name and set images corrisponding to the name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Selects radio button
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;
               // Sets textbox for simplicity
            SelectedTextBox.Text = _selectedRace.ToString();
            //just in case
            Program.character.Race = _selectedRace.ToString();
            //Finds the name of hte string and compares it to hte name of the image, sets if same
            String imageString = Regex.Replace(SelectedTextBox.Text, @"\+", "");

            RacePictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }

        private void RaceAndClassForm_Load(object sender, EventArgs e)
        {
            this._selectedRace = Program.character.Race;
        }
    }
}
