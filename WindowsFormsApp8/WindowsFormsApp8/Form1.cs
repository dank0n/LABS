using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private int x = 54, y = 23;
        private Button[,] buttons = new Button[3,3];
        private int player;
        int scoreX = 0, scoreO = 0;
        public Form1()
        {
            InitializeComponent();
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            label2.Text = scoreX.ToString();
            label4.Text = scoreO.ToString();
            player = 1;
            label1.Text = "Текущий ход: Игрок 1 - Х";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(121, 102);
                }
            }
            setButtons();
        }

        private void setButtons()
        {
            for (int j = 0; j < 3; j++)        
            {
                for (int i = 0; i < 3; i++)
                {
                    buttons[i, j].Location = new Point(54 + 127 * i, 85 + 108 * j);
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 48);
                    buttons[i, j].BackColor = Color.Gold;
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    
                    player = 0;
                    label1.Text = "Текущий ход: Игрок 2 - О";
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "O");
                    player = 1;
                    label1.Text = "Текущий ход: Игрок 1 - Х";
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
        }
           private void checkWin()
           {
               if (buttons[0,0].Text == buttons[0,1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
               {
                if (buttons[0, 0].Text != "")
                {
                    if (player == 1)
                    {
                        scoreO++;
                        label4.Text = scoreO.ToString();
                        MessageBox.Show("Победил игрок 2 - О!");
                    }
                    else
                    {
                        scoreX++;
                        label2.Text = scoreX.ToString();
                        MessageBox.Show("Победил игрок 1 - Х!");
                    }
                    enabled();
                    return;
                }
                
               }
               if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
               {
                if (buttons[1, 0].Text != "")
                {
                    if (player == 1)
                    {
                        scoreO++;
                        label4.Text = scoreO.ToString();
                        MessageBox.Show("Победил игрок 2 - О!");
                    }
                    else
                    {
                        scoreX++;
                        label2.Text = scoreX.ToString();
                        MessageBox.Show("Победил игрок 1 - Х!");
                    }
                    enabled();
                    return;
                }
               }
               if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
               {
                if (buttons[2, 0].Text != "")
                {
                    if (player == 1)
                    {
                        scoreO++;
                        label4.Text = scoreO.ToString();
                        MessageBox.Show("Победил игрок 2 - О!");
                    }
                    else
                    {
                        scoreX++;
                        label2.Text = scoreX.ToString();
                        MessageBox.Show("Победил игрок 1 - Х!");
                    }
                    enabled();
                    return;
                }                   
               }
               if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
               {
                   if (buttons[0, 0].Text != "")
                {
                    if (player == 1)
                    {
                        scoreO++;
                        label4.Text = scoreO.ToString();
                        MessageBox.Show("Победил игрок 2 - О!");
                    }
                    else
                    {
                        scoreX++;
                        label2.Text = scoreX.ToString();
                        MessageBox.Show("Победил игрок 1 - Х!");
                    }
                    enabled();
                    return;
                }                       
               }
               if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
               {
                   if (buttons[0, 1].Text != "")
                {
                    if (player == 1)
                    {
                        scoreO++;
                        label4.Text = scoreO.ToString();
                        MessageBox.Show("Победил игрок 2 - О!");
                    }
                    else
                    {
                        scoreX++;
                        label2.Text = scoreX.ToString();
                        MessageBox.Show("Победил игрок 1 - Х!");
                    }
                    enabled();
                    return;
                }                      
               }
               if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
               {
                   if (buttons[0, 2].Text != "")
                {
                    if (player == 1)
                    {
                        scoreO++;
                        label4.Text = scoreO.ToString();
                        MessageBox.Show("Победил игрок 2 - О!");
                    }
                    else
                    {
                        scoreX++;
                        label2.Text = scoreX.ToString();
                        MessageBox.Show("Победил игрок 1 - Х!");
                    }
                    enabled();
                    return;
                }                                 
               }
               if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
               {
                   if (buttons[0, 0].Text != "")
                {
                    if (player == 1)
                    {
                        scoreO++;
                        label4.Text = scoreO.ToString();
                        MessageBox.Show("Победил игрок 2 - О!");
                    }
                    else
                    {
                        scoreX++;
                        label2.Text = scoreX.ToString();
                        MessageBox.Show("Победил игрок 1 - Х!");
                    }
                    enabled();
                    return;
                }                      
               }
               if (buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text)
               {
                   if (buttons[0, 2].Text != "")
                {
                    if (player == 1)
                    {
                        scoreO++;
                        label4.Text = scoreO.ToString();
                        MessageBox.Show("Победил игрок 2 - О!");
                    }
                    else
                    {
                        scoreX++;
                        label2.Text = scoreX.ToString();
                        MessageBox.Show("Победил игрок 1 - Х!");
                    }
                    enabled();
                    return;
                }                      
               }
            if (buttons[0, 0].Text != "" && buttons[0, 2].Text != "" && buttons[2, 0].Text != "" && buttons[2, 2].Text != "" && buttons[1, 0].Text != "" && buttons[0, 1].Text != "" && buttons[1, 1].Text != "" && buttons[1, 2].Text != "" && buttons[2, 1].Text != "")
            {
                MessageBox.Show("Ничья!");
                enabled();
                return;
            }
        }

        private void enabled()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i,j].GetType().GetProperty("Enabled").SetValue(buttons[i, j], false);

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                    player = 1;
                    label1.Text = "Текущий ход: Игрок 1 - Х";
                }
            }
        }
        private Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
