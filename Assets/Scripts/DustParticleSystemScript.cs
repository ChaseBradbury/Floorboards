using UnityEngine;
using System.Collections;

public class DustParticleSystemScript : MonoBehaviour {

    public Transform particle;
    public float emissionRate;
    public int lifespan;
    public int maxParticles;
    public Vector3 startVelocity;
    public Vector3 startScale;
    public Color startColor;

    private float emissionOverflow;
    private DustParticleScript[] particles;
    private int numParticles;

    // Use this for initialization
    void Start () {
        numParticles = 0;
        emissionOverflow = 0;
        particles = new DustParticleScript[maxParticles];
    }

    // Update is called once per frame
    void Update()
    {
        if (numParticles <= maxParticles)
        {
            float newXPos;
            float newYPos;
            float newZPos;
            Transform newParticle;
            DustParticleScript newParticleScript;
            int i;
            for (i = 0; i < emissionRate + emissionOverflow - 1; i++)
            {
                newXPos = Random.Range(this.transform.position.x - this.transform.localScale.x, this.transform.position.x + this.transform.localScale.x);
                newYPos = Random.Range(this.transform.position.y - this.transform.localScale.y, this.transform.position.y + this.transform.localScale.y);
                newZPos = Random.Range(this.transform.position.z - this.transform.localScale.z, this.transform.position.z + this.transform.localScale.z);
                newParticle = Transform.Instantiate(particle, new Vector3(newXPos, newYPos, newZPos), Quaternion.identity) as Transform;
                newParticle.localScale = startScale;
                newParticle.GetComponent<SpriteRenderer>().color = startColor;
                newParticleScript = newParticle.GetComponent<DustParticleScript>();
                newParticleScript.velocity = startVelocity;
                particles[numParticles++] = newParticleScript;
            }
            emissionOverflow = emissionRate + emissionOverflow - i;
        }

        for (int i = 0; i < particles.Length; i++)
        {
            if (particles[i].life >= lifespan)
            {
                float newXPos = Random.Range(this.transform.position.x - this.transform.localScale.x, this.transform.position.x + this.transform.localScale.x);
                float newYPos = Random.Range(this.transform.position.y - this.transform.localScale.y, this.transform.position.y + this.transform.localScale.y);
                float newZPos = Random.Range(this.transform.position.z - this.transform.localScale.z, this.transform.position.z + this.transform.localScale.z);
                particles[i].Reset(new Vector3(newXPos, newYPos, newZPos));
            }
        }
    }
}
