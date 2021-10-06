using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(30, 40)] public int Speed;
    public bool OnGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponentInParent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Horizontal") * Speed, GetComponentInParent<Rigidbody>().velocity.y, 0);
        if (Input.GetKeyDown(KeyCode.Space) && (OnGround == true))
        {
            GetComponentInParent<Rigidbody>().velocity = GetComponentInParent<Rigidbody>().velocity + new Vector3(0, 10, 0);
            OnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            OnGround = true;
           
        }
    }
}
