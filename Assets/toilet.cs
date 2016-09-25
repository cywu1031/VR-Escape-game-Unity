using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class toilet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void touchToilet()
    {
        GetComponent<ParticleSystem>().Emit(10);
    }
}
