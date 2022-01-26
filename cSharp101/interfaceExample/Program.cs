using System;
namespace interfaceExample
{
    class Program{
    static void Main(string[] args){
        FileLogger file=new FileLogger();
        file.WriteLog();

        DatabaseLogger data=new DatabaseLogger();
        data.WriteLog();

        SmsLogger sms=new();
        sms.WriteLog();

        // Burası çok önemli "bridge pattern" örneği iyi anla!
        LogManager manager=new LogManager(new FileLogger());
        manager.WriteLog();
        
        }
    }
}