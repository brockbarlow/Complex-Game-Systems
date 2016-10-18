using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class Aim2 : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler {

    GameObject Cube;
   
    void Start()
    {

    }

    void Update()
    {


    }
    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
       
       
        Debug.Log("Gotteeem");
       
    }

   

    
}
