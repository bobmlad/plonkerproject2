using UnityEngine;
using System.Collections;

public class MeteorScript : MonoBehaviour {
	
	void Update () 
	{
		if (transform.position.y<-100)
		{
			Destroy(gameObject);
		}
	}
}
