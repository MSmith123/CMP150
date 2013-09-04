using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class CharacterControls
{
    public KeyCode MoveForward = KeyCode.W;
    public KeyCode MoveBack = KeyCode.S;
    public KeyCode MoveLeft = KeyCode.A;
    public KeyCode MoveRight = KeyCode.D;

}

public class MovementBehavior : MonoBehaviour 
{


    public float MoveSpeed = 5f;
    public CharacterControls = new CharacterControls();
    
   
    private float trueSpeed
    {
        get { return (MoveSpeed * Time.deltaTime); }
    }

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(MoveForward.W))
        {
            transform.Translate(transform.forward * trueSpeed);
        }

        if(Input.GetKey(MoveBack.S))
        {
            transform.Translate(transform.backward * trueSpeed);
        }

        if(Input.GetKey(MoveLeft.A))
        {
            transform.Translate(transform.left * trueSpeed);
        }
	
        if(Input.GetKey(MoveRight.D))
        {
            transform.Translate(transform.right * trueSpeed);
        }
	}
}
