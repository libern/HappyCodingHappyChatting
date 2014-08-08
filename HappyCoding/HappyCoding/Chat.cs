using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyCoding
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();

            var email = "happy@someline.com";
            var password = "12345678";

//            Client SomelineClient = new Client();
            Client.StartClient();
        }




    }
}
