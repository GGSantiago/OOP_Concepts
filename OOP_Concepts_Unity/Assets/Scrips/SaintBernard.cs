using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaintBernard : Dog
{
    private float jumpForceMultiplier = 0.9f;
    public float m_jumpForceMultiplier
    {
        get
        {
            return jumpForceMultiplier;
        }
        private set
        {
            jumpForceMultiplier = value;
        }
    }
    protected override IEnumerator Jump()
    {
        while(true){
            yield return new WaitForSeconds(3.0f);
            dogRb.AddRelativeForce(Vector3.up * jumpForce * jumpForceMultiplier, ForceMode.Impulse);
        }
        
    }
}