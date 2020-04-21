using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 3f;
    public GameObject target;
    public bool lookForTarget = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lookForTarget)
        {
            SetTarget();
        }

        transform.LookAt(target.transform);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

        if (target.GetComponent<Renderer>().material.color != Color.green || transform.position == target.transform.position)
        {
            lookForTarget = true;
        }
    }

    void SetTarget()
    {
        var index = Random.Range(0, InstantiateLights.trafficLight.Length);

        if (InstantiateLights.trafficLight[index].GetComponent<Renderer>().material.color == Color.green)
        {
            target = InstantiateLights.trafficLight[index];
            lookForTarget = false;
        }

        else
        {
            return;
        }
    }
}
