internal class Program
{
    private static void Main(string[] args)
    {
        FileLogger fileLogger=new FileLogger();
        fileLogger.WriteLog();

        DataBaseLogger dataBaseLogger=new DataBaseLogger();
        dataBaseLogger.WriteLog();

        SmsLogger smsLogger=new SmsLogger();
        smsLogger.WriteLog();

        LogManager logManager=new LogManager(new DataBaseLogger());
        logManager.WriteLog();
        
    }
}