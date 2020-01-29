using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using FinalProj.Classes.Entity;
using FinalProj.Classes.MapSettings;

namespace FinalProj.Classes.Entity
{

    public class Orcas : AbstractEntity
    {

        private Penguin prey;
        private int hitpoint;
        private int damage;
        static Image myImage = Image.FromFile("../../Classes/Resources/Orca.png");
        public Orcas(Penguin penguin, int rows, int columns) : base(200, rows, columns)
        {
            this.prey = penguin;
            this.hitpoint = 100;
            this.damage = 30;
        }

        public int Hitpoint { get => hitpoint; set => hitpoint = value; }

        public void Attack(Penguin penguin)
        {
            penguin.Hitpoint -= this.damage;
        }
        public bool isAlive() {
            return this.hitpoint > 0;
        }
        public override void Draw(Graphics g)
        {
            int side = Map.cSize;
            int x = this.columns * side;      
            int y = this.rows * side;
            Rectangle bounds = new Rectangle(x, y, side, side);    
            g.DrawImage(myImage, bounds);         
        }
    }
}
