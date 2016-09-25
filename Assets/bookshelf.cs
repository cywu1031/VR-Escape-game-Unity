using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class bookshelf : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void touchBookShelf()
    {
        GetComponent<ParticleSystem>().Emit(10);
    }
}
