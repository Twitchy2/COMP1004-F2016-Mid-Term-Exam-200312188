using COMP1004_F2016_Mid_Term_Exam_200312188.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam_200312188
{
    public partial class FinalForm : Form
    {
        /// <summary>
        /// Basic important information which should be here
        /// Made by: Logan Sikora Beder
        /// Mid Term Exam C# 2016
        /// october 20th, 2016
        /// </summary>
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Will return all of the text boxes to their desired program variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalForm_Load(object sender, EventArgs e)
        {
            //stuff on the left
            RaceTextBox.Text = Program.character.Race.ToString();
            FirstNameTextBox.Text = Program.character.FirstName.ToString();
            LastNameTextBox.Text = Program.character.lastName.ToString();

            //stuff in the groupbox
            StrengthTextBox.Text = Program.character.Strength.ToString();
            DexterityTextBox.Text = Program.character.Dexterity.ToString();
            WisdomTextBox.Text = Program.character.Wisdom.ToString();
            ConstitutionTextBox.Text = Program.character.Constitution.ToString();
            IntelligenceTextBox.Text = Program.character.Intelligence.ToString();
            CharismaTextBox.Text = Program.character.Charisma.ToString();

            //now for the piture box
            //Finds the name of hte string and compares it to hte name of the image, sets if same
            String imageString = Regex.Replace(RaceTextBox.Text, @"\+", "");

            RacePictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);

        }
    }
}
