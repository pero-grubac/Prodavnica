﻿using Prodavnica.Database.DTO;
using Prodavnica.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica.Forms.HelperForms.Admin
{
    public partial class Employee : Form
    {
        public Employee(User user)
        {
            InitializeComponent();

            LoadSettings.ApplySettins(user, this);
        }
    }
}
