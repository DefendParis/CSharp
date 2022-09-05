
class CarDealer
{
    //Fields
    public List<Car> AvailableCars = new List<Car>(); 
    public Car[] ArrayOfCars = new Car[5];
    public Car[][] MultiArrayOfCars = new Car[5][];
    public Car[][][] MultiMultiArrayOfCars = new Car[5][][];
    public Dictionary<int, Car> myCars = new Dictionary<int, Car>();

    private float _money;

    //Constructors
    public CarDealer()
    { 
        _money = 1000f;
        Car Car01 = new Car(500, new Tire());
        Car Car02 = new Car(500, new Tire());
        Car Car03 = new Car(500, new Tire());
        AvailableCars.Add(Car01);
        AvailableCars.Add(Car02);
        AvailableCars.Add(Car03);
    }

    //Public methods
    public Car Buy(Car car)
    { //Public buy method, which takes a Car as an argument/paramater
        Car returnValueCar = null;
        foreach (Car c in AvailableCars)
        {   
            if(car.Id == c.Id){
                returnValueCar = c;
            }
        }
        return returnValueCar;
    }

    public void Sell(Car car){}

    //Private methods
    //void ...(){}
}
