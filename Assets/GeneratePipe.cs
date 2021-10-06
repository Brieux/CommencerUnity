using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePipe : MonoBehaviour
{
    public GameObject prefab;
    public int Space;
    public GameObject Bird;
    public List<GameObject> AllPipe;
    public bool finish = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("create", 0.0f, 1.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void create()
    {
        if (finish == false)
        {
            GameObject pipe = Instantiate<GameObject>(prefab, new Vector3(Space, Random.Range(-9.0f, 3f), -6f), Quaternion.identity);
            pipe.GetComponent<MovePipe>().player = Bird;
            AllPipe.Add(pipe);
        }
    }

    public void StopPipe()
    {
        finish = true;
        foreach (GameObject objet in AllPipe)
        {
            objet.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}
