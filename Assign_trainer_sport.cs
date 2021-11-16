using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFinal
{
    public partial class Assign_trainer_sport : Form
    {
        public Assign_trainer_sport()
        {
            InitializeComponent();
        }

        private void Assign_trainer_sport_Load(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Employee_Menu m = new Employee_Menu();
            m.Show();
            this.Hide();
        }

        private void Assign_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trainer has been assigned to sport successfully");
        }
    }
}
