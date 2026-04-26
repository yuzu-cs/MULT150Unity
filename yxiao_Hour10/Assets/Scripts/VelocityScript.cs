//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class VelocityScript : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
using UnityEngine;
public class VelocityScript : MonoBehaviour
{
    public float startSpeed = 50f;
    void Start()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody> ();
        rigidBody.velocity = new Vector3(startSpeed, 0, startSpeed);
    }
}