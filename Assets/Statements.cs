using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statements : MonoBehaviour
{
    public string key = "keycode";
    void Start()
    {

        for (int i = 0; i < 5; i++)
        {
            print(i);
        }

        foreach (GameObject item in FindObjectsOfType<GameObject>())
        {
            print(item.name);
        }
    }
    void Update()
    {
        // == eşit mi?
        // != eşi değilse
        // > büyükse
        // < küçükse
        // >= büyük veya eşitse
        // <= küçük veya eşitse
        // && solumdaki ve sağımdaki doğru ise
        // || solumdaki yada sağımdaki doğru ise

        if (key != "keycode")
        {
            print("eşit değil");
        }
        else if (key == "keycode")
        {
            print("eşit");
        }
    }
}
