using UnityEngine; //Libreria general de unity
using UnityEngine.InputSystem; //Libreria de inputs

public class Script : MonoBehaviour
{

    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0);

        if (Keyboard.current.wKey.isPressed)
        {
            direction.y = 1f;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            direction.x = -1f;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            direction.y = -1f;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            direction.x = 1f;
        }

        transform.position = transform.position + direction * speed * Time.deltaTime;

        // first step: read user impus
        // second step: generate direction
        // third step: apply the movement
        
    }
}
