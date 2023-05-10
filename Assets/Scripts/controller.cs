using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{

    public GameObject[] canvases;
    void Start()
    {
        for(int i = 1; i < canvases.Length; i++)
        {
            canvases[i].SetActive(false);
        }
        
    }

    public void birTowIki()
    {
        canvases[0].SetActive(false);
        canvases[1].SetActive(true);

    }
    public void ikiTowUc()
    {
        canvases[1].SetActive(false);
        canvases[2].SetActive(true);

    }
    public void UcTowDort()
    {
        canvases[2].SetActive(false);
        canvases[3].SetActive(true);

    }
    public void dortToBes()
    {
        canvases[3].SetActive(false);
        canvases[4].SetActive(true);
    }
    public void BesToAlti()
    {
        canvases[4].SetActive(false);
        canvases[5].SetActive(true);
    }
    public void altiToYedi()
    {
        canvases[5].SetActive(false);
        canvases[6].SetActive(true);
    }
    public void yediTwoSekiz()
    {
        canvases[6].SetActive(false);
        canvases[7].SetActive(true);
    }
}
