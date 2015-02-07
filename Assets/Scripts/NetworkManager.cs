using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {
	
	private const string typeName = "Auniqueroom";
	private const string gameName = "hello deyre";
	public GameObject chaserPrefab;
	public GameObject runnerPrefab;

	private void StartServer()
	{
	//	MasterServer.ipAddress = "192.168.1.107";
		Network.InitializeServer(4, 25000, !Network.HavePublicAddress());
		MasterServer.RegisterHost(typeName, gameName);
	}
	private void RefreshHostList()
	{
		MasterServer.RequestHostList(typeName);
	}
	private HostData[] hostList;
	
	void OnMasterServerEvent(MasterServerEvent msEvent)
	{
		if (msEvent == MasterServerEvent.HostListReceived)
			hostList = MasterServer.PollHostList();
	}
	private void JoinServer(HostData hostData)
	{
		Network.Connect(hostData);
	}

	void OnGUI()
	{
		if (!Network.isClient && !Network.isServer)
		{
			if (GUI.Button(new Rect(100, 100, 250, 100), "Start Server"))
				StartServer();
			
			if (GUI.Button(new Rect(100, 250, 250, 100), "Refresh Hosts"))
				RefreshHostList();
			
			if (hostList != null)
			{
				for (int i = 0; i < hostList.Length; i++)
				{
					if (GUI.Button(new Rect(400, 100 + (110 * i), 300, 100), hostList[i].gameName))
						JoinServer(hostList[i]);
				}
			}
		}
	}

	
	void OnServerInitialized()
	{
		SpawnPlayer();
	}
	
	void OnConnectedToServer()
	{
		SpawnPlayer();
	}
	
	private void SpawnPlayer()
	{
		GameObject brian;
		float randomting;
		randomting=Random.Range(0.0f,1.0f);
		if (randomting<0.5f)
		{
			//brian=(GameObject) Network.Instantiate(zapperPrefab, new Vector3(1327f, 343f, 1115f), Quaternion.Euler(60,0,0),0);
			brian=(GameObject) Network.Instantiate(runnerPrefab, new Vector3(1400f, 24f, 1122f), Quaternion.identity, 0);
		}
		else
		{
			brian=(GameObject) Network.Instantiate(chaserPrefab, new Vector3(1400f, 24f, 1122f), Quaternion.identity, 0);
			brian.GetComponent<LifeController>().lifeText = GameObject.Find ("lifeText").GetComponent<GUIText>();
		}
		ControllerScript.players.Add(brian);
	}
}
