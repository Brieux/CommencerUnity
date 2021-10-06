using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public GameObject player;
    private bool ScoreBool = true;
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Rigidbody>().velocity = new Vector3(-6, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponentInChildren<Transform>().position.x < -4.7f && ScoreBool == true)
        {
            Debug.Log("Score");
            player.GetComponent<Score>().Scoring();
            ScoreBool = false;
        }
        if (GetComponentInChildren<Transform>().position.x < -5.7f)
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GeneratePipe>().AllPipe.RemoveAt(0);
            Destroy(gameObject);
        }
    }
}
