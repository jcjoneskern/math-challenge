using System;

public class NumberChecker
{
    public String getNumber()
    {
        String num;

        Console.WriteLine("Enter a whole number:");
        num = Console.ReadLine();

        while (!(Int32.TryParse(num, out int number)))
        {
            Console.WriteLine("That's not a whole number. Enter a whole number:");
            num = Console.ReadLine();
        }

        return num;
    }

    public String getNumber2(String origNum)
    {
        String num;

        Console.WriteLine("Enter another whole number with " + origNum.Length + " digits:");
        num = Console.ReadLine();

        while (!(Int32.TryParse(num, out int number)))
        {
            Console.WriteLine("That's not a whole number. Enter a whole number with " + origNum.Length + " digits:");
            num = Console.ReadLine();
        }


        while (num.Length != origNum.Length)
        {
            Console.WriteLine("No, enter a whole number with " + origNum.Length + " digits:");
            num = Console.ReadLine();
        }

        return num;
    }

    static public void Main()
    {
        String num1, num2;

        NumberChecker n = new NumberChecker();

        num1 = n.getNumber();
        num2 = n.getNumber2(num1);

        int initialTotal = Convert.ToInt32(num1[0]) + Convert.ToInt32(num2[0]);

        for (int i = 1; i < num1.Length; i++)
        {
            if (Convert.ToInt32(num1[i]) + Convert.ToInt32(num2[i]) == initialTotal)
            {
                if (i == num1.Length - 1)
                {
                    Console.WriteLine(true);
                }
            } else
            {
                Console.WriteLine(false);
                break;
            }

        }

        Console.ReadKey();
    }
}