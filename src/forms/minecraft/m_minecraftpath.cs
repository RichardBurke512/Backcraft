﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backcraft.forms.minecraft
{
    public partial class m_minecraftpath : Form
    {
        public m_minecraftpath()
        {
            InitializeComponent();
        }

        private void m_minecraftpath_Load(object sender, EventArgs e)
        {
            textbox_path.Text = logic.minecraftpath.GetMinecraftPath();
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
            textbox_path.Text = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            new logic.minecraftpath(textbox_path.Text.ToString()).WriteToFile();
            Form1._MinecraftPath = textbox_path.Text.ToString();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
