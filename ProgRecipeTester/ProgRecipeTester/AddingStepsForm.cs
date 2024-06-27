using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgRecipeTester
{
    public partial class AddingStepsForm : Form
    {
        public static List<StepsClass> StepsList { get; private set; } = new List<StepsClass>();


        public AddingStepsForm()
        {
            InitializeComponent();
        }

        private void btnSubmitSteps_Click(object sender, EventArgs e) //https://www.youtube.com/watch?v=ArnJ57ntgmc 
        {                   // int his method we are essentially collectong and pass information over 
            string Steps = txtbAddingSteps.Text;

            StepsClass Sclass = new StepsClass(Steps);
            StepsList.Add(Sclass);

            txtbAddingSteps.Text = "";


            this.Close();
        }
    }
}
