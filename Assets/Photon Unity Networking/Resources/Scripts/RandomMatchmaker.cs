using UnityEngine;
using System.Collections;

public class RandomMatchmaker : MonoBehaviour
{
	private GameObject player;
	public GameObject information;
	// Use this for initialization
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
		player = PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity, 0);
		((MonoBehaviour)player.GetComponent("Movement")).enabled = true;
		player.GetComponentInChildren<Camera> ().enabled = true;
	}

	void Update()
	{
		information.guiText.text = "PosX: " + player.gameObject.transform.position.x;
		information.guiText.text += " PosZ: " + player.gameObject.transform.position.z;
		information.guiText.text += " Number of players: " + PhotonNetwork.playerList.Length;
	}
}
