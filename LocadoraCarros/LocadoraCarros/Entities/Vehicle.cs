namespace LocadoraCarros.Entities
{
    class Vehicle
    {

        public string Model { get; set; }

        public Vehicle(string carModel)
        {
            Model = carModel;
        }
    }
}
