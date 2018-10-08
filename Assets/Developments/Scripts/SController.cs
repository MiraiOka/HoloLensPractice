using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SController : MonoBehaviour {

    new AudioSource audio;

	void Start () {
        audio = GetComponent<AudioSource>();
        audio.clip = Microphone.Start(null, true, 1, 44100);
        audio.Play();
	}

	void Update () {
        float[] data = new float[256];
        float vol = 0;
        audio.GetOutputData(data, 0);

        foreach (float s in data)
        {
            vol += Mathf.Abs(s);
        }

        VolumeManager.instance.setSVolume(vol);
	}
}