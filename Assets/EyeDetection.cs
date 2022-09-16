using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


namespace Unity.XR.PXR
{
    public class EyeDetection 
    {
        
        static bool GetEyeTrackingDevice(out InputDevice device)
        {
            device = default(InputDevice);

            if (!PXR_Manager.Instance.eyeTracking)
                return false;

            List<InputDevice> devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.EyeTracking | InputDeviceCharacteristics.HeadMounted, devices);
            if (devices.Count == 0)
            {
                Debug.Log("Failed at GetEyeTrackingDevice 0");
                return false;
            }
            device = devices[0];
            if (!device.isValid)
                Debug.Log("Failed at GetEyeTrackingDevice 1");
            return device.isValid;
        }

        public static bool GetLeftEyeGazeOpenness(out float openness)
        {
            openness = 0;

            if (!PXR_Manager.Instance.eyeTracking)
                return false;

            InputDevice device;
            if (!GetEyeTrackingDevice(out device))
                return false;

            if (!device.TryGetFeatureValue(PXR_Usages.leftEyeOpenness, out openness))
            {
                return false;
            }

            return true;
        }

        public static bool GetRightEyeGazeOpenness(out float openness)
        {
            openness = 0;

            if (!PXR_Manager.Instance.eyeTracking)
                return false;

            InputDevice device;
            if (!GetEyeTrackingDevice(out device))
                return false;

            if (!device.TryGetFeatureValue(PXR_Usages.rightEyeOpenness, out openness))
            {
                return false;
            }

            return true;
        }
    }

}
