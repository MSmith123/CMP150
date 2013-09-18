using UnityEngine;
using System.Collections;

public class InputReader : MonoBehaviour {

    public Control ControlInput;
    public float MoveSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (ControlInput.IsActive)
        {
            Debug.Log("HELLO");
        }
	
	}
}
