namespace EventYangin
{
    public class Alarm
    {
        public event YanginEvent AlarmCaldi;
        public void AlarmCal(object alarmTetikleyen)
        {
            
            if (alarmTetikleyen is Kablo)
            {
                Console.WriteLine("Alarm Kablo yanmasindan dolayi caldi");
                AlarmCaldi(this); 
            }
            else if (alarmTetikleyen is Sigara)
            {
                Console.WriteLine("Alarm Sigara dolayi caldi");
                return;
               
            }
        }
    }
}
