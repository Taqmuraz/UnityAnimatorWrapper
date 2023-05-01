public class DelegateVectorElements : IVectorElements
{
    public delegate float DelegateElements(int index);
    DelegateElements elements;
    
    public DelegateVectorElements(DelegateElements elements)
    {
        this.elements = elements;
    }
    public float At(int index)
    {
        return elements(index);
    }
}
