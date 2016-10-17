using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Box>() == null)
        {
            GameObject explosion = (GameObject)Instantiate(Resources.Load("Explosion", typeof(GameObject)));
            explosion.transform.position = col.transform.position;
        }
    }
}
