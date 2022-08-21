using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{

    [SerializeField] protected float weight = 4.0f;
     public float m_weight 
     {
        get{
            return weight;
        }
        set{
            weight = value;
        }
    }
    [SerializeField] protected float jumpForce = 10.0f;
    public float m_jumpForce 
     {
        get{
            return jumpForce;
        }
        set{
            jumpForce = value;
        }
    }
    protected Rigidbody dogRb;
    // Start is called before the first frame update
    void Start()
    {
        dogRb = GetComponent<Rigidbody>();
        Debug.Assert(dogRb !=  null);
        StartCoroutine(Jump());

    }

    // Update is called once per frame
    void Update()
    {
    }

    protected virtual IEnumerator  Jump()
    {
        while(true){
        yield return new WaitForSeconds(3.0f);
        dogRb.AddRelativeForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
    }
}
