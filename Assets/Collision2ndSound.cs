using UnityEngine;
using System.Collections;

public class Collision2ndSound : MonoBehaviour {
    public GameObject  wtever;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    
     void OnTriggerEnter(Collider other){
        AudioSource Birds = wtever.GetComponent<AudioSource>();
        Birds.PlayDelayed(2.5f);
    }
    
}
