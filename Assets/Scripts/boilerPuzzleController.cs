using UnityEngine;
using System.Collections;

public class boilerPuzzleController : MonoBehaviour 
{

    public GameObject boilerRed;
    public GameObject boilerBlue;

    public AudioSource timerSound;
    AudioSource myTimerSound;

    public AudioSource puzzleCompleteSound;
    AudioSource myPuzzleCompleteSound;

    public AudioSource correct;
    AudioSource correctSound;

    public AudioSource incorrect;
    AudioSource incorrectSound;

    public Material green;
    public Material red;
    public Material blue;

    Renderer redBoilerRenderer;
    Renderer blueBoilerRenderer;

    public bool redActive;
    public bool blueActive;
    bool redAlreadyHit;
    bool blueAlreadyHit;
    bool alreadyReset;
    bool complete;

    float timer;

	void Start () 
    {
        myTimerSound = timerSound.GetComponent<AudioSource>();

        complete = false;
        incorrectSound = incorrect.GetComponent<AudioSource>();

        alreadyReset = true;
        timer = 0f;
        correctSound = correct.GetComponent<AudioSource>();

        redActive = false;
        blueActive = false;
        redAlreadyHit = false;
        blueAlreadyHit = false;

        myPuzzleCompleteSound = puzzleCompleteSound.GetComponent<AudioSource>();
        redBoilerRenderer = boilerRed.GetComponent<Renderer>();
        blueBoilerRenderer = boilerBlue.GetComponent<Renderer>();
	}
	
	void Update () 
    {
        if(Time.time < timer && redActive == true && blueActive == true && complete == false)
        {
            Destroy(GameObject.Find("timer(Clone)"));
            complete = true;
            Instantiate(myPuzzleCompleteSound);
            Destroy(GameObject.Find("boiler_fire"));
            Destroy(GameObject.Find("boiler_water"));
            Destroy (GameObject.Find("blocker_1"));
            Destroy (GameObject.Find("blocker_2"));
            Destroy (GameObject.Find("blocker_3"));
            Destroy (GameObject.Find("water_sparkle"));
            Destroy (GameObject.Find("fire_sparkle"));
        }

        if(Time.time > timer)
        {
            if(alreadyReset == false)
            {
                alreadyReset = true;
                Instantiate(incorrectSound);
                redAlreadyHit = false;
                blueAlreadyHit = false;
                redActive = false;
                blueActive = false;
                redBoilerRenderer.material = red;
                blueBoilerRenderer.material = blue;
            }
        }
	}

    public void redHit()
    {
        if(redAlreadyHit == false)
        {
            redBoilerRenderer.material = green;
            redAlreadyHit = true;
            Instantiate(correctSound);
            redActive = true;
            if(blueAlreadyHit == false)
            {
                Instantiate(myTimerSound);
                timer = Time.time + 30f;
                alreadyReset = false;
            }
        }
    }

    public void blueHit()
    {
        if(blueAlreadyHit == false)
        {
            blueBoilerRenderer.material = green;
            blueAlreadyHit = true;
            Instantiate(correctSound);
            blueActive = true;
            if(redAlreadyHit == false)
            {
                Instantiate(myTimerSound);
                timer = Time.time + 30f;
                alreadyReset = false;
            }
        }
    }
}
