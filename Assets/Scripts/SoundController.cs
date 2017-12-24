using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {

    [SerializeField]
    AudioSource soundSrc;

    float counter;
    [SerializeField]
    float initSoundPlayDelay = 2.0f;
    [SerializeField]
    float soundPlayDuration = 2.0f;

	// Use this for initialization
	void Start () {
        counter = initSoundPlayDelay;
    }
	
	// Update is called once per frame
	void Update () {
        if (counter <= 0)
        {
            soundSrc.Play();
            counter = soundPlayDuration;
        }
        else
        {
            counter -= Time.deltaTime;
        }
       

    }
}
