using UnityEngine;
using System.Collections;

public class TerrainManager : MonoBehaviour {

	public GameObject t1;
	public GameObject t2;
	public GameObject player;
	public int whicht=0;

	float zpos=0;
	bool changed=false;
	// Use this for initialization
	void Start () 
	{
		whicht=1;
		zpos=player.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if(player.transform.position.z>=(zpos+299))
		{
			zpos=player.transform.position.z;

			if(whicht==1)
			{
				t2.transform.position=new Vector3(t2.transform.position.x,t2.transform.position.y,t2.transform.position.z+598);
				whicht=2;
			}
			else if(whicht==2)
			{
				t1.transform.position=new Vector3(t1.transform.position.x,t1.transform.position.y,t1.transform.position.z+598);
				whicht=1;
			}

		}
	}
}
