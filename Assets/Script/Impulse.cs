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
            float direction = Vector3.Angle(collision.gameObject.transform.position, this.gameObject.transform.position);
            Vector3 pos = new Vector3(collision.GetContact(0).point.x, collision.GetContact(0).point.y, 0);
            ParticleSystem FXS = Instantiate(FX, pos, new Quaternion());

            Vector3 tamp = Vector3.MoveTowards(collision.gameObject.transform.position, this.gameObject.transform.position, 1000);
            Vector2 TampV2 = new Vector2(tamp.x, tamp.y);
            Debug.Log(TampV2);
            Debug.Log(Vector2.Perpendicular(TampV2));
            FXS.gameObject.transform.eulerAngles = new Vector3(0,0, TampV2.x*90 + TampV2.y * 90);
            /*Debug.Log(direction);
            //Debug.Log(Vector3.Dot(collision.gameObject.transform.position, this.gameObject.transform.position));
            Debug.Log(Quaternion.LookRotation(collision.gameObject.transform.position, this.gameObject.transform.position));*/

        }
    }
}
