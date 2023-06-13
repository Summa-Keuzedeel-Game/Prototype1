using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationSpeed = 4;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, rotationSpeed * Time.deltaTime);
    }
}
