using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jennaMoveScript : MonoBehaviour
{
    public Transform targetLeft;
    public Transform targetRight;
    public float speed = 0.05f;
    public static int coins = 0;
    public Text coinText;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coins.ToString();
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = Vector3.MoveTowards(transform.position, targetLeft.position, speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = Vector3.MoveTowards(transform.position, targetRight.position, speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "coin")
        {
            Destroy(collision.gameObject);
            coins++;          
        }
    }
}
