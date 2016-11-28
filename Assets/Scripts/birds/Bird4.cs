using UnityEngine;
using System.Collections;

public class Bird4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0.0f, 0.0f, 110f * Time.deltaTime);
    }
}
