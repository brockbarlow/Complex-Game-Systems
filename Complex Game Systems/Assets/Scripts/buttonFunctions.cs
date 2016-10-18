//This script holds the various button functions for the game.

//required usings.
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFunctions : MonoBehaviour {

	public void restart() //this function will reload the game scene.
    {
        SceneManager.LoadScene("BrockScene");
    }

    public void start() //this function will load the game scene.
    {
        SceneManager.LoadScene("BrockScene");
    }

    public void howTo() //this function will load the how to play scene.
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void back() //this function will load the title scene.
    {
        SceneManager.LoadScene("Title");
    }
}
