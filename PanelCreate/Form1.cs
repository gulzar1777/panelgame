using System;
using System.Drawing;
using System.Windows.Forms;

namespace PanelCreate
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromStream(typeof(Form1).Assembly.GetManifestResourceStream("PanelCreate.Resources.bomba.png"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            Panel p = new Panel();
            p.Size = new Size(60, 60);
            p.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            p.Location = new Point(r.Next(0, ClientSize.Width - p.Width + 1),
                r.Next(0, panel1.Top - p.Height + 1));
            this.Controls.Add(p);
            pictureBox1.BringToFront();
            label2.Text = count.ToString();
            ToqqusmaYoxla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(r.Next(0, ClientSize.Width - pictureBox1.Width + 1),
                r.Next(0, panel1.Top - pictureBox1.Height + 1));
            ToqqusmaYoxla();
        }

        private void ToqqusmaYoxla()
        {
            bool toqqusma = false;
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c != panel1 && c.Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    toqqusma = true;
                    break;
                }
            }

            if (toqqusma)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                count = 0;
                label2.Text = count.ToString();
                DialogResult d = MessageBox.Show("Oyun bitdi! Yeni oyun üçün OK düyməsinə basın.",
                    "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    YeniOyun();
                }
            }
        }

        private void YeniOyun()
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control c = this.Controls[i];
                if (c is Panel && c != panel1)
                {
                    this.Controls.Remove(c);
                    c.Dispose();
                }
            }
            count = 0;
            label2.Text = count.ToString();
            pictureBox1.Location = new Point(65, 175);
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Bildiriş",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
