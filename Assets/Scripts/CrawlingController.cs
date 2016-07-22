using UnityEngine;
using System.Collections;

public class CrawlingController : MonoBehaviour {

	private bool isStanding = true;
	private float standingHeight;
	private float proneHeight;

	// Use this for initialization
	void Start () {
		standingHeight = transform.localScale.y;
		proneHeight = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C) && isStanding) {
			transform.localScale = new Vector3 (transform.localScale.x, proneHeight, transform.localScale.z);
			isStanding = false;
			print ("Crouch");
		}
		else if (Input.GetKeyDown (KeyCode.C) && !isStanding) 
		{
			transform.localScale = new Vector3 (transform.localScale.x, proneHeight, transform.localScale.z);
			isStanding = true;
			print ("stand up");
		}
	}
}
