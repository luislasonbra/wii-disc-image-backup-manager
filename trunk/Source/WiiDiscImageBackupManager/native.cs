//-----------------------------------------------------------------------------------------------------------
// WBFSSync Project by Omega Frost 
// http://wbfssync.codeplex.com/
//
// WBFSSync is Licensed under the terms of the 
// Microsoft Reciprocal License (Ms-RL)
//-----------------------------------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;

namespace WBFSManager
{
    //-------------------------------------------------------------------------------------------------------
    //
    //-------------------------------------------------------------------------------------------------------
    static class native
    {
        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        public static Boolean IsDeviceEvent(int msg, long wParam)
        {
            return (msg == WM_DEVICECHANGE) && ((wParam == DBT_DEVICEARRIVAL) 
                || (wParam == DBT_DEVICEREMOVECOMPLETE));
        }


        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        public static Boolean IsRemovingDevice(long wParam)
        {
            return wParam == DBT_DEVICEQUERYREMOVE;
        }


        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        public static Boolean HasRemovedDevice(long wParam)
        {
            return wParam == DBT_DEVICEREMOVECOMPLETE;
        }


        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        public static Boolean IsInsertingDevice(long wParam)
        {
            return wParam == DBT_DEVICEARRIVAL;
        }


        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        public static Boolean GetDeviceBroadcast(IntPtr lParam, out DEV_BROADCAST_HDR device)
        {
            try
            {
                device = (DEV_BROADCAST_HDR)Marshal.PtrToStructure(
                    lParam, typeof(DEV_BROADCAST_HDR));
                return true;
            }
            catch
            {
                device = new DEV_BROADCAST_HDR();
                return false;
            }
        }


    }
}
