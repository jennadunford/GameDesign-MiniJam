using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class jennaObstacleBehaviourScript : MonoBehaviour
{
    public Button restart;
    public static int gameTime;
    public float rawGameTime;
    public static int gravityScale = 1;

    void Update()
    {
        rawGameTime += Time.deltaTime;
        gameTime = (int)rawGameTime;
        Debug.Log("Game time: " + gameTime);
        if ((gameTime >= 3) && (gravityScale < 15))
        {
            gameTime = 0;
            rawGameTime = 0;
            gravityScale++;            
            Debug.Log("Gravity scale: " + gravityScale);
            
        }
    }


    public void stopAllObstacles()
    {
        if (jennaTimerScript.highScoreCount < jennaTimerScript.scoreCounter)
        {
            jennaTimerScript.highScoreCount = jennaTimerScript.scoreCounter;
        }
        GameObject[] obstacles;
        obstacles = GameObject.FindGameObjectsWithTag("obstacle");
        foreach(GameObject obstacle in obstacles)
        {
            obstacle.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
           
            
        }
        restart.gameObject.SetActive(true);
        
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
        gravityScale = 1;
        gameTime = 0;
        rawGameTime = 0;
        jennaTimerScript.rawTime = 0;
        jennaTimerScript.scoreCounter = 0;
        destroyAllObstacles();
        jennaTimerScript.gameEnd = false;
        restart.gameObject.SetActive(false);
    }
}
