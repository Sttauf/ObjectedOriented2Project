using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FinalProj.Classes.MapSettings;
using System.Windows.Forms;

namespace FinalProj.Classes.Entity
{

    public class Penguin : AbstractEntity
    {
        private int lives;
        private int hitpoint;
        private int damage = 30;
        static Image image = Image.FromFile("../../Classes/Resources/Penguin.png");

        public int Lives { get => lives; set => lives = value; }
        public int Hitpoint { get => hitpoint; set => hitpoint = value; }
      

        public Penguin(int rows, int columns) : base(0, rows, columns)
        {
            this.lives = 3;
            this.Hitpoint = 230;
        }
        public override void Eaten(AbstractEntity food)
        {
            base.Eaten(food);

        }
        public override void Draw(Graphics g)
        {
            int sd = Map.cSize;
            int x = this.columns * Map.cSize;
            int y = this.rows * Map.cSize;
            Rectangle bounds = new Rectangle(x, y, sd, sd);
            g.DrawImage(image, bounds);
        }
        public bool Eatable(AbstractEntity target)
        {
            return (target is FoodCrab || target is FoodFish);
        }
        public void Attack(Orcas enemy) {
            enemy.Hitpoint -= this.damage;
        }
        public bool PassThrough(AbstractEntity target)
        {
            return !(target is Wall);
        }
        public void Move() {
            Point move = base.GetDirection();
            int nextRow = this.Rows + move.Y;
            int nextColumn = this.Columns + move.X;

            if (Map.GetMap(nextRow, nextColumn) > 0)
            {
                AbstractEntity tgEntity = Map.eData[nextRow, nextColumn];
                if (this.PassThrough(tgEntity))
                {
                    if (tgEntity is Orcas && ((Orcas)tgEntity).isAlive())
                    {
                        BattleWindow form = new BattleWindow(this, (Orcas)tgEntity);
                        form.Show();
                    }
                    else
                    {
                        this.rows = nextRow;
                        this.columns = nextColumn;
                       
                        if (Eatable(tgEntity))
                        {
                            this.Eaten(tgEntity);

                        }
                    }
                }
                
                
            }
        }
    }
}
