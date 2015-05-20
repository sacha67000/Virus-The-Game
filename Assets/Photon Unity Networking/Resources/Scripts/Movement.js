#pragma strict

var speed: float = 10;

function Update () {
	if (Input.GetKey (KeyCode.UpArrow))
		transform.Translate(Vector3.forward * Time.deltaTime * (speed / this.gameObject.transform.localScale.x));
	if (Input.GetKey (KeyCode.LeftArrow))
		transform.Translate(Vector3.left * Time.deltaTime * (speed / this.gameObject.transform.localScale.x));
	if (Input.GetKey (KeyCode.DownArrow))
		transform.Translate(Vector3.back * Time.deltaTime * (speed / this.gameObject.transform.localScale.x));
	if (Input.GetKey (KeyCode.RightArrow))
		transform.Translate(Vector3.right * Time.deltaTime * (speed / this.gameObject.transform.localScale.x));

}