using UnityEngine;
using UnityEngine.UI;

public class CameraBehavior : MonoBehaviour
{

    public GameObject MainCamera;

    #region FixedLocations

    public Vector3 position1;
    public Vector3 position2;
    public Vector3 position3;
    public Vector3 position4;

    #endregion

    #region Buttons

    public Button CameraButton1;
    public Button CameraButton2;
    public Button CameraButton3;
    public Button CameraButton4;

    #endregion

    private int currentCamera = 1;


    // Start is called before the first frame update
    void Start()
    {
        MainCamera.transform.position = position1;
        MainCamera.transform.rotation = Quaternion.Euler(25, 225, 0);

        Debug.Log("Camera set on position 1");

        CameraButton1.onClick.AddListener(() =>
        {
            if(currentCamera != 1)
            {
                currentCamera = 1;
                MainCamera.transform.position = position1;
                MainCamera.transform.rotation = Quaternion.Euler(25, 225, 0);
            };
        });
        CameraButton2.onClick.AddListener(() =>
        {
            if (currentCamera != 2)
            {
                currentCamera = 2;
                MainCamera.transform.position = position2;
                MainCamera.transform.rotation = Quaternion.Euler(25, 135, 0);
            };
        });
        CameraButton3.onClick.AddListener(() =>
        {
            if (currentCamera != 3)
            {
                currentCamera = 3;
                MainCamera.transform.position = position3;
                MainCamera.transform.rotation = Quaternion.Euler(25, -45, 0);
            };
        });
        CameraButton4.onClick.AddListener(() =>
        {
            if (currentCamera != 4)
            {
                currentCamera = 4;
                MainCamera.transform.position = position4;
                MainCamera.transform.rotation = Quaternion.Euler(25, 45, 0);
            };
        });


    }

    // Update is called once per frame
    void Update()
    {
        
    }





}
