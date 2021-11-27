using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
	
		private int mode;
		private float speed;

	
    // Start is called before the first frame update
    void Start()
    {
		
		mode = Random.Range(1, 5);
		speed = 0.01f;
		

    }    
    

    // Update is called once per frame
    void Update()
    {
		speed += 0.001f;
		
		if (speed >= 4)
			speed = 4;
		
		Vector3 xell = this.transform.position;
		
		if (mode == 1)	{	//top, left
			
			xell.y += speed;
			xell.x -= speed;
			
		}
		
		if (mode == 2)	{	//bot, left
			
			xell.y -= speed;
			xell.x -= speed;
			
		}
		
        if (mode == 3)	{	//top, right
			
			xell.y += speed;
			xell.x += speed;
			
		}
		
		if (mode == 4)	{	//bot, right
			
			xell.y -= speed;
			xell.x += speed;
	
		}
		
		
		
		if (xell.y >= 18.5 && mode == 1)	//Roof
			mode = 2;
		
		if (xell.y >= 18.5 && mode == 3)
			mode = 4;
		
		if (xell.y <= -18.5 && mode == 2)
			mode = 1;
		
		if (xell.y <= -18.5 && mode == 4)
			mode = 3;
		
		this.transform.position = xell;
    }
	
	public void OnCollisionEnter(Collision col)	{
		
		Vector3 zell = this.transform.position;
		
		if (col.gameObject.name == "Left Pad")	{
			
			if (mode == 1)
				mode = 3;
			
			if (mode == 2)
				mode = 4;
		}
		if (col.gameObject.name == "Right Pad")	{
			
			if (mode == 3)
				mode = 1;
			if (mode == 4)
				mode = 2;
		}
		if (col.gameObject.name == "Left" || col.gameObject.name == "Right")	{
			
		mode = Random.Range(1, 5);
		Debug.Log(mode);
		speed = 0.01f;
		
		zell.x = 0f;
		zell.y = 0f;
		
		this.transform.position = zell;
		
			
		}
		
	}
}
