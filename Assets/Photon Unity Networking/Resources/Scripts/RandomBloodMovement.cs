using UnityEngine;
using System.Collections;

public class RandomBloodMovement : MonoBehaviour {
	Vector3 v3t;

	void 		RandomMove()
	{
		v3t = this.gameObject.transform.position;
		int random = Random.Range (0, 3);
		switch (random) 
		{
		case 0:
			v3t.x -= 10;
			break ;
		case 1:
			v3t.x += 10;
			break ;
		case 2:
			v3t.z -= 10;
			break ;
		case 3:
			v3t.z += 10;
			break ;
		}
	}

	void       Start()
	{
		InvokeRepeating ("RandomMove", 0, 5F);
	}

	void	Update()
	{
		Debug.Log (v3t);
		this.gameObject.transform.position = Vector3.Lerp (this.gameObject.transform.position, v3t, 1/300f);
	}
}
