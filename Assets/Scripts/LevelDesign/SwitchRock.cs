using UnityEngine;
using System.Collections;

public class SwitchRock : MonoBehaviour {

	public GameObject rock;
	public AudioSource destructionSound;
	AudioSource myDestructionSound;
	bool rockIsGone;

    public AudioSource puzzleStartSound;
    AudioSource myPuzzleStartSound;

	void Start () {
	
        myPuzzleStartSound = puzzleStartSound.GetComponent<AudioSource>();
        rockIsGone = false;
		myDestructionSound = destructionSound.GetComponent<AudioSource>();
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player") {
			if (!rockIsGone) {
				Instantiate (myDestructionSound);
                Instantiate(myPuzzleStartSound);
				Destroy (rock);
				rockIsGone = true;
			}
		}
	}
}
