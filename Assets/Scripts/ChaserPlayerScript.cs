using UnityEngine;
using System.Collections;

public class ChaserPlayerScript : MonoBehaviour {

	static private int isspeedy=0;

	private void SpeedyTime()
	{
		isspeedy=1;
	}
	void OnGUI() 
	{
		if (GUI.Button(new Rect(100, 100, 250, 100), "Speed"))
			SpeedyTime();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
