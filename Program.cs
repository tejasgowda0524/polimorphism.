namespace polimorphim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cargoplane c = new cargoplane();
            passengerplane p = new passengerplane();
            fighterplane f = new fighterplane();

            airport.permit(c);
            airport.permit(p); 
            airport.permit(f);
        }
    }
}
