using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public GameObject UI;
    public GameObject highScoreUI;
    public Stockage data;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        highScoreUI.GetComponentInChildren<TextMesh>().text = data.highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scoring()
    {
        score += 1;
        UI.GetComponentInChildren<TextMesh>().text = score.ToString();
        //cam.GetComponent<Shake>().activated = true;
        if (score > data.highScore)
        {
            data.highScore = score;
            highScoreUI.GetComponentInChildren<TextMesh>().text = data.highScore.ToString();
        } 
    }
    }
