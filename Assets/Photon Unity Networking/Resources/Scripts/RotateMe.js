#pragma strict


function Update () {
	this.transform.Rotate(Vector3.up * Time.deltaTime * 20);
}