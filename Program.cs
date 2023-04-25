using HowComputerCalculateTangent;

while (true)
{
    Console.ResetColor();
    Console.Write("angle (0-360) : ");
    var angle = int.Parse(Console.ReadLine()!);
    var radian = MrkMathHelper.AngleToRadian(angle);
    Console.WriteLine($"radian : {angle} * PI * 180 = {radian}");
    Console.Write("precision : ");
    var precision = int.Parse(Console.ReadLine()!);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    var Sin = MrkMathHelper.Sin(radian, precision);
    var Cos = MrkMathHelper.Cos(radian);
    var Tan = MrkMathHelper.Tan(radian);
    Console.WriteLine($"Sin Of radian by precision {Sin} (Calculeted by Teylor Series)");
    Console.WriteLine($"Cos Of radian {Cos} (Calculeted by Teylor Series)");
    Console.WriteLine($"Rounded Cos Of radian {Math.Round(Cos)} (Calculeted by Teylor Series & Rounded)");
    Console.WriteLine($"Tan Of radian {Tan} (Tan = Sin / Cos)");
    Console.WriteLine($"Rounded Tan Of radian {Sin / Math.Round(Cos)} (Tan = Sin / Round(Cos))");
    Console.WriteLine();
}
