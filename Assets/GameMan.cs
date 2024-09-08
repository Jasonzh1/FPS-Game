using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMan : MonoBehaviour
{
    public float gameTime;
    public int point = 0;
    public Text pointUI;
    public Text timeUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameTime -= Time.deltaTime;
        if(gameTime <= 0){
            Debug.Log("Time is up");
        }

        pointUI.text = "Score: " + point;
        timeUI.text = "Time: " + Mathf.FloorToInt(gameTime/60) + ":" + (gameTime%60).ToString("f1");
    }
}
