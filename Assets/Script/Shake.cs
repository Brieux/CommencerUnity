using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    float timing = 0;
    public bool activated = false;
    public int compteur = 300;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activated && compteur > 0)
        {
            GetComponent<Camera>().orthographicSize = 7.5f;
            transform.Translate(new Vector3(Mathf.Cos(timing) * 0.3f, Mathf.Sin(timing) * 0.3f, 0));
            timing = timing + 1;
            compteur -= 1;
        }

        else
        {
            GetComponent<Camera>().orthographicSize = 8.4f;
            activated = false;
            compteur = 300;
            transform.position = new Vector3(0, 0, -10);
        }
    }
}
