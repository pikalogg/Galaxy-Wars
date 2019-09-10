using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Spaceship spaceship;
    // Start is called before the first frame update
    void Start()
    {
        spaceship = Manage.user.spaceshipSelect; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
