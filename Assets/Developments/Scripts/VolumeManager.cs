using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeManager : MonoBehaviour {

    public static VolumeManager instance;
    [SerializeField] float sVolume;

    [SerializeField] GameObject[] sFire;

	void Start () {
		if(instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(this);
	}

    public void setSVolume(float s)
    {
        sVolume = s;
        for(int i = 0; i < 3; i++)
        {
            sFire[i].gameObject.transform.localScale = new Vector3(sVolume, sVolume, sVolume);
        }

    }
}
