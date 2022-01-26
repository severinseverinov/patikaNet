namespace interfaceExample2
{
    public class Grandland:ICar{
        public int Wheels(){
            return 4;
        }
        public Colors Color(){
            return Colors.Blue;
        }
        public Brands Brand(){
            return Brands.Opel;
        }
    }
}