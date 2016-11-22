using UnityEngine;
using System.Collections;

public class move_tank : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			transform.position += transform.right * 0.05f;
		}
		if (Input.GetKey("s")) {
			transform.position += transform.right * -0.05f;
		}
		if (Input.GetKey("d")) {
			transform.Rotate(0, 1, 0);
		}
		if (Input.GetKey ("a")) {
			transform.Rotate(0, -1, 0);
		}
	}
}
