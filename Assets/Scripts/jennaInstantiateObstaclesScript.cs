using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jennaInstantiateObstaclesScript : MonoBehaviour
{
    public Transform rightInstantiate;
    public Transform leftInstantiate;
    public float timerRaw;
    public int timer = 0;
    public bool bInstantiate = true;
    public GameObject Obstacle;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        timerRaw += Time.deltaTime;
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
            
            
            
        }
        
    }
}
