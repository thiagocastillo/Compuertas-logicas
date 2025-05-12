namespace Library
{
    public class TrustValue : ITrustValue
    {
        private bool value;

        public TrustValue(bool value)
        {
            this.value = value;
        }

        public bool Calculate()
        {
            return value;
        }
    }
}