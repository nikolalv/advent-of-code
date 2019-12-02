        // Will require System.IO and System.Linq
        static int GetFuel(double x) => Convert.ToInt32(Math.Floor(x / 3)) - 2;

        static int Part1() => File.ReadAllLines("input.txt").Select(x => GetFuel(double.Parse(x))).Sum();

        static int GetFuelFuel(int x) => x + ((GetFuel(x) > 0) ? GetFuelFuel(GetFuel(x)) : 0);
        
        static int Part2() => File.ReadAllLines("input.txt").Select(x => GetFuelFuel(GetFuel(double.Parse(x)))).Sum();