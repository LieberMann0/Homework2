/* Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
   Создать на его основе масив B, отбрасывая те, которые нарушают порядок

    - возрастания
    - элементы, больше 8
    - знакочередования
*/



int FillArray(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}

int[] A = new int[10];
int index = 0;

while (index < 10)
{
    A[index] = FillArray(-10, 11);
    index++;
}

index = 0;

while (index < 10)
{
    Console.WriteLine(A[index]);
    index++;
}

Console.WriteLine();



// По возрастанию
Console.WriteLine("Элементы по возрастанию");

index = 1;
int CurEl = A[0];
Console.WriteLine(CurEl);
while (index < 10)
{
    if(A[index] > CurEl)
    {
        Console.WriteLine(A[index]);
        CurEl = A[index];
    }
    index++;
}

Console.WriteLine();



// Элементы меньше 8
Console.WriteLine("Элементы меньше 8");

index = 0;
while (index < 10)
{
    if (A[index] < 8)
        {
        Console.WriteLine(A[index]);        
        }
    index++;
}

Console.WriteLine();




// Знакочередование
Console.WriteLine("Знакочередующиеся элементы");

index = 0;
int sw = 0;
while (index < 10)
{
    if (sw == 0)
    {
        if (A[index] > 0)
        {
            Console.WriteLine(A[index]); 
            sw = 1;
        }        
    }

    else
    {
        if (A[index] < 0)
        {
            Console.WriteLine(A[index]); 
            sw = 0;
        }        
    }
    index++;    
}