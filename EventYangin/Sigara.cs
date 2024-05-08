namespace EventYangin
{
    public class Sigara
    {
        public event YanginEvent Yandim;
        public void SigaraIc()
        {
            Console.WriteLine("Sigara İcildi");
            Yandim(this); 
        }
    }
}
