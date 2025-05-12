namespace Library;

public interface ILogicalGate
{
    void AddInput(ILogicalGate gate);
    
}