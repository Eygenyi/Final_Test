string[] arr =
{
    "How",
    "Do",
    "You",
    "Do?;)"
};
string[] temp = new string[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
    if (arr[i].Length <= 3)
    {
        temp[i] = arr[i];
        Console.WriteLine(" --->   " + temp[i]);
    }
    else
    {
        Console.WriteLine(" --->  >3 symbols");
    }

}
