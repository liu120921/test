using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenetest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    int i = 0;
	// Update is called once per frame
	void Update () {
		if (i < 5)
        {
            Debug.Log(i);
            i++;
        }
	}
}
