using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{

    public Transform targetLeft;
    public Transform targetRight;
    public float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = Vector3.MoveTowards(transform.position, targetLeft.position, speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = Vector3.MoveTowards(transform.position, targetRight.position, speed);
        }
    }
}
