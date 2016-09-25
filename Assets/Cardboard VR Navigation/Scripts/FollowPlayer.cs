/* © 2015 Studio Pepwuper http://www.pepwuper.com */

using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public GameObject Player;
    public GameObject message;
	private Vector3 playerPosition;

    void Start() {
        message.SetActive(false);
    }
	
	void LateUpdate () {
		playerPosition = Player.transform.position;
		Vector3 newPos = new Vector3(playerPosition.x, transform.position.y, playerPosition.z); // not changing Y value
		transform.position = newPos;
	}
}
