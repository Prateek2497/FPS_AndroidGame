using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Movement : MonoBehaviour {


	public float speed = 3f;

	private float hmov;
	private float vmov;

	void Awake()
	{

	}

	void Start () {




	}



	void Update () {
		

	}



	void FixedUpdate(){
		
		float translate = CrossPlatformInputManager.GetAxis ("Vertical") * speed *Time.deltaTime;
		float straffe = CrossPlatformInputManager.GetAxis ("Horizontal") * speed *Time.deltaTime;	

		transform.Translate (straffe,0,translate);

		//eyes.transform.localEulerAngles = new Vector3 (-looky,0,0);
	}

	/*
	public void left(){
		hmov = CrossPlatformInputManager.GetAxis ("Horizontal") * speed * Time.deltaTime;
		Debug.Log (hmov);
		transform.Translate (-hmov,0,0);
	}
	public void right(){

		hmov = CrossPlatformInputManager.GetAxis ("Horizontal") * speed * Time.deltaTime;
		Debug.Log (hmov);
		transform.Translate (hmov,0,0);
	}
	public void stop(){
		Debug.Log (hmov);
		transform.Translate (0,0,0);
	}*/
}
