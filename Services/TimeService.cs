namespace lr3.Services
{
    public class TimeService
    {
        public string GetTimeOfDayMessage()
        {
            var currentTime = DateTime.Now; 
            string timeMessage;

            // Визначаємо, яка частина доби
            if (currentTime.Hour >= 6 && currentTime.Hour < 12)
                timeMessage = "Зараз ранок";
            else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
                timeMessage = "Зараз день";
            else if (currentTime.Hour >= 18 && currentTime.Hour < 24)
                timeMessage = "Зараз вечір";
            else
                timeMessage = "Зараз ніч";

            // Формуємо повідомлення з поточним часом
            return $"{timeMessage}, поточний час {currentTime:HH:mm}";
        }
    }
}