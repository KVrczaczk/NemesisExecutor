using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace MialasExecutor
{
    public partial class UserControl1 : UserControl
    {
        readonly ExploitAPI api = new ExploitAPI();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            api.SendLuaScript(script);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = Properties.Settings.Default.textboxvalue;
        }

        private void UserControl1_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.textboxvalue = fastColoredTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Title = "Open",
                Filter = "Text (*.txt)|*.txt|Lua (*.lua)|*.lua|All Files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dialog = new SaveFileDialog
            {
                Title = "Save as",
                Filter = "Text (*.txt)|*.txt|Lua (*.lua)|*.lua|All Files (*.*)|*.*"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(Dialog.FileName))
                {
                    File.Create(Dialog.FileName).Close();
                }
                else
                {
                    File.WriteAllText(Dialog.FileName, fastColoredTextBox1.Text);
                }
            }
        }
    }
}
