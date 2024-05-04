namespace _7_Polimorfizm.Hayvanlar
{
    public class Hayvan
    {
        //İstedigim kalitim verdigim yerde bu methodu kendileri ezip kendilerine göre düzenlenmesi
        //Bunu Virtual keywordu ile yapariz kalitim verilen yerde bu methodu yeniden tanimlayabiliriz override ederek.
        //Base siniftan gelen methodu kedide degistirmeyip leoparda degistirebiilriz.
        public virtual void SesCikar()
        {

        }
        public virtual void HareketEt()
        {

        }
    }

}
