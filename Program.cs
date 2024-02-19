class Program
{
  public static void Main(string[] args)
  {
    int[] expensesCost;
    Console.WriteLine("Entre com o número de despesas: ");

    int numberOfExpenses = GetNumberOfExpenses();
    expensesCost = new int[numberOfExpenses];

    for (int i = 0; i < numberOfExpenses; i++)
    {
      expensesCost[i] = GetExpenseCostFromUser();
    }
    
    int totalExpenses = 0;

    for (int i = 0; i < numberOfExpenses; i++)
    {
      totalExpenses += expensesCost[i];
    }

    Console.WriteLine("O total das despesas é: " + totalExpenses);
  }

  public static int GetNumberOfExpenses()
  {
    string? entry = Console.ReadLine();
    int convertInt = Convert.ToInt32(entry);
    return convertInt;
  }

   public static int GetExpenseCostFromUser()
    {
        Console.WriteLine("Entre com a despesa: ");
        string? entry = Console.ReadLine();
        int convertInt = Convert.ToInt32(entry);
        return convertInt;
    }
}

