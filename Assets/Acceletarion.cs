using UnityEngine;
using System.Collections;

public class Acceletarion : MonoBehaviour {

    // Use this for initialization

    public WaypointAgent ways;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ways.Speed *= 1.0f;

    }
}
