using ClassScheduleCalendar;
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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        // On start up of form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load calendar from storage
            Storage storage = new Storage();
            //ClassSchedule schedule = storage.Load("../storage/test.json");
            
        }

        // Button to open form for new class input
        private void addClass_Click(object sender, EventArgs e)
        {
            // Close the main screen and open up form to add new class
            this.Hide();
            AddClass addClass = new AddClass();
            addClass.ShowDialog();
            this.Close();
        }

    }
}
