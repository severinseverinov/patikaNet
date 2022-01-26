namespace interfaceExample2
{
    public class Civic:ICar{
        public int Wheels(){
            return 3;
        }
        public Colors Color(){
            return Colors.Red;
        }
        public Brands Brand(){
            return Brands.Toyota;
        }
    }
}