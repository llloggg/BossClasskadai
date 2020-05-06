using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  kadai : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = new int[5];

        array[0] = 90;
        array[1] = 50;
        array[2] = 70;
        array[3] = 20;
        array[4] = 100;

        for (int i = 0; i < 5; i++)
       {
            Debug.Log(array[i]);
        }


             
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
