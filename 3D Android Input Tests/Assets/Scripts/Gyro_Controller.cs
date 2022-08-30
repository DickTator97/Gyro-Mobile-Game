using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro_Controller : MonoBehaviour
{
    Gyroscope my_gyro;
    Quaternion Original_Rotation;
    
    // Start is called before the first frame update
    void Start()
    {
        my_gyro = Input.gyro;
        my_gyro.enabled = true;
        Debug.Log(my_gyro.enabled);
        Original_Rotation = my_gyro.attitude;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = my_gyro.attitude*Original_Rotation;
      
    }
}
