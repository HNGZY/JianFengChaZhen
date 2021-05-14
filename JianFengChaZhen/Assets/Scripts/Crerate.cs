using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crerate : MonoBehaviour
{
    public GameObject prefab;
    Turn turn;
    // Start is called before the first frame update
    void Start()
    {
        turn = GetComponent<Turn>();
    }

    // Update is called once per frame
    void Update()
    {
     
        if(Input.GetMouseButtonDown(0))
        {
            if (turn.Switch)
            {

                GameObject gg = Instantiate(prefab);
            }
        }
    }
}
