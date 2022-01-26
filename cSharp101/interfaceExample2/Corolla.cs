namespace interfaceExample2
{
    public class Corolla:ICar{
        public int Wheels(){
            return 4;
        }
        public Colors Color(){
            return Colors.White;
        }
        public Brands Brand(){
            return Brands.Toyota;
        }
    }
}