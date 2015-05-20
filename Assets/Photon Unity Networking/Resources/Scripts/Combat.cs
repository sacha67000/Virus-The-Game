using UnityEngine;
using System.Collections;

public class Combat : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if (this.gameObject.transform.localScale.x > other.gameObject.transform.localScale.x * 1.1)
		{
			Debug.Log(this.gameObject.transform.localScale.x);
			Debug.Log(other.gameObject.transform.localScale.x);
			Debug.Log(other.gameObject.transform.localScale.x * 1.1);
			other.gameObject.GetComponent<Combat>().MyDestroy();
			this.gameObject.transform.localScale += other.gameObject.transform.localScale;
		}
	}

	void MyDestroy()
	{
		Debug.Log("Destroy2");
		PhotonNetwork.Destroy(this.gameObject);
	}
}
