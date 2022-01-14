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



