using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LS : MonoBehaviour
{
    // Start is called before the first frame update
	
	public static int count;
	
    void Start()
    {
		
		count = 0;
		
    }

    // Update is called once per frame
    void Update()
    {
		
		gameObject.GetComponent<Text>().text = "" + count;
		
    }
	
	
}
