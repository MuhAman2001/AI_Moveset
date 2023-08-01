using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public static class JointFunctions2
{


    public static void configureJoints(Transform avatar_transform)
    {
        // Manipulate2.root = avatar_transform.Find("root");
        // Manipulate2.Spine = avatar_transform.Find("Spine");
        // Manipulate2.LeftHand = avatar_transform.Find("LeftHand");
        // Manipulate2.Neck = avatar_transform.Find("Neck");
        // Manipulate2.RightLeg = avatar_transform.Find("RightLeg");
        // Manipulate2.LeftLeg = avatar_transform.Find("LeftLeg");
        // Manipulate2.LeftForeArm = avatar_transform.Find("LeftForeArm");
        // Manipulate2.LeftToe_End = avatar_transform.Find("LeftToe_End");
        // Manipulate2.RightUpLeg = avatar_transform.Find("RightUpLeg");
        // Manipulate2.LeftArm = avatar_transform.Find("LeftArm");
        // Manipulate2.Head_End = avatar_transform.Find("Head_End");
        // Manipulate2.RightHand_End = avatar_transform.Find("RightHand_End");
        // Manipulate2.RightForeArm = avatar_transform.Find("RightForeArm");
        // Manipulate2.RightArm = avatar_transform.Find("RightArm");
        // Manipulate2.RightToe_End = avatar_transform.Find("RightToe_End");
        // Manipulate2.RightFoot = avatar_transform.Find("RightFoot");
        // Manipulate2.LeftFoot = avatar_transform.Find("LeftFoot");
        // Manipulate2.LeftUpLeg = avatar_transform.Find("LeftUpLeg");
        // Manipulate2.RightHand = avatar_transform.Find("RightHand");
        // Manipulate2.LeftHand_End = avatar_transform.Find("LeftHand_End");


        Manipulate2.root = avatar_transform.Find("root");
        Manipulate2.Spine = Manipulate2.root.Find("Spine");
        Manipulate2.LeftHand = Manipulate2.root.Find("LeftHand");
        Manipulate2.Neck = Manipulate2.root.Find("Neck");
        Manipulate2.RightLeg = Manipulate2.root.Find("RightLeg");
        Manipulate2.LeftLeg = Manipulate2.root.Find("LeftLeg");
        Manipulate2.LeftForeArm = Manipulate2.root.Find("LeftForeArm");
        Manipulate2.LeftToe_End = Manipulate2.root.Find("LeftToe_End");
        Manipulate2.RightUpLeg = Manipulate2.root.Find("RightUpLeg");
        Manipulate2.LeftArm = Manipulate2.root.Find("LeftArm");
        Manipulate2.Head_End = Manipulate2.root.Find("Head_End");
        Manipulate2.RightHand_End = Manipulate2.root.Find("RightHand_End");
        Manipulate2.RightForeArm = Manipulate2.root.Find("RightForeArm");
        Manipulate2.RightArm = Manipulate2.root.Find("RightArm");
        Manipulate2.RightToe_End = Manipulate2.root.Find("RightToe_End");
        Manipulate2.RightFoot = Manipulate2.root.Find("RightFoot");
        Manipulate2.LeftFoot = Manipulate2.root.Find("LeftFoot");
        Manipulate2.LeftUpLeg = Manipulate2.root.Find("LeftUpLeg");
        Manipulate2.RightHand = Manipulate2.root.Find("RightHand");
        Manipulate2.LeftHand_End = Manipulate2.root.Find("LeftHand_End");
    }

    public static void setJointsFromData(FrameData data)
    {
    
    // Vector3 root_pos = data.jointdata[0].get_joint("root");
    // Manipulate2.root.position = new Vector3(root_pos.x, root_pos.y, root_pos.z);

    // Vector3 RightArm_pos = data.jointdata[0].get_joint("RightArm");
    // Manipulate2.RightArm.position = new Vector3(RightArm_pos.x, RightArm_pos.y, RightArm_pos.z);

    // Vector3 LeftToe_End_pos = data.jointdata[0].get_joint("LeftToe_End");
    // Manipulate2.LeftToe_End.position = new Vector3(LeftToe_End_pos.x, LeftToe_End_pos.y, LeftToe_End_pos.z);
    
    // Vector3 LeftForeArm_pos = data.jointdata[0].get_joint("LeftForeArm");
    // Manipulate2.LeftForeArm.position = new Vector3(LeftForeArm_pos.x, LeftForeArm_pos.y, LeftForeArm_pos.z);
    
    // Vector3 Head_End_pos = data.jointdata[0].get_joint("Head_End");
    // Manipulate2.Head_End.position = new Vector3(Head_End_pos.x, Head_End_pos.y, Head_End_pos.z);
    
    // Vector3 RightLeg_pos = data.jointdata[0].get_joint("RightLeg");
    // Manipulate2.RightLeg.position = new Vector3(RightLeg_pos.x, RightLeg_pos.y, RightLeg_pos.z);
    
    // Vector3 RightToe_End_pos = data.jointdata[0].get_joint("RightToe_End");
    // Manipulate2.RightToe_End.position = new Vector3(RightToe_End_pos.x, RightToe_End_pos.y, RightToe_End_pos.z);
    
    // Vector3 RightUpLeg_pos = data.jointdata[0].get_joint("RightUpLeg");
    // Manipulate2.RightUpLeg.position = new Vector3(RightUpLeg_pos.x, RightUpLeg_pos.y, RightUpLeg_pos.z);
    
    // Vector3 LeftHand_pos = data.jointdata[0].get_joint("LeftHand");
    // Manipulate2.LeftHand.position = new Vector3(LeftHand_pos.x, LeftHand_pos.y, LeftHand_pos.z);
    
    // Vector3 RightHand_End_pos = data.jointdata[0].get_joint("RightHand_End");
    // Manipulate2.RightHand_End.position = new Vector3(RightHand_End_pos.x, RightHand_End_pos.y, RightHand_End_pos.z);
    
    // Vector3 LeftFoot_pos = data.jointdata[0].get_joint("LeftFoot");
    // Manipulate2.LeftFoot.position = new Vector3(LeftFoot_pos.x, LeftFoot_pos.y, LeftFoot_pos.z);
    
    // Vector3 LeftHand_End_pos = data.jointdata[0].get_joint("LeftHand_End");
    // Manipulate2.LeftHand_End.position = new Vector3(LeftHand_End_pos.x, LeftHand_End_pos.y, LeftHand_End_pos.z);
    
    // Vector3 LeftLeg_pos = data.jointdata[0].get_joint("LeftLeg");
    // Manipulate2.LeftLeg.position = new Vector3(LeftLeg_pos.x, LeftLeg_pos.y, LeftLeg_pos.z);
    
    // Vector3 Neck_pos = data.jointdata[0].get_joint("Neck");
    // Manipulate2.Neck.position = new Vector3(Neck_pos.x, Neck_pos.y, Neck_pos.z);
    
    // Vector3 RightHand_pos = data.jointdata[0].get_joint("RightHand");
    // Manipulate2.RightHand.position = new Vector3(RightHand_pos.x, RightHand_pos.y, RightHand_pos.z);
    
    // Vector3 Spine_pos = data.jointdata[0].get_joint("Spine");
    // Manipulate2.Spine.position = new Vector3(Spine_pos.x, Spine_pos.y, Spine_pos.z);
    
    // Vector3 LeftUpLeg_pos = data.jointdata[0].get_joint("LeftUpLeg");
    // Manipulate2.LeftUpLeg.position = new Vector3(LeftUpLeg_pos.x, LeftUpLeg_pos.y, LeftUpLeg_pos.z);
    
    // Vector3 LeftArm_pos = data.jointdata[0].get_joint("LeftArm");
    // Manipulate2.LeftArm.position = new Vector3(LeftArm_pos.x, LeftArm_pos.y, LeftArm_pos.z);
    
    // Vector3 RightFoot_pos = data.jointdata[0].get_joint("RightFoot");
    // Manipulate2.RightFoot.position = new Vector3(RightFoot_pos.x, RightFoot_pos.y, RightFoot_pos.z);
    
    // Vector3 RightForeArm_pos = data.jointdata[0].get_joint("RightForeArm");
    // Manipulate2.RightForeArm.position = new Vector3(RightForeArm_pos.x, RightForeArm_pos.y, RightForeArm_pos.z);

    Vector3 direction = data.jointdata[0].get_joint("direction");
    // Debug.Log(direction);



    Vector3 root_pos = data.jointdata[0].get_joint("root");
    Manipulate2.root.position = new Vector3(root_pos.x, 0, root_pos.z);
    Manipulate2.root.eulerAngles = new Vector3(0, direction[0], 0);

    Vector3 RightArm_pos = data.jointdata[0].get_joint("RightArm");
    Manipulate2.RightArm.localPosition = new Vector3(RightArm_pos.x, RightArm_pos.y, RightArm_pos.z);

    Vector3 LeftToe_End_pos = data.jointdata[0].get_joint("LeftToe_End");
    Manipulate2.LeftToe_End.localPosition = new Vector3(LeftToe_End_pos.x, LeftToe_End_pos.y, LeftToe_End_pos.z);
    
    Vector3 LeftForeArm_pos = data.jointdata[0].get_joint("LeftForeArm");
    Manipulate2.LeftForeArm.localPosition = new Vector3(LeftForeArm_pos.x, LeftForeArm_pos.y, LeftForeArm_pos.z);
    
    Vector3 Head_End_pos = data.jointdata[0].get_joint("Head_End");
    Manipulate2.Head_End.localPosition = new Vector3(Head_End_pos.x, Head_End_pos.y, Head_End_pos.z);
    
    Vector3 RightLeg_pos = data.jointdata[0].get_joint("RightLeg");
    Manipulate2.RightLeg.localPosition = new Vector3(RightLeg_pos.x, RightLeg_pos.y, RightLeg_pos.z);
    
    Vector3 RightToe_End_pos = data.jointdata[0].get_joint("RightToe_End");
    Manipulate2.RightToe_End.localPosition = new Vector3(RightToe_End_pos.x, RightToe_End_pos.y, RightToe_End_pos.z);
    
    Vector3 RightUpLeg_pos = data.jointdata[0].get_joint("RightUpLeg");
    Manipulate2.RightUpLeg.localPosition = new Vector3(RightUpLeg_pos.x, RightUpLeg_pos.y, RightUpLeg_pos.z);
    
    Vector3 LeftHand_pos = data.jointdata[0].get_joint("LeftHand");
    Manipulate2.LeftHand.localPosition = new Vector3(LeftHand_pos.x, LeftHand_pos.y, LeftHand_pos.z);
    
    Vector3 RightHand_End_pos = data.jointdata[0].get_joint("RightHand_End");
    Manipulate2.RightHand_End.localPosition = new Vector3(RightHand_End_pos.x, RightHand_End_pos.y, RightHand_End_pos.z);
    
    Vector3 LeftFoot_pos = data.jointdata[0].get_joint("LeftFoot");
    Manipulate2.LeftFoot.localPosition = new Vector3(LeftFoot_pos.x, LeftFoot_pos.y, LeftFoot_pos.z);
    
    Vector3 LeftHand_End_pos = data.jointdata[0].get_joint("LeftHand_End");
    Manipulate2.LeftHand_End.localPosition = new Vector3(LeftHand_End_pos.x, LeftHand_End_pos.y, LeftHand_End_pos.z);
    
    Vector3 LeftLeg_pos = data.jointdata[0].get_joint("LeftLeg");
    Manipulate2.LeftLeg.localPosition = new Vector3(LeftLeg_pos.x, LeftLeg_pos.y, LeftLeg_pos.z);
    
    Vector3 Neck_pos = data.jointdata[0].get_joint("Neck");
    Manipulate2.Neck.localPosition = new Vector3(Neck_pos.x, Neck_pos.y, Neck_pos.z);
    
    Vector3 RightHand_pos = data.jointdata[0].get_joint("RightHand");
    Manipulate2.RightHand.localPosition = new Vector3(RightHand_pos.x, RightHand_pos.y, RightHand_pos.z);
    
    Vector3 Spine_pos = data.jointdata[0].get_joint("Spine");
    Manipulate2.Spine.localPosition = new Vector3(Spine_pos.x, Spine_pos.y, Spine_pos.z);
    
    Vector3 LeftUpLeg_pos = data.jointdata[0].get_joint("LeftUpLeg");
    Manipulate2.LeftUpLeg.localPosition = new Vector3(LeftUpLeg_pos.x, LeftUpLeg_pos.y, LeftUpLeg_pos.z);
    
    Vector3 LeftArm_pos = data.jointdata[0].get_joint("LeftArm");
    Manipulate2.LeftArm.localPosition = new Vector3(LeftArm_pos.x, LeftArm_pos.y, LeftArm_pos.z);
    
    Vector3 RightFoot_pos = data.jointdata[0].get_joint("RightFoot");
    Manipulate2.RightFoot.localPosition = new Vector3(RightFoot_pos.x, RightFoot_pos.y, RightFoot_pos.z);
    
    Vector3 RightForeArm_pos = data.jointdata[0].get_joint("RightForeArm");
    Manipulate2.RightForeArm.localPosition = new Vector3(RightForeArm_pos.x, RightForeArm_pos.y, RightForeArm_pos.z);
    }
}
