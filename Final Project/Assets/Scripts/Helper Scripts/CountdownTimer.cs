using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 30f;

    [SerializeField] Text countdownText;


    [Header("UI")]
    public Text winText;
    public Text infoText;
 

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        



        if (currentTime <= 0) 
        {
            currentTime = 0;
        }

        if(currentTime <= 0) 
        {
            infoText.gameObject.SetActive(true);
            infoText.text = "You Win";
            GameOver();
            currentTime = 0;
        }

       
    }

    public void GameOver() 
    {
        Application.Quit();
    }

}
