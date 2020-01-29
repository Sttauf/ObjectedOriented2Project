using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FinalProj.Classes.MapSettings;

namespace FinalProj.Classes.Entity
{
    public abstract class AbstractEntity
    {
        protected Point currLocation;
        protected int rows;
        protected int columns;
        protected Direction currDirection;
        protected bool eat;
        protected int score;

        protected Point CurrLocation { get => currLocation; set => currLocation = value; }
        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }
        public Direction CurrDirection { get => currDirection; set => currDirection = value; }
        public bool Eat { get => eat; set => eat = value; }
        public int Score { get => score; set => score = value; }

        protected AbstractEntity(int score, int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.Score = score;

            this.CurrLocation = new Point (columns * Map.cSize, rows * Map.cSize);
        }
        public virtual void Eaten(AbstractEntity food)
        {
            if (!food.Eat)
            {
                this.Score += food.Score;
                food.eat = true;
            }
        }
        protected Point GetDirection()
        {
            Point dir = new Point(0, 0);
            switch (this.currDirection)
            {
                case Direction.UP:
                    dir = new Point(0, -1);
                    break;   
                case Direction.DOWN:
                    dir = new Point(0,1);
                    break;
                case Direction.RIGHT:
                    dir = new Point(1,0);
                    break;
                case Direction.LEFT:
                    dir = new Point(-1, 0);
                    break;
            }
            return dir;               
        }
       
        public abstract void Draw(Graphics g);
    }
}
