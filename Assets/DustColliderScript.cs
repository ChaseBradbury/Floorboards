using UnityEngine;
using System.Collections;

public class DustColliderScript : MonoBehaviour {

    public Color enterColor;
    public Color exitColor;
    public Vector3 enterScale;
    public Vector3 exitScale;

    private ParticleSystem dustSystem;
    private ParticleCollisionEvent[] events;

	void Start () {
        dustSystem = GetComponent<ParticleSystem>();
        events = new ParticleCollisionEvent[16];
        Debug.Log("Start");
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter Collision");
        if (other.gameObject.CompareTag("DustParticle"))
        {
            other.GetComponent<Transform>().localScale = enterScale;
            other.GetComponent<SpriteRenderer>().color = enterColor;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("DustParticle"))
        {
            other.GetComponent<Transform>().localScale = exitScale;
            other.GetComponent<SpriteRenderer>().color = exitColor;
        }
    }

    /*void OnParticleCollision(GameObject other) {
        dustSystem = other.GetComponent<ParticleSystem>();
        int safeLength = dustSystem.GetSafeCollisionEventSize();
        if (events.Length < safeLength)
            events = new ParticleCollisionEvent[safeLength];

        int numCollisionEvents = dustSystem.GetCollisionEvents(other, events);
        Rigidbody rb = other.GetComponent<Rigidbody>();

        ParticleSystem.Particle[] particles = new ParticleSystem.Particle[dustSystem.particleCount];
        int num = dustSystem.GetParticles(particles);
        Debug.Log("Found " + num + " active particles.");

        int i = 0;
        while (i < numCollisionEvents)
        {
            for (int j = 0; j < num; j++)
            {
                if (events[i].intersection == particles[j].position)
                {
                    particles[j].velocity = new Vector3(1, 0, 0);
                }
            }
        }
    }*/

    /*void Update()
    {
        // initialize an array the size of our current particle count
        ParticleSystem.Particle[] particles = new ParticleSystem.Particle[dustSystem.particleCount];
        // *pass* this array to GetParticles...
        int num = dustSystem.GetParticles(particles);
        Debug.Log("Found " + num + " active particles.");
        for (int i = 0; i < num; i++)
        {
            particles[i].Equals
            if (particles[i].position.z > 5) // large local z: let particle drop down
                particles[i].velocity -= Vector3.up * 0.1f;
            if (particles[i].position.x > 1) // positive x: make it red
                particles[i].color = Color.red;
        }
        // re-assign modified array
        dustSystem.SetParticles(particles, num);
    }*/
}
