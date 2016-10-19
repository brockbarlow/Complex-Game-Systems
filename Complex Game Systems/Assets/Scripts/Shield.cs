using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

    void Update()
    {
        if (FindObjectOfType<Box>() == null)
        {
            Destroy(gameObject);
        }
    }
}
