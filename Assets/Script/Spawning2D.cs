using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning2D : MonoBehaviour
{
    public GameObject BallPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(BallPrefab);
        Instantiate(BallPrefab);
        Instantiate(BallPrefab);
        Instantiate(BallPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
