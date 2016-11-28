using UnityEngine;
using System.Collections;

public class RedSaberRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(40.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
