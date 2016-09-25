using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Bed : MonoBehaviour {
    private Rect mButtonRect = new Rect(50, 50, 120, 60);
    private bool showButton = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
  
    }

    public void touchBed()
    {
        showButton = true;
        GetComponent<ParticleSystem>().Emit(10);
    }
}
