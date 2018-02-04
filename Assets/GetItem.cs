using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour {

    //static int WATER_BOTTLE = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if(Input.GetButtonDown("Get Item"))
            {

                if (hit.collider.CompareTag("Salt"))
                {
                    Destroy(hit.collider.gameObject);
                    Debug.Log("[소금]을 주웠습니다.");
                }
                if (hit.collider.CompareTag("Key"))
                {
                    Destroy(hit.collider.gameObject);
                    Debug.Log("[키]를 주웠습니다.");
                }
                if (hit.collider.CompareTag("Oil"))
                {
                    Destroy(hit.collider.gameObject);
                    Debug.Log("[기름]을 주웠습니다.");
                }
                if (hit.collider.CompareTag("Battery"))
                {
                    Destroy(hit.collider.gameObject);
                    Debug.Log("[건전지]를 주웠습니다.");
                }
                if (hit.collider.CompareTag("Lighter"))
                 {
                    Destroy(hit.collider.gameObject);
                    Debug.Log("[라이터]를 주웠습니다.");
                }
                if (hit.collider.CompareTag("Bottle"))
                {
                    Destroy(hit.collider.gameObject);
                    Debug.Log("[물]을 주웠습니다.");
                }
            }
        }
    }
}
