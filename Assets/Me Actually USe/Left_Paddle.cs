using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left_Paddle : MonoBehaviour
{

    protected Joystick [] js;

    // Start is called before the first frame update
    void Start()
    {

        js = FindObjectsOfType<Joystick>();

    }

    // Update is called once per frame
    void Update()
    { 

        Vector3 position = this.transform.position;
		if (Input.GetKey(KeyCode.S))
        {
            
            position.y -= 0.3f;
            
        }
        if (Input.GetKey(KeyCode.W))
        {
            
            position.y += 0.3f;
            
        }
		
		if (position.y >= 17)	{	
			position.y = 17;
		}
		if (position.y <= -17)	{
			position.y = -17;
		}
		
		this.transform.position = position;

        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(rigidbody.velocity.x, js[0].Vertical * 10f, rigidbody.velocity.z);

        
        

    }
}
