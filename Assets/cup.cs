using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class cup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void touchCup()
    {
        GetComponent<ParticleSystem>().Emit(10);
    }
}
