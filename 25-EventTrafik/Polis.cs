namespace _25_EventTrafik
{
    public class Polis : Insan
    {
        private string _ad;
        public Polis(string ad) : base(ad)
        {
            _ad = ad;
        }
        public void HizKontrolEt(int hiz,object tetikleyen)
        {
            if (tetikleyen is Araba )
            {
                if (hiz>120)
                {
                    Araba araba = tetikleyen as Araba;
                    araba.ArabaCalisiyorMu = false;
                    string msj = $"{araba.Plaka} plakali aracin {araba.soforAdi} isimli sofore {hiz} km hizla gittiginden dolayi" +
                        $" {this._ad} isimli polis tarafindan ceza kesilmistir";
                    Console.WriteLine(msj);
                }
            }
        }
    }
}
