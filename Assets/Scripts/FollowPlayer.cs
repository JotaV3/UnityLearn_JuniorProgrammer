using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // private field with SerializeField attribute to allow editing in the Unity Inspector
    [SerializeField] private Transform playerTransform;

    // private field
    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Calculate the initial offset between the camera and the player
        offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Update the camera's position to follow the player while maintaining the initial offsets
        transform.position = playerTransform.position + offset;
    }
}
