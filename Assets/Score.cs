using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public GameObject UI; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scoring()
    {
        score += 1;
        UI.GetComponentInChildren<TextMesh>().text = score.ToString();
    }
    }
