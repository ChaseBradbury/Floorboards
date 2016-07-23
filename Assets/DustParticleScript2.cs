using UnityEngine;
using System.Collections;

public class DustParticleScript2 : MonoBehaviour
{
    public Vector2 boundsX;
    public Vector2 boundsY;
    public Vector2 boundsZ;

    public Vector3 velocity;
    private float velRange;
    

    // Use this for initialization
    void Start()
    {
        velRange = 0.001F;
        velocity = new Vector3(Random.Range(-velRange, velRange), Random.Range(-velRange, velRange), Random.Range(-velRange, velRange));
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < boundsX.x)
        {
            this.transform.position = new Vector3(boundsX.x + 0.01F, this.transform.position.y, this.transform.position.z);
            velocity = new Vector3(Random.Range(-velRange, velRange), Random.Range(-velRange, velRange), Random.Range(-velRange, velRange));
        }
        if (this.transform.position.x > boundsX.y)
        {
            this.transform.position = new Vector3(boundsX.y - 0.01F, this.transform.position.y, this.transform.position.z);
            velocity = new Vector3(Random.Range(-velRange, velRange), Random.Range(-velRange, velRange), Random.Range(-velRange, velRange));
        }
        if (this.transform.position.y < boundsY.x)
        {
            this.transform.position = new Vector3(this.transform.position.x, boundsY.x + 0.01F, this.transform.position.z);
            velocity = new Vector3(Random.Range(-velRange, velRange), Random.Range(-velRange, velRange), Random.Range(-velRange, velRange));
        }
        if (this.transform.position.y > boundsY.y)
        {
            this.transform.position = new Vector3(this.transform.position.x, boundsY.y - 0.01F, this.transform.position.z);
            velocity = new Vector3(Random.Range(-velRange, velRange), Random.Range(-velRange, velRange), Random.Range(-velRange, velRange));
        }
        if (this.transform.position.z < boundsZ.x)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, boundsZ.x + 0.01F);
            velocity = new Vector3(Random.Range(-velRange, velRange), Random.Range(-velRange, velRange), Random.Range(-velRange, velRange));
        }
        if (this.transform.position.z > boundsZ.y)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, boundsZ.x + 0.01F);
            velocity = new Vector3(Random.Range(-velRange, velRange), Random.Range(-velRange, velRange), Random.Range(-velRange, velRange));
        }
        this.transform.position += velocity;
        transform.rotation = Quaternion.LookRotation(-Camera.main.transform.forward);
    }

    public void Reset(Vector3 position)
    {
        this.transform.position = position;
    }
}
