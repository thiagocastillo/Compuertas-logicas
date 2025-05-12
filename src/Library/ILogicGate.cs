namespace Library;

public interface ILogicGate : ITrustValue
{
    void AddInput(ITrustValue input);
}