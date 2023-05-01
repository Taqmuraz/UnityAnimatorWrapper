public class DelegateVectorClient : IVectorClient
{
    public delegate void DelegateCall(IVectorElements elements);
    DelegateCall call;
    
    public DelegateVectorClient(DelegateCall call)
    {
        this.call = call;
    }
    public void Call(IVectorElements elements)
    {
        call(elements);
    }
}
