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
int countElements (string[] array)
{
  int count = 0;
  foreach (string element in array)
  {
    if (element.Length <= 3)
        count++;
  }
  return count;
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
int countNew = countElements(arrayString);
if (countNew > 0)
{ 
string[] newArrayString = new string[countNew];
int i = 0;
foreach (string element in arrayString)
{
  if (element.Length <= 3)
  {
    newArrayString[i] = element;
    i++;
  }
}
Console.Write(" -> ");
printArray(newArrayString);
}
else Console.Write(" -> []");
