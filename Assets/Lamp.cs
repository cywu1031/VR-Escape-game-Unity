﻿using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Lamp : MonoBehaviour {
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void rubLamp()
    {
        GetComponent<ParticleSystem>().Emit(10);
    }
}
