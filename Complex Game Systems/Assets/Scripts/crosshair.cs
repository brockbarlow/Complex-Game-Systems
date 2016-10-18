//This script is used for the crosshair

using UnityEngine;

public class crosshair : MonoBehaviour {

    public Texture2D crosshairTexture;
    private Rect crosshairRect;
    private int crosshairSizeX = 64;
    private int crosshairSizeY = 64;

    void Awake()
    {
        Cursor.visible = false;
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Event.current.mousePosition.x, Event.current.mousePosition.y, crosshairSizeX, crosshairSizeY), crosshairTexture);
    }
}
