using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public ParticleSystem FX;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-4f, 4f), Random.Range(-4f, 4f));
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Vector3 pos = new Vector3(collision.GetContact(0).point.x, collision.GetContact(0).point.y, 0);
            Instantiate(FX, pos, new Quaternion(0, 0, 0, 0));
        }
    }
}
