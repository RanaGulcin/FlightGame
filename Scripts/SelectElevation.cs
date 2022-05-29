using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectElevation : MonoBehaviour
{
    public GameObject _back;
    public GameObject _right;
    public GameObject _left;
    public GameObject buton;
    void Start()
    {
        Baslangic();
    }

    private void Baslangic()
    {
        _back.SetActive(false);
        _right.SetActive(false);
        _left.SetActive(false);
        buton.SetActive(true);
    }
    public void Back()
    {
        _back.SetActive(true);
        _right.SetActive(false);
        _left.SetActive(false);
        buton.SetActive(false);
    }

    public void Right()
    {
        _back.SetActive(false);
        _right.SetActive(true);
        _left.SetActive(false);
        buton.SetActive(false);
    }
    public void Left()
    {
        _back.SetActive(false);
        _right.SetActive(false);
        _left.SetActive(true);
        buton.SetActive(false);
    }
   

}
