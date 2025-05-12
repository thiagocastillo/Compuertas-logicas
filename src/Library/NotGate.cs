namespace Library;

namespace Library
{
    public class NotGate : ILogicGate
    {
        private ITrustValue input;

        public void AddInput(ITrustValue input)
        {
            this.input = input;
        }

        public bool Calculate()
        {
            return !input.Calculate();
        }
    }