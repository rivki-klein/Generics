// See https://aka.ms/new-console-template for more information
using Generics;
Console.WriteLine("Hello, World!");

static void PrintTheObj<T>(T obj)
{
    Console.WriteLine(obj);
}
PrintTheObj<int>(3);
PrintTheObj<string>("hi");
PrintTheObj<double>(1.2);

SwapList<int> arr = new SwapList<int> { 1, 2, 3 };
Console.WriteLine(arr[1]+" " + arr[2]);
arr.MySwap(1,2);
Console.WriteLine(arr[1] + " " + arr[2]);


