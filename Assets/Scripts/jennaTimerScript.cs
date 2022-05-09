using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jennaTimerScript : MonoBehaviour
{
    public Text timerText;
    public Text highScoreText;
    public static int scoreCounter = 0;
    public static int highScoreCount = 0;
    public static float rawTime = 0;

    public static bool gameEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameEnd)
        {
            rawTime += Time.deltaTime;
            scoreCounter = ((int)rawTime) * 10;
            timerText.text = scoreCounter.ToString();
        }
            
        
        
        
    }
}
