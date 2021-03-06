﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EASTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDecodeRawResponse_Click(object sender, EventArgs e)
        {
            DecodeWbxmlBinaryFile oForm = new DecodeWbxmlBinaryFile();
            oForm.Show();
            oForm = null;
        }

        private void btnDecodeWbxmlBytesIntoXML_Click(object sender, EventArgs e)
        {
            DecodeWbxmlBytesIntoXML oForm = new DecodeWbxmlBytesIntoXML();
            oForm.Show();
            oForm = null;
        }

        private void btsEasConversations_Click(object sender, EventArgs e)
        {
            frmRawEAS oForm = new frmRawEAS();
            oForm.Show();
            oForm = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text  += " (" + Application.ProductVersion + ")";
        }
    }
}
