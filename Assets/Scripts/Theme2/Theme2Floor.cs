using UnityEngine;
using System.Collections;

public class Theme2Floor : MonoBehaviour {

    public bool hasCollided;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        hasCollided = true;
    }
}
