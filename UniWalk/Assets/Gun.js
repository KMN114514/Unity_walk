#pragma strict

var BulletPrefab:GameObject;

function Update () {
	if(Input.GetMouseButtonDown(0)){
		Fire();
	}
}



function Fire(){
	var bullet:GameObject = Instantiate(
	BulletPrefab,
	transform.position,
	transform.rotation
	);
	var rd:Rigidbody = bullet.GetComponent(Rigidbody);
	rd.AddForce(transform.up*30,ForceMode.VelocityChange);
}

