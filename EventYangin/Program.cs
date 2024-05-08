namespace EventYangin
{
    public delegate void YanginEvent(object b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Kablo kablo = new Kablo();
            Alarm alarm = new Alarm();
            Itfaiye itfaiye = new Itfaiye();
            Sigara Malboro = new Sigara();

            Insan veysel = new Insan("Veysel");
            Insan eylem = new Insan("Eylem");
            Insan muhammed = new Insan("Muhammed");
            Insan didem = new Insan("Didem");



            kablo.Yandim += alarm.AlarmCal;
            kablo.Yandim += veysel.TepkiVer;
            kablo.Yandim+= eylem.RahatsizOl;

            alarm.AlarmCaldi += itfaiye.MudahaleEt;
            alarm.AlarmCaldi += muhammed.TepkiVer;
            alarm.AlarmCaldi += didem.Kac;

            Malboro.Yandim += eylem.RahatsizOl;
            Malboro.Yandim += didem.TepkiVer;

            kablo.AkimGecir();
            Malboro.SigaraIc();


        }
    }
}
