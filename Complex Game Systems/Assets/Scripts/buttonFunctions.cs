//This script holds the various button functions for the game.

//required usings.
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFunctions : MonoBehaviour {

	public void restart() //
    {
        SceneManager.LoadScene("BrockScene");
    }
}
