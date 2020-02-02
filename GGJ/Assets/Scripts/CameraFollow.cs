using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    public Transform Obstruction;

    float zoomSpeed = 2f;

    public Material matToAssign;
    public Material tempMat;

    public Transform lastObstruct = null;
    // Start is called before the first frame update
    void Start()
    {
        Obstruction = target;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
        ViewObstructed();
    }

    private void Update()
    {
        ViewObstructed();
    }

    void ViewObstructed()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, target.position - transform.position, out hit, 100f))
        {
            if(hit.collider.gameObject.tag != "Player")
            {
                Obstruction = hit.transform;
                //if(Obstruction != lastObstruct)
                //tempMat = Obstruction.gameObject.GetComponent<MeshRenderer>().material;
                Obstruction.gameObject.GetComponent<MeshRenderer>().material = matToAssign; //shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                lastObstruct = Obstruction;
                //if(Vector3.Distance(Obstruction.position, transform.position) >= 3f && Vector3.Distance(transform.position, target.position) >= 1.5f)
                //{
                //    transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime);
                //}
            }
            else
            {
                Debug.Log(Obstruction.gameObject.name);
                lastObstruct.gameObject.GetComponent<MeshRenderer>().material = tempMat; // = UnityEngine.Rendering.ShadowCastingMode.On;
                //if (Vector3.Distance(transform.position, target.position) > 4.5f)
                //{
                //    transform.Translate(Vector3.back * zoomSpeed * Time.deltaTime);
                //}
            }
        }
    }
}
