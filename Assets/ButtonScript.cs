using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
    public GameObject canvas;
    public PlayerMotor player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void hideCanvas() {
        canvas.SetActive(false);
    }
}
