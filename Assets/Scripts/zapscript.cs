using UnityEngine;
using System.Collections;

public class zapscript : MonoBehaviour {
	Ray ray;
	RaycastHit hit;
	public GameObject prefab;
	public Camera cameraa;
	public int canclick;
	public int countdown;
	public int wait;
	
	// Use this for initialization
	void Start () 
	{
		canclick=1;
	}
	
	// Update is called once per frame
	void Update () {
		
		ray=cameraa.ScreenPointToRay(Input.mousePosition);
		
		if(Physics.Raycast(ray,out hit))
		{
			
			if(Input.GetKey(KeyCode.Mouse0))
			{
				if (canclick==1)
				{
					canclick=0;
					countdown=wait;
					Instantiate(prefab,new Vector3(hit.point.x,200,hit.point.z), Quaternion.identity);
				}
				
			}
		}
		countdown=countdown-1;
		if (countdown<1)
		{
			canclick=1;
		}
		
	}
}