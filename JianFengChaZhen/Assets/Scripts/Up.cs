using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Up : MonoBehaviour
{
    public int velocity = 1;
    bool ZTSwtich = false;
    GameObject center;
    LineRenderer Line;
    // Start is called before the first frame update
    void Start()
    {
        Line = transform.GetComponent<LineRenderer>();
        center = GameObject.Find("Center");
    }

    // Update is called once per frame
    void Update()
    {
        if(ZTSwtich)
        {
            Line.SetPosition(1, transform.position);

            return;
        }

        transform.Translate(0, velocity*Time.deltaTime, 0);
        if(transform.position.y>=-2.3f)
        {
            transform.position = new Vector3(0, -2.3f, 0);
            ZTSwtich = true;
            transform.parent = center.transform;
        } 
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            center.GetComponent<Turn>().Switch = false;
            Invoke("OnOver", 1);
        }
    }


    private void OnOver()
    {
        SceneManager.LoadScene(0);
    }
}
