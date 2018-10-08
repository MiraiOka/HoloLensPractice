using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
        gameObject.transform.position += new Vector3(0.01f, 0, 0);
	}
}
