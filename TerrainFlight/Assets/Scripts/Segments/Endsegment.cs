using UnityEngine;
using System.Collections;

public class Endsegment : MonoBehaviour {
   // public GameObject exp;
   // public AudioClip expSound;
    bool isTrigger = false;
    float startTime = 0;
    //public Vector3 endPoint;
    void OnTriggerEnter(Collider col)
    {
//        if (col.gameObject.tag == "Car")
//        {
//            Destroy(col.gameObject);
//        }
//        else if (!isTrigger)
//        {
//            isTrigger = true;
//            if (col.gameObject.tag == "Player")
//            {
////                CarPlayerController player=col.gameObject.GetComponent<CarPlayerController>();
//                startTime = Time.time;
//            }
//        }
        
    }
	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update () 
    {

	}
}
