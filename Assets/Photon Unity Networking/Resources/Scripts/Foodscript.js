#pragma strict

function OnTriggerEnter (other : Collider) {
		other.gameObject.transform.localScale.x += 0.01;
		other.gameObject.transform.localScale.y += 0.01;
		other.gameObject.transform.localScale.z += 0.01;
		Destroy(this.gameObject);
	}