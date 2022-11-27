using UnityEngine;

public class Rigidbody2D_AddRelativeForceXY : MonoBehaviour
{
#if UNITY_2022_OR_NEWER            
    public float forceX;
    public float forceY;

    private Rigidbody2D m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        m_Rigidbody.AddRelativeForceX(forceX);
        m_Rigidbody.AddRelativeForceY(forceY);
    }
#endif
}
