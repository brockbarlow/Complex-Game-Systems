//This script is used for the crosshair

using UnityEngine;
using System.Collections;

public class crosshair : MonoBehaviour {

    public Texture2D crosshairTexture;
    private Rect crosshairRect;
    public bool isCrosshairVisible = true;
    public int crosshairSizeX = 32;
    public int crosshairSizeY = 32;
    public static bool lockCursor;

    void Awake()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("SpaceBar"))
        {
            isCrosshairVisible = !
        }
    }

    void OnGUI()
    {

    }
}
