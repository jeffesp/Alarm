using System;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Alert : Form
    {
        private string message;

        public Alert()
        {
            InitializeComponent();
        }

        public Alert(string message)
            : this()
        {
            this.message = message;
        }

        protected override void OnActivated(EventArgs e)
        {
            messageLabel.Text = message;
        }

        private void dismissButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
