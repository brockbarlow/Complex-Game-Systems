using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    void Update()
    {
        // Will return the user to the main menu after pressing B.
        if (Input.GetKeyDown("r") || Input.GetButtonDown("R"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
