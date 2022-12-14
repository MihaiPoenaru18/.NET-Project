using System.Text.RegularExpressions;

class TestAlgorithm
{
    static public void Main(String[] args)
    {
        Console.Write("N= ");
        string number = Console.ReadLine();
        int n = int.Parse(number);
        List<string> strings = new List<string>();
        for (int i = 0; i < n; i++)
        {
            strings.Add(Console.ReadLine());
        }
        Console.Write("[");
        foreach (string s in strings)
        {
            GetArrayOfNumbers(FindNumbers(s));
        }
        Console.Write("[");
    }

    private static List<int> FindNumbers(string input)
    {
        int number = 0;
        string[] numberInString;
        List<int> numbers = new List<int>();
        numberInString = Regex.Split(input, @"\D+");
        foreach (string item in numberInString)
        {
            if (item != string.Empty)
            {
                number = Convert.ToInt32(item);
                numbers.Add(number);
                
            }
          
        }
        return numbers;
    }

    private static void GetArrayOfNumbers(List<int> element)
    {
        
        foreach (int number in element)
        {
            Console.Write($" {number} ");
        }
      
    }
}

