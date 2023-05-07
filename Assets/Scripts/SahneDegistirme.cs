using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneDegistirme : MonoBehaviour
{
   

  public void sahneYukle()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ikiToUc()
    {
        SceneManager.LoadScene("sahne3");
    }
    
}
