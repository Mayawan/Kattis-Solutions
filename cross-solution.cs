using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    class Program
    {
        static int[][] board;
        static bool[][][] impossibleValues;
        static bool[][] isFull;
        static void Main(string[] args)
        {
            board = new int[9][];
            isFull = new bool[3][];

            //fills isFull matrix
            for(int i = 0; i < 3; i++)
            {
                isFull[i] = new bool[3];
            }

            //input and check for row ERROR
            for(int i = 0; i < 9; i++)
            {
                board[i] = Console.ReadLine().Select(x => (x == '.') ? 0 : int.Parse(x.ToString())).ToArray();
                if(board[i].Where(x => x != 0).Count() != board[i].Where(x => x != 0).Distinct().Count())
                {
                    Console.WriteLine("ERROR");
                    return;
                }
            }

            //check for column ERROR
            for(int i = 0; i < 9; i++)
            {
                int[] col = board.Select(x => x[i]).Where(x => x != 0).ToArray();
                if(col.Count() != col.Distinct().Count())
                {
                    Console.WriteLine("ERROR");
                    return;
                }
            }

            //check for group ERROR
            for(int i = 0; i < 3; i++)//group col
            {
                for (int j = 0; j < 3; j++)//group row
                {
                    int[] group = new int[9];
                    int counter = 0;
                    for(int k = 0; k < 3; k++)//internal col
                    {
                        for(int l = 0; l < 3; l++)//internal row
                        {
                            group[counter] = board[3 * i + k][3 * j + l];
                            counter++;
                        }
                    }

                    group = group.Where(x => x != 0).ToArray();

                    if(group.Count() != group.Distinct().Count())
                    {
                        Console.WriteLine("ERROR");
                        return;
                    }
                }
            }

            Deduct:
            impossibleValues = new bool[9][][]; //false = possible, true = impossible
            for(int i = 0; i < 9; i++)
            {
                impossibleValues[i] = new bool[9][];
                for(int j = 0; j < 9; j++)
                {
                    impossibleValues[i][j] = new bool[9];
                }
            } //fills impossibleValues matrix

            //make row, col, and group of value impossible
            for (int i = 0; i < 9; i++)//col
            {
                for (int j = 0; j < 9; j++)//row
                {
                    int value = board[i][j];

                    if (value == 0) continue;

                    //make cell impossible for every value
                    for(int k = 0; k < 9; k++)
                    {
                        impossibleValues[k][i][j] = true;
                    }

                    //cells in row and col can not be value
                    for(int k = 0; k < 9; k++)//loops row and col of cell
                    {
                        impossibleValues[value - 1][i][k] = true;
                        impossibleValues[value - 1][k][j] = true;
                    }

                    //get x and y where group[x][y] is the group the cell is in
                    int x = (int)Math.Floor((decimal)i / 3);
                    int y = (int)Math.Floor((decimal)j / 3);

                    //cells in group can not be value
                    for(int k = 0; k < 3; k++)
                    {
                        for(int l = 0; l < 3; l++)
                        {
                            impossibleValues[value - 1][3 * x + k][3 * y + l] = true;
                        }
                    }
                }
            }

            bool determined = false;
            for(int i = 0; i < 3; i++)//group col
            {
                for(int j = 0; j < 3; j++)//group row
                {
                    Dictionary<int, List<Vector>> cellAvailability = new Dictionary<int, List<Vector>>();
                    for(int k = 1; k <= 9; k++)//loops values 1-9
                    {
                        bool isPresent = false;
                        List<Vector> vectors = new List<Vector>();
                        for(int l = 0; l < 3; l++)//internal col
                        {
                            for(int m = 0; m < 3; m++)//internal row
                            {
                                int x = 3 * i + l;
                                int y = 3 * j + m;
                                if (!impossibleValues[k - 1][x][y])
                                {
                                    vectors.Add(new Vector(x, y));
                                }
                                if (board[x][y] == k) isPresent = true;
                            }
                        }
                        if(!isPresent) cellAvailability.Add(k, vectors);
                    }

                    if (!isFull[i][j] && cellAvailability.Where(x => x.Value.Count() == 0).Count() > 0)
                    {
                        Console.WriteLine("ERROR");
                        return;
                    }

                    var determinable = cellAvailability.Where(x => x.Value.Count() == 1).GroupBy(x => x.Value);

                    

                    foreach(var cell in determinable)
                    {
                        if(cell.Count() == 1)
                        {
                            KeyValuePair<int, List<Vector>> pair = cell.First();
                            int value = pair.Key;
                            Vector v = pair.Value[0];

                            board[v.x][v.y] = value;
                            determined = true;

                            bool isfull = true;
                            for (int l = 0; l < 3 && isfull; l++)//internal col
                            {
                                for (int m = 0; m < 3 && isfull; m++)//internal row
                                {
                                    int x = 3 * i + l;
                                    int y = 3 * j + m;
                                    
                                    if(board[x][y] == 0)
                                    {
                                        isfull = false;
                                    }
                                }
                            }

                            if(isfull)
                            {
                                isFull[i][j] = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("ERROR");

                            return;
                        }
                    }
                }
            }

            if (determined) goto Deduct;
            else
            {
                board.Select(x => string.Join("", x.Select(y => y.ToString().Replace("0", ".")).ToArray())).ToList().ForEach(x => Console.WriteLine(x));
            }
        }
    }

    class Vector
    {
        public int x;
        public int y;
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
