using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringBall : MonoBehaviour
{
    public GameObject UI;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UI.GetComponentInChildren<TextMesh>().text = score.ToString();
    }
}
