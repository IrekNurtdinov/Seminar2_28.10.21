// int[] arr = new int[10];

// int index = 0;

// while (index < 10)
// {
//      Console.WriteLine($"{arr[index++]}");
     
// }

//Рисуем прямоугольник

// void DrawRectangle(int posX, int posY, int width, int height )
// {
// int row = 0;
// while (row < height)
// {
//     Console.SetCursorPosition(posX, posY+row);
//     int count = 0;
//     while (count < width)
//     {
//        Console.Write("+"); 
//        count++; 
       
//     }
//     row++;
// }
// }
// DrawRectangle(5, 5, 9, 4);

// Нужно написать рограмму решения квадратных уравнений

// Ax^2 + Bx + C = 0
// 1x^2 - 2x + 6 = 0

// Метод еоторый не возвращает:

// void Solve(double a, double b, double c) {
    
//     double d = b * b - 4 * a * c; // дискриминант
//     Console.WriteLine(d);

//     if (d < 0)
//     {
//         Console.WriteLine("Действительных корней нет");
//     }
//     else 
//     {
//         double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//         double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//         Console.WriteLine(x1);
//         Console.WriteLine(x2);

//     }
//     Console.WriteLine();
//     }


// Метод который возвращает:   
(double, double) Solve(double a, double b, double c) {
    
    double d = b * b - 4 * a * c; // дискриминант
    Console.WriteLine(d);

    if (d < 0)
    {
        //Console.WriteLine("Действительных корней нет");
        return (double.NaN, double.NaN);
    }
    else 
    {
        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
        return (x1, x2);

    }
    Console.WriteLine();
    }

(double, double) roots = Solve(1, -7, 6); Console.WriteLine(roots);   
roots = Solve(1, 0, 6); Console.WriteLine(roots); 
roots = Solve(1, 0, -4); Console.WriteLine(roots); 
roots = Solve(1, 2, -4); Console.WriteLine(roots); 