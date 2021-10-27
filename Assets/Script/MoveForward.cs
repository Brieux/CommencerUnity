using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public Vector3 Destination;
    public GameObject Cam;
    public bool shot = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shot)
        {
            GetComponent<Rigidbody>().velocity = (Destination - transform.position) * 5f;
            //Cam.GetComponent<LaunchBall>().Invoke("Reset", 1.2f);
            Destroy(gameObject, 2f);
            shot = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().useGravity = true;
        if (collision.gameObject.tag== "Floor")
        {
            Debug.Log("Floor touch");
            Cam.GetComponent<LaunchBall>().Reset();
        }
    }
}
