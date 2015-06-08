using UnityEngine;
using System.Collections;

public class SetRandomColor : MonoBehaviour {
	private int rdm;

	// Use this for initialization
	void Start () {
		rdm = Random.Range (0, 6);
		switch (rdm)
		{
		case 0:
			this.gameObject.renderer.material.color = Color.blue;
			break;
		case 1:
			this.gameObject.renderer.material.color = Color.red;
			break;
		case 2:
			this.gameObject.renderer.material.color = Color.green;
			break;
		case 3:
			this.gameObject.renderer.material.color = Color.cyan;
			break;
		case 4:
			this.gameObject.renderer.material.color = Color.yellow;
			break;
		case 5:
			this.gameObject.renderer.material.color = Color.magenta;
			break;
		case 6:
			this.gameObject.renderer.material.color = Color.white;
			break;
		}
	}
}
