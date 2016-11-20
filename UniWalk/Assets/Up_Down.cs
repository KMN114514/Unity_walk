using UnityEngine;
using System.Collections;

public class Up_Down : MonoBehaviour {
	float move = 0.01f;
	int mf = 0;
	void Update () {
		this.transform.position += new Vector3 (0,move,0);

		if (move > 1.0f) {
			mf = 1;
		}
		if (move < 0.0f) {
			mf = 0;
		}

		if (mf == 0) {
			move += 0.01f;
		} else {
			move -= 0.01f; 
		}



	}
}
