using UnityEngine;
using System.Collections;

public class RotateTowardsMouse : MonoBehaviour {

	private Vector3 mouse_pos;
	public Transform target; //Assign to the object you want to rotate
	private Vector3 object_pos;
	private float angle;

	void Update ()
	{
		mouse_pos = Input.mousePosition;
		mouse_pos.z = 5.23f; //The distance between the camera and object
		object_pos = Camera.main.WorldToScreenPoint(target.position);
		mouse_pos.x = mouse_pos.x - object_pos.x;
		mouse_pos.y = mouse_pos.y - object_pos.y;
		angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
		this.transform.rotation = Quaternion.Euler(new Vector3(0, -1 * angle, 0));
	}
}
