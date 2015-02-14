using UnityEngine;
using System.Collections;

public class AttackScript : MonoBehaviour {

	private GameObject target;
	public int speed;
	public int pushes = 10;

	void Start ()
	{
		target=GameObject.Find ("First Person Controller(Clone)");
	}

	void Update () 
	{
		if (Network.isServer)
		{
			if (pushes>0)
			{
				if (target.transform.position.x>transform.position.x)
					
				{
					Vector3 movement = new Vector3(50.0f,0.0f,0.0f);
					rigidbody.AddForce(movement*speed*Time.deltaTime);
					
				}
				
				if (target.transform.position.x<transform.position.x)
					
				{
					
					Vector3 movement = new Vector3(-50.0f,0.0f,0.0f);
					rigidbody.AddForce(movement*speed*Time.deltaTime);
					
				}
				
				if (target.transform.position.z>transform.position.z)
					
				{
					
					Vector3 movement = new Vector3(0.0f,0.0f,50.0f);
					rigidbody.AddForce(movement*speed*Time.deltaTime);
					
				}
				
				if (target.transform.position.z<transform.position.z)
					
				{
					
					Vector3 movement = new Vector3(0.0f,0.0f,-50.0f);
					rigidbody.AddForce(movement*speed*Time.deltaTime);
					
				}
				if (target.transform.position.y>transform.position.z)
					
				{
					
					Vector3 movement = new Vector3(0.0f,50.0f,0.0f);
					rigidbody.AddForce(movement*speed*Time.deltaTime);
					
				}
				
				if (target.transform.position.y<transform.position.y)
					
				{
					
					Vector3 movement = new Vector3(0.0f,-50.0f,0.0f);
					rigidbody.AddForce(movement*speed*Time.deltaTime);
					
				}
				pushes=pushes-1;
			}
			else
			{
				Destroy(gameObject);
			}
		}
	}
}
