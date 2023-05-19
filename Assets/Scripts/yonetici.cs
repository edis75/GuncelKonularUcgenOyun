using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetici : MonoBehaviour
{

    public AudioSource dogru;
    public GameObject tebrikPic;
    public GameObject resim;
    Animator anim;

    int yerlestirilen_parca = 0;
    int toplam_puzle = 7;
    int mor = 8;
    int kahverengi = 7;
    int pembe = 9;
    int mavi = 7;
    int yesil = 7;
    public GameObject mavi_ucgen;
    public GameObject kahverengi_ucgen;
    public GameObject mor_ucgen;
    public GameObject pembe_ucgen;
    public GameObject sari_ucgen;
    public GameObject yesil_ucgen;



    void Start()
    {
        kahverengi_ucgen.SetActive(false);
        mor_ucgen.SetActive(false);
        pembe_ucgen.SetActive(false);
        sari_ucgen.SetActive(false);
        yesil_ucgen.SetActive(false);

        resim.SetActive(false);


        anim =tebrikPic.GetComponent<Animator>();
        anim.SetInteger("index", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sayi_artir()
    {
        // mavi üçgeni temsil eder
        yerlestirilen_parca++;
        if (yerlestirilen_parca == toplam_puzle)
        {
            dogru.Play();
            anim.SetInteger("index", 1);
            yerlestirilen_parca = 0;
            mavi_ucgen.SetActive(false);
            mor_ucgen.SetActive(true);
            Debug.Log("Baþarý ile hepsini yerleþtirdin Tebrikler mavi");
           //
        }
    }
    public void sayi_artir_mor()
    {

        yerlestirilen_parca++;
        if (yerlestirilen_parca == mor)
        {
            dogru.Play();
            anim.SetInteger("index", 2);
            yerlestirilen_parca = 0;
            Debug.Log("Baþarý ile hepsini yerleþtirdin Tebrikler mor");
            mor_ucgen.SetActive(false);
            kahverengi_ucgen.SetActive(true);
            
            //
        }
    }
    public void sayi_artir_kahverengi()
    {

        yerlestirilen_parca++;
        if (yerlestirilen_parca == kahverengi)
        {
            dogru.Play();
            anim.SetInteger("index", 3);
            yerlestirilen_parca = 0;
            kahverengi_ucgen.SetActive(false);
            pembe_ucgen.SetActive(true);
            Debug.Log("Baþarý ile hepsini yerleþtirdin Tebrikler kahverengi");
            //
        }
    }
    public void sayi_artir_pembe()
    {

        yerlestirilen_parca++;
        if (yerlestirilen_parca == pembe)
        {
            dogru.Play();
            anim.SetInteger("index", 4);
            yerlestirilen_parca = 0;
            pembe_ucgen.SetActive(false);
            sari_ucgen.SetActive(true);
            Debug.Log("Baþarý ile hepsini yerleþtirdin Tebrikler pembe");
            //
        }
    }
    public void sayi_artir_sari()
    {

        yerlestirilen_parca++;
        if (yerlestirilen_parca == mavi)
        {
            dogru.Play();
            anim.SetInteger("index", 5);
            yerlestirilen_parca = 0;
            sari_ucgen.SetActive(false);
            yesil_ucgen.SetActive(true);
            Debug.Log("Baþarý ile hepsini yerleþtirdin Tebrikler Sari");
            //
        }
    }
    public void sayi_artir_yesil()
    {

        yerlestirilen_parca++;
        if (yerlestirilen_parca == yesil)
        {
            dogru.Play();
            anim.SetInteger("index", 6);
            yerlestirilen_parca = 0;
            Debug.Log("Baþarý ile hepsini yerleþtirdin Tebrikler yesil");
            resim.SetActive(true);
            //
        }
    }
}
