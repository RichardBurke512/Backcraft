﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backcraft.forms.backcraft
{
    public partial class b_7zip : Form
    {
        public b_7zip()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void b_7zip_Load(object sender, EventArgs e)
        {
            textbox_path.Text = logic.cfg.GetPathFromFile("7zip");
        }

        private void brn_search_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textbox_path.Text = fbd.SelectedPath;
            }
        }

        private void btn_usedefault_Click(object sender, EventArgs e)
        {
            textbox_path.Text = @"C:\Program Files\7-Zip";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                new logic.cfg("7zip", textbox_path.Text.ToString()).WriteCFG();
                new logs.log().WriteLog(0, "Saved 7zip path: " + textbox_path.Text.ToString());
            }
            catch (Exception)
            {
                new logs.log().WriteLog(2, "Saved 7zip path: " + textbox_path.Text.ToString());
            }

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
