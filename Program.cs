void inputArray(string[] array)
{
  Console.WriteLine("Input elements of the array:");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"Array[{i}] = ");
    array[i] = Console.ReadLine()!;
  }
}
void printArray(string[] array)
{ 
  Console.Write("[");
  for (int i = 0; i < array.Length-1; i++)
  Console.Write($"\"{array[i]}\",");
  Console.Write($"\"{array[array.Length-1]}\"]");
}

Console.Clear();
string[] arrayString; 
Console.Write("Input a number of elements in the array = ");
int count = Int32.Parse(Console.ReadLine()!);
while ((count < 1))
{
    Console.Write("You make a mistake!\nInput a number of elements in the array = ");
    count = Int32.Parse(Console.ReadLine()!);
}
arrayString = new string[count];
inputArray(arrayString);
printArray(arrayString);
