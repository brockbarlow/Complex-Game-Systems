//This script is used for the crosshair

using UnityEngine;

public class crosshair : MonoBehaviour {

    public Texture2D crosshairTexture;
    private Rect crosshairRect;
    private int crosshairSizeX = 48;
    private int crosshairSizeY = 48;

    void Awake()
    {
        Cursor.visible = false;
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Event.current.mousePosition.x - 25, Event.current.mousePosition.y - 25, crosshairSizeX, crosshairSizeY), crosshairTexture);
    }
}
