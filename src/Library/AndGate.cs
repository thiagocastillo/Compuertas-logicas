namespace Library;

public class AndGate:ILogicGate
{
    List <ILogicGate> entradas = new List<ILogicGate>();
    
    public void AddInput(ILogicGate gate)
    {
        entradas.Add(gate);
    }
    
    public bool Calculate()
    {
        return entradas[0].Calculate() && entradas[1].Calculate();
    }
}