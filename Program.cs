// See https://aka.ms/new-console-template for more information
using ConAppAssignment2;
using System.Collections.Generic;


SortedList<string,Product> productList = new SortedList<string, Product>();
// Adding sample product 
productList.Add("001", new Product("Laptop", 50000, "Lenevo", new DateTime(2023, 1, 25), new DateTime(2026, 1, 25)));
productList.Add("002", new Product("Dextop", 42000, "Apple", new DateTime(2022, 1, 21), new DateTime(2025, 1, 21)));
productList.Add("003", new Product("Camera", 30000, "Canon", new DateTime(2021, 1, 22), new DateTime(2024, 1, 22)));
productList.Add("004", new Product("Lights", 20000, "Santox", new DateTime(2020, 1, 28), new DateTime(2022, 1, 20)));
Console.WriteLine("Index\tPName\t\tPrice\tmfDate\t\tExpDate");
// Displaying Details
for(int i = 0; i < productList.Count; i++)
{
    Product product = productList.Values[i];
    Console.WriteLine($"{i + 1}\t{product.PName}\t\t{product.PPrice}\t{product.PBrand}\t{product.ManufacturingDate.ToShortDateString()}\t{product.ExpiryDate.ToShortDateString()}");
}

