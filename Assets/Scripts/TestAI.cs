using UnityEngine;
using System.Collections;

public class TestAI : MonoBehaviour {

	private NavMeshAgent agent;
	public GameObject Player;

	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		agent.SetDestination(Player.transform.position);
	}
}
