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
    public partial class nudSteps : Form
    {
        public List<StepsClass> StepsList { get; set; } = new List<StepsClass>();
    
        public static int NumofSteps;
        public nudSteps()
        {
            InitializeComponent();
        }

        private void btnStepForm_Click(object sender, EventArgs e)
        {//https://www.youtube.com/watch?v=4nXUWpC2GuA&list=PL480DYS-b_kfOd8KRx93r92u5UYyzdQ_w&index=7

            NumofSteps = (int)numericUpDown1.Value;

            for (int i = 0; i < NumofSteps; i++)
            {
                AddingStepsForm asf = new AddingStepsForm();
                asf.ShowDialog();

                StepsList.AddRange(AddingStepsForm.StepsList);

            }

            this.Close();
            
        }

        public List<StepsClass> GetSteps()
        {
            return StepsList;
        }

    }
}
