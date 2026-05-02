using UnityEngine;

public class PlanePropeller : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
