
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMove1 : MonoBehaviour
{
    public Joystick joystick;
    public float Speed;
    public float TurnSpeed;
    public float Acceleration;
    void Update()
    {
        var y = joystick.Vertical/10;
        var x = joystick.Horizontal/10;
        //transform.Rotate(0, inputHorizontal * TurnSpeed * Time.deltaTime, 0);
        //var x = inputHorizontal;
        //var y = inputVertical;
        var z = 0;


        transform.Translate(x,z,y);
        if (Input.GetKey("r"))
            SceneManager.LoadScene(0);

    }
}
