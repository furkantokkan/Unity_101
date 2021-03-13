using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMembers : MonoBehaviour
{
    //Data members
    public float floatDataMember;
    public int intDataMember;
    public string stringDataMember;
    public List<GameObject> listDataMember = new List<GameObject>();
    //var - object = herşey
    //Unity Members
    public Transform transformDataMember;
    public GameObject gameObjectDataMember;
    public Vector3 vector3DataMember;
    public Vector2 vector2DataMember;
    public Rigidbody rigidbodyDataMember;
    public Rigidbody2D rigidbody2DDataMember;
    public Collider colliderDataMember;
    public Collider2D collider2DDataMember;
    public Quaternion quaternionDataMember;
    public enumDataMember enumData = enumDataMember.testEnum1;
    public enum enumDataMember
    {
        testEnum1,
        testenum2
    }
    // oyun başlamadan önceki kara de 1 kare(1)
    private void Awake()
    {

    }
    // ikinci kare de oyunun başladığı ilk kare (2)
    void Start()
    {

    }
    //obje aktif olduktan sonra çalışır (3)
    private void OnEnable()
    {
    }

    //Oyun boyunca çalışır (oyun bitene kadar 3 den sonra başlar)
    void Update()
    {

    }
}
