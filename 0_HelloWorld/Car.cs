class Car {
    public string Id;
    public int Price;
    public Car(int price, Tire tires){
        this.Price = price;
        this.Id = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
    }

    public void SigHej(){
        Console.WriteLine("Hej fra " + Id + " jeg koster " + Price);
    }
}
