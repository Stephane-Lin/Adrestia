﻿using UnityEngine;
using System.Collections;

public class LightningParticle : MonoBehaviour
{
    public AudioSource destructionSound;
    AudioSource myDestructionSound;

    void Start()
    {
        myDestructionSound = destructionSound.GetComponent<AudioSource>();
    }

    void OnParticleCollision(GameObject obj)
    {
        if(obj.tag == "WeakToLightning")
        {
            Instantiate(myDestructionSound);
            Destroy(obj);
        }

        if(obj.name != "Mage" && obj.tag != "Planet")
        {
            gameObject.GetComponent<ParticleSystem>().Clear();
        }
    }
}
