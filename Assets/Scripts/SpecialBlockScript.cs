using UnityEngine;
using System.Collections;

public class SpecialBlockScript : MonoBehaviour {

	public GameObject me;
	public Material material;
	public Material normmaterial;
	public GameObject nextinline;
	
//	void Start () 
//	{
//
//	}
//
	void Update () 
	{
		Vector3 TP = me.transform.position; TP.y= Random.Range(-0.3f,0.0f);; TP.z=me.transform.position.z;  TP.x=me.transform.position.x;me.transform.position = TP;
	}
	void OnCollisionEnter (Collision other)
	{
		if(other.gameObject.tag=="Player")
		{
//			if (order==toget)
//			{
				nextinline.renderer.material = material;
				me.renderer.material = normmaterial;
//			}
		}
	}
}
