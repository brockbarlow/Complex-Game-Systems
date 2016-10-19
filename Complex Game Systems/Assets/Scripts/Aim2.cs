using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class Aim2 : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler {

   
    void Start()
    {

    }

    void Update()
    {


    }
    public void OnPointerDown(PointerEventData eventData)
    {
      //Displays text in log when OnPointerDown is Active.
        Debug.Log("OnPointerDown");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
     //Displays text in log when OnPointerUp is Active.   
        Debug.Log("OnPointerUp");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
      //Indicates that the mouse is being clicked on a collider. 
      //Object needs to have collider, Event Trigger, Event System, Camera
      //Also needs Physics Raycast  
        Debug.Log("Gotteeem");
       
    }

   

    
}
