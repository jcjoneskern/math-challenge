using System;
 
public class NumberChecker
{
    public String getNumber() 
    {
        String num;
        int number;

        Console.WriteLine("Enter a whole number:");
        num = Console.ReadLine();

        while (!(Int32.TryParse(num, out number))) {
            Console.WriteLine("That's not a whole number. Enter a whole number:");
            num = Console.ReadLine();
        }

        return num;
    }

    public String getNumber2(String origNum) 
    {
        String num;
        int number; 

        Console.WriteLine("Enter another whole number with " + origNum.Length + " digits:");
        num = Console.ReadLine();

        while (!(Int32.TryParse(num, out number))) {
            Console.WriteLine("That's not a whole number. Enter a whole number with " + origNum.Length + " digits:");
            num = Console.ReadLine();
        }


        while (num.Length != origNum.Length) {
            Console.WriteLine("No, enter a whole number with " + origNum.Length + " digits:");
            num = Console.ReadLine();
        }

        return num;
    }
    
    static public void Main ()
    {
        String num1, num2;
        NumberChecker n = new NumberChecker();

        num1 = n.getNumber();
        num2 = n.getNumber2(num1);

        Console.WriteLine(num1);
        Console.WriteLine(num2);
    }
}


// still need to:
// -check if input is a number -- done
// -do math on each index