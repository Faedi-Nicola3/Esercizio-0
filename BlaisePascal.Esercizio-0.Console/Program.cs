public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the number of books to purchase.");
        double numberOfBooks = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the cost of a single book.");
        double priceOfTheBook = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter whether you are a student (true/false)");
        bool isStudent = bool.Parse(Console.ReadLine());

        Console.WriteLine("Select the shipping method: enter 1 for shipping (+€5) or 2 for pickup.");
        string deliveryMethod = Console.ReadLine();

        double totalCost = numberOfBooks * priceOfTheBook;

        if (deliveryMethod == "1")
        {
            totalCost += 5;
        }

        if (numberOfBooks > 1)
        {
            int i = 0;
            while (i < numberOfBooks)
            {
                Console.WriteLine("Enter the title of book number " + (i + 1));
                string bookTitle = Console.ReadLine();
                i++;

            }
        }
        else
        {
            Console.WriteLine("Enter the book title.");
            string bookTitle = Console.ReadLine();

        }

        Console.WriteLine("Name: " + name);

        Console.WriteLine("Number of books: " + numberOfBooks);

        Console.WriteLine("Price of a single book: " + priceOfTheBook);

        Console.WriteLine("Shipping method: " + deliveryMethod);

        if (deliveryMethod == "1")
        {
            Console.WriteLine("Total cost: " + (totalCost - 5));
        }
        else
        {
            Console.WriteLine("Total cost: " + totalCost);
        }

        if (deliveryMethod == "1")
        {
            Console.WriteLine("Total cost: " + totalCost);
        }

        if (deliveryMethod == "1")
        {
            Console.WriteLine("Shipping costs are €5");
        }
        else
        {
            Console.WriteLine("Shipping costs are €0");
        }

        if (numberOfBooks <= 0 || priceOfTheBook <= 0)
        {
            Console.WriteLine("Invalid order!");
        }
        else if (totalCost < 20)
        {
            Console.WriteLine("Small-value order! Thank you for your purchase.");
        }
        else
        {
            Console.WriteLine("Grazie per il tuo ordine!");
        }

    }
}