using UnityEngine;

public class SystemInteractions : MonoBehaviour
{
    public float move = 0.01f;
    public float pushBack = 0.02f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.x += move;
        transform.position = newPos;

        if (transform.position.x > -1)
        {          
            move = 0;
        }
    }
}
