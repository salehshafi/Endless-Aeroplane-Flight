using UnityEngine;
using System.Collections;

public class Segment : MonoBehaviour {
    bool isTrigger = false;
    //public Vector3 endPoint;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Car")
        {
            col.gameObject.transform.parent = gameObject.transform;
        }
        else if (!isTrigger)
        {
            isTrigger = true;
            if (col.gameObject.tag == "Player")
            {
                SegmentGenerator.Instance.SpawnSegmentsAtNextLevel();
            }
        }
        
    }
	// Use this for initialization
	void Start () 
    {
        
       // endPoint = transform.FindChild("EndPoint").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
