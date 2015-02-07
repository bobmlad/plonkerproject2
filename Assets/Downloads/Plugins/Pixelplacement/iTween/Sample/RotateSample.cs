using UnityEngine;
using System.Collections;

public class RotateSample : MonoBehaviour
{	
	void Start(){
		iTween.RotateBy(gameObject, iTween.Hash("x", .180, "easeType", "easeInOutBack", "loopType", "pingPong", "delay", .4));
	}
}

