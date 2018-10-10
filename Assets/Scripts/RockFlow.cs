using UnityEngine;
using System.Collections;

public class RockFlow : MonoBehaviour {

    private float speed = 0.0001F;
    private float xspeed = 1.0001f;
    private int counter = 0;
    private bool direction = false;

	void FixedUpdate () {
        if(counter == 100)
        {
            direction = !direction;
            speed = 0.0001f;
            xspeed = 0.00001f;
            counter = 0;
        }
        if(direction)
        {
            this.transform.Translate((Vector3.up / 100) * xspeed);
            xspeed += speed;
        }
        else if(!direction)
        {
            this.transform.Translate((Vector3.down / 100) * xspeed);
            xspeed += speed;
        }
       
        counter++;
	}

}
