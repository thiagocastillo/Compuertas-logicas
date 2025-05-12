namespace Library;

public class AndGate:ILogicGate
{
    private List<ITrustValue> inputs = new List<ITrustValue>();

    public void AddInput(ITrustValue input)
    {
        inputs.Add(input);
    }
    
    public bool Calculate()
    {
        return inputs[0].Calculate() && inputs[1].Calculate();
    }
}