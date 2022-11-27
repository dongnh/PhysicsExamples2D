using UnityEngine;

public class Rigidbody2D_VelocityXY : MonoBehaviour
{
#if UNITY_2022_OR_NEWER            
    public float velocityX;
    public float velocityY;

    private Rigidbody2D m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        m_Rigidbody.velocityX = velocityX;
        m_Rigidbody.velocityY = velocityY;
    }
#endif
}
