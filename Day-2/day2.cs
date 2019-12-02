// Requires System.IO

static int Part1()
{
    int[] arr = File.ReadAllText("input.txt").Split(',').Select(x => int.Parse(x)).ToArray();
    arr[1] = 12;
    arr[2] = 2;
    bool finished = false;
    for(int i = 0; i < arr.Length && !finished; i++)
    {
        switch (arr[i])
        {
            case 99:
                finished = true;
                break;
            case 1:
                int num = arr[arr[++i]] + arr[arr[++i]];
                arr[arr[++i]] = num;
                break;
            case 2:
                int num2 = arr[arr[++i]] * arr[arr[++i]];
                arr[arr[++i]] = num2;
                break;
        }
    }
    return arr[0];
}