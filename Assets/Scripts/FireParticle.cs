using UnityEngine;
using System.Collections;

public class FireParticle : MonoBehaviour
{
    public AudioSource destructionSound;
	public AudioSource puzzlestartsound;

    AudioSource myDestructionSound;
	AudioSource puzzlestartSound1;

    void Start()
    {
        myDestructionSound = destructionSound.GetComponent<AudioSource>();
		puzzlestartSound1 = puzzlestartsound.GetComponent<AudioSource>();
    }

    void OnParticleCollision(GameObject obj)
    {
        if(obj.tag == "WeakToFire")
        {
            Instantiate(myDestructionSound);
            Destroy(obj);
        }

		if (obj.tag == "Boss") {
			obj.GetComponent<BossControl> ().Hit ();
			print ("Hit boss");
		}

		if (obj.tag == "GrowOnFire") {
			obj.GetComponent<BridgeController> ().Grow();
		}
       


		if(obj.tag == "fire_interaction")
		{
			Instantiate (puzzlestartSound1);
			boiler_puzzle.boiler_fire_time = 30.00f;

		}

        if(obj.name != "Mage" && obj.tag != "Planet")
        {
           gameObject.GetComponent<ParticleSystem>().Clear();
        }
    }
}
