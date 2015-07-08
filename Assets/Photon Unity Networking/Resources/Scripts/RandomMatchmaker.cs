using UnityEngine;
using System.Collections;

public class RandomMatchmaker : MonoBehaviour
{
	public GameObject player;
	public GameObject information;
	public GameObject playerGui;
	private GameObject[] allplayers;

	void Start()
	{
		PhotonNetwork.ConnectUsingSettings("0.1");
	}
	
	void OnGUI()
	{
		GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
	}

	void OnJoinedLobby()
	{
		PhotonNetwork.JoinRandomRoom();
	}

	void OnPhotonRandomJoinFailed()
	{
		Debug.Log("Can't join random room!");
		PhotonNetwork.CreateRoom(null);
	}

	void OnJoinedRoom()
	{
		Debug.Log("Joined random room!");
		player = PhotonNetwork.Instantiate("Player", new Vector3(Random.Range(-100, 100), 0, Random.Range(-100, 100)), Quaternion.identity, 0);
		player.GetComponentInChildren<Move> ().enabled = true;
		player.GetComponentInChildren<Camera> ().enabled = true;
		player.GetComponentInChildren<RotateTowardsMouse> ().enabled = true;
		player.GetComponentInChildren<Menu> ().enabled = true;
		player.GetComponentInChildren<AudioListener> ().enabled = true;
	}

	void Update()
	{
		if (player != null) {
						Vector3 v3T = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15);
						v3T = Camera.main.ScreenToWorldPoint (v3T);
						information.guiText.text = "PosX: " + player.gameObject.transform.position.x;
						information.guiText.text += " PosZ: " + player.gameObject.transform.position.z;
						information.guiText.text += " Number of players: " + PhotonNetwork.playerList.Length;
						information.guiText.text += " Ping: " + PhotonNetwork.GetPing();
						information.guiText.text += " Current Size: " + (int)(player.transform.localScale.x * 100);

						playerGui.guiText.text = "Players:";
						allplayers =  GameObject.FindGameObjectsWithTag("Player");
						foreach (GameObject play in allplayers)
						playerGui.guiText.text += "\nPlayer with size:" + (int)(play.gameObject.transform.localScale.x * 100);
				} 
		else if (PhotonNetwork.inRoom == true) 
		{
			PhotonNetwork.Disconnect();
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
