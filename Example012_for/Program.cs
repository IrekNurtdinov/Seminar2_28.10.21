// int[] arr = new int[10];

// int index = 0;

// while (index < 10)
// {
//      Console.WriteLine($"{arr[index++]}");
     
// }

void DrawRectangle(int posX, int posY, int width, int height )
{

    Console.SetCursorPosition(posX, posY);
    int count = 0;
    while (count < width)
    {
       Console.Write("+"); 
       count++; 
       
    }
    
}

DrawRectangle(20, 10, 6, 2);