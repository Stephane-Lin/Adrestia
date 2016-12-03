using UnityEngine;
using System.Collections;



public class boiler_puzzle : MonoBehaviour {


	public static float boiler_fire_time=-10.01f;
	public static float boiler_water_time=-10.01f;


	bool timer_on=false;

	public AudioClip timer;
	private AudioSource source;


	// Use this for initialization
	void Start ()
	{
		source = GetComponent<AudioSource> ();

	}
	// Update is called once per frame
	void Update () {



		if (boiler_fire_time > 0.00f && boiler_water_time > 0.00f) 
		{

			source.Stop ();
			Destroy(GameObject.Find("boiler_fire"));
			Destroy(GameObject.Find("boiler_water"));
			Destroy (GameObject.Find("blocker_1"));
			Destroy (GameObject.Find("blocker_2"));
			Destroy (GameObject.Find("blocker_3"));
			//GameObject.Find("water_sparkle").GetComponent<ParticleSystem>().emission.enabled = false;
			//GameObject.Find("fire_sparkle").GetComponent<ParticleSystem>().emission.enabled = false;
			Destroy (GameObject.Find("water_sparkle"));
			Destroy (GameObject.Find("fire_sparkle"));
			boiler_fire_time = 0;
			boiler_water_time = 0;
		}



		if (boiler_fire_time > 0.00f) 
		{
			print (boiler_fire_time);
			boiler_fire_time -= Time.deltaTime;
			print ("decrease time fire boiler" + boiler_fire_time);
			if (timer_on) {


				//play sound
				source.PlayOneShot(timer,1f);
				timer_on = false;
			}


		}

		if (boiler_water_time > 0.00f) 
		{

			boiler_water_time -= Time.deltaTime;
			print ("decrease time water boiler " + boiler_water_time);
			if (timer_on) {


				//play sound
				source.PlayOneShot(timer,1f);
				timer_on = false;
			}
		}



	}
}
