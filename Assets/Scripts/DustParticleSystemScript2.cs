using UnityEngine;
using System.Collections;

public class DustParticleSystemScript2 : MonoBehaviour
{

    public Transform particle;
    public int numParticles;
    public Vector3 startVelocity;
    public Vector3 startScale;
    public Color startColor;
    
    private DustParticleScript2[] particles;

    // Use this for initialization
    void Start()
    {
        particles = new DustParticleScript2[numParticles];
        float newXPos;
        float newYPos;
        float newZPos;
        Transform newParticle;
        DustParticleScript2 newParticleScript;
        int i;
        for (i = 0; i < numParticles; i++)
        {
            newXPos = Random.Range(this.transform.position.x - this.transform.localScale.x, this.transform.position.x + this.transform.localScale.x);
            newYPos = Random.Range(this.transform.position.y - this.transform.localScale.y, this.transform.position.y + this.transform.localScale.y);
            newZPos = Random.Range(this.transform.position.z - this.transform.localScale.z, this.transform.position.z + this.transform.localScale.z);
            newParticle = Transform.Instantiate(particle, new Vector3(newXPos, newYPos, newZPos), Quaternion.identity) as Transform;
            newParticle.localScale = startScale;
            newParticle.GetComponent<SpriteRenderer>().color = startColor;
            newParticleScript = newParticle.GetComponent<DustParticleScript2>();
            newParticleScript.boundsX = new Vector2(this.transform.position.x - this.transform.localScale.x, this.transform.position.x + this.transform.localScale.x);
            newParticleScript.boundsY = new Vector2(this.transform.position.y - this.transform.localScale.y, this.transform.position.y + this.transform.localScale.y);
            newParticleScript.boundsZ = new Vector2(this.transform.position.z - this.transform.localScale.z, this.transform.position.z + this.transform.localScale.z);
            particles[i] = newParticleScript;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
