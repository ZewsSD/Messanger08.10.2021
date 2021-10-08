using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZOOP19
{
    public partial class Form1 : Form
    {
        public event Action<string> SendMessageAllForms;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            SendMessageAllForms?.Invoke(richTextBox.Text);
        }

        public void PrintMessage(string text)
        {
            listBoxHistory.Items.Add(text);
        }
    }
}
