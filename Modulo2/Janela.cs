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
            this.Size = new Size(800, 600);
            this.WindowState = FormWindowState.Normal;
            this.MinimumSize = new Size(800, 600);
            //this.MaximumSize = new Size(800, 600);
            this.MaximizeBox = true;
            this.ShowInTaskbar = true;
            this.ShowIcon = true;
            this.Icon = new Icon("logo.ico");

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
            t.Size = new Size(300, 50);
            //t.Anchor = 
            this.Controls.Add(t);
        }
    }
}

