using DG.Tweening;

using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class SpiderManController : MonoBehaviour
{

    private bool isTriggerPressed = false;
    public LineRenderer RightlineRenderer;
    public LineRenderer leftLineRenderer;
    public GameObject webLineRenderer;
    public Vector3 hitPoint;
    public Vector3 hitPoint2;
    public float duration = 2.0f;



    private void Update()
    {
        bool isTriggerDownRight = false;
        bool isTriggerDownLeft = false;
        InputDevice deviceRight = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        InputDevice deviceLeft = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);

        deviceRight.TryGetFeatureValue(CommonUsages.triggerButton, out isTriggerDownRight);
        deviceLeft.TryGetFeatureValue(CommonUsages.triggerButton, out isTriggerDownLeft);


        if (isTriggerDownRight)
        {
            if (!isTriggerPressed)
            {


                if (Physics.Raycast(RightlineRenderer.transform.position, RightlineRenderer.transform.forward, out RaycastHit hit))
                {
                    Vector3 startPoint = RightlineRenderer.transform.position;
                    Vector3 endPoint = hit.point;


                    GameObject lineObject = new GameObject("Line");
                    LineRenderer lineRenderer = lineObject.AddComponent<LineRenderer>();

                    lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
                    lineRenderer.startColor = Color.white;
                    lineRenderer.endColor = Color.white;
                    lineRenderer.startWidth = 0.2f;
                    lineRenderer.endWidth = 0.1f;
                    lineRenderer.positionCount = 2;


                    lineRenderer.SetPosition(0, startPoint);
                    lineRenderer.SetPosition(1, endPoint);



                    hitPoint = hit.point;
                    Debug.Log(hitPoint);
                    transform.DOMove(hitPoint, duration)
                         .OnComplete(() =>
                         {
                             Destroy(lineObject);

                         });


                }

            }

            isTriggerPressed = true;
        }
        else if (isTriggerDownLeft)
        {
            if (!isTriggerPressed)
            {
                if (Physics.Raycast(leftLineRenderer.transform.position, leftLineRenderer.transform.forward, out RaycastHit hit2))
                {
                    Vector3 startPoint = RightlineRenderer.transform.position;
                    Vector3 endPoint = hit2.point;
                    GameObject lineObject = new GameObject("Line");
                    LineRenderer lineRenderer = lineObject.AddComponent<LineRenderer>();

                    lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
                    lineRenderer.startColor = Color.white;
                    lineRenderer.endColor = Color.white;
                    lineRenderer.startWidth = 0.2f;
                    lineRenderer.endWidth = 0.1f;
                    lineRenderer.positionCount = 2;


                    lineRenderer.SetPosition(0, startPoint);
                    lineRenderer.SetPosition(1, endPoint);



                    hitPoint2 = hit2.point;
                    Debug.Log(hitPoint2);

                    transform.DOMove(hitPoint2, duration)
                        .OnComplete(() =>
                        {
                            Destroy(lineObject);

                        });



                }

            }
            isTriggerPressed = true;
        }


        else
        {

            hitPoint = Vector3.zero;
            isTriggerPressed = false;

        }







    }
}

