using UnityEngine;
using UnityEngine.UIElements;

public class CollectableRotate : MonoBehaviour
{
    [SerializeField] int rotateSpeed = 1;

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
