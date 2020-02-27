using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAGenerator : MonoBehaviour
{
    public GameObject ia;
    public Transform target;

    private float nextActionTime = 0.0f;
    public float period = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            ia.GetComponent<AgentController>().target = target;
            Instantiate(ia, new Vector3(5, 2, -2), Quaternion.identity);
        }
    }
}