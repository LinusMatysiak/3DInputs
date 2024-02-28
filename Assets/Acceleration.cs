using UnityEngine;

public class Acceleration : MonoBehaviour
{
    public GameObject MoveableObject;
    private Vector3 initialOrientation;
    private void Awake()
    {
        //zapisuje w jakiej pozycji znajdowa³o siê urz¹dzenie
        initialOrientation = Input.acceleration;
        Debug.Log(Input.acceleration);
    }
    private void Update()
    {
        MoveObject();
    }
    void MoveObject()
    {
        Vector3 dir = Input.acceleration - initialOrientation;
        //Debug.Log(dir);
        Debug.Log(dir.magnitude);
        if (dir.magnitude > 0.5)
        {
            dir.Normalize();
            MoveableObject.transform.Rotate(new Vector3(dir.y, 0, -dir.x) * Time.deltaTime);
        }
        //Debug.Log(Input.acceleration);

    }
}