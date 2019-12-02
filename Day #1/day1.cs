        // Will require System.IO and System.Linq
        static int GetFuel(double x) => Convert.ToInt32(Math.Floor(x / 3)) - 2;

        static int Part1() => File.ReadAllLines("input.txt").Select(x => GetFuel(double.Parse(x))).Sum();

        static int Part2()
        {
            int sum = 0;
            foreach (string line in File.ReadAllLines("input.txt"))
            {
                int tmp = GetFuel(double.Parse(line));
                while (tmp > 0)
                {
                    sum += tmp;
                    tmp = GetFuel(tmp);
                }
            }
            return sum;
        }