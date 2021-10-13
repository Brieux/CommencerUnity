using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingOnBall : MonoBehaviour
{
    public GameObject Spawner;
    public bool Destroyer=false;
    public int CD;
    public bool played = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Destroyer == true)
        {
            CD = CD - 1;
            if (played == false)
            {
                GetComponentInChildren<ParticleSystem>().Play();
                played = true;
            }

        }
        if (CD <= 0)
        {
            Destroying();
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Salut");
        Destroyer = true;
    }

    private void OnTriggerStay(Collider collision)
    {
        if ((collision.gameObject.GetComponent<SetColor>().Type == this.gameObject.GetComponent<SetColor>().Type) && (Destroyer == true))
        {
            collision.GetComponent<ClickingOnBall>().Destroyer = true;
        }
    }

    public void Destroying()
    {
        Spawner.GetComponent<ScoringBall>().score += 1;
        Spawner.GetComponent<SpawningBall>().AllBall.Remove(this.gameObject);
        Destroy(this.gameObject);
    }
};
