using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public GameObject camera;
	public float speed = 20.0f;

	void Update () {
		if (((Input.mousePosition.x > (Screen.width / 2) + 10) || (Input.mousePosition.x  < (Screen.width / 2) - 10)) || ((Input.mousePosition.y > (Screen.height / 2) + 10) || (Input.mousePosition.y  < (Screen.height / 2) - 10))) 
		{
			Vector3 v3T = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, camera.transform.position.y);
			v3T = Camera.main.ScreenToWorldPoint (v3T);
			v3T.y = 0;
			float distance = Mathf.Sqrt (Mathf.Pow (v3T.x - this.gameObject.transform.position.x, 2f) + Mathf.Pow (v3T.z - this.gameObject.transform.position.z, 2f));
			this.gameObject.transform.position = Vector3.Lerp (this.gameObject.transform.position, v3T, (speed / 200) / distance);
		}
	}
}
