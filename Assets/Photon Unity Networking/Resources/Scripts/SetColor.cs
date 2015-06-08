using UnityEngine;
using System.Collections;

public class SetColor : MonoBehaviour {

	public float	red;
	public float	green;
	public float	blue;

	void Start () {
		this.gameObject.renderer.material.color = new Color (red, blue, green);
	}
}
