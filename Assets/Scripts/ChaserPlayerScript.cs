using UnityEngine;
using System.Collections;

public class ChaserPlayerScript : MonoBehaviour {

	static private int isspeedy=0;
	static private int istracking=0;
	static private int isattacking=0;
	public int mana;

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
	void OnGUI() 
	{
		if (GUI.Button(new Rect(50, 10, 100, 50), "Speed"))
		{
			if (mana > 4) 
			{
				SpeedyTime ();
			}
		}

		if (GUI.Button (new Rect (175, 10, 100, 50), "Tracker"))
		{
			if (mana > 2) 
			{
				TrackerTime ();
			}
		}

		if (GUI.Button(new Rect(300, 10, 100, 50), "Attack"))
		{
				if (mana > 49)
			{
				AttackTime();
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isspeedy == 1) 
		{
			//go fast
			mana=mana-5;
		}
		if (istracking == 1) 
		{
			//track the player maybe with a beep that gets quicker or slower
			mana=mana-3;
		}
		if (isattacking == 1) 
		{
			//throw fireball or create enemy or whateva
			isattacking=0;
			mana=mana-50;
		}
	}
}
