using UnityEngine;
using System.Collections;
using System;

public static class Extensions
{
    public static bool Has<T>(this Enum type, T value)
    {
        try
        {
            return (((int)(object)type & (int)(object)value) == (int)(object)value);
        }
        catch
        {
            return false;
        }
    }
}

[RequireComponent(typeof(CharacterController))]
public class PlatformController : MyDerivedMono 
{
    public Control MoveLeft,
                   MoveRight,
                   Jump;

    public float Gravity = 9,
                 JumpStrength = 20,
                 MoveSpeed = 30;

    private CharacterController controller;

    CollisionFlags prevFlags;

	// Use this for initialization
	void Start() 
    {
        controller = GetComponent<CharacterController>();
        if (controller == null)
        {
            Debug.LogError("No character controller found on: " + name);
        }
	
	}
	
	// Update is called once per frame
	void Update() 
    {
        Vector3 moveVec = Vector3.zero;

        if (MoveLeft.IsActive)
        {
            moveVec.x -= MoveSpeed;
        }
        if (MoveLeft.IsActive)
        {
            moveVec.x += MoveSpeed;
        }

        if (!prevFlags.Has(CollisionFlags.CollidedBelow))
        {
            moveVec.y -= Gravity;
        }
        
        prevFlags = controller.Move(moveVec * Time.deltaTime);
      
        /* if(Flags.Has(CollisionFlags.CollidedSides))
        {
            Debug.Log("I HIT SOMETHING..ON THE SIDE!!");
        }*/
	
	}
}
