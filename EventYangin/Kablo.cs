namespace EventYangin
{
    public class Kablo
    {
        public event YanginEvent Yandim;
        public void AkimGecir()
        {
            bool kisaDevreVarmi=true;
            if(kisaDevreVarmi)
            {
                Console.WriteLine("Kablo Yandi");
                Yandim(this);
            }
        }
    }
}
