using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateLights : MonoBehaviour
{
    public static int numberOfLights = 10;
    public GameObject trafficLightPrefab;
    GameObject[] trafficLight = new GameObject[numberOfLights];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject instanceLight = (GameObject)Instantiate(trafficLightPrefab);
            instanceLight.transform.position = this.transform.position;
            instanceLight.transform.parent = this.transform;

            this.transform.eulerAngles = new Vector3(0, (360 / numberOfLights) * i, 0);
            instanceLight.transform.position = Vector3.forward * 10;
            trafficLight[i] = instanceLight;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
