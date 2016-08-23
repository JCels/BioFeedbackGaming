using UnityEngine;
using System.Collections;

public class Sate : MonoBehaviour {

	public static string state;
	public clientTcp mess;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		string action = clientTcp.mess; 

		if(action.Contains("Idle")) {
			state = "Idle";
		} else if (action.Contains("Walking")) {
			state = "Walking";
		} else if ( action.Contains("Running")) {
			state = "Running";
		} else {
			//in case message is something else, no change
		}
	}

	void OnGUI() {
		GUI.Label (new Rect (100, 200, 100, 200), "Action : " + state);
	}
}
