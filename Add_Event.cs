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
    public partial class Add_Event : Form
    {
        public Add_Event()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_Menu m =new Employee_Menu();
            m.Show();
            this.Hide();

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Event Added Successfully");
        }
    }
}
