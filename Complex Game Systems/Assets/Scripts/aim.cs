using UnityEngine;
using System.Collections;

public class aim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Checks to see the hit position of the mouse
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Input.mousePosition, 10);
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, +10));
        if (Input.GetMouseButtonDown(0) == true)
        {//Plays Audio when the mouse button down.
            GetComponent<AudioSource>().Play();

            if (hit != null && hit.collider != null)
            {//Will hold the object that is being hit and have it add to score or whatever is needed.
               hit.collider.gameObject.GetComponent<Box>().enabled = false;
            }
              
            //Could possibly be used for health detection.
            //hit.collider.GetComponent<HP>().hp -= 10;
            Aim();
        }

    }
    //Checks to see that the mouse click is being detected
    public void Aim()
    {
        Debug.Log("Gotteem");
    }
}
