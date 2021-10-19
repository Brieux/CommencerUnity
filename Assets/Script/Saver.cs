using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{
    public Stockage datas;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(datas.highScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
