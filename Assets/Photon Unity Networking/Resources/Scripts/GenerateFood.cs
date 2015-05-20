using UnityEngine;
using System.Collections;

public class GenerateFood : MonoBehaviour {

	void 		createFood()
	{
		PhotonNetwork.Instantiate("Food", new Vector3(Random.Range(-500, 500), 0, Random.Range(-500, 500)), Quaternion.identity, 0);
	}
	void       Start()
	{
		Debug.Log ("Starting Generation");
		//PhotonNetwork.Instantiate("Food", new Vector3(0,0,0), Quaternion.identity, 0);
		InvokeRepeating ("createFood", 2, 0.1F);
	}
}
