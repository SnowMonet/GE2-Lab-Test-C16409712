using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightColors : MonoBehaviour
{
    /*  
      public Material greenLight;
      public Material yellowLight;
      public Material redLight;
    */

    Renderer trafficLightRenderer;

    float colorDelay;

    // Start is called before the first frame update
    void Start()
    {
        trafficLightRenderer = GetComponent<Renderer>();

        StartCoroutine(ChangeColorLoop());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ChangeColorLoop()
    {
        while(true)
        {
            ChangeColor();
            yield return new WaitForSeconds(colorDelay);
        }
    }

    void ChangeColor()
    {
        if (trafficLightRenderer.material.color == Color.green)
        {
            colorDelay = 4;
            trafficLightRenderer.material.color = Color.yellow;
        }

        else if (trafficLightRenderer.material.color == Color.yellow)
        {
            colorDelay = Random.Range(5,10);
            trafficLightRenderer.material.color = Color.red;
        }

        else if (trafficLightRenderer.material.color == Color.red)
        {
            colorDelay = Random.Range(5, 10);
            trafficLightRenderer.material.color = Color.green;
        }
    }
}
