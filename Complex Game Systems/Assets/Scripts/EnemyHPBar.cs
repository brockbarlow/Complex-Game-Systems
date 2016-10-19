//This script is used to display how much health the target has.

//required usings.
using UnityEngine;

public class EnemyHPBar : MonoBehaviour {

    private float max; //represents the targets max health value.
    private Box target; //target object.

    void Start()
    {
        target = FindObjectOfType<Box>(); //find the target
        max = gameObject.transform.localScale.x; //setup the max variable
    }

    void Update()
    {
        gameObject.transform.localScale = new Vector3(max * (target.health / 100), 1, 1); //this will change as the target gets damaged.
    }
}
