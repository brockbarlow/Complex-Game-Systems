using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {

    public float health;
    private bool check;
    public bool win;

    void Start()
    {
        health = 100;
        win = false;
        check = true;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Shield>() == null)
        {
            health -= 10;
        }
    }

    void Update()
    {
        if (health <= 0 && check == true)
        {
            win = true;
            GameObject Win = (GameObject)Instantiate(Resources.Load("Win_A", typeof(GameObject)));
            Win.transform.SetParent(FindObjectOfType<Canvas>().transform);
            check = false;
            Destroy(gameObject);
        }
    }
}
