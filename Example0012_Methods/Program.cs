// // Вид 1
// void Method1()
// {
//     Console.WriteLine("Method1");
// }
// Method1();





// // Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Test Message");

// // Вид 2.1
// void Method2_1(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method2_1($"Test Message+", 4);


// // Вид 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// // Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result += text;
//         i++;

//     }
//     return result;
// }

// string res = Method4(10,"qwerty");
// Console.WriteLine(res);



//for


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}