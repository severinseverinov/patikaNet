namespace interfaceExample2
{
    public class Focus:ICar{
        public int Wheels(){
            return 4;
        }
        public Colors Color(){
            return Colors.Black;
        }
        public Brands Brand(){
            return Brands.Ford;
        }
    }
}