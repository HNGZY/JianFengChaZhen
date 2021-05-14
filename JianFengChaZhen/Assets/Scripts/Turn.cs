using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn : MonoBehaviour
{
    public int velocity = 1,state=1;//1是顺时针，2是逆时针
    public bool Switch = true;
    public int Num = 10;
    public Text T1;
    public Text T2;
    public Text T3;
    public int Index = 0;
    public Text Text;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text").GetComponent<Text>();
        T1 = GameObject.Find("T1").GetComponent<Text>();
        T2 = GameObject.Find("T2").GetComponent<Text>();
        T3 = GameObject.Find("T3").GetComponent<Text>();
        SetText();
        StartCoroutine(Yan());
        StartCoroutine(Yan2());
    }

    void SetText()
    {
        Text.text = Index.ToString();
        //T1.text = Num.ToString();
        //T2.text = (Num-1).ToString();
        //T3.text = (Num-2).ToString();

        if (Num <= 2)
        {
            T3.gameObject.SetActive(false);
        }
        if (Num <= 1)
        {
            T2.gameObject.SetActive(false);
        }
        if (Num <= 0)
        {
            T1.gameObject.SetActive(false);
        }
    }

    public void OnPlay()
    {
        Switch = true;
    }
    public void OnStop()
    {
        Switch = false;
    }

    IEnumerator Yan2()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            velocity += 3;
            if(velocity>=180)
            {
                velocity = 80;
            }
        }
    }

    IEnumerator Yan()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            if(state==1)
            {
                state = 2;
            }
            else
            {
                state = 1;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
      
        if(Switch)
        {
            if (Input.GetMouseButtonDown(0))
            {
                    Num--;
                    Index++;
                    SetText();

            }
            if (state == 1)
            {
                transform.Rotate(0, 0, -Time.deltaTime * velocity);
            }
            else if (state == 2)
            {
                {
                    transform.Rotate(0, 0, Time.deltaTime * velocity);
                }
            }
            
        }
    }
}
