using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType_Fields : MonoBehaviour
{ // everything within these brackets are within the class, MonoBehavior

    // Basics to what goes into the class, MonoBehavior
    // Start:  what happens when you start up the game
    // Update: what happens continously as you play the game

    // Things to Consider:
    // What kind of scope does this container/field need to have? (public or private)
    // naming convention: _(underscore) = private (more common --> default --> what you'll always do unless told otherwise)
    //                    Capital Letter = public
    // What type of data is that container/field? (integer, float, boolean ...)
    [SerializeField] private int _playerHealth = 100;     // SerializeField allows us to manipulate this property within Unity's interface

    private float _playerSpeed = 4.6f;                    //f is required to establish that it is a float
    private bool _isGrounded = true;                      // if he is on the ground, true | if he is in the air, false
    [SerializeField] private string _playerName = "Greg";
    private Vector3 _playerPos = new Vector3(0f, 0f, 0f); // begin player centered to scene 

    // Set up variable to mess with componenets inside the Inspector that is in the Unity Interface
    private Rigidbody2D _rb; // right now this is just an empty container that we will use to mess with the physics

    // Creating two propertie:
    public int PlayerHealth
    {
        // must have one get and one set
        get
        {
            return _playerHealth;
        }
        set
        {
            _playerHealth = value;
        }
    }

    public string DisplayHealth
    {
        get
        {
            // if you want people to read the value but not write over it, you can remove the set
            string health = _playerHealth.ToString() + "%";
            return health; // return a player health
        }
    }

    private void Start() 
    {
        _rb = gameObject.GetComponent<Rigidbody2D>(); // grab the component Rigidbody 2D with relation to the variable _rb
                                                      // ("it has all the physics attached to it now and so now we can manipulate it")
        _rb.gravityScale = 0;                         // Now we can change the gravity acting on our code

        // Video 4 Notes:
        // the best way to manipulate the fields (_playerSpeed, _playerHealth, etc) is to edit their properties
        // this helps us set limits to the fields (_playerHealth should never be > 100) (this is done within the set method)
        
        PlayerHealth = 50; // now we are changing the property rather than the field using the set method 
        Debug.Log(DisplayHealth); // displays DisplayHealth in the Console
    }

}
