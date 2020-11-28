using System;
using System.IO;
using System.Windows.Forms;

namespace JsonComparer
{
    public partial class Form2 : Form
    {
        public string JsonName { get; set; }
        public string JsonText { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public void ShowJson()
        {
            tbContent.Text = JsonText;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "(*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,
                FileName = JsonName == string.Empty ? "diff" : JsonName
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filename = saveFileDialog.FileName;
                File.WriteAllText(filename, tbContent.Text);
            }
        }
    }
}