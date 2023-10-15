using System;

class Program
{
    static void ReadNumber(int start, int end)
    {
        int num, count = 1, length = 10;

        do
        {
            try
            {
                Console.Write($"Enter a {count} number in the range [{start}...{end}]: ");
                num = Int32.Parse(Console.ReadLine());
                if (num >= (end - length + count))
                    throw new ArgumentOutOfRangeException();
                if (num <= start)
                    throw new ApplicationException("Your number is not bigger than previous!");
                else
                {
                    start = num;
                    count++;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        } while (count < length);
    }


    static void Main()
    {
        int start, end;
        Console.Write("Enter start of your range: ");
        start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter end of your range: ");
        end = Convert.ToInt32(Console.ReadLine());

        ReadNumber(start, end);

    }
}
