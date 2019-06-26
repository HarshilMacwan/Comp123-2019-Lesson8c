using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp123_2019_Lesson8c
{
    public partial class Lab8 : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is constructor for lab 8
        /// </summary>
        public Lab8()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is event handler for submit buttton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextbox.Text;
            UserAge = float.Parse(AgeTextbox.Text);
            NameTextbox.Text = string.Empty;
            AgeTextbox.Text = string.Empty;

            OutputLabel.Text = UserName+""+UserAge;
        }
        /// <summary>
        /// This is the event handler for the lab8 form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8_Load(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;

        }

        private void AgeTextbox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }
    }
}
