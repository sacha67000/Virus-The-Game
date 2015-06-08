using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	void Update () {
		Vector3 v3T = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
		v3T = Camera.main.ScreenToWorldPoint (v3T);
		v3T.y = 0;
		float distance = Mathf.Sqrt(Mathf.Pow(v3T.x - this.gameObject.transform.position.x , 2f) + Mathf.Pow(v3T.z - this.gameObject.transform.position.z , 2f));
		//float speed = 0.05f - this.gameObject.transform.localScale.x / 100;
		this.gameObject.transform.position = Vector3.Lerp (this.gameObject.transform.position, v3T, 0.05f / distance);
	}
}
