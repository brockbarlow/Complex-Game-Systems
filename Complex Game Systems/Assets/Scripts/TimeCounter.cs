//This script is used for the count down timer for the project

//required usings
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//count down timer without using delta time
public class TimeCounter : MonoBehaviour
{
    private float countdownValue = 99; //private float variable. set to 99 seconds
    private float countdown; //private float variable. will be used in coroutine.

    [SerializeField]
    private GameObject counterText; //used to display the text to the canvas

    void Start()
    {
        countdown = countdownValue; //countdown variable now has the same data as countdownValue.
        StartCoroutine(StartCountdown()); //Initiate coroutine.
        counterText.SetActive(true); //will ensure that timer can be seen when game starts.
    }

    public IEnumerator StartCountdown() //where the magic happens
    {
        while (countdown >= 0) //as long as countdown is greater than zero, do this.
        {
            //Debug.Log(countdown); //used only for testing
            yield return new WaitForSeconds(1.0f); //wait for one second, then continue.
            countdown--; //decrement variable value.
        }
    }

    //void Update()
    //{
    //    counterText.GetComponent<Text>.text = "Time left: " + countdown;
    //}
}