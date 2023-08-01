using UnityEngine;
using System.IO;


using System.Net;
using UnityEngine.Networking;
using UnityEngine.InputSystem;
using System.Collections;
using System.Reflection;

public class Manipulate2: MonoBehaviour {

    public Transform avatar_trans;

    public FrameData jsonFrameData;

    public HttpWebRequest request;
    public HttpWebResponse response;
    public string responseString;
    public Gamepad gamepad;


    /* Transforms of the Joints of the avatar*/

    public static Transform root;
    public static Transform LeftFoot;
    public static Transform RightForeArm;
    public static Transform Head_End;
    public static Transform RightArm;
    public static Transform Neck;
    public static Transform RightUpLeg;
    public static Transform LeftHand;
    public static Transform Spine;
    public static Transform LeftToe_End;
    public static Transform LeftLeg;
    public static Transform RightFoot;
    public static Transform RightHand;
    public static Transform LeftForeArm;
    public static Transform LeftHand_End;
    public static Transform LeftArm;
    public static Transform LeftUpLeg;
    public static Transform RightToe_End;
    public static Transform RightHand_End;
    public static Transform RightLeg;



    void Start() {

        System.Diagnostics.Process.Start("NN_Server\\run_minimized.lnk");
        
        gamepad = Gamepad.current;
        
        JointFunctions2.configureJoints(avatar_trans);
        

        StartCoroutine(requestAndSetJoints());
        
    }
    void FixedUpdate() {
        
        if (gamepad.yButton.wasPressedThisFrame)
        {
            System.Diagnostics.Process.Start("NN_Server\\stop.bat");
            
        }

        if (gamepad.xButton.wasPressedThisFrame)
        {
            System.Diagnostics.Process.Start("NN_Server\\run_minimized.lnk");
        }

        StartCoroutine(requestAndSetJoints());
    }

    void OnApplicationQuit()
    {
        System.Diagnostics.Process.Start("NN_Server\\stop.bat");
    }

    

    IEnumerator requestAndSetJoints()
    {
        Vector2 stickL = gamepad.leftStick.ReadValue();
        string control_string = "?joy_x="+ stickL.x.ToString() + "&joy_y=" + stickL.y.ToString() + "&kick=" + gamepad.aButton.wasPressedThisFrame;
        UnityWebRequest www = UnityWebRequest.Get("http://localhost:8000/frame"+control_string);
        yield return www.SendWebRequest();



        if (www.result != UnityWebRequest.Result.Success)
        {
            if (www.responseCode == 500)
            {
                StartCoroutine(resetRequest());
            }
            else
            {
                // Debug.Log(www.error);
            }

        }
        else
        {
            responseString = www.downloadHandler.text;
            jsonFrameData = JsonUtility.FromJson<FrameData>(responseString);
            JointFunctions2.setJointsFromData(jsonFrameData);
        }
    }

    IEnumerator resetRequest()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://localhost:8000/frame/reset");
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);

        }
        else
        {
            responseString = www.downloadHandler.text;
            Debug.Log(responseString);
        }
    }

    IEnumerator setmotionRequest(int number)
    {
        UnityWebRequest www = UnityWebRequest.Get("http://localhost:8000/motion/" + number); // set motion @depricated
        yield return www.SendWebRequest();

        

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);

        }
        else
        {
            responseString = www.downloadHandler.text;
            Debug.Log(responseString);
        }
    }


}


