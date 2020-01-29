using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using FinalProj.Classes.Entity;


namespace FinalProj.Classes.MapSettings
{
    public static class Map
    {

        public static string map = "../../Classes/Resources/Map.txt";
        public static int[,] mData = null;
        public static AbstractEntity[,] eData = null;
        public static readonly int cSize = 23;
        public static List<Point> orcasMap = new List<Point>();
        public static List<Point> fishMap = new List<Point>();
        public static List<Point> crabMap = new List<Point>();
        
        public static void LoadMapData()
        {
            string[] fLines = File.ReadAllLines(map);
            int nRow = fLines.Length;
            int nCol = fLines[0].Length;
            mData = new int[nRow, nCol];
            eData = new AbstractEntity[nRow, nCol];
            int row = 0;

            foreach (string line in fLines)
            {
                char[] ch = line.ToCharArray();
                int col = 0;
                foreach (char characteres in ch)
                {
                    switch (characteres)
                    {
                        case '#':
                            mData[row, col] = -1;
                            eData[row, col] = EntityFactory.CreateWall(new Point(row, col));
                            break;
                        case '.':
                            mData[row, col] = 1;
                            eData[row, col] = EntityFactory.CreateWay(new Point(row, col));
                            orcasMap.Add(new Point(row, col));
                            fishMap.Add(new Point(row, col));
                            crabMap.Add(new Point(row, col));
                            break;
                        case 'I':
                            mData[row, col] = 1;
                            eData[row, col] = EntityFactory.CreateIglu(new Point(row, col));
                            break;
                        default:
                            break;
                    }
                    col++;
                }
                row++;
            }          
        }
        public static int GetMap(int rows, int columns)
        {
            int maxRow = mData.GetUpperBound(1);
            int maxCol = mData.GetUpperBound(0);
            if (columns < 0 || columns > maxCol) { return -1; }
            if (rows < 0 || rows > maxRow) { return -1; }
            return mData[rows, columns];
        }
    }
}
