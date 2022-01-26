using System;

namespace interfaceExample
{
    public class SmsLogger:ILogger{
        public void WriteLog(){
            Console.WriteLine("Sms olarak log yazar.");
        }
    }
}