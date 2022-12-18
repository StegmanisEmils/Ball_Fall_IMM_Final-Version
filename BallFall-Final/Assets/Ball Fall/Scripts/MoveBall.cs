using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 0.3f;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Input.GetAxis("Horizontal"), Time.deltaTime, speed);
    }
}
