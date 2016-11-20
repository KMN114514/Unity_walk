
using UnityEngine;
using System.Collections;

public class UnityDemo : MonoBehaviour {

	int Jf = 0;

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			transform.position += transform.forward * 0.1f;
			animator.SetBool("isRun", true);
		} else {
			animator.SetBool("isRun", false);
		}
		if (Input.GetKey("d")) {
			transform.Rotate(0, 5, 0);
		}
		if (Input.GetKey ("a")) {
			transform.Rotate(0, -5, 0);
		}

		if (Input.GetKey ("space") && Jf == 0) {
		Rigidbody Uni = GetComponent<Rigidbody>();
			Uni.AddForce(0, 500, 0);
			animator.SetBool("Jamp", true);
			Jf = 1;
		}
	}

	void OnCollisionEnter () {
		animator.SetBool("Jamp", false);
		Jf = 0;
	}


}