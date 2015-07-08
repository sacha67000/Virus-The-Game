using UnityEngine;
using System.Collections;

public class Screenshot : MonoBehaviour {
	string imagename;

	void LateUpdate () {
		if (Input.GetKeyUp (KeyCode.F12)) 
		{
			imagename = "screenshot" + Random.Range(0, 2000000).ToString() + ".png";
			Application.CaptureScreenshot(imagename);
			var pathToImage = Application.persistentDataPath + "/" + imagename;
			Debug.Log(pathToImage);
		}
	}
}
