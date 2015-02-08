using UnityEngine;
using System.Collections;

public class ChaserPlayerScript : MonoBehaviour {

	static private int isspeedy=0;
	static private int istracking=0;
	static private int isattacking=0;
	static public int mana = 1000;
	public int tobewaited;
	private int waittime;
	public GameObject prefab;
	public GameObject me; // = GameObject.Find ("First Person Controller);

	private void SpeedyTime()
	{
		if (isspeedy==1)
		{
			isspeedy=0;
		}
		else
		{
			isspeedy=1;
		}

	}
	private void TrackerTime()
	{
		if (istracking==1)
		{
			istracking=0;
		}
		else
		{
			istracking=1;
		}
		
	}
	private void AttackTime()
	{
		if (isattacking==1)
		{
			isattacking=0;
		}
		else
		{
			isattacking=1;
		}
		
	}
	private void ManaBoostTime()
	{
		mana=mana+1;
		waittime=tobewaited;
	}
	void OnGUI() 
	{
		if (GUI.Button(new Rect(50, 10, 100, 50), "Speed"))
		{
			if (mana > 2) 
			{
				SpeedyTime ();
			}
		}

		if (GUI.Button (new Rect (175, 10, 100, 50), "Tracker"))
		{
			if (mana > 1) 
			{
				TrackerTime ();
			}
		}

		if (GUI.Button(new Rect(300, 10, 100, 50), "Attack"))
		{
				if (mana > 249)
			{
				AttackTime();
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (waittime>0)
		{
			waittime=waittime-1;
		}
		else
		{
			ManaBoostTime ();
		}
		if (isspeedy == 1) 
		{
			if (mana > 2)
			{
				//go fast
				mana=mana-3;
			}
			else
			{
				isspeedy=0;
			}
		}
		if (istracking == 1) 
		{
			if (mana > 1)
			{
				//track the player maybe with a beep that gets quicker or slower
				mana=mana-2;
			}
			else
			{
				istracking=0;
			}
		}
		if (isattacking == 1) 
		{
			if (mana > 249)
			{
				//throw fireball or create enemy or whateva
				Instantiate(prefab,new Vector3(me.transform.position.x,me.transform.position.y + 10.0f,me.transform.position.z), Quaternion.identity);
				isattacking=0;
				mana=mana-250;
			}
		}
	}
}
