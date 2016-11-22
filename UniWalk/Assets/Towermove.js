#pragma strict


function Update () {
		if (Input.GetKey("e")) {
			transform.Rotate(0, 0, 1);
		}
		if (Input.GetKey ("q")) {
			transform.Rotate(0, 0, -1);
		}
}