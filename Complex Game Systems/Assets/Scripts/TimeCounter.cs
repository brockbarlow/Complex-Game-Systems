//This script is used for the count down timer for the project.

//required usings.
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//count down timer without using delta time.
public class TimeCounter : MonoBehaviour
{
    private float countdownValue = 25; //private float variable. 
    private float countdown; //private float variable. will be used in coroutine.
    private Box target; //target object
    bool stopTime; //used to stop the timer

    [SerializeField]
    private GameObject counterText; //used to display the text to the canvas.

    void Start()
    {
        countdown = countdownValue; //countdown variable now has the same data as countdownValue.
        StartCoroutine(StartCountdown()); //Initiate coroutine.
        counterText.SetActive(true); //will ensure that timer can be seen when game starts.
        target = FindObjectOfType<Box>(); //find the target
        stopTime = false; //set this to false or timer will never start
    }

    public IEnumerator StartCountdown() //where the magic happens.
    {
        while (countdown >= 1 && stopTime == false) //as long as countdown is greater than zero, do this.
        {
            yield return new WaitForSeconds(1.0f); //wait for one second, then continue.
            countdown--; //decrement variable value.
        }
    }

    void Update()
    {
        counterText.GetComponent<Text>().text = "Time left: " + countdown; //displays the text for the timer in the canvas.

        if (target.win == true) //if the player wins the game, the timer will stop counting down.
        {
            stopTime = true;
        }

        if (countdown == 0) //when the count down timer reaches zero, the game over scene will load.
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}