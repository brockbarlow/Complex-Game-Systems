using UnityEngine;
using System.Collections;

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
    }

    void Update()
    {
        // If the target loses all it's health you win
        if (health <= 0 && check == true)
        {
            win = true;
            // I make a game winning animation
            GameObject Win = (GameObject)Instantiate(Resources.Load("Win_A", typeof(GameObject)));
            Win.transform.SetParent(FindObjectOfType<Canvas>().transform);
            check = false;
            // Destroy(gameObject);
        }
    }
}
