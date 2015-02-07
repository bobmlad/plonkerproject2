using UnityEngine;
using System.Collections;

public class enemyscript : MonoBehaviour {
	public GameObject Player;
	public float speed;
	private Vector3 offset;
	public Quaternion angleoffset;
	
	void Start () 
	{
		Player=GameObject.Find ("First Person Controller");
	}
	
	void Update ()
	{
		offset=Player.transform.position-transform.position;
		transform.rotation = Quaternion.LookRotation(offset)*angleoffset;
		if (speed<0.4f)
		{
			speed=speed*1.00001f;
		}
		if (GameObject.Find("First Person Controller") !=null)

		{
			if (Player.transform.position.x>transform.position.x)
				
			{
				transform.position = new Vector3(transform.position.x+speed, transform.position.y, transform.position.z);
			}
			
			if (Player.transform.position.x<transform.position.x)
				
			{
				transform.position = new Vector3(transform.position.x-speed, transform.position.y, transform.position.z);
			}
			
			if (Player.transform.position.z>transform.position.z)
				
			{
				transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+speed);
			}
			
			if (Player.transform.position.z<transform.position.z)
				
			{
				transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-speed);
			}
			if (Player.transform.position.y>transform.position.y)
				
			{
				transform.position = new Vector3(transform.position.x, transform.position.y+speed, transform.position.z);
			}
			
			if (Player.transform.position.y<transform.position.y)
				
			{
				transform.position = new Vector3(transform.position.x, transform.position.y-speed, transform.position.z);
			}
			
		}
		
	}
}
