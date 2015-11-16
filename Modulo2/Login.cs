using System;
using System.Drawing;
using System.Windows.Forms;

namespace Modulo2
{
    public class Login : Form
    {
        public Login()
        {
            this.Text = "Login";

            // button
            Button b = new Button();
            b.Text = "Login";
            b.AutoSize = true;
            b.Location = new Point(30, 30);
            b.Click += new EventHandler(this.button_Click);
            this.Controls.Add(b);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Janela j;

            j = new Janela();

            this.Hide();

            j.ShowDialog();

            this.Close();
        }
    }
}

