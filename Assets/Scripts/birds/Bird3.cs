using UnityEngine;
using System.Collections;

public class Bird3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0.0f, 110f * Time.deltaTime, 0.0f);
    }
}
