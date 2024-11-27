using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;

    private void Start() // Note: Case-sensitive; "start" should be "Start"
    {
        offset = transform.position - player.position;
    }

    private void Update()
    {
        Vector3 targetPos = player.position + offset;
        targetPos.x = 0; // Lock the x-axis to 0
        transform.position = targetPos; // Assign the entire Vector3 to transform.position
    }
}
