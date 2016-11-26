using System;
namespace Solution
{
    class Solution
    {
        enum GoToPosition
        {
            Up,
            Down,
            Right,
            Left
        }

        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Trim();
            var H = (line1.Split(' ').Length > 0) ? Int32.Parse(line1.Split(' ')[0]) : 1;
            var W = (line1.Split(' ').Length > 1) ? Int32.Parse(line1.Split(' ')[1]) : 1;
            var boxes = new char[H, W];
            for (var i = 0; i < H; i++)
            {
                var data = Console.ReadLine().Trim().ToCharArray();
                for (int j = 0; j < W; j++)
                {
                    boxes[i, j] = data[j];
                }
            }
            var nowH = 0;
            var nowW = 0;
            var throughBoxes = 0;
            var nowGoToPosition = GoToPosition.Right;
            while (true)
            {
                if (nowH >= H || nowH < 0 || nowW >= W || nowW < 0) break;
                var box = boxes[nowH, nowW];
                throughBoxes += 1;
                switch (box)
                {
                    case '_':
                        switch(nowGoToPosition)
                        {
                            case GoToPosition.Up:
                                nowH -= 1;
                                break;
                            case GoToPosition.Down:
                                nowH += 1;
                                break;
                            case GoToPosition.Right:
                                nowW += 1;
                                break;
                            case GoToPosition.Left:
                                nowW -= 1;
                                break;
                        }
                        break;

                    case '\\':
                        switch (nowGoToPosition)
                        {
                            case GoToPosition.Up:
                                nowW -= 1;
                                nowGoToPosition = GoToPosition.Left;
                                break;
                            case GoToPosition.Down:
                                nowW += 1;
                                nowGoToPosition = GoToPosition.Right;
                                break;
                            case GoToPosition.Right:
                                nowH += 1;
                                nowGoToPosition = GoToPosition.Down;
                                break;
                            case GoToPosition.Left:
                                nowH -= 1;
                                nowGoToPosition = GoToPosition.Up;
                                break;
                        }
                        break;

                    case '/':
                        switch (nowGoToPosition)
                        {
                            case GoToPosition.Up:
                                nowW += 1;
                                nowGoToPosition = GoToPosition.Right;
                                break;
                            case GoToPosition.Down:
                                nowW -= 1;
                                nowGoToPosition = GoToPosition.Left;
                                break;
                            case GoToPosition.Right:
                                nowH -= 1;
                                nowGoToPosition = GoToPosition.Up;
                                break;
                            case GoToPosition.Left:
                                nowH += 1;
                                nowGoToPosition = GoToPosition.Down;
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine(throughBoxes);
        }
    }
}