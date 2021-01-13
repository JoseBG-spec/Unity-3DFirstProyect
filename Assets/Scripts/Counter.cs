using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    private int counter;
    [SerializeField]
    private GameObject counterNumber;
    [SerializeField]
    private GameObject youWin;
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (counter >= 7)
        {
            ShowYouWin();
        }
    }
    public void AddToCounter()
    {
        counter += 1;
        counterNumber.GetComponent<Text>().text = counter.ToString();
    }
    private void ShowYouWin()
    {
        youWin.active = true;
    }
}
