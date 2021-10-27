using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    public GameObject prefabBall;
    public GameObject pointLight;
    public float lerp;
    public bool ActiveBall = false;
    public bool SpawnBall = false;
    private GameObject balle;
    [SerializeField] GameManager GM;
    public Texture2D cursorTexture;
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
            Cursor.SetCursor(cursorTexture, new Vector2(0,0), CursorMode.Auto);
            pointLight.transform.position = Vector3.Lerp(pointLight.transform.position, hit.point, lerp);
        }
        if (!SpawnBall && GM.GetComponent<GameManager>().coupDispo())
        {
            balle = Instantiate(prefabBall, new Vector3(2.6099999f, 14.6099997f, -23.8299999f), new Quaternion(0, 0, 0, 0));
            SpawnBall = true;
        }
        if (Input.GetMouseButton(0) && ActiveBall == false && GM.GetComponent<GameManager>().coupDispo())
        {
            ActiveBall = true;
            balle.GetComponent<MoveForward>().shot = true;
            balle.GetComponent<MoveForward>().Destination = pointLight.transform.position;
            balle.GetComponent<MoveForward>().Cam = gameObject;
            GM.GetComponent<GameManager>().tirBalle();
        }

    }

    public void Reset()
    {
        ActiveBall = false;
        SpawnBall = false;
    }
}
