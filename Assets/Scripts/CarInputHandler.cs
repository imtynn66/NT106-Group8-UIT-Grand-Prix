using UnityEngine;

public class CarInputHandler : MonoBehaviour
{
    // Reference to TDCController to set the input vector for the car
    TDCController TDCController;

    // Ki?u input m� xe s? s? d?ng (ph�m m?i t�n ho?c WASD)
    public enum ControlType
    {
        ArrowKeys,
        WASD
    }

    public ControlType controlType = ControlType.ArrowKeys;

    void Awake()
    {
        TDCController = GetComponent<TDCController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        // Ki?m tra ki?u �i?u khi?n v� �p d?ng input t��ng ?ng
        if (controlType == ControlType.ArrowKeys)
        {
            // �i?u khi?n b?ng ph�m m?i t�n
            inputVector.x = Input.GetKey(KeyCode.RightArrow) ? 1 : (Input.GetKey(KeyCode.LeftArrow) ? -1 : 0);
            inputVector.y = Input.GetKey(KeyCode.UpArrow) ? 1 : (Input.GetKey(KeyCode.DownArrow) ? -1 : 0);
        }
        else if (controlType == ControlType.WASD)
        {
            // �i?u khi?n b?ng ph�m WASD
            inputVector.x = Input.GetKey(KeyCode.D) ? 1 : (Input.GetKey(KeyCode.A) ? -1 : 0);
            inputVector.y = Input.GetKey(KeyCode.W) ? 1 : (Input.GetKey(KeyCode.S) ? -1 : 0);
        }

        // G?i input cho TDCController
        TDCController.SetInputVector(inputVector);
    }
}
