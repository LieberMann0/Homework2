/*Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
  Создать на его основе масив B, отбрасывая те, которые:

   1. нарушают порядок возрастания
   2. больше среднего арифметического элементов A
   3. чётные
*/


int[] A = new int[10];

int index = 0;

while (index < 10)
{
    A[index] = new Random().Next(10, 100);
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

index = 1;
int CurrentEl = A[0];
Console.WriteLine(CurrentEl);
while (index < 10)
{
    if(A[index] > CurrentEl)
    {
        Console.WriteLine(A[index]);
        CurrentEl = A[index];
    }
    index++;
}

Console.WriteLine();



// Меньше среднего арифметического

index = 1;
int sum = A[0];

while (index < 10)
{
    sum = sum + A[index];
    index++;
}

double average = sum / 10;

index = 0;
while (index < 10)
{
    if (A[index] < average)
        {
        Console.WriteLine(A[index]);        
        }
    index++;
}

Console.WriteLine();



// Нечетные

index = 0;
while (index < 10)
{
    if (A[index]%2 == 1) 
        {
        Console.WriteLine(A[index]);        
        }
    index++;
}
