using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) 
		{
			PhotonNetwork.Destroy(this.gameObject);
			PhotonNetwork.Disconnect();
			Application.LoadLevel("Start");
		}
	}
}
