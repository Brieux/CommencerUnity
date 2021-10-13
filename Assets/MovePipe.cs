using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public GameObject player;
    private bool ScoreBool = true;
    public bool hard = false;
    private float basics;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(0, 5) >= 3f)
        {
            hard = true;
            Debug.Log("Salut");
            GetComponentInChildren<Rigidbody>().velocity = new Vector3(-6, 2, 0);
            basics = transform.position.y;
            
        }
        else
        {
            GetComponentInChildren<Rigidbody>().velocity = new Vector3(-6, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hard)
        {
            if (GetComponentInChildren<Transform>().position.y > basics + 2)
            {
                GetComponentInChildren<Rigidbody>().velocity = new Vector3(-6, -2, 0);
            }
            if (GetComponentInChildren<Transform>().position.y < basics - 2)
            {
                GetComponentInChildren<Rigidbody>().velocity = new Vector3(-6, 2, 0);
            }
        }
        if (GetComponentInChildren<Transform>().position.x < -1.7f && ScoreBool == true)
        {
            Debug.Log("Score");
            player.GetComponent<Score>().Scoring();
            ScoreBool = false;
            GetComponentInChildren<ParticleSystem>().Play();
        }
        if (GetComponentInChildren<Transform>().position.x < -5.7f)
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GeneratePipe>().AllPipe.RemoveAt(0);
            Destroy(gameObject);
        }
    }
}
