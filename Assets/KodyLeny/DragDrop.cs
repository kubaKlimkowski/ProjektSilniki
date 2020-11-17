using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler {
    
    private CanvasGroup canvasGroup;
    private GameObject currentDragObject;


    private void Awake()
    {
        instance = this;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData) {
        //czy to jest w ogole potrzebne do dzialania
        //czy obiekt jest przesuwalny
    }

    public void OnBeginDrag(PointerEventData eventData) {
        canvasGroup.alpha = .5f;
        canvasGroup.blocksRaycasts = false;
        Debug.Log("podnosze");
        var canvas = FindInParents<Canvas>(gameObject);
        if (canvas == null)
            return;

        

    }

    public void OnDrag(PointerEventData eventData){
        currentDragObject.transform.position = Input.mousePosition;
        //przemiesc
    }

    public void OnEndDrag(PointerEventData eventData) {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        //czy tu moge upuscic
        //czy to miejsce na ten obiekt
        //nie - odeslij do eq 
        //tak - umiesc i zwolnij slot w eq
    }



}
