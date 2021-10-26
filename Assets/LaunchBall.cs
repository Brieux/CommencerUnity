using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    public GameObject prefabBall;
    public GameObject pointLight;
    public float lerp;
    public bool ActiveBall = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool isHit = Physics.Raycast(raycast, out hit, 100);
        if (isHit)
        {
            pointLight.transform.position = Vector3.Lerp(pointLight.transform.position, hit.point, lerp);
        }
        if (Input.GetMouseButton(0) && ActiveBall == false)
        {
            GameObject ball = Instantiate(prefabBall, new Vector3(0.340000004f, 10.54f, -12.2399998f), new Quaternion (0,0,0,0));
            ActiveBall = true;
            ball.GetComponent<MoveForward>().Destination = pointLight.transform.position;
            ball.GetComponent<MoveForward>().Cam = gameObject;

        }
    }

    public void Reset()
    {
        ActiveBall = false;
    }
}
