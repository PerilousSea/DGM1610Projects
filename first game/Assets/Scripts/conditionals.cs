using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditionals : MonoBehaviour
{

    int time = 104;
    public string weather = "clear";
    bool isStopLightRed = true;
    public float gpa = 3.25f;
    public double temperature = 101.45d;


    // Start is called before the first frame update
    void Start()
    {
        //Check time
        if(time >= 200)
        {
            Debug.Log("Rise and Shine!");
        }
        else
        {
            Debug.Log("It's too early go back to bed!");
        }
        //Check StopLight
        if(isStopLightRed == true)
        {
            Debug.Log("Stop!");
        }
        else 
        {
            Debug.Log("Go!");
        }

       /*

       if(conditional_01)
        {
            //if condtion_01 is true run this code
        } 
        elseif (conditional_02)
        {
            //if condtion_02 is true run this code
        }
        else
        {
            //if no other conditions are true run this code
        }
        */ 
    }

    // Update is called once per frame
    void Update()

    {
        //Check weather
        if(weather == "cloudy")
        {
            Debug.Log("It is cloudy outside.");
        }
        else if(weather == "raining")
        {
            Debug.Log("It is raining outside.");
        }
        else if(weather == "clear")
        {
            Debug.Log("It's a beautiful day!");
        }
        else if(weather == "ThunderLightning")
        {
            Debug.Log("Stay inside there is a storm!");
        }
        else if(weather == "Snowing")
        {
            Debug.Log("Bundle up for the snow!");
        }
        else
        {
            Debug.Log("It's a day, do whatever.");
        }

         //Check temperature
        if(temperature >= 100)
        {
            Debug.Log("It feels like death is in the air!");
        } 
        else if (temperature == 90)
        {
            Debug.Log("It is too hot!");
        }
        else if (temperature == 80)
        {
            Debug.Log("It is hot.");
        }
        else if (temperature == 70)
        {
            Debug.Log("It the perfect temperature!");
        }
         else if (temperature <= 69)
        {
            Debug.Log("It is too cold!");
        }
        else
        {
            Debug.Log("Temperature is undetectable.");
        }

        //Check gpa
        if(gpa >= 3.5)
        {
            Debug.Log("Amazing grades!");
        }
        else if (gpa <= 2.0)
        {
            Debug.Log("This isn't good.");
        }
        else
        {
            Debug.Log("Average.");
        }

    }
}
