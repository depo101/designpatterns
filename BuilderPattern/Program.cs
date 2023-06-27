// See https://aka.ms/new-console-template for more information

#region Sample01
using BuilderPattern.Sample01;
ProductManager productManager = new();
var product = productManager.CreateProductBuilder(new ProductBuilderFormOne());
string response = product.Run();
Console.WriteLine("Product - 1 : \n" + response);
Console.WriteLine();
product = productManager.CreateProductBuilder(new ProductBuilderFormTwo());
response = product.Run();
Console.WriteLine("Product - 2 : \n" + response);
#endregion
