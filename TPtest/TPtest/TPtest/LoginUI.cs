using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers; 

namespace TPtest
{
    public partial class LoginScreen : Form
    {
//==============================================================================================
        public LoginScreen()
        {
            InitializeComponent();
            //===============================
            //secures password text
            password_text.PasswordChar = '*';
            //================================
            //prevents excessive text entry that
            //could lead to program failure
            password_text.MaxLength = 10;
            username_text.MaxLength = 15;
        }
//===============================================================================================
        private void ExitTP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//===============================================================================================
        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                
                if ((username_text.Text == "admin") || (username_text.Text == "guest"))
                {
                    if ((password_text.Text == "admin") && (username_text.Text == "admin"))
                    {
                        AdminUI AUI = new AdminUI();
                        AUI.ShowDialog();
                    }

                    else if ((password_text.Text == "guest") && (username_text.Text == "guest"))
                    {
                       GuestUI GUI = new GuestUI();
                        GUI.ShowDialog();
                    }

                    else
                    {
                        MessageBox.Show("Password Incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Username Incorrect");
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error");
            }
        //===============================
            //clears text boxes so user
            //must re-enter password to
            //prevent unauthorized access
            username_text.Text = String.Empty;
            password_text.Text = String.Empty;
        }
//==================================================================================================
        private void clock_timer_Tick(object sender, EventArgs e)
        {
            this.DateTimeLabel.Text = DateTime.Now.ToString("t");
        }
//===================================================================================================
    }

   
}
