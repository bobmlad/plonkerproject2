using UnityEngine;
using System.Collections;

public class MainEnemyScript : MonoBehaviour {

	private GameObject Player;
	public float speed;
	private Vector3 offset;
	public string run_anim;
	public Quaternion angleoffset;
	public float animationspeed;


	
	void Start () 
	{
	}
	
	void Update () 
	{
		
		if (ControllerScript.players.Count >0)
		{
			Player=ControllerScript.players[0];
			float Dis=(Player.transform.position.x-transform.position.x)*(Player.transform.position.x-transform.position.x)+(Player.transform.position.y-transform.position.y)*(Player.transform.position.y-transform.position.y)+(Player.transform.position.z-transform.position.z)*(Player.transform.position.z-transform.position.z);
			foreach(GameObject g in ControllerScript.players)
			{
				float Dis2=(g.transform.position.x-transform.position.x)*(g.transform.position.x-transform.position.x)+(g.transform.position.y-transform.position.y)*(g.transform.position.y-transform.position.y)+(g.transform.position.z-transform.position.z)*(g.transform.position.z-transform.position.z);
				if (Dis2<Dis)
				{
					Player=g;
					Dis=Dis2;
				}
			}

		animation.Play(run_anim);
		animation[run_anim].speed=animationspeed;
		offset=Player.transform.position-transform.position;
		transform.rotation = Quaternion.LookRotation(offset)*angleoffset;
	
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
			
		}
		
	}
}
