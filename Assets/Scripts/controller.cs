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

}
