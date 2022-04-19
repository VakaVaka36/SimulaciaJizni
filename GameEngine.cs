using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

public class GameEngine
{
    private bool[,] field;
    private readonly int rows;
    private readonly int cols;
    private Random random = new Random();    

    public GameEngine(int rows, int cols, int density)
    {
        this.rows = rows;
        this.cols = cols;
        field = new bool[rows, cols];

        for (int x = 0; x < cols; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                field[x, y] = random.Next((int)nudDensity.Value) == 0; //Генерация клеток первого поколения
            }
        }
    }
}
