﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reatal_House_Management_System
{
    public partial class UpdateOwnerForm : MetroFramework.Forms.MetroForm
    {
        public UpdateOwnerForm()
        {
            InitializeComponent();
        }

        private void UpdateOwnerForm_Load(object sender, EventArgs e)
        {
            String id = UserNameBox.Text;
            Admin s = DB.Admins.SingleOrDefault(x => x.Mobile_No == id);
            if (s != null)
            {
                NameTextBox.Text = s.Name;
                PasswordTextBox.Text = s.Password;
                MobileNoTextBox.Text = s.Mobile_No;
            }
        }
    }
}
