using UnityEngine;
using System.Collections;

public class Foodscript : MonoBehaviour {
	
			void OnTriggerEnter(Collider other) {

			Debug.Log ("Food");
			Vector3 temp = other.gameObject.transform.localScale;
			temp.x += 0.01f;
			temp.y += 0.01f;
			temp.z += 0.01f;
			other.gameObject.transform.localScale = temp;
		GameObject.Find ("Scripts").GetComponent<GenerateFood> ().nbFood -= 1;
			PhotonNetwork.Destroy (this.gameObject);
		}

		void Update()
		{
		this.gameObject.transform.Rotate (Vector3.right * Time.deltaTime * 30);
		}

		void Start()
		{
			this.gameObject.transform.localRotation = Quaternion.Euler(90, 0, 0);
		}

}