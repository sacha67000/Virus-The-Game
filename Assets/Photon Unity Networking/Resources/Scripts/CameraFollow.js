#pragma strict

var Virus : GameObject;


function Update () {
	this.gameObject.transform.position.x = Virus.gameObject.transform.position.x;
	this.gameObject.transform.position.y = Virus.gameObject.transform.position.y + 15 * Mathf.Round(Virus.gameObject.transform.localScale.y);
	this.gameObject.transform.position.z = Virus.gameObject.transform.position.z;

}