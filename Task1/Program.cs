
//Service prices
decimal smallCarpetPrice = 25;
decimal LargeCarpetPrice = 35;
decimal tax = 0.06m;


// Welcome massage 
Console.WriteLine("Welcome to Islam Carpet Cleaning Service");
// Reading number of small carpets
Console.Write("Enter Number of small carpets : ");
int smallCarpetNumber = Convert.ToInt32(Console.ReadLine());
// Reading number of large carpets
Console.Write("Enter Number of large carpets : ");
int largeCarpetNumber = Convert.ToInt32(Console.ReadLine());

// Invoice
Console.WriteLine($"Number of small carpets: {smallCarpetNumber}");
Console.WriteLine($"Number of large carpets: {largeCarpetNumber}");
Console.WriteLine($"Price per small room: ${smallCarpetPrice}");
Console.WriteLine($"Price per small room: ${LargeCarpetPrice}");
decimal cost = (LargeCarpetPrice * largeCarpetNumber) + (smallCarpetNumber * smallCarpetPrice);
Console.WriteLine($"Cost : ${cost}");
Console.WriteLine($"Tax : ${cost * tax}");
Console.WriteLine("===============================");
Console.WriteLine($"Total estimate: ${(cost * tax) + cost}");
Console.WriteLine("This estimate is valid for 30 days");


