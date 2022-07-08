using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
   int ilksecimdegeri;

    void Start()
    {
        ilksecimdegeri = 0;
    
    }

    public void ObjeVer(GameObject objem)
    {

    }

    public void ButonTiklandi(int deger)
    {
        Debug.Log("Buton Tıkladı: Gelen Değer"+deger);

        if (ilksecimdegeri == 0)
        {

            ilksecimdegeri = deger;
        }
        else
        {
            if (ilksecimdegeri == deger)
            {
                Debug.Log("EŞLEŞTİR");
            }
            else
            {
                Debug.Log("Eşleşmedi!!!");
                ilksecimdegeri = 0;

            }
        }
    }
}
