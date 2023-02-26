void MethodCreateInputArray(string[] InputArray)
{
    Console.Write($"Input array: ");
    for (int i = 0; i < InputArray.Length; i++) Console.Write($"{InputArray[i]} ");
    Console.WriteLine();
}
void MethodCreateOutputArray(string[] OutputArray)
{
    Console.Write($"Output array: ");
    string[] NewArray = new string[OutputArray.Length];
    for (int i = 0; i < OutputArray.Length; i++)
    {
        if (OutputArray[i].Length <= 3)
        {
            NewArray[i] = OutputArray[i];
            Console.Write($"{NewArray[i]} ");
        }
    }
    Console.WriteLine();
}