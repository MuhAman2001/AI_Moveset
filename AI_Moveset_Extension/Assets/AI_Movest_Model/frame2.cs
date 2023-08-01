using UnityEngine;
using System.Collections.Generic; 

[System.Serializable]
public class JointsResponse2{
    public Dictionary<string,Dictionary<string,Dictionary<string,Frame2>>> joints;
}
// public class JointsData{
//     public Dictionary<string,Dictionary<string,int>> joints;
// }

// public class JointsDict{
//     public Dictionary<string,int> joints;
// }

[System.Serializable]
public class Frame2
{   
    public double direction;
    public double root_x;
    public double root_y;
    public double root_z;
    public double RightLeg_x;
    public double RightLeg_y;
    public double RightLeg_z;
    public double RightArm_x;
    public double RightArm_y;
    public double RightArm_z;
    public double Spine_x;
    public double Spine_y;
    public double Spine_z;
    public double RightHand_End_x;
    public double RightHand_End_y;
    public double RightHand_End_z;
    public double LeftToe_End_x;
    public double LeftToe_End_y;
    public double LeftToe_End_z;
    public double Head_End_x;
    public double Head_End_y;
    public double Head_End_z;
    public double LeftHand_x;
    public double LeftHand_y;
    public double LeftHand_z;
    public double LeftFoot_x;
    public double LeftFoot_y;
    public double LeftFoot_z;
    public double RightHand_x;
    public double RightHand_y;
    public double RightHand_z;
    public double LeftLeg_x;
    public double LeftLeg_y;
    public double LeftLeg_z;
    public double RightForeArm_x;
    public double RightForeArm_y;
    public double RightForeArm_z;
    public double RightUpLeg_x;
    public double RightUpLeg_y;
    public double RightUpLeg_z;
    public double Neck_x;
    public double Neck_y;
    public double Neck_z;
    public double LeftHand_End_x;
    public double LeftHand_End_y;
    public double LeftHand_End_z;
    public double LeftUpLeg_x;
    public double LeftUpLeg_y;
    public double LeftUpLeg_z;
    public double RightToe_End_x;
    public double RightToe_End_y;
    public double RightToe_End_z;
    public double RightFoot_x;
    public double RightFoot_y;
    public double RightFoot_z;
    public double LeftArm_x;
    public double LeftArm_y;
    public double LeftArm_z;
    public double LeftForeArm_x;
    public double LeftForeArm_y;
    public double LeftForeArm_z;

    public Vector3 get_joint(string name)
    {
        if (name == "root"){ return new Vector3((float)root_x, (float)root_y, (float)root_z); }

        else if (name == "RightHand_End") { return new Vector3((float)RightHand_End_x, (float)RightHand_End_y, (float)RightHand_End_z); }
        else if (name == "RightUpLeg") { return new Vector3((float)RightUpLeg_x, (float)RightUpLeg_y, (float)RightUpLeg_z); }
        else if (name == "RightArm") { return new Vector3((float)RightArm_x, (float)RightArm_y, (float)RightArm_z); }
        else if (name == "Neck") { return new Vector3((float)Neck_x, (float)Neck_y, (float)Neck_z); }
        else if (name == "LeftFoot") { return new Vector3((float)LeftFoot_x, (float)LeftFoot_y, (float)LeftFoot_z); }
        else if (name == "RightHand") { return new Vector3((float)RightHand_x, (float)RightHand_y, (float)RightHand_z); }
        else if (name == "LeftToe_End") { return new Vector3((float)LeftToe_End_x, (float)LeftToe_End_y, (float)LeftToe_End_z); }
        else if (name == "RightFoot") { return new Vector3((float)RightFoot_x, (float)RightFoot_y, (float)RightFoot_z); }
        else if (name == "LeftHand") { return new Vector3((float)LeftHand_x, (float)LeftHand_y, (float)LeftHand_z); }
        else if (name == "LeftForeArm") { return new Vector3((float)LeftForeArm_x, (float)LeftForeArm_y, (float)LeftForeArm_z); }
        else if (name == "LeftArm") { return new Vector3((float)LeftArm_x, (float)LeftArm_y, (float)LeftArm_z); }
        else if (name == "Spine") { return new Vector3((float)Spine_x, (float)Spine_y, (float)Spine_z); }
        else if (name == "LeftLeg") { return new Vector3((float)LeftLeg_x, (float)LeftLeg_y, (float)LeftLeg_z); }
        else if (name == "RightToe_End") { return new Vector3((float)RightToe_End_x, (float)RightToe_End_y, (float)RightToe_End_z); }
        else if (name == "RightForeArm") { return new Vector3((float)RightForeArm_x, (float)RightForeArm_y, (float)RightForeArm_z); }
        else if (name == "RightLeg") { return new Vector3((float)RightLeg_x, (float)RightLeg_y, (float)RightLeg_z); }
        else if (name == "LeftHand_End") { return new Vector3((float)LeftHand_End_x, (float)LeftHand_End_y, (float)LeftHand_End_z); }
        else if (name == "Head_End") { return new Vector3((float)Head_End_x, (float)Head_End_y, (float)Head_End_z); }
        else if (name == "LeftUpLeg") { return new Vector3((float)LeftUpLeg_x, (float)LeftUpLeg_y, (float)LeftUpLeg_z); }

        else if (name == "direction") { return new Vector3((float)direction, 0, 0); }

        else { return new Vector3(0, 0, 0); }
    }
}
