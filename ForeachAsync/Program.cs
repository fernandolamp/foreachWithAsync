// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var lista = new List<int>()
{
    1,2,3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
};

//foreach (var item in lista)
//{
//    await Output(item);
//}
lista.ForEach(async x => await Output(x));
Console.WriteLine("fim");

static async Task Output(int i)
{
    await Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine(i);
    });
}