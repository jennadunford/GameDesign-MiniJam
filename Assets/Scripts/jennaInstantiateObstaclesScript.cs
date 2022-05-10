using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jennaInstantiateObstaclesScript : MonoBehaviour
{
    public Transform rightInstantiate;
    public Transform leftInstantiate;
    public float timerRaw;
    public int timer = 0;
    public float timer2 = 0;
    public float rawTimer2 = 0;
    public bool bInstantiate = true;
    public GameObject Obstacle;
    public GameObject Coin;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        timerRaw += Time.deltaTime;
        rawTimer2 += Time.deltaTime;
        timer2 = rawTimer2;
        timer = (int)timerRaw;
        if (jennaTimerScript.gameEnd == false)
        {
      
            if(timer >= 1)
            {
                if (bInstantiate)
                {
                    Instantiate(Obstacle, rightInstantiate);

                }
                else
                {
                    Instantiate(Obstacle, leftInstantiate);

                }
                bInstantiate = !bInstantiate;
                timer = 0;
                timerRaw = 0;
            }

            if(timer2 >= 0.2f)
            {
                if (bInstantiate)
                {
                    Instantiate(Coin, leftInstantiate);
                }
                else
                {
                    Instantiate(Coin, rightInstantiate);
                }
                rawTimer2 = 0;
                timer2 = 0;

           }

            
            
            
            
        }
        
    }
}
