using UnityEngine;

public class CameraMoment : MonoBehaviour
{
    [SerializeField] private Transform target;

    // Update is called once per frame
    private void Update()
    {
        if(transform.position.y < target.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
        }
    }
}
