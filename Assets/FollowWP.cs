using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWP : MonoBehaviour
{
    public GameObject[] wayPoints;
    int currentWP = 0;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, wayPoints[currentWP].transform.position) < 5)
        {
            currentWP++;
        }
        if (currentWP >= wayPoints.Length)
        {
            currentWP = 0;
        }
        transform.LookAt(wayPoints[currentWP].transform);
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
