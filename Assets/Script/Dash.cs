using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public GameObject AllPipe;
    public float CdBase;
    public float Cd;
    public GameObject Particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 

        if (Input.GetButtonDown("Fire1") && (Cd <= 0))
        {
            Cd = CdBase;
            GameObject particle = Instantiate(Particle, transform.localPosition, transform.rotation);
            
            foreach(GameObject objet in AllPipe.GetComponent<GeneratePipe>().AllPipe)
            {
                objet.transform.Translate(-4, 0, 0);
                //objet.position = new Vector3(objet.GetComponent<Rigidbody>().position.x -4 , objet.GetComponent<Rigidbody>().position.y, objet.GetComponent<Rigidbody>().position.z);
            }
        }
        if (Cd >0) Cd = Cd - 1;
    }
}
