using UnityEngine;

public class SwapHandler : MonoBehaviour
{
    [SerializeField] private SwapInput SI;
    
    private RaycastHit2D _hit;

    private void OnMouseDown()
    {
        SI.IsDrag = true;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        if (_hit.collider != null)
            SI.SelectedSlot = _hit.collider.gameObject;
    }

    private void OnMouseEnter()
    {
        if (SI.IsDrag && SI.SelectedSlot != this)
        {
            SI.IsDrag = false;
            Debug.Log("Swap, œ≈–≈»Ã≈Õ”…  À¿——€");
        }
    }
}
