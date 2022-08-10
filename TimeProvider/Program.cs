namespace TimeProvider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeProvider timeProvider = new TimeProvider(new DateTimeNowProvider());
            DateTime dateTimeNow = timeProvider.GetNextOneMinuteFromNow();
            Console.WriteLine(dateTimeNow);
        }
    }

    public interface IDateTimeNowProvider
    {
        DateTime DateTimeNow { get; }
    }

    public class DateTimeNowProvider : IDateTimeNowProvider
    {
        public DateTime DateTimeNow => DateTime.Now;
    }

    public class TimeProvider
    {
        public IDateTimeNowProvider DateTimeNowProvider { get; }

        public TimeProvider(IDateTimeNowProvider dateTimeNowProvider)
        {
            DateTimeNowProvider = dateTimeNowProvider;
        }

        public DateTime GetNextOneMinuteFromNow()
        {
            return DateTimeNowProvider.DateTimeNow.AddMinutes(1);
        }
    }
}