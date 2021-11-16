using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SoftwareFinal
{
    public partial class Member_Login : Form
    {
        public Member_Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
                OracleConnection conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "checkId";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", id.Text);
                cmd.Parameters.Add("pass", pass.Text);

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.RowSize == 1)
                {
                    Member_menu m = new Member_menu();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Check your username and password", "Error");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {

            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Mian_Page m = new Mian_Page();
            m.Show();
            this.Hide();
        }
    }
}
