using UnityEngine;
using UnityEngine.InputSystem;
public class ChaserPushBack : MonoBehaviour
{
    public float pushBackValue = 1f;
    public float chasingValue = 2f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * chasingValue * (Time.deltaTime * 2);
    }
    public void PushItBack()
    {
        transform.position -= Vector3.right * pushBackValue;
    }
}
