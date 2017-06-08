using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class MouseLook : MonoBehaviour {


	public float sensi=0.9f;
	private float lookx;
	private float looky;
	GameObject character;

	// Use this for initialization
	void Start () {
		
		character = this.transform.parent.gameObject;


	}

	// Update is called once per frame
	void Update () {
		

		lookx += CrossPlatformInputManager.GetAxis ("Mouse X")*sensi;
		looky += CrossPlatformInputManager.GetAxis ("Mouse Y")*sensi;


		looky = Mathf.Clamp (looky, -50f, 60f); 

	}

	void FixedUpdate(){
		
		character.transform.localEulerAngles = new Vector3 (0,lookx,0) ;
		transform.localEulerAngles = new Vector3 (-looky,0,0) ;


	}
}
