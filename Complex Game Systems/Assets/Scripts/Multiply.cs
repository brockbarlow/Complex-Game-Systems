using UnityEngine;
using System.Collections;

public class Multiply : MonoBehaviour {

    // I take in the sphere prefab
    [SerializeField]
    private GameObject SpherePre;

    // Used to determine how many spheres we make.
    [SerializeField]
    private float numbSpheres;

    // Use this for initialization
    void Start ()
    {
        // I make a random number of spheres
        numbSpheres = Mathf.Round(Random.Range(10.0f, 100.0f));
        // and spawn them in random locations around the target
        for (int i = 0; i < numbSpheres; i++)
        {
            Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(SpherePre, position, spawnRotation);
        }
    }
}
