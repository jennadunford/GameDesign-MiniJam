using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class jennaObstacleBehaviourScript : MonoBehaviour
{
    public Button restart;
    

    public void stopAllObstacles()
    {
        GameObject[] obstacles;
        obstacles = GameObject.FindGameObjectsWithTag("obstacle");
        foreach(GameObject obstacle in obstacles)
        {
            obstacle.GetComponent<Rigidbody2D>().gravityScale = 0;
           
            restart.gameObject.SetActive(true);
        }
        if (jennaTimerScript.highScoreCount < jennaTimerScript.scoreCounter)
        {
            jennaTimerScript.highScoreCount = jennaTimerScript.scoreCounter;
        }
    }

    public void destroyAllObstacles()
    {

        GameObject[] obstacles;
        obstacles = GameObject.FindGameObjectsWithTag("obstacle");
        foreach (GameObject obstacle in obstacles)
        {
            Destroy(obstacle);
        }

    }

    public void restartGame()
    {      
        jennaTimerScript.rawTime = 0;
        jennaTimerScript.scoreCounter = 0;
        destroyAllObstacles();
        restart.gameObject.SetActive(false);
    }
}
