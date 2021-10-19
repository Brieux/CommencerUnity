using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Loading()
    {
        SceneManager.LoadScene("BubbleDefense");
    }

    public void ShowImage()
    {
        image.GetComponent<>
    }
}
