using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Mouse X") / 10;
        float mY = Input.GetAxis("Mouse Y") / 10;
        float kX = Input.GetAxis("Horizontal") * Time.deltaTime * 5;
        float kY = Input.GetAxis("Vertical") * Time.deltaTime * 5;

        transform.Translate(mX + kX, mY + kY, 0);
    }
}
