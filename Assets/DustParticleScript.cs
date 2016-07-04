using UnityEngine;
using System.Collections;

public class DustParticleScript : MonoBehaviour {

    public Vector3 velocity;
    public int life;

	// Use this for initialization
	void Start ()
    {
        life = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        life++;
        this.transform.position += velocity;
        transform.rotation = Quaternion.LookRotation(-Camera.main.transform.forward);
    }

    public void Reset (Vector3 position)
    {
        life = 0;
        this.transform.position = position;
    }

    
}
