using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPtest
{
    public partial class GuestUI : Form
    {
        public GuestUI()
        {
            InitializeComponent();
        }
//========================================================================
        private void ExitGuestUI_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//=========================================================================
        private void clock_timer_Tick(object sender, EventArgs e)
        {
            this.DateTimeLabel.Text = DateTime.Now.ToString("t");
        }
//=========================================================================
    }
}
