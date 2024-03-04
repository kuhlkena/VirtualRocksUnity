using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    public float speed = 30.0f;

    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        if (device.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxis))
        {
            if (primary2DAxis.y > 0.4f)
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
            if (primary2DAxis.y < -0.4f)
            {
                transform.position -= Vector3.up * speed * Time.deltaTime;
            }
        }
    }
}

