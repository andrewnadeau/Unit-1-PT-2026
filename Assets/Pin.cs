using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isKnockedDown;
    void Start()
    {
        
    }

    void Update()
    {

        if( Vector3.Angle(Vector3.up, transform.up) > 10f )
        {
            isKnockedDown = true;
        }
        
    }
}
