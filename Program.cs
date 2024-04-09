string[] arr = new string[] { "Hello", "2", "world", ":-)" };
List<string> new_arr = new List<string>();

for (int i = 0; i < arr.Length; i++)
{
    string str = arr[i];
    if (str.Length <= 3)
    {
        new_arr.Add(str);
    }
}

Console.WriteLine(string.Join(", ", new_arr));
