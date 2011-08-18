#region Using

	using System;
	using System.Collections;
	using System.Collections.Concurrent;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Collections.Specialized;
	using System.ComponentModel;
	using System.Configuration;
	using System.Configuration.Assemblies;
	using System.Data;
	using System.Data.Common;
	using System.Data.Odbc;
	using System.Data.OleDb;
	using System.Data.ProviderBase;
	using System.Data.Sql;
	using System.Data.SqlClient;
	using System.Data.SqlTypes;
	using System.Diagnostics;
	using System.Diagnostics.Contracts;
	using System.Diagnostics.Contracts.Internal;
	using System.Diagnostics.PerformanceData;
	using System.Dynamic;
	using System.Globalization;
	using System.IO;
	using System.IO.Compression;
	using System.IO.IsolatedStorage;
	using System.IO.MemoryMappedFiles;
	using System.IO.Pipes;
	using System.IO.Ports;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Management; 
	using System.Management.Instrumentation;
	using System.Media;
	using System.Net;
	using System.Net.Cache;
	using System.Net.Configuration;
	using System.Net.Mail;
	using System.Net.Mime;
	using System.Net.NetworkInformation;
	using System.Net.Security;
	using System.Net.Sockets;
	using System.Reflection;
	using System.Reflection.Cache;
	using System.Reflection.Emit;
	using System.Resources;
	using System.Runtime.InteropServices;
	using System.Runtime.Serialization;
	using System.Runtime.Versioning;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.InteropServices.Expando;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Threading;
	using System.Threading.Tasks;
	using System.Timers;
	using System.Xml;
	using System.Xml.Linq;
	using System.Xml.Resolvers;
	using System.Xml.Schema;
	using System.Xml.Serialization;
	using System.Xml.Serialization.Advanced;
	using System.Xml.Serialization.Configuration;
	using System.Xml.XPath;
	using System.Xml.Xsl;
	using System.Web;
	using System.Windows.Forms;

	using Microsoft.Win32.SafeHandles;

#endregion

namespace WBFSLibrary
{
	#region Types

		using s8 = SByte;
		using u8 = Byte;
		using S8 = SByte;
		using U8 = Byte;
		using s16 = Int16;
		using u16 = UInt16;
		using le16_t = UInt16;
		using be16_t = UInt16;
		using s32 = Int32;
		using u32 = UInt32;
		using S32 = Int32;
		using U32 = UInt32;
		using le32_t = UInt32;
		using be32_t = UInt32;
		using s64 = Int64;
		using u64 = UInt64;
		using le64_t = UInt32;
		using be64_t = UInt32;
		using S64 = Int64;
		using U64 = UInt64;
		using f32 = Single;
		using f64 = Double;
		using F32 = Single;
		using F64 = Double;

		using BOOL = Boolean;
		using BOOLEAN = Boolean;

		using BYTE = Byte;

		using WORD = UInt16;
		using DWORD = UInt32;
		using QWORD = UInt64;

		using CHAR = Char;
		using TCHAR = Char;
		using WCHAR = Char;

		using INT = Int32;
		using UINT = UInt32;

		using LONG = Int32;
		using ULONG = UInt32;

		using LONGLONG = UInt64;
		using ULONGLONG = UInt64;

		using DEVICE_TYPE = UInt16;
		using ACCESS_MASK = UInt16;

		using HANDLE = SafeHandle;
		using LPVOID = IntPtr;
		using LPOVERLAPPED = IntPtr;
		using LPSECURITY_ATTRIBUTES = IntPtr;

		using LPCTSTR = String;
		using LPTSTR = StringBuilder;

		using __in = InAttribute;
		using __out = OutAttribute;
		using __opt = OptionalAttribute;

		using _in = InAttribute;
		using _out = OutAttribute;
		using _opt = OptionalAttribute;

		using Opt = OptionalAttribute;

	#endregion

	static public class wbfs_library
	{

		//wbfs_t hdd = null;

		//s32 WBFS_Open()
		//{
		//    /* Close hard disk */
		//    if (hdd)
		//        wbfs_close(hdd);

		//    /* Open hard disk */
		//    wbfs_part_fs = 0;
		//    wbfs_part_idx = 0;
		//    wbfs_part_lba = 0;
		//    hdd = wbfs_open_hd(readCallback, writeCallback, NULL, wbfs_dev_sector_size, nb_sectors, 0);
		//    if (!hdd)
		//        return -1;
		//    wbfs_part_idx = 1;
		//    wbfs_part_lba = hdd->part_lba;

		//    return 0;
		//}
		
			//[Flags]
			//public enum FileAccess : uint
			//{
			//    GenericRead = 0x80000000,
			//    GenericWrite = 0x40000000,
			//    GenericExecute = 0x20000000,
			//    GenericAll = 0x10000000,

			//    GenericReadWrite = GenericRead | GenericWrite,
			//}

			//[Flags]
			//public enum FileShare : uint
			//{
			//    None = 0,
			//    Read = 1,
			//    Write = 2,
			//    Delete = 4,

			//    ReadWrite = Read | Write,
			//}

			//public enum CreationDisposition : uint
			//{
			//    New = 1,
			//    CreateAlways = 2,
			//    OpenExisting = 3,
			//    OpenAlways = 4,
			//    TruncateExisting = 5,
			//}

			//[Flags]
			//public enum FileAttributes : uint
			//{
			//    None = 0,
			//    Readonly = 0x00000001,
			//    Hidden = 0x00000002,
			//    System = 0x00000004,
			//    Directory = 0x00000010,
			//    Archive = 0x00000020,
			//    Device = 0x00000040,
			//    Normal = 0x00000080,
			//    Temporary = 0x00000100,
			//    SparseFile = 0x00000200,
			//    ReparsePoint = 0x00000400,
			//    Compressed = 0x00000800,
			//    Offline = 0x00001000,
			//    NotContentIndexed = 0x00002000,
			//    Encrypted = 0x00004000,
			//    WriteThrough = 0x80000000,
			//    Overlapped = 0x40000000,
			//    NoBuffering = 0x20000000,
			//    RandomAccess = 0x10000000,
			//    SequentialScan = 0x08000000,
			//    DeleteOnClose = 0x04000000,
			//    BackupSemantics = 0x02000000,
			//    PosixSemantics = 0x01000000,
			//    OpenReparsePoint = 0x00200000,
			//    OpenNoRecall = 0x00100000,
			//    FirstPipeInstance = 0x00080000
			//}
  
			//public enum StdHandle : int
			//{
			//    StdInput = -10,
			//    StdOutput = -11,
			//    StdError = -12,
			//}

			//public enum ConsoleScreenBufferFlags
			//{
			//    TextModeBuffer = 1,
			//}

			//[Flags]
			//public enum ConsoleOutputModeFlags : uint
			//{
			//    EnableProcessedOutput = 1,
			//    EnableWrapAtEolOutput = 2,
			//}

			//[Flags]
			//public enum ConsoleInputModeFlags : uint
			//{
			//    EnableProcessedInput = 0x0001,
			//    EnableLineInput = 0x0002,
			//    EnableEchoInput = 0x0004,
			//    EnableWindowInput = 0x0008,
			//    EnableMouseInput = 0x0010,
			//}
		//    #region Callback Function Pointer Delegate EnumResNameDelegate

		//    //public delegate bool EnumResNameDelegate(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, Object lParam);

		//#endregion
		
		//public Boolean IsVolume(this DEV_BROADCAST_HDR dbch)
		//{ 
		//    return dbch.dbch_devicetype == Kernel32.DBT.DEVTYP_VOLUME; }
		//};


		// use this in headers?
		//[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)] 
		// :)

		//
		//[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		//
		//				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]

		//[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)] 

		//				[SuppressUnmanagedCodeSecurity]
		//				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]

		//
		//
		//ThreadPool.BindHandle( deviceHandle );  
		//
	}
}
	
//    #region winioctl
	
//    #region Private Structures

//        [StructLayout(LayoutKind.Sequential)]
//        public struct MoveFileData
//        {
//            public IntPtr	hFile;
//            public Int64	StartingVCN;
//            public Int64	StartingLCN;
//            public Int32	ClusterCount;
//        }

//    #endregion
//        public class winioctl
//        {

//            #region Helpers

//                internal static BOOL LockVolume(HANDLE hDevice)
//                {
//                    DWORD bytes = 0;
//                    return kernel32.DeviceIoControl(hDevice, FSCTL.LOCK_VOLUME, IntPtr.Zero, 0, IntPtr.Zero, 0, ref bytes, IntPtr.Zero);
//                }

//                internal static BOOL UnlockVolume(HANDLE hDevice)
//                {
//                    DWORD bytes = 0;
//                    return kernel32.DeviceIoControl(hDevice, FSCTL.UNLOCK_VOLUME, IntPtr.Zero, 0, IntPtr.Zero, 0, ref bytes, IntPtr.Zero);
//                }

//                internal static BOOL DismountVolume(HANDLE hDevice)
//                {
//                    DWORD bytes = 0;
//                    return kernel32.DeviceIoControl(hDevice, FSCTL.DISMOUNT_VOLUME, IntPtr.Zero, 0, IntPtr.Zero, 0, ref bytes, IntPtr.Zero);
//                }

//                internal static BOOL GetSectorSize(HANDLE hDevice, out uint sectorSize)
//                {
//                    DWORD bytes = 0;

//                    DISK_GEOMETRY managed_dg = new DISK_GEOMETRY();
//                    LONG dg_size = Marshal.SizeOf(managed_dg);

//                    IntPtr unmanaged_dg = Marshal.AllocHGlobal(dg_size);

//                    BOOLEAN result = kernel32.DeviceIoControl(hDevice, IOCTL_DISK.GET_DRIVE_GEOMETRY, IntPtr.Zero, 0, unmanaged_dg, (DWORD)dg_size, ref bytes, IntPtr.Zero);

//                    managed_dg = (DISK_GEOMETRY)Marshal.PtrToStructure(unmanaged_dg, typeof(DISK_GEOMETRY));
//                    Marshal.FreeHGlobal(unmanaged_dg);

//                    sectorSize = managed_dg.BytesPerSector;

//                    return result;
//                }

//                internal static BOOL GetPartitionSize(HANDLE hDevice, out s64 partitionSize)
//                {
//                    DWORD bytes = 0;

//                    PARTITION_INFORMATION managed_pi = new PARTITION_INFORMATION();
//                    LONG pi_size = Marshal.SizeOf(managed_pi);

//                    IntPtr unmanaged_pi = Marshal.AllocHGlobal(pi_size);

//                    BOOLEAN result = kernel32.DeviceIoControl(hDevice, IOCTL_DISK.GET_PARTITION_INFO, IntPtr.Zero, 0, unmanaged_pi, (DWORD)pi_size, ref bytes, IntPtr.Zero);

//                    managed_pi = (PARTITION_INFORMATION)Marshal.PtrToStructure(unmanaged_pi, typeof(PARTITION_INFORMATION));
//                    Marshal.FreeHGlobal(unmanaged_pi);

//                    partitionSize = managed_pi.PartitionLength.QuadPart;

//                    return result;
//                }

//                internal static BOOL SetSparseRegion(HANDLE hFile, s64 position, s64 count)
//                {
//                    DWORD bytes = 0;

//                    FILE_ZERO_DATA_INFORMATION managed_fzdi = new FILE_ZERO_DATA_INFORMATION();
//                    LONG fzdi_size = Marshal.SizeOf(managed_fzdi);

//                    IntPtr unmanaged_fzdi = Marshal.AllocHGlobal(fzdi_size);

//                    managed_fzdi.FileOffset.QuadPart = position;
//                    managed_fzdi.BeyondFinalZero.QuadPart = position + count;

//                    Marshal.StructureToPtr(managed_fzdi, unmanaged_fzdi, true);

//                    BOOLEAN result = kernel32.DeviceIoControl(hFile, FSCTL.SET_ZERO_DATA, unmanaged_fzdi, (DWORD)fzdi_size, IntPtr.Zero, 0, ref bytes, IntPtr.Zero);
//                    Marshal.FreeHGlobal(unmanaged_fzdi);

//                    return result;
//                }

//                internal static BOOL SetSparseFile(HANDLE hFile)
//                {
//                    DWORD bytes = 0;

//                    BOOLEAN result = kernel32.DeviceIoControl(hFile, FSCTL.SET_SPARSE, IntPtr.Zero, 0, IntPtr.Zero, 0, ref bytes, IntPtr.Zero);

//                    return result;
//                }

//                internal static BOOL GetSparseSize(HANDLE hFile, out long size)
//                {
//                    DWORD bytes = 0;

//                    FILE_ZERO_DATA_INFORMATION managed_fzdi = new FILE_ZERO_DATA_INFORMATION();
//                    LONG fzdi_size = Marshal.SizeOf(managed_fzdi);
//                    LONG fzdis_size = fzdi_size * 1024;

//                    IntPtr unmanaged_fzdis = Marshal.AllocHGlobal(fzdis_size);
//                    IntPtr unmanaged_fzdi = Marshal.AllocHGlobal(fzdi_size);

//                    BOOL result;

//                    managed_fzdi.FileOffset.QuadPart = 0;

//                    if (!kernel32.GetFileSizeEx(hFile, ref managed_fzdi.BeyondFinalZero)) { return false; }

//                    do
//                    {
//                        // Send the range to the unmanaged memory
//                        Marshal.StructureToPtr(managed_fzdi, unmanaged_fzdi, true);

//                        // Retrieve the layout
//                        result = kernel32.DeviceIoControl(hFile, FSCTL.QUERY_ALLOCATED_RANGES, unmanaged_fzdi, (DWORD)fzdi_size, unmanaged_fzdis, (DWORD)fzdis_size, ref bytes, IntPtr.Zero);

//                        if (!result)
//                        {
//                            Marshal.FreeHGlobal(unmanaged_fzdis);
//                            Marshal.FreeHGlobal(unmanaged_fzdi);

//                            return false;
//                        }

//                        IntPtr p = unmanaged_fzdis;
//                        DWORD n = bytes / (DWORD)fzdi_size;

//                        region.FileOffset = 0;
//                        region.BeyondFinalZero = 0;

//                        for (uint i = 0; i < n; i++)
//                        {
//                            region = (Region)Marshal.
//                                PtrToStructure(p, typeof(Region));

//                            size += region.BeyondFinalZero; //Length

//                            p = IntPtr.Add(p, (int)Region.Size);
//                        }

//                        long delta = region.FileOffset +
//                            region.BeyondFinalZero -
//                            range.FileOffset;

//                        range.FileOffset += delta;
//                        range.BeyondFinalZero -= delta; //Length

//                    } while (r == 234); // ERROR_MORE_DATA

//                    // Free the unmanaged memory
//                    Marshal.FreeHGlobal(ranges);
//                    Marshal.FreeHGlobal(prange);

//                    return true;
//                }

//            #endregion

//            public IntPtr OpenVolume(String DeviceName)
//            {
//                IntPtr hDevice = kernel32.CreateFile(@"\\.\" + DeviceName, GENERIC.READ | GENERIC.WRITE, FILE_SHARE.WRITE, IntPtr.Zero, GLOBAL.OPEN_EXISTING, 0, IntPtr.Zero);

//                if (hDevice == HANDLES.INVALID_PTR)
//                {
//                    throw new Exception(Marshal.GetLastWin32Error().ToString());
//                }

//                return hDevice;
//            }

//            public IntPtr OpenFile(String FilePath)
//            {
//                IntPtr hFile = kernel32.CreateFile(FilePath, FILE.READ_ATTRIBUTES | FILE.WRITE_ATTRIBUTES, FILE_SHARE.READ | FILE_SHARE.WRITE, IntPtr.Zero, GLOBAL.OPEN_EXISTING, 0, IntPtr.Zero);

//                if (hFile == HANDLES.INVALID_PTR)
//                {
//                    throw new Exception(Marshal.GetLastWin32Error().ToString());
//                }

//                return hFile;
//            }

//            /// <summary>
//            /// Get cluster usage for a device
//            /// </summary>
//            /// <param name="DeviceName">use "c:"</param>
//            /// <returns>a bitarray for each cluster</returns>
//            public BitArray GetVolumeMap(String DeviceName)
//            {
//                IntPtr pAlloc = IntPtr.Zero;
//                IntPtr hDevice = IntPtr.Zero;

//                try
//                {
//                    hDevice = this.OpenVolume(DeviceName);

//                    Int64 i64 = 0;

//                    GCHandle handle = GCHandle.Alloc(i64, GCHandleType.Pinned);
//                    IntPtr p = handle.AddrOfPinnedObject();

//                    // alloc off more than enough for my machine
//                    // 64 megs == 67108864 bytes == 536870912 bits == cluster count
//                    // NTFS 4k clusters == 2147483648 k of storage == 2097152 megs == 2048 gig disk storage
//                    uint q = 1024 * 1024 * 64; // 1024 bytes == 1k * 1024 == 1 meg * 64 == 64 megs

//                    uint size = 0;
//                    pAlloc = Marshal.AllocHGlobal((int)q);
//                    IntPtr pDest = pAlloc;

//                    bool fResult = kernel32.DeviceIoControl( hDevice, FSCTL.GET_VOLUME_BITMAP, p, (uint)Marshal.SizeOf(i64), pDest, q, ref size, IntPtr.Zero);

//                    if (!fResult)
//                    {
//                        throw new Exception(Marshal.GetLastWin32Error().ToString());
//                    }
//                    handle.Free();

//                    /*
//                        object returned was...
					
//                        typedef struct 
//                        {
//                            LARGE_INTEGER StartingLcn;
//                            LARGE_INTEGER BitmapSize;
//                            BYTE Buffer[1];
//                        } VOLUME_BITMAP_BUFFER, *PVOLUME_BITMAP_BUFFER;
//                    */
//                    Int64 StartingLcn = (Int64)Marshal.PtrToStructure(pDest, typeof(Int64));

//                    Debug.Assert(StartingLcn == 0);

//                    pDest = (IntPtr)((Int64)pDest + 8);
//                    Int64 BitmapSize = (Int64)Marshal.PtrToStructure(pDest, typeof(Int64));

//                    Int32 byteSize = (int)(BitmapSize / 8);
//                    byteSize++; // round up - even with no remainder

//                    IntPtr BitmapBegin = (IntPtr)((Int64)pDest + 8);

//                    byte[] byteArr = new byte[byteSize];

//                    Marshal.Copy(BitmapBegin, byteArr, 0, (Int32)byteSize);

//                    BitArray retVal = new BitArray(byteArr);
//                    retVal.Length = (int)BitmapSize; // truncate to exact cluster count
//                    return retVal;
//                }
//                finally
//                {
//                    kernel32.CloseHandle(hDevice);
//                    hDevice = IntPtr.Zero;

//                    Marshal.FreeHGlobal(pAlloc);
//                    pAlloc = IntPtr.Zero;
//                }
//            }

//            /// <summary>
//            /// returns a 2*number of extents array - 
//            /// the vcn and the lcn as pairs
//            /// </summary>
//            /// <param name="path">file to get the map for ex: "c:\windows\explorer.exe" </param>
//            /// <returns>An array of [virtual cluster, physical cluster]</returns>
//            public Array GetFileMap(String path)
//            {
//                IntPtr hFile = IntPtr.Zero;
//                IntPtr pAlloc = IntPtr.Zero;

//                try
//                {
//                    hFile = this.OpenFile(path);

//                    Int64 i64 = 0;

//                    GCHandle handle = GCHandle.Alloc(i64, GCHandleType.Pinned);
//                    IntPtr p = handle.AddrOfPinnedObject();

//                    uint q = 1024 * 1024 * 64; // 1024 bytes == 1k * 1024 == 1 meg * 64 == 64 megs

//                    uint size = 0;
//                    pAlloc = Marshal.AllocHGlobal((int)q);
//                    IntPtr pDest = pAlloc;
//                    bool fResult = kernel32.DeviceIoControl( hFile, FSCTL.GET_RETRIEVAL_POINTERS, p, (uint)Marshal.SizeOf(i64), pDest, q, ref size, IntPtr.Zero);

//                    if (!fResult)
//                    {
//                        throw new Exception(Marshal.GetLastWin32Error().ToString());
//                    }

//                    handle.Free();

//                    /*
//                        object returned was...

//                        typedef struct RETRIEVAL_POINTERS_BUFFER 
//                        {
//                            DWORD ExtentCount;  
//                            LARGE_INTEGER StartingVcn;  
//                            struct
//                            {
//                                LARGE_INTEGER NextVcn;
//                                LARGE_INTEGER Lcn;
//                            } Extents[1];
//                        } RETRIEVAL_POINTERS_BUFFER, *PRETRIEVAL_POINTERS_BUFFER;
//                    */

//                    Int32 ExtentCount = (Int32)Marshal.PtrToStructure(pDest, typeof(Int32));

//                    pDest = (IntPtr)((Int64)pDest + 4);

//                    Int64 StartingVcn = (Int64)Marshal.PtrToStructure(pDest, typeof(Int64));

//                    Debug.Assert(StartingVcn == 0);

//                    pDest = (IntPtr)((Int64)pDest + 8);

//                    // now pDest points at an array of pairs of Int64s.

//                    Array retVal = Array.CreateInstance(typeof(Int64), new int[2] { ExtentCount, 2 });

//                    for (int i = 0; i < ExtentCount; i++)
//                    {
//                        for (int j = 0; j < 2; j++)
//                        {
//                            Int64 v = (Int64)Marshal.PtrToStructure(pDest, typeof(Int64));
//                            retVal.SetValue(v, new int[2] { i, j });
//                            pDest = (IntPtr)((Int64)pDest + 8);
//                        }
//                    }

//                    return retVal;
//                }
//                finally
//                {
//                    kernel32.CloseHandle(hFile);
//                    hFile = IntPtr.Zero;

//                    Marshal.FreeHGlobal(pAlloc);
//                    pAlloc = IntPtr.Zero;
//                }
//            }

//            /// <summary>
//            /// move a virtual cluster for a file to a logical cluster on disk, repeat for count clusters
//            /// </summary>
//            /// <param name="deviceName">device to move on"c:"</param>
//            /// <param name="path">file to muck with "c:\windows\explorer.exe"</param>
//            /// <param name="VCN">cluster number in file to move</param>
//            /// <param name="LCN">cluster on disk to move to</param>
//            /// <param name="count">for how many clusters</param>
//            public void MoveFile(String deviceName, String path, Int64 VCN, Int64 LCN, Int32 count)
//            {
//                IntPtr hVol = IntPtr.Zero;
//                IntPtr hFile = IntPtr.Zero;
//                try
//                {
//                    hVol = this.OpenVolume(deviceName);

//                    hFile = this.OpenFile(path);

//                    MoveFileData mfd = new MoveFileData();
//                    mfd.hFile = hFile;
//                    mfd.StartingVCN = VCN;
//                    mfd.StartingLCN = LCN;
//                    mfd.ClusterCount = count;

//                    GCHandle handle = GCHandle.Alloc(mfd, GCHandleType.Pinned);
//                    IntPtr p = handle.AddrOfPinnedObject();
//                    uint bufSize = (uint)Marshal.SizeOf(mfd);
//                    uint size = 0;

//                    bool fResult = kernel32.DeviceIoControl(hVol, FSCTL.MOVE_FILE, p, bufSize, IntPtr.Zero, 0, ref size, IntPtr.Zero);

//                    handle.Free();

//                    if (!fResult)
//                    {
//                        throw new Exception(Marshal.GetLastWin32Error().ToString());
//                    }
//                }
//                finally
//                {
//                    kernel32.CloseHandle(hVol);
//                    kernel32.CloseHandle(hFile);
//                }
//            }
//        }

//    #endregion
//}

 



//static void Main(string[] args)
//{
//IntPtr hflp = CreateFile( @"\\.\A:", 0, FILE_SHARE_READ, IntPtr.Zero, OPEN_ALWAYS, 0, IntPtr.Zero );
//if( (int)hflp == INVALID_HANDLE_VALUE )
//{ Console.WriteLine("CreateFile failed"); return; }

//Type ts = typeof( DISK_GEOMETRY );
//int ss = Marshal.SizeOf( ts );
//int ssa = ss * 20;
//IntPtr mptr = Marshal.AllocHGlobal( ssa );
//int byret = 0;
//bool ok = DeviceIoControl( hflp, IOCTL_DISK_GET_MEDIA_TYPES, IntPtr.Zero, 0,
//mptr, ssa, ref byret, IntPtr.Zero );
//if( ! ok )
//{ Console.WriteLine("DeviceIoControl failed"); return; }
//int count = byret / ss;
//int run = (int) mptr;
//DISK_GEOMETRY gem;
//for( int i = 0; i < count; i++ )
//{
//gem = (DISK_GEOMETRY) Marshal.PtrToStructure( (IntPtr) run, ts );
//Console.WriteLine( "MediaType={0} SectorsPerTrack={1}", gem.MediaType, gem.SectorsPerTrack );
//run += ss;
//}
//Marshal.FreeHGlobal( mptr );
//}
//}