using UnityEngine;

public class InputVector : IVector
{
    public void Serve(IVectorClient client)
    {
        client.Call(new Vector2Elements(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }
}
