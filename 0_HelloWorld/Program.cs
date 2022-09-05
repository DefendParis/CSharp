
CarDealer dealer = new CarDealer(); //This class you need to create yourself!
while(true){

    Console.WriteLine("Write an action [buy, sell, exit]");
    string input = Console.ReadLine();

    switch (input)
    {
        case "buy":
            Car firstCar = dealer.AvailableCars[0];
            Car myNewCar = dealer.Buy(firstCar);
            Console.WriteLine("My first car cost " + myNewCar.Price);
            break;
        case "sell":
            break;
        case "exit":
            return;
        default:
            break;
    }
}
