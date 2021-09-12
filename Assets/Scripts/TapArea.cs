using UnityEngine;

using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler

{
    public AudioSource gameClip;

    public void OnPointerDown (PointerEventData eventData)

    {
        // Script by Hariz Abdurrafi
        // https://github.com/RyukoSan20/Incremental_Game-Dilo_Academy
        GameManager.Instance.CollectByTap (eventData.position, transform);
        gameClip.Play();

    }

}