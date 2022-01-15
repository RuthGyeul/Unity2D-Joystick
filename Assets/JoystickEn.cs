using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickEn : MonoBehaviour
{
    public GameObject Character;
    MovementManager Move;

    void Start()
    {
        Move = Character.GetComponent<MovementManager>();
    }

    void Update(){}

    public void LeftD()
    {
        Move.Left_Key = true;
    }
    public void LeftU()
    {
        Move.Left_Key = false;
    }
    public void RightD()
    {
        Move.Right_Key = true;
    }
    public void RightU()
    {
        Move.Right_Key = false;
    }
    public void UpD()
    {
        Move.Up_Key = true;
    }
    public void UpU()
    {
        Move.Up_Key = false;
    }
    public void DownD()
    {
        Move.Down_Key = true;
    }
    public void DownU()
    {
        Move.Down_Key = false;
    }
}
