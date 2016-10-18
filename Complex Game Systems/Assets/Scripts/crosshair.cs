//This script is used for the crosshair

//required usings.
using UnityEngine;

public class crosshair : MonoBehaviour {

    public Texture2D crosshairTexture; //used for the texture
    private Rect crosshairRect; //used for render.
    private int crosshairSizeX = 48; //size of crosshair on the x axis
    private int crosshairSizeY = 48; //size of crosshair on the y axis

    void Awake()
    {
        Cursor.visible = false; //hides the mouse during play.
    }

    void OnGUI() //calculation to generate the crosshair texture.
    {
        GUI.DrawTexture(new Rect(Event.current.mousePosition.x - 25, Event.current.mousePosition.y - 25, crosshairSizeX, crosshairSizeY), crosshairTexture);
    }
}
