using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int area;
    public int currentInt = 0, highestInt = 0;
    void Start()
    {
        //Area(15, 25);

        HighestRandomNumber(10, 100);
    }

    void Update()
    {

    }

    public void Area(int l, int w)
    {
        area = l * w;
        Debug.Log(area);
    }

    public void HighestRandomNumber(int amount, int range)
    {
        for (int i = 0; i < amount; i++)
        {
            currentInt = Random.Range(0, range + 1);
            Debug.Log(currentInt);
            if (currentInt > highestInt)
            {
                highestInt = currentInt;
            }
        }
        Debug.Log("Highest Value: " + highestInt);
    }
}
