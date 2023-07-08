int[] original = new int[5];

for  (int x = 0; x < original.Length; x++)
{
    Console.Write("Enter a Number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    original[x] = number;
}

int[] copy = original[0..];
string copyString = string.Join(", ", copy);
Console.WriteLine(copyString);
