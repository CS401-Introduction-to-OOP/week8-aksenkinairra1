using Week8;
    class Program
    {
        static void Main()
        {
            var letter = new Letter("111", 0.5);
            var parcel = new Parcel("112", 15.0, "60x50x40");
            
            var myCargo = new CargoContainer<DeliveryItem>();

            myCargo.AddItem(letter);
            myCargo.AddItem(parcel);

            Console.WriteLine($"\nЗагальна вартість замовлень: {myCargo.GetTotalCost()} грн");
        }
    }
