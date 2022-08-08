// See https://aka.ms/new-console-template for more information



    Console.Write("輸入1~10的數字");
    var input = Console.ReadLine();
    var number = Convert.ToInt32(input);

    if (number >= 0 && number <= 10)
        Console.WriteLine("有效");
    else
        Console.WriteLine("無效");




    Console.WriteLine("輸入數字1");
    var number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("輸入數字2");
    var number2 = Convert.ToInt32(Console.ReadLine());

    var max = (number1 > number2) ? number1 : number2;
    Console.WriteLine("Max is " + max);







Console.WriteLine("輸入寬的長度 :");
var width = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("輸入長的長度 :");
var height = Convert.ToInt32(Console.ReadLine());

    var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
    Console.WriteLine("圖形為 " + orientation);






Console.WriteLine("速限為");

var speedLimt = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("車速為");

var carSpeed = Convert.ToInt32(Console.ReadLine());

if (carSpeed < speedLimt)
    Console.WriteLine("ok");
else
{
    const int kmPerDemeritPoint = 5;
    var demeritPoint = (carSpeed - speedLimt) / kmPerDemeritPoint;
    if (demeritPoint > 22)
        Console.WriteLine("吊扣牌照");
    else
        Console.WriteLine("扣點為" + demeritPoint);
}


enum ImageOrientation
{
    Landscape,
    Portrait
}