using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    public Material[] allColors;
    public int Type;
    // Start is called before the first frame update
    void Start()
    {
        Type = Random.Range(0, allColors.Length);
        GetComponentInChildren<MeshRenderer>().material = allColors[Type];
        gameObject.GetComponentInChildren<ParticleSystem>().GetComponentInChildren<Renderer>().material = GetComponentInChildren<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
