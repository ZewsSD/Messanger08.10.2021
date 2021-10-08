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
    public partial class FormServer : Form
    {
        private List<Form1> _forms;

        public FormServer()
        {
            InitializeComponent();
            _forms = new List<Form1>();
        }

        private void buttonCreareForm_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.SendMessageAllForms += SendMessage;
            newForm.Show();
            _forms.Add(newForm);
        }

        private void SendMessage(string text)
        {
            foreach (var item in _forms)
            {
                item.PrintMessage(text);
            }
        }
    }
}
