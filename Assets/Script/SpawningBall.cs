using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningBall : MonoBehaviour
{
    public GameObject ball;
    public List<GameObject> AllBall;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void spawn()
    {
        if (AllBall.Count <= 25)
        {
            Vector3 positionInst = new Vector3(Random.Range(-2f, 2), transform.localPosition.y, 0);
            GameObject pref = (Instantiate(ball, positionInst, new Quaternion(0, 0, 0, 0)));
            AllBall.Add(pref);
            pref.GetComponent<ClickingOnBall>().Spawner = this.gameObject;
        }
    }
}
