using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterBall : MonoBehaviour
{
    LineRenderer Line;
    // Start is called before the first frame update
    void Start()
    {
        Line = transform.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Line.SetPosition(1, transform.position);
    }
}
