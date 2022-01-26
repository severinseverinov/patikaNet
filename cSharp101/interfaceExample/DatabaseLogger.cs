namespace interfaceExample
{
    public class DatabaseLogger:ILogger{
        public void WriteLog(){
            Console.WriteLine("Database'e logları kayıt eder.");
        }
    }
}