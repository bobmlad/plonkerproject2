using UnityEngine;
using System.Collections;

public class SurvivalScript : MonoBehaviour {

	public GameObject Meteor;
	public GameObject Me;
	public int create;
	public int createtime;

	void Start ()
	{
		create=createtime;
	}
	

	void Update () 
	{
		if (create==0)
		{
			Vector3 TP = Me.transform.position; TP.y= 1000; TP.x=Random.Range(1000.0f,2000.0f);  TP.z=Random.Range(400.0f,1600.0f);Me.transform.position = TP;
			create=createtime;
			Instantiate (Meteor,Me.transform.position,Quaternion.identity);
		}
		create=create-1;
	}
}
