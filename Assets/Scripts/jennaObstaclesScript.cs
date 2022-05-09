using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jennaObstaclesScript : MonoBehaviour
{
    GameObject Manager;
    GameObject behaviourScript;


    // Start is called before the first frame update
    void Start()
    {

        Manager = GameObject.FindGameObjectWithTag("Manager");
        gameObject.GetComponent<Rigidbody2D>().gravityScale = jennaObstacleBehaviourScript.gravityScale;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroy")
        {
            Destroy(gameObject);
        }

        if(collision.tag == "Player")
        {
            jennaTimerScript.gameEnd = true;
            Manager.GetComponent<jennaObstacleBehaviourScript>().stopAllObstacles();
            
        }
        
    }
}
