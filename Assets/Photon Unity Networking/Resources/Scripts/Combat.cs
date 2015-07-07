using UnityEngine;
using System.Collections;

public class Combat : MonoBehaviour {

	public GameObject camera;

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Collision");
		if (other.gameObject.tag == "Player" && this.gameObject.transform.localScale.x < other.gameObject.transform.localScale.x * 0.9)
		{
			Debug.Log ("Good Collision");
			Debug.Log (other.gameObject.transform.localScale);
			other.gameObject.transform.localScale += this.gameObject.transform.localScale;
			Debug.Log (other.gameObject.transform.localScale);
			MyDestroy();
		}
	}

	void MyDestroy()
	{
		Debug.Log("Destroy2");
		PhotonNetwork.Destroy(this.gameObject);
	}


}
