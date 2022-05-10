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
    public SpriteRenderer playerSprite;
    public Sprite faceImage;

    public Button changeRed;
    public Button changeGreen;
    public Button ChangeFace;
    public Button changeBlue;

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
        changeGreen.gameObject.SetActive(true);
        changeBlue.gameObject.SetActive(true);
        changeRed.gameObject.SetActive(true);
        ChangeFace.gameObject.SetActive(true);
        
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
        restart.gameObject.SetActive(false);
        changeGreen.gameObject.SetActive(false);
        changeBlue.gameObject.SetActive(false);
        changeRed.gameObject.SetActive(false);
        ChangeFace.gameObject.SetActive(false);
    }

    public void changeColourBlue()
    {
        if(jennaMoveScript.coins >= 200)
        {
            jennaMoveScript.coins = jennaMoveScript.coins - 200;
            playerSprite.color = Color.blue;
        }
    }

    public void changeColourRed()
    {
        if (jennaMoveScript.coins >= 200)
        {
            jennaMoveScript.coins = jennaMoveScript.coins - 200;
            playerSprite.color = Color.red;
        }
    }

    public void changeColourGreen()
    {
        if (jennaMoveScript.coins >= 200)
        {
            jennaMoveScript.coins = jennaMoveScript.coins - 200;
            playerSprite.color = Color.green;
        }
    }

    public void changeToFace()
    {
        if (jennaMoveScript.coins >= 1000)
        {
            jennaMoveScript.coins = jennaMoveScript.coins - 1000;
            playerSprite.sprite = faceImage;
        }
    }
}
