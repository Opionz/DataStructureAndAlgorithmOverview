// See https://aka.ms/new-console-template for more information

Arrays arrays = new Arrays();
    int[] array1 = new int[5];

        array1[0] = 1;
        array1[1] = 2;
        array1[2] = 3;
        array1[3] = 4;
        array1[4] = 5;

var output = arrays.ArrayMethod(array1.ToArray());
Console.WriteLine("Array Results are as follow");
Console.WriteLine(string.Join(", ", output));

foreach (var el in array1)
{
    Console.WriteLine($" {el} ");
}

for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine($" {array1[i]} ");
}

    Console.WriteLine("MultiDimArray starts here");
    int[,] mArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

    for (int i = 0; i < mArray.GetLength(0); i++)
    {
        for (int j = 1; j < mArray.GetLength(1); j++)
        {
            Console.WriteLine(mArray[i,j]);
        }
    }

    Console.WriteLine("MultiDimArray ends here");
Console.ReadKey();


public class Arrays
{
    

    public Arrays()
    {
        
    }

    public int[] ArrayMethod(int[] array1)
    {
      
        return array1;
    }
}



