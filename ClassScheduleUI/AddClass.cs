using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassScheduleUI
{
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void AddClass_Load(object sender, EventArgs e)
        {

        }

        // Add new class to calendar and return to main screen
        private void confirmClass_Click(object sender, EventArgs e)
        {
            // Add the class to the calendar

            // Close this form and open the main screen
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.ShowDialog();
            this.Close();
        }

        // Return to main screen
        private void cancelClass_Click(object sender, EventArgs e)
        {
            // Close this form and open the main screen
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.ShowDialog();
            this.Close();
        }

    }
}
