using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindComponets : MonoBehaviour
{
    private GetTheComponets componets;
    void Start()
    {
       // GameObject.FindWithTag(""); // bütün verdiğim taga sahip olan objeleri tarar ilk bulduğunu döner bulamazsa false döner
       // GameObject.FindGameObjectWithTag(""); // bütün verdiğim taga sahip olan objeleri tarar ilk bulduğunu döner
       // GameObject.Find(""); // verdiğimiz adı arar ve bulduğu ilk objeyi döner
      //  GetComponent<object>(); //scriptin takılı olduğu objeyi arar ve ilk bulduğunu geri döner
      //  GetComponentInChildren<object>(); // scriptinm takılı olduğu objenin altınkdati scripti arar ve ilk bulduğunu geri döner
      //  FindObjectOfType<GetTheComponets>(); // bütün oyunu tarar ve ilk bulduğu scripti geri döner
    }

}
