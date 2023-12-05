class Program
{
    static void Main()
    {
        // 1 Dimensional Array
        int[] arrayInt = new int[4];
        arrayInt[0] = 5;
        Console.WriteLine(arrayInt[0]);

        var arrayInt2 = new int[4];
        arrayInt2[0] = 2;
        Console.WriteLine(arrayInt2[0]);

        // int[] arrayInt3 = [5, 6, 7, 8, 9];      // C# 12 saja
        // Console.WriteLine(arrayInt3[2]);

        int[] arrayInt4 = new int[] {1,2,3,4};
        Console.WriteLine(arrayInt4[2]);

        int[] arrayInt5 = new int[4] {1,2,3,4};
        Console.WriteLine(arrayInt5[3]);
        
        // 2 Dimensional Array
        int[,] arrayInt6 = new int[4,5];
        arrayInt6[0,2] = 100;
        Console.WriteLine(arrayInt6[0,2]);
    }
}


