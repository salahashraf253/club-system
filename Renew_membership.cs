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
    public partial class Renew_membership : Form
    {
        public Renew_membership()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void renew_btn_Click(object sender, EventArgs e)
        {
            string card_number = cardN.Text;
            if (card_number.Length != 16)
            {
                MessageBox.Show( "Invalid credit card number", "Error");
            }
            else
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
                    MessageBox.Show("You have successfully renewed your membership");
                }
                else
                {
                    MessageBox.Show("Check your id and password", "Error");
                }
                conn.Close();
                
            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Mian_Page m = new Mian_Page();
            m.Show();
            this.Hide();
        }
    }
}
