using UnityEngine;
using System.Collections;

public class LifeController : MonoBehaviour {

	public int life;
	public GUIText lifeText;
	
	void Update () 
	{
		lifeText.text="Life: "+life.ToString();
	
		if (life<1)
		{
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter (Collision other)
	{
		if(other.gameObject.tag=="enemy")
		{
			life=life-1;
			SetLifeText ();
			rigidbody.AddForce(0, 500, 500);
		}
	}
	void SetLifeText()
	{
		// This function changes the text of countText to something like "Count: 5"
		// It depends on what number the count variable is.
		lifeText.text="Life: "+life.ToString();
	}
}
