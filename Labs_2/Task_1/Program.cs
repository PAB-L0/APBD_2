// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("1st Modification");
Console.WriteLine("2nd Modification");
Console.WriteLine("3rd Modification");

static double average(int[] array)
{
    var sum = 0;
    foreach(var element in array)
        sum += element;
    return (double)sum / array.Length;
}

static int max(int[] array)
{
    var max = array[0];
    for(var i = 1; i < array.Length; i++)
        if(max < array[i])
            max = array[i];
    return max;
}