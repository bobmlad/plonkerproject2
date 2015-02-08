using UnityEngine;
using System.Collections;

public class RunnerScript : MonoBehaviour {

	void Update () {
	
	}
	void OnCollisionEnter (Collision other)
	{
		if(other.gameObject.tag=="attack")
		{
			Destroy(gameObject);
		}
	}
}
