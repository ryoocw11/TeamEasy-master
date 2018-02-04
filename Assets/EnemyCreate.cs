using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
    public GameObject EnemyManager;
    public Transform kitten;

    public Transform[] EnemyCreatePoint;



    public List<GameObject> EnemyList = new List<GameObject>();


    void Enemy_Create()
    {

        int randomX = Random.Range(0, 6); //고양이 생성 위치 범위
        kitten.transform.position = new Vector3(EnemyCreatePoint[randomX].transform.position.x,1, EnemyCreatePoint[randomX].transform.position.z);

    }
    //    private int EnmeyMaxCount = 3;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Enemy_Create", 3, 1);
      //  int randomX = Random.Range(1, 3);

       // kitten.transform.position = new Vector3(EnemyCreatePoint[randomX].transform.position.x, 1   , EnemyCreatePoint[randomX].transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
    }


}