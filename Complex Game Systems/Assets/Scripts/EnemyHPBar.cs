//This script is used to display how much health the target has.

//required usings.
using UnityEngine;

public class EnemyHPBar : MonoBehaviour {

    private float max; //represents the targets max health value.

    private Box target;

    void Start()
    {
        target = FindObjectOfType<Box>();
        max = gameObject.transform.localScale.x;
    }

    void Update()
    {
        gameObject.transform.localScale = new Vector3(max * (target.health / 100), 1, 1);
    }
}
