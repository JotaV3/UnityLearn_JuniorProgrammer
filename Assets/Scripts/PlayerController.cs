using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private fields with SerializeField attributo to allow editing in the Unity Inspector
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the player's input for horizontal and vertical axes
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moves the car forward based on the vertical input
        transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);
        // Rotates the car based on the horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
