using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class table : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void touchTable()
    {
        GetComponent<ParticleSystem>().Emit(10);
    }
}
