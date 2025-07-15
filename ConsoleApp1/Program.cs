// See https://aka.ms/new-console-template for more information
Console.WriteLine("1つ目の数値を入力してください:");
string? input1 = Console.ReadLine();
int number1 = int.Parse(input1 ?? "0");

Console.WriteLine("2つ目の数値を入力してください:");
string? input2 = Console.ReadLine();
int number2 = int.Parse(input2 ?? "0");

Console.WriteLine($"入力された値: {number1}, {number2}");

// 足し算と引き算の計算
int sum = number1 + number2;
int difference = number1 - number2;

Console.WriteLine($"足し算の結果: {number1} + {number2} = {sum}");
Console.WriteLine($"引き算の結果: {number1} - {number2} = {difference}");
