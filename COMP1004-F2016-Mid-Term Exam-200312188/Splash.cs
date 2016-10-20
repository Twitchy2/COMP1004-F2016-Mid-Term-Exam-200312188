using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam_200312188
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;

            GenerateNameForm NameForm = new GenerateNameForm();
            NameForm.Show();
            this.Hide();
        }
    }
}
