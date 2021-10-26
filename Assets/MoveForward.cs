using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public Vector3 Destination;
    public GameObject Cam;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = (Destination- transform.position) * 5f;
        Cam.GetComponent<LaunchBall>().Invoke("Reset", 1.2f);
        Destroy(gameObject, 1.25f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
