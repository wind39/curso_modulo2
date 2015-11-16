using System;
using System.Drawing;
using System.Windows.Forms;

namespace Modulo2
{
    public class Janela : Form
    {
        public Janela()
        {
            // formulario
            this.Text = "Exemplo Curso de Programação C#";
            this.Size = new Size(600, 400);
            this.WindowState = FormWindowState.Normal;
            this.MinimumSize = new Size(600, 400);
            //this.MaximumSize = new Size(600, 400);
            this.MaximizeBox = true;
            this.ShowInTaskbar = true;
            this.ShowIcon = true;
            this.Icon = new Icon("logo.ico");
            //this.FormClosed += new FormClosedEventHandler(this.form_Closed);
            this.FormClosing += new FormClosingEventHandler(this.form_Closing);

            // label
            Label l = new Label();
            l.Text = "Isso é um label!";
            l.Location = new Point(30, 30);
            l.AutoSize = true;
            this.Controls.Add(l);

            // textbox
            TextBox t = new TextBox();
            //t.Text = "";
            t.Location = new Point(30, 50);
            t.Size = new Size(540, 50);
            t.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.Controls.Add(t);

            // button
            Button b = new Button();
            b.Text = "Salvar";
            b.AutoSize = true;
            b.Location = new Point(450, 320);
            b.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            b.Click += new EventHandler(this.button_Click);
            this.Controls.Add(b);

            CheckBox c = new CheckBox();

        }

        private void form_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                    "Tem certeza que deseja sair?",
                    "Encerrar programa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                ) == DialogResult.Yes)
            {
                this.Close();
            }
            else
                e.Cancel = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Tem certeza que deseja salvar em arquivo?",
                    "Salvar em arquivo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                ) == DialogResult.Yes)
            {
                // salva em arquivo
                Console.WriteLine("Salvando em arquivo");

                MessageBox.Show("Arquivo salvo com sucesso");
            }
        }
    }
}

