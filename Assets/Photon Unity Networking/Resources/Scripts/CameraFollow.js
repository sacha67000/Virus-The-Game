#pragma strict

function Update () {
	this.gameObject.transform.position.x = this.gameObject.transform.parent.position.x;
	this.gameObject.transform.position.y = this.gameObject.transform.parent.position.y + 15 * Mathf.Round(this.gameObject.transform.parent.localScale.y);
	this.gameObject.transform.position.z = this.gameObject.transform.parent.position.z;

}