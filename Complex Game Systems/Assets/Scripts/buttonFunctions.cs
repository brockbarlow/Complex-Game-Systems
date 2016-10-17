using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class buttonFunctions : MonoBehaviour {

	public void restart()
    {
        SceneManager.LoadScene("BrockScene");
    }
}
