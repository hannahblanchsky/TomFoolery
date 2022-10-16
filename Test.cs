using System.Collections; // these first three are namespaces, which hold a collection of classes
using System.Collections.Generic; 
using UnityEngine;

// C# is a object oriented program (namespaces --> classes --> objects)
//      we can reference namespaces to utilize pre-existing code
// Note: file name must match public class name (in turquoise)
// we can "derive" from MonoBehavior to build our script (Monobehavior is a class that exists within the namespace UnityEngine)


public class Test : MonoBehaviour
{
    // Set up physics for the asset(s) using rigidbody 
    Rigidbody2D _rb; //declare the variable _rb which is 

    float _walkSpeed; // walk speed of player
    float _inputHorizontal; 
    // Start is called before the first frame update 
    void Start() 
    {
        _rb = gameObject.GetComponent<Rigidbody2D>(); // Assign "the physics of the player" to the rigid body variable _rb

        _walkSpeed = 5.5f; // f is for float

    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal"); // this changes based on what we press on the keyboard (left and right arrow keys)
                                                           // (Left = -1, Right = 1, Still = 0)

        if (_inputHorizontal != 0)
        {
            // If the input != 0, then move the player along the x-axis
            _rb.AddForce(new Vector2(_inputHorizontal * _walkSpeed, 0f));

        }
        
    }
}
