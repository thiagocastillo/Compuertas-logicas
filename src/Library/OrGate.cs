namespace Library;

public class OrGate:ILogicGate
{
    List <ILogicGate> entradas;
    
    public void AddInput(ILogicGate gate)
    {
        entradas.Add(gate);
    }
    
    public bool Calculate()
    {
        return entradas[0].Calculate() || entradas[1].Calculate();
    }
}