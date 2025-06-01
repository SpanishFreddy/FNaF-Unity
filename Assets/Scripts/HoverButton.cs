using UnityEngine;
using UnityEngine.EventSystems;

public class HoverButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioClip hoverSound;
    public GameObject[] showOnHover;

    private bool hasPlayedSound = false;

    void Awake()
    {
        SetObjectsActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!hasPlayedSound && hoverSound != null)
        {
            AudioSource.PlayClipAtPoint(hoverSound, Camera.main.transform.position);
            hasPlayedSound = true;
        }

        SetObjectsActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hasPlayedSound = false;
        SetObjectsActive(false);
    }

    private void SetObjectsActive(bool state)
    {
        foreach (var obj in showOnHover)
        {
            if (obj != null)
                obj.SetActive(state);
        }
    }
}