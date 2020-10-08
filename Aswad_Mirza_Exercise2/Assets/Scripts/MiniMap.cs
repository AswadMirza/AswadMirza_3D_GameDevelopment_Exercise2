using UnityEngine;

//Aswad Mirza 991445135
//Obtained from the textbook, with a minor change to just have a public player Gameobject
public class MiniMap : MonoBehaviour
{
    public GameObject mapUI;

    public GameObject playerObject;
    private Transform target;

    void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Player").transform;
        target = playerObject.transform;
    }

    void Update()
    {
        Vector3 compassAngle = new Vector3();
        compassAngle.z = target.transform.eulerAngles.y;
        mapUI.transform.eulerAngles = compassAngle;
    }
}