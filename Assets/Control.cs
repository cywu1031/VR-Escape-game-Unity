using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void touchObject()
    {
        GetComponent<ParticleSystem>().Emit(10);
    }
}
