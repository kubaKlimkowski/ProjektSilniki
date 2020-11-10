using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler {
    
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData) {
       
    }
   
    public void OnBeginDrag(PointerEventData eventData) {
        canvasGroup.alpha = .5f;
        canvasGroup.blocksRaycasts = false;


    }

    public void OnDrag(PointerEventData eventData){
        
    }

    public void OnEndDrag(PointerEventData eventData) {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

    }



}
