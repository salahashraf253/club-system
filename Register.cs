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
    public partial class Register : Form
    {
        

        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        public void WrongPassMess()
        {
            MessageBox.Show("Wrong Password\nPlease enter" +
             " the password correctly.", 
             "Password does not match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        char type;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = 'M';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = 'F';
        }
        private void register_btn_Click(object sender, EventArgs e)
        {
            string pass = textBox2.Text;
            string confirmPass = textBox3.Text;
            string dob = dateTimePicker1.Value.ToString();
            if (pass.Length != confirmPass.Length)
            {
                WrongPassMess();
            }
            else
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (pass[i] != confirmPass[i])
                    {
                        WrongPassMess();
                        break;
                    }
                }
            }
            try
            {
                string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
                OracleConnection conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd=new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Members(MEMEBERID,DOB,PASSWORD,GENDER) values (:id,:dob,:pass,:type)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", int.Parse(textBox1.Text));
                cmd.Parameters.Add("dob", dateTimePicker1.Value.ToString());
                cmd.Parameters.Add("pass", textBox2.Text);
                //........................
                cmd.Parameters.Add("type");
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Registiration Completed");
                    conn.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
