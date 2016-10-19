using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Box : MonoBehaviour {

    // This is the health value
    public float health;
    // Stops the check for if health is gone
    private bool check;
    // Checks if you have won
    public bool win;

    void Start()
    {
        // Starting the target off with 100 health
        health = 100;
        win = false;
        check = true;
    }

    public void Involcable()
    {
        health -= 10;
        Image Good = (Image)Instantiate(Resources.Load("Good", typeof(Image)));
        Good.transform.SetParent(FindObjectOfType<Canvas>().transform);

        RectTransform CanvasRect = FindObjectOfType<Canvas>().GetComponent<RectTransform>();
        Vector2 ViewportPosition = FindObjectOfType<Camera>().WorldToViewportPoint(transform.position);
        Vector2 WorldObject_ScreenPosition = new Vector2(
        ((ViewportPosition.x * CanvasRect.sizeDelta.x) - (CanvasRect.sizeDelta.x * 0.5f)),
        ((ViewportPosition.y * CanvasRect.sizeDelta.y) - (CanvasRect.sizeDelta.y * 0.5f)));

        Good.rectTransform.anchoredPosition = WorldObject_ScreenPosition;
    }

    void Update()
    {
        // If the target loses all it's health you win
        if (health <= 0 && check == true)
        {
            win = true;
            // I make a game winning animation
            Canvas Can = FindObjectOfType<Canvas>();
            Image Win = (Image)Instantiate(Resources.Load("Win_A", typeof(Image)));
            Win.rectTransform.SetParent(FindObjectOfType<Canvas>().transform);
            Win.rectTransform.rect.Set(Win.rectTransform.rect.x, Win.rectTransform.rect.y, Can.pixelRect.width, Can.pixelRect.height);
            check = false;
            Destroy(gameObject);
        }
    }
}
