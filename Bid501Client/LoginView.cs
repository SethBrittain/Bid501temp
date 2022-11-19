using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bid501Client
{
    public partial class UxLoginForm : Form
    {
        public UxLoginForm()
        {
            InitializeComponent();
        }

        private void UxLoginButton_Click(object sender, EventArgs e)
        {
            string username = UxUsernameInput.Text;
            string password = UxPasswordInput.Text;
        }
    }
}
