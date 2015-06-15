using UnityEngine;
using System.Collections;

public class GenerateFood : MonoBehaviour {
	public int nbFood = 0;

	void 		createFood()
	{
		if (nbFood < 800)
		{
			PhotonNetwork.Instantiate("Food", new Vector3(Random.Range(-100, 100), 0.2f, Random.Range(-100, 100)), Quaternion.identity, 0);
			nbFood++;
		}
	}

	void       Start()
	{
		Debug.Log ("Starting Generation");
		//PhotonNetwork.Instantiate("Food", new Vector3(0,0,0), Quaternion.identity, 0);
		InvokeRepeating ("createFood", 2, 0.1F);
	}
}
