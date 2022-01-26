namespace interfaceExample2
{
    class CarManager{
        public ICar _icar;
        public CarManager(ICar icar){
            this._icar=icar;
        }

        public void PrintCarInfo(){
            Console.WriteLine("Car brand : "+_icar.Brand().ToString()+" color : "+_icar.Color().ToString()+" wheels : "+_icar.Wheels().ToString());
        }
    }
}