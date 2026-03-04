using UnityEngine;

public class FirstCode : MonoBehaviour
{
    public Rigidbody ballRigidbody;
    public Transform ballTransform;
    public GameObject arrow;
    public int throwForce;
    public bool isThrown;

    void Start()
    {
        
    }


    void Update()
    {

        if (isThrown)
        {
            return;
        }


        if ( Input.GetKeyDown(KeyCode.Space) )
        {
            isThrown = true;
            arrow.SetActive(false);        
            ballRigidbody.AddForce( arrow.transform.forward * throwForce );            
        }

        if ( ballTransform.position.x > -0.45f)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                ballTransform.Translate(-Time.deltaTime, 0, 0);
            }
        }

        if (ballTransform.position.x < 0.45f)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                ballTransform.Translate(Time.deltaTime, 0, 0);
            }
        }

    }


    void OnTriggerEnter(Collider other)
    {     
        Debug.Log("Something enter the trigger");
        
        gameObject.SetActive(false);

    }

}
