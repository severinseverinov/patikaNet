namespace interfaceExample{
    public class FileLogger:ILogger{
        public void WriteLog(){
            Console.WriteLine("Dosyaya loglama işlemini yazar.");
        }
    }
}