namespace _9_Abstract
{
    public class Gitar : MuzikAleti
    {
        private string _model;
        public override string Marka { get; set; }
        public override string Model
        {
            get
            {
                return _model;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _model = value;
                }
                else
                {
                    throw new Exception("model alani boş geçilemez");
                }
            }
        }
        public override string Cal()
        {

            //Eger Kod yazamaz isenin NotImplementedException hatasi verecektir.
            //throw new NotImplementedException();

            return "Gitar Çaldi";
        }
    }
}
