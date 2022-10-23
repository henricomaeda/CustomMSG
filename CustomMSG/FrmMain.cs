using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMSG
{
    public partial class FrmMain : Form
    {
        readonly Label label = new Label();
        Color backColor = Color.MediumPurple;
        Color foreColor = Color.White;

        public FrmMain()
        {
            InitializeComponent();
            LblMessage.Select();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            label.Cursor = Cursors.Hand;
            label.Click += new EventHandler(LabClick);
        }

        private void BtnColourAndSend_Click(object sender, EventArgs e)
        {
            LblMessage.Select();
            if (Controls.Contains(label))
            {
                Task.Run(() =>
                {
                    var height = 40;
                    var width = Width;
                    for (int i = height; i >= 0; i -= 2)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            label.Size = new Size(width, i);
                        });
                        Thread.Sleep(10);
                    }
                    Invoke((MethodInvoker)delegate
                    {
                        Controls.Remove(label);
                        BtnColourAndSend_Click(sender, e);
                    });
                });
            }
            else
            {
                if (sender == BtnBackColour && Colour.ShowDialog() == DialogResult.OK) backColor = Colour.Color;
                else if (sender == BtnForeColour && Colour.ShowDialog() == DialogResult.OK) foreColor = Colour.Color;
                else if (sender == BtnSend) Message(TxtMessage.Text);
            }
        }

        private void PicLicense_Click(object sender, EventArgs e)
        {
            var t = "Email icons created by Freepik\nhttps://www.flaticon.com/free-icons/email\n\nColor icons created by Freepik\nhttps://www.flaticon.com/free-icons/color\n\nDriving license icons created by Freepik\nhttps://www.flaticon.com/free-icons/driving-license";
            var c = "Flaticon";
            var b = MessageBoxButtons.OK;
            var i = MessageBoxIcon.Information;

            MessageBox.Show(t, c, b, i);
        }

        private void Message(string message, bool sucess = true)
        {
            var width = Width;
            var height = 40;

            Enabled = false;
            if (!Controls.Contains(label))
            {
                label.Size = new Size(width, 0);
                label.Location = new Point(0, 0);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = message;

                label.BackColor = backColor;
                label.ForeColor = foreColor;
                Controls.Add(label);
                label.BringToFront();

                Task.Run(() =>
                {
                    for (int i = 0; i <= height; i += 2)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            label.Size = new Size(width, i);
                        });
                        Thread.Sleep(10);
                    }
                    Invoke((MethodInvoker)delegate
                    {
                        Enabled = true;
                    });
                });
            }
        }

        private void LabClick(object sender, EventArgs e)
        {
            var t = label.Text;
            var c = "CustomMSG";
            var b = MessageBoxButtons.OK;
            var i = MessageBoxIcon.Information;

            MessageBox.Show(t, c, b, i);
        }
    }
}
