using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace X_O_Csharp_forms
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void myGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start("https://github.com/GingerCRO/");

        }
    }
}
