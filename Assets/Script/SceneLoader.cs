using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public GameObject image;
    public AnimationCurve curveAlpha;
    public bool showCredit = false;
    public float newTimer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (showCredit)
        {
            newTimer += Time.deltaTime; 
            Color newColor = image.GetComponent<Image>().color;
            newColor.a = curveAlpha.Evaluate(newTimer);
            image.GetComponent<Image>().color = newColor;
        }
    }

    public void Loading()
    {
        SceneManager.LoadScene("BubbleDefense");
    }

    public void show()
    {
        newTimer = 0;
        showCredit = true;
    }
}
