namespace TimeProvider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeProvider timeProvider = new TimeProvider();
            DateTime dateTimeNow = timeProvider.GetNextOneMinuteFromNow();
            Console.WriteLine(dateTimeNow);
        }
    }

    public class TimeProvider
    {
        public DateTime GetNextOneMinuteFromNow()
        {
            return DateTime.Now.AddMinutes(1);
        }
    }
}