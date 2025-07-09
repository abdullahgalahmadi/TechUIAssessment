using UnityEngine;
using UnityEngine.EventSystems;

public class HandFollowUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public RectTransform handImage;

    
    private float handOffsetX = 250f;
    private float handYOffset = 140f; 

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (handImage != null)
        {
            Vector2 buttonPos = ((RectTransform)transform).anchoredPosition;
            handImage.gameObject.SetActive(true);
            handImage.anchoredPosition = new Vector2(handOffsetX, buttonPos.y + handYOffset);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (handImage != null)
        {
            handImage.gameObject.SetActive(false);
        }
    }
}
