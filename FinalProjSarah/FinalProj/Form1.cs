using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProj.Classes;
using FinalProj.Classes.Entity;


namespace FinalProj
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            GameManager.StartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            GameManager.Draw(e.Graphics);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool moved = true;
            if (e.KeyCode == Keys.Up) { GameManager.penguin.CurrDirection = Direction.UP; }
            else if (e.KeyCode == Keys.Down) { GameManager.penguin.CurrDirection = Direction.DOWN; }
            else if (e.KeyCode == Keys.Left) { GameManager.penguin.CurrDirection = Direction.LEFT; }
            else if (e.KeyCode == Keys.Right) { GameManager.penguin.CurrDirection = Direction.RIGHT; }
            else { moved = false; }
            if (moved) { GameManager.penguin.Move(); }
            this.label1Score.Text = GameManager.penguin.Score.ToString();
            this.label3.Text = GameManager.penguin.Lives.ToString();

            this.pictureBox1.Update();
            this.Refresh();
        }

        private void button1Quit_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}
