using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateLights : MonoBehaviour
{
    public static int numberOfLights = 10;
    public GameObject trafficLightPrefab;
    GameObject[] trafficLight = new GameObject[numberOfLights];

    Color[] colors = new Color[3];

    // Start is called before the first frame update
    void Start()
    {
        colors[0] = Color.green;
        colors[1] = Color.yellow;
        colors[2] = Color.red;

        for (int i = 0; i < 10; i++)
        {
            GameObject instanceLight = (GameObject)Instantiate(trafficLightPrefab);
            instanceLight.transform.position = this.transform.position;
            instanceLight.transform.parent = this.transform;

            this.transform.eulerAngles = new Vector3(0, (360 / numberOfLights) * i, 0);
            instanceLight.transform.position = Vector3.forward * 10;
            trafficLight[i] = instanceLight;

            instanceLight.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
