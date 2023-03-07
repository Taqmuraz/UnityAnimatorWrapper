using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IEndDragHandler, IDragHandler, IController
{
    [SerializeField] RectTransform center;
    [SerializeField] RectTransform handle;
    [SerializeField] float maxDistance = 100f;

    Vector2 input;

    public void OnDrag(PointerEventData data)
    {
        Vector2 relative = Vector2.ClampMagnitude(data.position - (Vector2)center.position, maxDistance);
        handle.anchoredPosition = relative;
        input = relative / maxDistance;
    }
    public void OnEndDrag(PointerEventData data)
    {
        handle.anchoredPosition = input = Vector2.zero;
    }
    public Vector2 Movement()
    {
        return input;
    }
}