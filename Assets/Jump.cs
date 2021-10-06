using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public GameObject BG;
    public Sprite Night;
    public GameObject go;
    public GameObject UIDeb;
    public GameObject GamePipes;
    public bool begin;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && begin == false)
        {
            GetComponentInParent<Transform>().position = new Vector3(-3.21000004f, 0.0858799964f, -5.32000017f);
            Time.timeScale = 1;
            GetComponentInParent<Rigidbody>().velocity = new Vector3(0, 9, 0);
            begin = true;
            UIDeb.SetActive(false);
        }
        if (Input.GetMouseButtonDown(0))
        {
            GetComponentInParent<Rigidbody>().velocity = new Vector3(0, 9, 0);
        }
        if (Input.GetMouseButtonDown(0) && (GamePipes.GetComponent<GeneratePipe>().finish == true)){
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Killer")
        {
            Debug.Log("Perdu");
            GetComponent<Animator>().enabled = false;
            GamePipes.GetComponent<GeneratePipe>().StopPipe();
            BG.GetComponentInChildren<SpriteRenderer>().sprite = Night;
            go.SetActive(true);
            this.GetComponent<Transform>().Rotate(0, 0, -90);            
        }
    }
}
