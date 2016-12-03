using UnityEngine;
using System.Collections;

public class orbSoundScript : MonoBehaviour 
{
    public AudioSource puzzleStartSound;
    AudioSource myPuzzleStartSound;

	void Start () 
    {
        myPuzzleStartSound = puzzleStartSound.GetComponent<AudioSource>();
	}
	
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            Instantiate(myPuzzleStartSound);
        }
    }
}
