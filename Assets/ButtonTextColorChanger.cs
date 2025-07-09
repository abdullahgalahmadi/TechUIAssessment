using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonTextColorChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Text targetText;
    public Color normalColor = Color.black;
    public Color hoverColor = new Color(1f, 0.5f, 0f); // Orange

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (targetText != null)
            targetText.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (targetText != null)
            targetText.color = normalColor;
    }
}
