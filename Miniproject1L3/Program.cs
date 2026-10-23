bool running = true;
List<string> validProducts = new List <string> ();


Console.WriteLine("--------------------------------------");
Console.WriteLine("  PRODUCT LIST MANAGER - LEVEL 3  ");
Console.WriteLine("--------------------------------------");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Enter product names.");
Console.WriteLine("Type 'exit' to finish.");
Console.WriteLine();
Console.WriteLine();

while (running)
{
    Console.Write("Product: ");
    string input = Console.ReadLine().Trim();

    if (input == null || input == "")
    {
        Console.WriteLine("ERROR:Input cannot be empty.\n");
        continue;

    }
    if (input.ToLower().Trim() == "exit")
    {
        running = false;
        continue;
    }
    string[] parts = input.Split('-');
    if (parts.Length != 2)
    {
        Console.WriteLine("Invalid format. Product must contain a dash (-)");
        continue;
    }
    string leftSide = parts[0];
    string rightSide = parts[1];

    // 4. Validar lado izquierdo (solo letras)
    if (leftSide == null || leftSide == "" || leftSide.All(char.IsLetter) == false)
    {
        Console.WriteLine("ERROR:The left side must contain letters only.");
        continue;

    }

    // 5. Validar lado derecho (solo números)
    if (rightSide == null || rightSide == "" || rightSide.All(char.IsDigit) == false)
    {
        Console.WriteLine("ERROR: The right side must contain numbers only.\n");
        continue;
    }

    // 6. Validar rango numérico (200 - 500)
    int numericValue = int.Parse(rightSide);
    if (numericValue < 200 || numericValue > 500)
    {
        Console.WriteLine("ERROR: The numeric part must be between 200 and 500.\n");
        continue;
    }
    
    string formattedProduct = input.ToUpper();
    validProducts.Add(formattedProduct);
    Console.WriteLine($"Product added successfully: {formattedProduct}\n");
       
   
}
Console.WriteLine("´Sorted valid Products: ");
if (validProducts.Count == 0)
{
    Console.WriteLine("No products registered yet.\n");
}
else
{
    validProducts.Sort();
    foreach (var prod in validProducts)
    {
        Console.WriteLine("- " + prod);
    }
    Console.WriteLine();
}
