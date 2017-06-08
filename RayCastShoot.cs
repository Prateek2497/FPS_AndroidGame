using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RayCastShoot : MonoBehaviour {


	public float weaponRange = 100f;
	public Camera fpsCam;
	private AudioSource gunAudio;
	public int score = 0;
	//public ParticleSystem muzzleFlash;
	//public ParticleSystem impactFlash;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void fireShot(){


		RaycastHit hit;

		if (Physics.Raycast (fpsCam.transform.position,fpsCam.transform.forward, out hit, weaponRange)) {
			
			Target target = hit.transform.GetComponent<Target> ();
			if (target != null) {
				target.Die ();
				score = score + 1;
			}
		}

		if (score == 4) {
				
			SceneManager.LoadScene ("endScene");
		}
	
	}


}
