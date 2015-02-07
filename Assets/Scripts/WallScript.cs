using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {
	
	private float flipchance;
	public int tobewaited;
	private int waittime;
	public float flipfreq;
	public float toturn = 90.0f;
	public int turning; 
	
	void Update ()
	{
		if (waittime>1)
		{
			waittime=waittime-1;
		}
		else
		{
			waittime=tobewaited;
			flipchance=Random.Range(0.0f,1.0f);
			if (flipchance<flipfreq)
			{
				if (toturn>0)
				{
					turning=1;
				}
				
			}
		}
		if (turning==1)
		{
			if (toturn>0)
			{
				transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y+0.25f, transform.eulerAngles.z);
				toturn=toturn-0.25f;
			}
			else
			{
				turning=0;
				toturn=90.0f;
			}
		}
	}
	//	void Update () 
	//	{
	//		if (waittime>1)
	//		{
	//			waittime=waittime-1;
	//		}
	//		else
	//		{
	//			if (toturn>0)
	//			{
	//			flipchance=Random.Range(0.0f,1.0f);
	//			waittime=tobewaited;
	//			if (flipchance<flipfreq)
	//				{
	//					transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y+1, transform.eulerAngles.z);
	//					toturn=toturn-1;
	//				}
	//
	//			}
	//			else
	//			{
	//				toturn=90;
	//			}
	//
	//		}
	//	}
}
