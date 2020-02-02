//cameraFacingBillboard.cs v02
//by Neil Carter (NCarter)
//modified by Juan Castaneda (juanelo)
//
//added in-between GRP object to perform rotations on
//added auto-find main camera
//added un-initialized state, where script will do nothing
using UnityEngine;
using System.Collections;


public class CameraFacingBillboard : Rotator
{
    void Awake()
    {
        target = Camera.main.gameObject;
    }

    private void Update()
    {
        Face(target, lockY: false);
    }


}