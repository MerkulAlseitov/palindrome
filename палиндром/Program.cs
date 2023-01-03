string word= Console.ReadLine().ToLower();
char[] letters = word.ToArray();
char[] numbers = word.ToArray();
int a = 0;
int b = numbers.Length;
Array.Reverse(letters);
foreach (var item in letters)
{
    Console.WriteLine(item);
}
for (int i = 0; i < letters.Length; i++)
{
    if (letters[i] == numbers[i])
    {
        a++;
    }
}
if (a == b)
{
    Console.WriteLine("word is palindrome");
}
else
{
    Console.WriteLine("word is not palindrome");
}