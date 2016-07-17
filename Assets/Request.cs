using UnityEngine;
using System.Collections;

public class Request : MonoBehaviour {
	
	void Start () {
		string url = "http://159.203.97.81/chefs";
		WWW www = new WWW(url);
		StartCoroutine(WaitForRequest(www));
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.data);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}
}
