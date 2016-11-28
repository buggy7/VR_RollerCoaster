﻿using UnityEngine;
using System.Collections;

public class CollideTrack : MonoBehaviour {

    public bool hasCollided;
	// Use this for initialization
	void Start () {
        hasCollided = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        hasCollided = true;
    }
}
