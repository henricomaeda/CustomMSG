using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMSG
{
    public partial class FrmMain : Form
    {
        Label lab = new Label();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            lab.Cursor = Cursors.Hand;
            lab.Click += new EventHandler(this.LabClick);
        }

        private void LabClick(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou na mensagem!");
        }

        private void Message(string message, bool sucess = true)
        {
            var width = this.Width;
            var height = 40;

            this.Enabled = false;
            if (this.Controls.Contains(lab))
            {
                Task.Run(() =>
                {
                    for (int i = height; i >= 0; i -= 2)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            lab.Size = new Size(width, i);
                        });
                        Thread.Sleep(10);
                    }
                    Invoke((MethodInvoker)delegate
                    {
                        this.Controls.Remove(lab);
                        Message(message, sucess);
                    });
                });
            }
            else
            {
                lab.Size = new Size(width, 0);
                lab.Location = new Point(0, 0);
                lab.TextAlign = ContentAlignment.MiddleCenter;
                lab.Text = message;

                if (sucess) lab.BackColor = Color.FromArgb(60, 0, 140, 255);
                else lab.BackColor = Color.FromArgb(60, 255, 0, 144);
                this.Controls.Add(lab);
                lab.BringToFront();

                Task.Run(() =>
                {
                    for (int i = 0; i <= height; i += 2)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            lab.Size = new Size(width, i);
                        });
                        Thread.Sleep(10);
                    }
                    Invoke((MethodInvoker)delegate
                    {
                        this.Enabled = true;
                    });
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message("Você enviou uma mensagem com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Message("Ocorreu um erro ao tentar enviar a mensagem.", false);
        }
    }
}
