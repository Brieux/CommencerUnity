using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int nbCoup = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool coupDispo()
    {
        if (nbCoup > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void tirBalle()
    {
        nbCoup -= 1;
    }
}
