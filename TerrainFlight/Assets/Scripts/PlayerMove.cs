using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{

	public float speed=500;
    public float turnSpeed = 500;
	public GameObject model;

	// Use this for initialization
	void Start () 
	{
		//GetComponent<Rigidbody>().velocity=new Vector3(0,0,speed*Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}

		//rigidbody.AddForce(new Vector3(0,0,speed*Time.deltaTime));

		if(Application.platform!=RuntimePlatform.Android && Application.platform!=RuntimePlatform.IPhonePlayer)
		{
            transform.Translate(transform.forward * speed * Time.deltaTime);
            transform.Translate(transform.right * turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
            float x = Mathf.Clamp(transform.position.x, -100, 100);
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
            //GetComponent<Rigidbody>().AddForce(new Vector3(turnSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0,0));
            model.transform.localEulerAngles= new Vector3 (15,0,-45*Input.GetAxis("Horizontal"));
			
		}

		//else
		//{
		//	GetComponent<Rigidbody>().AddForce(new Vector3(-Input.acceleration.x*speed*25*Time.deltaTime,0,0));

		//	//if(Input.acceleration.x>0.2 ||Input.acceleration.x<-0.2)
		//	model.transform.localEulerAngles= new Vector3 (0,90*Input.acceleration.x,0);
		//}
	}
}
