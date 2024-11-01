﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpClient
{
    public partial class LoginForm : Form
    {

        private Form1 formref;
        private ListBox mlbref;
        private ListBox ulbref;

        public LoginForm(Form1 form1, ref ListBox mlbref, ref ListBox ulbref)
        {
            this.formref = form1;
            this.mlbref = mlbref;
            this.ulbref = ulbref;
            InitializeComponent();
        }
  

        private void UsernameSendBTN_Click(object sender, EventArgs e)
        {
            if (UsernameTEXT.Text != "")
            {
                var m = Message.send(MessageRecipients.MR_BROKER, MessageTypes.MT_INIT, UsernameTEXT.Text);
                if (m.GetAction() == MessageTypes.MT_DECLINE)
                {
                    MessageBox.Show("Error");
                    UsernameTEXT.Text = "";
                }
                else
                {
                    Form1.username = UsernameTEXT.Text;
                    formref.Enabled = true;
                    mlbref.Items.Add($"server: Hello {UsernameTEXT.Text}!");
                    Thread t = new Thread(() => Form1.ProcessMessages(ref this.formref, ref this.mlbref, ref this.ulbref));
                    t.Start();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
