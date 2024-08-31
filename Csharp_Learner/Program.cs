using System;
    class program {
    static void Main(string[] args)
    {
        Console.Write("Enter how many tables do u want to merge: ");
        int no_of_tables = Convert.ToInt32(Console.ReadLine());
        int no_of_seats = 4;
        for(int i = 1; i < no_of_tables ; i++)
        {
            no_of_seats += 2;
        }
        Console.WriteLine($"Total no of seats when joining {no_of_tables} tables is {no_of_seats}");
    }
}