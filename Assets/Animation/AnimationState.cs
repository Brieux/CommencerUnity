using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationState : MonoBehaviour
{
    public bool isBouncing;
    public bool isExploding;
    [SerializeField] GameObject bouche;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        Vector2 direction = (mousePos - transform.position).normalized;
        bouche.transform.localPosition = direction*0.2f;

        if (isBouncing)
        {
            GetComponent<Animator>().SetTrigger("Bouncing");
            isBouncing = !isBouncing;
        }
        if (isExploding)
        {
            GetComponent<Animator>().SetTrigger("Explosion");
            
        }
    }
    public void Explode()
    {
        Destroy(gameObject);
    }
}
