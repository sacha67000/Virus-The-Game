using UnityEngine;
using System.Collections;

public class Combat : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player" && this.gameObject.transform.localScale.x < other.gameObject.transform.localScale.x * 0.9)
		{
			other.gameObject.transform.localScale += this.gameObject.transform.localScale;
			MyDestroy();
		}
	}

	void MyDestroy()
	{
		Debug.Log("Destroy2");
		PhotonNetwork.Destroy(this.gameObject);
	}


}
