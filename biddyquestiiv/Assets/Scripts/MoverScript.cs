using UnityEngine;
using System.Collections;

public class MoverScript : MonoBehaviour {

	bool _movingUp = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(_movingUp)
		{
			this.rigidbody2D.velocity = new Vector2(0,1);
		}
		else
		{
			this.rigidbody2D.velocity = new Vector2(0,-1);
		}

		if(Input.GetKeyDown(KeyCode.Space))
		{
			if(_movingUp)
			{
				_movingUp = false;
			}
			else
			{
				_movingUp = true;
			}
		}
	}
}
