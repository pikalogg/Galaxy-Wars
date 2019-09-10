using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage : MonoBehaviour
{
    public static User user;

    // Start is called before the first frame update
    void Start()
    {
        user = new User();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    public void Click()
    {
        Application.LoadLevel("GamePlay");
    }
}
