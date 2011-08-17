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
	using System.Runtime.Caching;
	using System.Runtime.Caching.Configuration;
	using System.Runtime.Caching.Hosting;
	using System.Runtime.Collections;
	using System.Runtime.CompilerServices;
	using System.Runtime.ConstrainedExecution;
	using System.Runtime.Diagnostics;
	using System.Runtime.DurableInstancing;
	using System.Runtime.ExceptionServices;
	using System.Runtime.Hosting;
	using System.Runtime.Interop;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.InteropServices.Expando;
	using System.Runtime.InteropServices.TCEAdapterGen;
	using System.Runtime.Remoting;
	using System.Runtime.Remoting.Activation;
	using System.Runtime.Remoting.Channels;
	using System.Runtime.Remoting.Channels.Http;
	using System.Runtime.Remoting.Channels.Ipc;
	using System.Runtime.Remoting.Channels.Tcp;
	using System.Runtime.Remoting.Contexts;
	using System.Runtime.Remoting.Lifetime;
	using System.Runtime.Remoting.Messaging;
	using System.Runtime.Remoting.Metadata;
	using System.Runtime.Remoting.Metadata.W3cXsd2001;
	using System.Runtime.Remoting.MetadataServices;
	using System.Runtime.Remoting.Proxies;
	using System.Runtime.Remoting.Services;
	using System.Runtime.Serialization;
	using System.Runtime.Serialization.Configuration;
	using System.Runtime.Serialization.Diagnostics;
	using System.Runtime.Serialization.Formatters;
	using System.Runtime.Serialization.Formatters.Binary;
	using System.Runtime.Serialization.Formatters.Soap;
	using System.Runtime.Serialization.Json;
	using System.Runtime.Versioning;
	using System.Security;
	using System.Security.AccessControl;
	using System.Security.Authentication;
	using System.Security.Authentication.ExtendedProtection;
	using System.Security.Authentication.ExtendedProtection.Configuration;
	using System.Security.Cryptography;
	using System.Security.Cryptography.Pkcs;
	using System.Security.Cryptography.X509Certificates;
	using System.Security.Cryptography.Xml;
	using System.Security.Permissions;
	using System.Security.Policy;
	using System.Security.Principal;
	using System.Security.Util;
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

	using Microsoft;
	using Microsoft.Runtime;
	using Microsoft.Runtime.Hosting;
	using Microsoft.Internal.Collections;
	using Microsoft.Internal.Performance;
	using Microsoft.Internal.Runtime;
	using Microsoft.Internal.Runtime.Serialization;
	using Microsoft.Win32;
	using Microsoft.Win32.SafeHandles;

#endregion

namespace WBFSLibrary
{
	#region Unmanaged Type Map

		/* Block Revision = r23 */

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
		using S64 = Int64;
		using U64 = UInt64;
		using le64_t = UInt32;
		using be64_t = UInt32;
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

		using HANDLE = SafeFileHandle;
		using HINSTANCE = SafeHandle;
		using HLOCAL = SafeHandle;
		using HWND = SafeHandle;
	
		//using VOID = Void;

		using PVOID = IntPtr;
		using LPVOID = IntPtr;
		using LPCVOID = IntPtr;

		using POVERLAPPED = NativeOverlapped;
		using LPOVERLAPPED = NativeOverlapped;

		using CString = String;
		using LPCTSTR = String;
		using LPTSTR = StringBuilder;
		
		using __in = InAttribute;
		using __out = OutAttribute;
		using __opt = OptionalAttribute;

		using _in = InAttribute;
		using _out = OutAttribute;
		using _opt = OptionalAttribute;

		using Opt = OptionalAttribute;

		#region Kernel32

			using _SECURITY_ATTRIBUTES = Kernel32.SECURITY_ATTRIBUTES;
			using PSECURITY_ATTRIBUTES = Kernel32.SECURITY_ATTRIBUTES;
			using LPSECURITY_ATTRIBUTES = Kernel32.SECURITY_ATTRIBUTES;

		#endregion

	#endregion

	public class Kernel32
	{
		#region Structs 

			#region SECURITY_ATTRIBUTES

				/*
					typedef struct _SECURITY_ATTRIBUTES
					{
						DWORD nLength;
						LPVOID lpSecurityDescriptor;
						BOOL bInheritHandle;
					} 	SECURITY_ATTRIBUTES;

					typedef struct _SECURITY_ATTRIBUTES *PSECURITY_ATTRIBUTES;

					typedef struct _SECURITY_ATTRIBUTES *LPSECURITY_ATTRIBUTES;
				*/

				[StructLayout(LayoutKind.Sequential)]
				public struct SECURITY_ATTRIBUTES
				{
					public	DWORD		nLength;
					public	LPVOID		lpSecurityDescriptor;
					public	BOOL		bInheritHandle;
				};

			#endregion

			#region DEV_BROADCAST_HDR

				/*
					typedef struct _DEV_BROADCAST_HDR
					{
					  DWORD dbch_size;
					  DWORD dbch_devicetype;
					  DWORD dbch_reserved;
					} DEV_BROADCAST_HDR, *PDEV_BROADCAST_HDR;
				*/

				public struct DEV_BROADCAST_HDR
				{
					public DWORD dbch_size;
					public DWORD dbch_devicetype;
					public DWORD dbch_reserved;
				};

				public Boolean IsVolume(this DEV_BROADCAST_HDR dbch)
				{ 
					return dbch.dbch_devicetype == DBT_DEVTYP_VOLUME; }
				}

			#endregion

			#region DEV_BROADCAST_HDR

				public struct DEV_BROADCAST_VOLUME
				{
					public uint dbcv_size;
					public uint dbcv_devicetype;
					public uint dbcv_reserved;

					public uint dbcv_unitmask;
					public ushort dbcv_flags;

					public DEV_BROADCAST_VOLUME(uint dbcv_size, uint dbcv_devicetype,
						uint dbcv_reserved, uint dbcv_unitmask, ushort dbcv_flags)
					{
						this.dbcv_size = dbcv_size;
						this.dbcv_devicetype = dbcv_devicetype;
						this.dbcv_reserved = dbcv_reserved;
						this.dbcv_unitmask = dbcv_unitmask;
						this.dbcv_flags = dbcv_flags;
					}
				}

			#endregion

			//public delegate bool EnumResNameDelegate(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, Object lParam);

		#endregion

		#region Enumerations

			[Flags]
			public enum FileAccess : uint
			{
				GenericRead = 0x80000000,
				GenericWrite = 0x40000000,
				GenericExecute = 0x20000000,
				GenericAll = 0x10000000,

				GenericReadWrite = GenericRead | GenericWrite,
			}

			[Flags]
			public enum FileShare : uint
			{
				None = 0,
				Read = 1,
				Write = 2,
				Delete = 4,

				ReadWrite = Read | Write,
			}

			public enum CreationDisposition : uint
			{
				New = 1,
				CreateAlways = 2,
				OpenExisting = 3,
				OpenAlways = 4,
				TruncateExisting = 5,
			}

			[Flags]
			public enum FileAttributes : uint
			{
				None = 0,
				Readonly = 0x00000001,
				Hidden = 0x00000002,
				System = 0x00000004,
				Directory = 0x00000010,
				Archive = 0x00000020,
				Device = 0x00000040,
				Normal = 0x00000080,
				Temporary = 0x00000100,
				SparseFile = 0x00000200,
				ReparsePoint = 0x00000400,
				Compressed = 0x00000800,
				Offline = 0x00001000,
				NotContentIndexed = 0x00002000,
				Encrypted = 0x00004000,
				WriteThrough = 0x80000000,
				Overlapped = 0x40000000,
				NoBuffering = 0x20000000,
				RandomAccess = 0x10000000,
				SequentialScan = 0x08000000,
				DeleteOnClose = 0x04000000,
				BackupSemantics = 0x02000000,
				PosixSemantics = 0x01000000,
				OpenReparsePoint = 0x00200000,
				OpenNoRecall = 0x00100000,
				FirstPipeInstance = 0x00080000
			}
  
			public enum StdHandle : int
			{
				StdInput = -10,
				StdOutput = -11,
				StdError = -12,
			}

			public enum ConsoleScreenBufferFlags
			{
				TextModeBuffer = 1,
			}

			[Flags]
			public enum ConsoleOutputModeFlags : uint
			{
				EnableProcessedOutput = 1,
				EnableWrapAtEolOutput = 2,
			}

			[Flags]
			public enum ConsoleInputModeFlags : uint
			{
				EnableProcessedInput = 0x0001,
				EnableLineInput = 0x0002,
				EnableEchoInput = 0x0004,
				EnableWindowInput = 0x0008,
				EnableMouseInput = 0x0010,
			}

		#endregion

		#region Callback Function Pointer Delegates

			#region LPOVERLAPPED_COMPLETION_ROUTINE

				/*
					typedef VOID (*LPOVERLAPPED_COMPLETION_ROUTINE)
					( 
						DWORD dwErrorCode,
						DWORD dwNumberOfBytesTransfered,
						LPVOID lpOverlapped
					);
				*/

				public delegate void LPOVERLAPPED_COMPLETION_ROUTINE(DWORD dwErrorCode, DWORD dwNumberOfBytesTransfered, LPVOID lpOverlapped);

			#endregion

		#endregion

		#region Constants

			public class GLOBAL
			{
				public static readonly UInt32	RT_STRING						=	0x00000006;
				public static readonly UInt32	RT_ICON							=	0x00000003;
				public static readonly UInt32	RT_GROUP_ICON					=	0x0000000E;

				public static readonly UInt32	LOAD_LIBRARY_AS_DATAFILE		=	0x00000002;

				public static readonly UInt32	SUBLANG_DEFAULT					=	0x01;
				public static readonly UInt32	LANG_NEUTRAL						=	0x00;
				public static readonly UInt32	LANGID							=	(UInt32)((((ushort)(SUBLANG_DEFAULT)) << 10) | (ushort)(LANG_NEUTRAL));

				public static readonly UInt32	WM_DEVICECHANGE					=	537;
			}

			public class SECURITY
			{
				//public static readonly UInt32	SECURITY_NULL_SID_AUTHORITY			=	0x10000000;
				//public static readonly UInt32	SECURITY_WORLD_SID_AUTHORITY		=	{0,0,0,0,0,0};
				//#define SECURITY_NULL_SID_AUTHORITY         {0,0,0,0,0,0}
				//#define SECURITY_WORLD_SID_AUTHORITY        {0,0,0,0,0,1}
				//#define SECURITY_LOCAL_SID_AUTHORITY        {0,0,0,0,0,2}
				//#define SECURITY_CREATOR_SID_AUTHORITY      {0,0,0,0,0,3}
				//#define SECURITY_NON_UNIQUE_AUTHORITY       {0,0,0,0,0,4}
				//#define SECURITY_RESOURCE_MANAGER_AUTHORITY {0,0,0,0,0,9}
				//#define SECURITY_NULL_RID                 (0x00000000L)
				//#define SECURITY_WORLD_RID                (0x00000000L)
				//#define SECURITY_LOCAL_RID                (0x00000000L)
				//#define SECURITY_LOCAL_LOGON_RID          (0x00000001L)
				//#define SECURITY_CREATOR_OWNER_RID        (0x00000000L)
				//#define SECURITY_CREATOR_GROUP_RID        (0x00000001L)
				//#define SECURITY_CREATOR_OWNER_SERVER_RID (0x00000002L)
				//#define SECURITY_CREATOR_GROUP_SERVER_RID (0x00000003L)
				//#define SECURITY_CREATOR_OWNER_RIGHTS_RID (0x00000004L)
				//#define SECURITY_NT_AUTHORITY           {0,0,0,0,0,5}
				//#define SECURITY_DIALUP_RID             (0x00000001L)
				//#define SECURITY_NETWORK_RID            (0x00000002L)
				//#define SECURITY_BATCH_RID              (0x00000003L)
				//#define SECURITY_INTERACTIVE_RID        (0x00000004L)
				//#define SECURITY_LOGON_IDS_RID          (0x00000005L)
				//#define SECURITY_LOGON_IDS_RID_COUNT    (3L)
				//#define SECURITY_SERVICE_RID            (0x00000006L)
				//#define SECURITY_ANONYMOUS_LOGON_RID    (0x00000007L)
				//#define SECURITY_PROXY_RID              (0x00000008L)
				//#define SECURITY_ENTERPRISE_CONTROLLERS_RID (0x00000009L)
				//#define SECURITY_SERVER_LOGON_RID       SECURITY_ENTERPRISE_CONTROLLERS_RID
				//#define SECURITY_PRINCIPAL_SELF_RID     (0x0000000AL)
				//#define SECURITY_AUTHENTICATED_USER_RID (0x0000000BL)
				//#define SECURITY_RESTRICTED_CODE_RID    (0x0000000CL)
				//#define SECURITY_TERMINAL_SERVER_RID    (0x0000000DL)
				//#define SECURITY_REMOTE_LOGON_RID       (0x0000000EL)
				//#define SECURITY_THIS_ORGANIZATION_RID  (0x0000000FL)
				//#define SECURITY_IUSER_RID              (0x00000011L)
				//#define SECURITY_LOCAL_SYSTEM_RID       (0x00000012L)
				//#define SECURITY_LOCAL_SERVICE_RID      (0x00000013L)
				//#define SECURITY_NETWORK_SERVICE_RID    (0x00000014L)
				//#define SECURITY_NT_NON_UNIQUE          (0x00000015L)
				//#define SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT  (3L)
				//#define SECURITY_ENTERPRISE_READONLY_CONTROLLERS_RID (0x00000016L)
				//#define SECURITY_BUILTIN_DOMAIN_RID     (0x00000020L)
				//#define SECURITY_WRITE_RESTRICTED_CODE_RID (0x00000021L)
				//#define SECURITY_PACKAGE_BASE_RID       (0x00000040L)
				//#define SECURITY_PACKAGE_RID_COUNT      (2L)
				//#define SECURITY_PACKAGE_NTLM_RID       (0x0000000AL)
				//#define SECURITY_PACKAGE_SCHANNEL_RID   (0x0000000EL)
				//#define SECURITY_PACKAGE_DIGEST_RID     (0x00000015L)
				//#define SECURITY_CRED_TYPE_BASE_RID             (0x00000041L)
				//#define SECURITY_CRED_TYPE_RID_COUNT            (2L)
				//#define SECURITY_CRED_TYPE_THIS_ORG_CERT_RID    (0x00000001L)
				//#define SECURITY_MIN_BASE_RID           (0x00000050L)
				//#define SECURITY_SERVICE_ID_BASE_RID    (0x00000050L)
				//#define SECURITY_SERVICE_ID_RID_COUNT   (6L)
				//#define SECURITY_RESERVED_ID_BASE_RID   (0x00000051L)
				//#define SECURITY_APPPOOL_ID_BASE_RID    (0x00000052L)
				//#define SECURITY_APPPOOL_ID_RID_COUNT   (6L)
				//#define SECURITY_VIRTUALSERVER_ID_BASE_RID    (0x00000053L)
				//#define SECURITY_VIRTUALSERVER_ID_RID_COUNT   (6L)
				//#define SECURITY_USERMODEDRIVERHOST_ID_BASE_RID  (0x00000054L)
				//#define SECURITY_USERMODEDRIVERHOST_ID_RID_COUNT (6L)
				//#define SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_BASE_RID  (0x00000055L)
				//#define SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_RID_COUNT (6L)
				//#define SECURITY_WMIHOST_ID_BASE_RID  (0x00000056L)
				//#define SECURITY_WMIHOST_ID_RID_COUNT (6L)
				//#define SECURITY_TASK_ID_BASE_RID                 (0x00000057L)
				//#define SECURITY_NFS_ID_BASE_RID        (0x00000058L)
				//#define SECURITY_COM_ID_BASE_RID        (0x00000059L)
				//#define SECURITY_VIRTUALACCOUNT_ID_RID_COUNT   (6L)
				//#define SECURITY_MAX_BASE_RID		(0x0000006FL)
				//#define SECURITY_MAX_ALWAYS_FILTERED    (0x000003E7L)
				//#define SECURITY_MIN_NEVER_FILTERED     (0x000003E8L)
				//#define SECURITY_OTHER_ORGANIZATION_RID (0x000003E8L)
				//#define SECURITY_WINDOWSMOBILE_ID_BASE_RID (0x00000070L)
			}

			public class DBT
			{
				/*
					//
					// Message = WM_DEVICECHANGE
					// wParam  = DBT_NODISKSPACE
					// lParam  = drive number of drive that is out of disk space (1-based)
					//
					// Message issued by IFS manager when it detects that a drive is run out of
					// free space.
					//

					#define DBT_NO_DISK_SPACE               0x0047

					//
					// Message = WM_DEVICECHANGE
					// wParam  = DBT_LOW_DISK_SPACE
					// lParam  = drive number of drive that is low on disk space (1-based)
					//
					// Message issued by VFAT when it detects that a drive it has mounted
					// has the remaning free space below a threshold specified by the
					// registry or by a disk space management application.
					// The broadcast is issued by VFAT ONLY when space is either allocated
					// or freed by VFAT.
					//

					#define DBT_LOW_DISK_SPACE      0x0048

					#define DBT_CONFIGMGPRIVATE             0x7FFF

					//
					// The following messages are for WM_DEVICECHANGE. The immediate list
					// is for the wParam. ALL THESE MESSAGES PASS A POINTER TO A STRUCT
					// STARTING WITH A DWORD SIZE AND HAVING NO POINTER IN THE STRUCT.
					//
					//
					#define DBT_DEVICEARRIVAL               0x8000  // system detected a new device
					#define DBT_DEVICEQUERYREMOVE           0x8001  // wants to remove, may fail
					#define DBT_DEVICEQUERYREMOVEFAILED     0x8002  // removal aborted
					#define DBT_DEVICEREMOVEPENDING         0x8003  // about to remove, still avail.
					#define DBT_DEVICEREMOVECOMPLETE        0x8004  // device is gone
					#define DBT_DEVICETYPESPECIFIC          0x8005  // type specific event

					#if(WINVER >= 0x040A)
					#define DBT_CUSTOMEVENT                 0x8006  // user-defined event
					#endif // WINVER >= 0x040A 

					#if(WINVER >= _WIN32_WINNT_WIN7)
					#define DBT_DEVINSTENUMERATED            0x8007  // system detected a new device
					#define DBT_DEVINSTSTARTED               0x8008  // device installed and started
					#define DBT_DEVINSTREMOVED               0x8009  // device removed from system
					#define DBT_DEVINSTPROPERTYCHANGED       0x800A  // a property on the device changed
					#endif // WINVER >= _WIN32_WINNT_WIN7 

					#define DBT_DEVTYP_OEM                  0x00000000  // oem-defined device type
					#define DBT_DEVTYP_DEVNODE              0x00000001  // devnode number
					#define DBT_DEVTYP_VOLUME               0x00000002  // logical volume
					#define DBT_DEVTYP_PORT                 0x00000003  // serial, parallel
					#define DBT_DEVTYP_NET                  0x00000004  // network resource

					#if(WINVER >= 0x040A)
					#define DBT_DEVTYP_DEVICEINTERFACE      0x00000005  // device interface class
					#define DBT_DEVTYP_HANDLE               0x00000006  // file system handle
					#endif // WINVER >= 0x040A 

					#if(WINVER >= _WIN32_WINNT_WIN7)
					#define DBT_DEVTYP_DEVINST              0x00000007  // device instance
					#endif // WINVER >= _WIN32_WINNT_WIN7 
				*/

				public static readonly UInt32	NO_DISK_SPACE					=	0x0047;
				public static readonly UInt32	LOW_DISK_SPACE					=	0x0048;
				public static readonly UInt32	CONFIGMGPRIVATE					=	0x7FFF;
				public static readonly UInt32	DEVICEARRIVAL					=	0x8000;
				public static readonly UInt32	DEVICEQUERYREMOVE				=	0x8001;
				public static readonly UInt32	DEVICEQUERYREMOVEFAILED			=	0x8002;
				public static readonly UInt32	DEVICEREMOVEPENDING				=	0x8003;
				public static readonly UInt32	DEVICEREMOVECOMPLETE			=	0x8004;
				public static readonly UInt32	DEVICETYPESPECIFIC				=	0x8005;
				public static readonly UInt32	CUSTOMEVENT						=	0x8006;
				public static readonly UInt32	DEVINSTENUMERATED				=	0x8007;
				public static readonly UInt32	DEVINSTSTARTED					=	0x8008;
				public static readonly UInt32	DEVINSTREMOVED					=	0x8009;
				public static readonly UInt32	DEVINSTPROPERTYCHANGED			=	0x800A;
				public static readonly UInt32	DEVTYP_OEM						=	0x00000000;
				public static readonly UInt32	DEVTYP_DEVNODE					=	0x00000001;
				public static readonly UInt32	DEVTYP_VOLUME					=	0x00000002;
				public static readonly UInt32	DEVTYP_PORT						=	0x00000003;
				public static readonly UInt32	DEVTYP_NET						=	0x00000004;
				public static readonly UInt32	DEVTYP_DEVICEINTERFACE			=	0x00000005;
				public static readonly UInt32	DEVTYP_HANDLE					=	0x00000006;
				public static readonly UInt32	DEVTYP_DEVINST					=	0x00000007;
			}

		#endregion

		#region DLL Imports

			#region CreateFile

				/*
					HANDLE WINAPI CreateFile
					(
						__in      LPCTSTR lpFileName,
						__in      DWORD dwDesiredAccess,
						__in      DWORD dwShareMode,
						__in_opt  LPSECURITY_ATTRIBUTES lpSecurityAttributes,
						__in      DWORD dwCreationDisposition,
						__in      DWORD dwFlagsAndAttributes,
						__in_opt  HANDLE hTemplateFile
					);
				*/

				[DllImport("kernel32.dll",
					CallingConvention = CallingConvention.Winapi,
					CharSet = CharSet.Auto,
					SetLastError = true)]
				public static extern HANDLE CreateFile
				(
					[In]			LPCTSTR lpFileName,
					[In]			DWORD dwDesiredAccess,
					[In]			DWORD dwShareMode,
					[In][Opt]	ref SECURITY_ATTRIBUTES lpSecurityAttributes,
					[In]			DWORD dwCreationDisposition,
					[In]			DWORD dwFlagsAndAttributes,
					[In][Opt]		HANDLE hTemplateFile
				);

			#endregion

			#region CloseHandle

				/*
					BOOL WINAPI CloseHandle
					(
						__in  HANDLE hObject
					);
				*/

				[DllImport("kernel32.dll",
					CallingConvention = CallingConvention.Winapi,
					CharSet = CharSet.Auto,
					SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL CloseHandle
				(
					[In]	HANDLE hObject
				);

			#endregion

			#region DeviceIoControl

				/*
					BOOL WINAPI DeviceIoControl
					(
						__in         HANDLE hDevice,
						__in         DWORD dwIoControlCode,
						__in_opt     LPVOID lpInBuffer,
						__in         DWORD nInBufferSize,
						__out_opt    LPVOID lpOutBuffer,
						__in         DWORD nOutBufferSize,
						__out_opt    LPDWORD lpBytesReturned,
						__inout_opt  LPOVERLAPPED lpOverlapped
					);
					*/

				[DllImport("kernel32.dll",
					CallingConvention = CallingConvention.Winapi,
					CharSet = CharSet.Auto,
					SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL DeviceIoControl
				(
					[In]				HANDLE hDevice,
					[In]				DWORD dwIoControlCode,
					[In][Opt]			LPVOID lpInBuffer,
					[In]				DWORD nInBufferSize,
					[Out][Opt]			LPVOID lpOutBuffer,
					[In]				DWORD nOutBufferSize,
					[Out][Opt]		ref DWORD lpBytesReturned,
					[In][Out][Opt]		LPOVERLAPPED lpOverlapped
				);

			#endregion

			#region GetVolumeInformation

				/*
					BOOL WINAPI GetVolumeInformation
					(
						__in_opt   LPCTSTR lpRootPathName,
						__out      LPTSTR lpVolumeNameBuffer,
						__in       DWORD nVolumeNameSize,
						__out_opt  LPDWORD lpVolumeSerialNumber,
						__out_opt  LPDWORD lpMaximumComponentLength,
						__out_opt  LPDWORD lpFileSystemFlags,
						__out      LPTSTR lpFileSystemNameBuffer,
						__in       DWORD nFileSystemNameSize
					);
				*/

				[DllImport("kernel32.dll",
					CallingConvention = CallingConvention.Winapi,
					CharSet = CharSet.Auto,
					SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL GetVolumeInformation
				(
					[In][Opt]		LPCTSTR RootPathName,
					[Out]			LPTSTR VolumeNameBuffer,
					[In]			DWORD VolumeNameSize,
					[Out][Opt]	ref DWORD VolumeSerialNumber,
					[Out][Opt]	ref DWORD MaximumComponentLength,
					[Out][Opt]	ref DWORD FileSystemFlags,
					[Out]			LPTSTR FileSystemNameBuffer,
					[In]			DWORD nFileSystemNameSize
				);

			#endregion

			#region GetFileSize

				/*
					DWORD WINAPI GetFileSize
					(
						__in       HANDLE hFile,
						__out_opt  LPDWORD lpFileSizeHigh
					);
				*/

				[DllImport("kernel32.dll",
					CallingConvention = CallingConvention.Winapi,
					CharSet = CharSet.Auto,
					SetLastError = true)]
				[return: MarshalAs(UnmanagedType.U4)]
				public static extern DWORD GetFileSize
				(
					[In]		HANDLE hFile,
					[Out]	ref DWORD lpFileSiz
				);
			
			#endregion

			#region GetFileSizeEx

				/*
					BOOL WINAPI GetFileSizeEx
					(
						__in   HANDLE hFile,
						__out  PLARGE_INTEGER lpFileSize
					);
				*/

				[DllImport("kernel32.dll",
					CallingConvention = CallingConvention.Winapi,
					CharSet = CharSet.Auto,
					SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL GetFileSizeEx
				(
					[In]		HANDLE hFile,
					[Out]	ref LARGE_INTEGER lpFileSiz
				);

			#endregion

			#region SetFilePointer

				/*
					DWORD WINAPI SetFilePointer
					(
						__in         HANDLE hFile,
						__in         LONG lDistanceToMove,
						__inout_opt  PLONG lpDistanceToMoveHigh,
						__in         DWORD dwMoveMethod
					);
					*/

				[DllImport("kernel32.dll",
					CallingConvention = CallingConvention.Winapi,
					CharSet = CharSet.Auto,
					SetLastError = true)]
				[return: MarshalAs(UnmanagedType.U4)]
				public static extern DWORD SetFilePointer
				(
					[In]				HANDLE hFile,
					[In]				LONG liDistanceToMove,
					[In][Out][Opt]	ref LONG lpDistanceToMoveHigh,
					[In]				DWORD dwMoveMethod
				);

			#endregion

			#region SetFilePointerEx

				/*
					BOOL WINAPI SetFilePointerEx
					(
						__in       HANDLE hFile,
						__in       LARGE_INTEGER liDistanceToMove,
						__out_opt  PLARGE_INTEGER lpNewFilePointer,
						__in       DWORD dwMoveMethod
					);
					*/

				[DllImport("kernel32.dll",
					CallingConvention = CallingConvention.Winapi,
					CharSet = CharSet.Auto,
					SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL SetFilePointerEx
				(
					[In]				HANDLE hFile,
					[In]				LONG liDistanceToMove,
					[In][Out][Opt]	ref LONG lpNewFilePointer,
					[In]				DWORD dwMoveMethod
				);

			#endregion

			#region ReadFile

				/*
					BOOL WINAPI ReadFile
					(
						__in         HANDLE hFile,
						__out        LPVOID lpBuffer,
						__in         DWORD nNumberOfBytesToRead,
						__out_opt    LPDWORD lpNumberOfBytesRead,
						__inout_opt  LPOVERLAPPED lpOverlapped
					);
				*/

				[DllImport("kernel32.dll",
					CallingConvention = CallingConvention.Winapi,
					CharSet = CharSet.Auto,
					SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL ReadFile
				(
					[In]				HANDLE hFile,
					[Out]			ref Byte[] lpBuffer,
					[In]				DWORD nNumberOfBytesToRead,
					[Out][Opt]		ref DWORD lpNumberOfBytesRead,
					[In][Out][Opt]		LPOVERLAPPED lpOverlapped
				);

			#endregion

			#region ReadFileEx

				/*
					BOOL WINAPI ReadFileEx
					(
						__in       HANDLE hFile,
						__out_opt  LPVOID lpBuffer,
						__in       DWORD nNumberOfBytesToRead,
						__inout    LPOVERLAPPED lpOverlapped,
						__in_opt   LPOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine
					);
				*/

				[DllImport("kernel32.dll",
					CallingConvention = CallingConvention.Winapi,
					CharSet = CharSet.Auto,
					SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL ReadFileEx
				(
					[In]			HANDLE hFile,
					[Out][Opt]	ref Byte[] lpBuffer,
					[In]			DWORD nNumberOfBytesToRead,
					[In][Out]		LPOVERLAPPED lpOverlapped,
					[In][Opt]		LPOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine
				);

			#endregion

			#region WriteFile

				/*
					BOOL WINAPI WriteFile
					(
						__in         HANDLE hFile,
						__in         LPCVOID lpBuffer,
						__in         DWORD nNumberOfBytesToWrite,
						__out_opt    LPDWORD lpNumberOfBytesWritten,
						__inout_opt  LPOVERLAPPED lpOverlapped
					);
				*/

				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL WriteFile
				(
					[In]				HANDLE hFile,
					[In]				LPCVOID lpBuffer, 
					[In]				DWORD nNumberOfBytesToWrite,
					[Out][Opt]		ref DWORD lpNumberOfBytesWritten,
					[In][Out][Opt]		LPOVERLAPPED lpOverlapped
				);

			#endregion

			#region WriteFileEx

				/*
					BOOL WINAPI WriteFileEx
					(
					  __in      HANDLE hFile,
					  __in_opt  LPCVOID lpBuffer,
					  __in      DWORD nNumberOfBytesToWrite,
					  __inout   LPOVERLAPPED lpOverlapped,
					  __in_opt  LPOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine
					);
				*/

				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL WriteFile
				(
					[In]		HANDLE hFile,
					[In][Opt]	LPCVOID lpBuffer, 
					[In]		DWORD nNumberOfBytesToWrite,
					[In][Out]	LPOVERLAPPED lpNumberOfBytesWritten,
					[In][Opt]	LPOVERLAPPED_COMPLETION_ROUTINE lpOverlapped
				);

			#endregion

			#region SetEndOfFile

				/*
					BOOL WINAPI SetEndOfFile
					(
					  __in  HANDLE hFile
					);
				*/

				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL SetEndOfFile
				(
					[In]	HANDLE hFile
				);

			#endregion

			#region FlushFileBuffers

				/*
					BOOL WINAPI FlushFileBuffers
					(
					  __in  HANDLE hFile
					);
				*/

				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL FlushFileBuffers
				(
					[In]	HANDLE hFile
				);

			#endregion

			#region FormatMessage

				/*
					DWORD WINAPI FormatMessage
					(
					  __in      DWORD dwFlags,
					  __in_opt  LPCVOID lpSource,
					  __in      DWORD dwMessageId,
					  __in      DWORD dwLanguageId,
					  __out     LPTSTR lpBuffer,
					  __in      DWORD nSize,
					  __in_opt  va_list *Arguments
					);
				*/

				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				[return: MarshalAs(UnmanagedType.U4)]
				public static extern DWORD FormatMessage
				(
					[In]			DWORD dwFlags,
					[In][Opt]		LPCVOID lpSource,
					[In]			DWORD dwMessageId,
					[In]			DWORD dwLanguageId,
					[Out]		ref LPTSTR lpBuffer,
					[In]			DWORD nSize,
					[In][Opt]		String[] pArguments
				);

			#endregion

			#region LocalAlloc

				/*
					HLOCAL WINAPI LocalFree
					(
					  __in  HLOCAL hMem
					);
				*/

				[SuppressUnmanagedCodeSecurity]
				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				public static extern SafeLocalAllocHandle LocalAlloc
				(
					[In]	IntPtr hMem
				);

			#endregion

			#region LocalFree

				/*
					HLOCAL WINAPI LocalFree
					(
					  __in  HLOCAL hMem
					);
				*/

				[SuppressUnmanagedCodeSecurity]
				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				public static extern IntPtr LocalFree
				(
					[In]	IntPtr hMem
				);

			#endregion

			#region LoadLibrary

				/*
					HMODULE WINAPI LoadLibrary
					(
						__in  LPCTSTR lpFileName
					);
				*/

				[SuppressUnmanagedCodeSecurity]
				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				public static extern SafeLibraryHandle LoadLibrary
				(
					[In]	LPCTSTR lpFileName
				);

			#endregion

			#region LoadLibraryEx

				/*
					HMODULE WINAPI LoadLibraryEx
					(
						__in        LPCTSTR lpFileName,
						__reserved  HANDLE hFile,
						__in        DWORD dwFlags
					);
				*/

				[SuppressUnmanagedCodeSecurity]
				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				public static extern SafeLibraryHandle LoadLibraryEx
				(
					[In]			LPCTSTR lpFileName,
					/*Reserved*/	HANDLE hFile,
					[In]			DWORD dwFlags
				);

			#endregion

			#region FreeLibrary

				/*
					BOOL WINAPI FreeLibrary
					(
						__in  HMODULE hModule
					);
				*/

				[SuppressUnmanagedCodeSecurity]
				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL FreeLibrary
				(
					[In]	IntPtr hModule
				);

			#endregion

			#region GetProcAddress

				/*
					FARPROC WINAPI GetProcAddress
					(
					  __in  HMODULE hModule,
					  __in  LPCSTR lpProcName
					);
				*/

				[SuppressUnmanagedCodeSecurity]
				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				public static extern IntPtr GetProcAddress
				(
					[In]	SafeLibraryHandle hModule,
					[In]	String lpProcName
				);

			#endregion


				/*
					BOOL WINAPI FreeLibrary
					(
					  __in  HMODULE hModule
					);
				*/
				/*
					VOID WINAPI FreeLibraryAndExitThread
					(
					  __in  HMODULE hModule,
					  __in  DWORD dwExitCode
					);
				*/
				/*
					DWORD WINAPI LoadModule
					(
					  __in  LPCSTR lpModuleName,
					  __in  LPVOID lpParameterBlock
					);
				*/
				/*
					FARPROC WINAPI GetProcAddress
					(
					  __in  HMODULE hModule,
					  __in  LPCSTR lpProcName
					);
				*/
				/*
					DWORD WINAPI GetModuleFileName
					(
					  __in_opt  HMODULE hModule,
					  __out     LPTSTR lpFilename,
					  __in      DWORD nSize
					);
				*/
				/*
					HMODULE WINAPI GetModuleHandle
					(
					  __in_opt  LPCTSTR lpModuleName
					);
				*/
				/*
					BOOL WINAPI GetModuleHandleEx
					(
					  __in      DWORD dwFlags,
					  __in_opt  LPCTSTR lpModuleName,
					  __out     HMODULE *phModule
					);
				*/
				/*
					HLOCAL WINAPI LocalFree
					(
					  __in  HLOCAL hMem
					);
				*/
				/*
					HLOCAL WINAPI LocalAlloc
					(
					  __in  UINT uFlags,
					  __in  SIZE_T uBytes
					);
				*/
				/*
					HLOCAL WINAPI LocalDiscard
					(
					  [in]  HLOCAL hlocMem
					);
				*/
				/*
					UINT WINAPI LocalFlags
					(
					  __in  HLOCAL hMem
					);
				*/
				/*
					HLOCAL WINAPI LocalHandle
					(
					  __in  LPCVOID pMem
					);
				*/
				/*
					LPVOID WINAPI LocalLock(
					  __in  HLOCAL hMem
					);
				*/
				/*
					HLOCAL WINAPI LocalReAlloc
					(
					  __in  HLOCAL hMem,
					  __in  SIZE_T uBytes,
					  __in  UINT uFlags
					);
				*/
				/*
					UINT WINAPI LocalSize
					(
					  __in  HLOCAL hMem
					);
				*/
				/*
					BOOL WINAPI LocalUnlock
					(
					  __in  HLOCAL hMem
					);
				*/
				/*
					LPVOID WINAPI HeapAlloc(
					  __in  HANDLE hHeap,
					  __in  DWORD dwFlags,
					  __in  SIZE_T dwBytes
					);
				*/
				/*
					SIZE_T WINAPI HeapCompact(
					  __in  HANDLE hHeap,
					  __in  DWORD dwFlags
					);
				*/
				/*
					HANDLE WINAPI HeapCreate(
					  __in  DWORD flOptions,
					  __in  SIZE_T dwInitialSize,
					  __in  SIZE_T dwMaximumSize
					);
				*/
				/*
					BOOL WINAPI HeapDestroy(
					  __in  HANDLE hHeap
					);
				*/
				/*
					BOOL WINAPI HeapFree(
					  __in  HANDLE hHeap,
					  __in  DWORD dwFlags,
					  __in  LPVOID lpMem
					);
				*/
				/*
					BOOL WINAPI HeapLock(
					  __in  HANDLE hHeap
					);
				*/
				/*
					BOOL WINAPI HeapQueryInformation(
					  __in_opt   HANDLE HeapHandle,
					  __in       HEAP_INFORMATION_CLASS HeapInformationClass,
					  __out      PVOID HeapInformation,
					  __in       SIZE_T HeapInformationLength,
					  __out_opt  PSIZE_T ReturnLength
					);
				*/
				/*
					LPVOID WINAPI HeapReAlloc(
					  __in  HANDLE hHeap,
					  __in  DWORD dwFlags,
					  __in  LPVOID lpMem,
					  __in  SIZE_T dwBytes
					);
				*/
				/*
					BOOL WINAPI HeapSetInformation(
					  __in_opt  HANDLE HeapHandle,
					  __in      HEAP_INFORMATION_CLASS HeapInformationClass,
					  __in      PVOID HeapInformation,
					  __in      SIZE_T HeapInformationLength
					);
				*/
				/*
					SIZE_T WINAPI HeapSize(
					  __in  HANDLE hHeap,
					  __in  DWORD dwFlags,
					  __in  LPCVOID lpMem
					);
				*/
				/*
					BOOL WINAPI HeapUnlock(
					  __in  HANDLE hHeap
					);
				*/
				/*
					BOOL WINAPI HeapValidate(
					  __in      HANDLE hHeap,
					  __in      DWORD dwFlags,
					  __in_opt  LPCVOID lpMem
					);
				*/
				/*
					BOOL WINAPI HeapWalk(
					  __in     HANDLE hHeap,
					  __inout  LPPROCESS_HEAP_ENTRY lpEntry
					);
				*/

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetShortPathName(
           [MarshalAs(UnmanagedType.LPTStr)] String lpszLongPath,
           [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszShortPath,
           uint cchBuffer);

        [DllImport("kernel32.dll", SetLastError = true)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern bool CreateHardLink(
            string lpszHardLinkPath,
            string lpszExistingFileName,
            IntPtr lpSecurityAttributes);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, int dwFlags);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern bool DeleteFile(string lpFileName);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern bool RemoveDirectory(string lpPathName);

        //[DllImport("kernel32.dll")]
        //public static extern Size GetConsoleFontSize(SafeFileHandle hConsoleOutput, int nFont);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        //[DllImport("kernel32.dll")]
        //public static extern bool GetCurrentConsoleFont(SafeFileHandle hConsoleOutput, bool bMaximumWindow, out ConsoleFontInfo lpConsoleCurrentFont);

        #region kernel32!CreateFile
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern SafeFileHandle CreateFile(
            string lpFileName,
            FileAccess dwDesiredAccess,
            FileShare dwShareMode,
            IntPtr lpSecurityAttributes,
            CreationDisposition dwCreationDisposition,
            FileAttributes dwFlagsAndAttributes,
            IntPtr hTemplateFile);
		#endregion

        #region kernel32!CreateConsoleScreenBuffer
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern SafeFileHandle CreateConsoleScreenBuffer(
            FileAccess dwDesiredAccess,
            FileShare dwShareMode,
            IntPtr lpSecurityAttributes,
            ConsoleScreenBufferFlags dwFlags,
            IntPtr lpScreenBufferData
        );
        #endregion

        #region kernel32!SetConsoleActiveScreenBuffer
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern bool SetConsoleActiveScreenBuffer(SafeFileHandle hConsoleOutput);
        #endregion

        #region ke
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleMode", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern bool GetConsoleInputMode(SafeFileHandle handle, out ConsoleInputModeFlags flags);

        [DllImport("kernel32.dll", EntryPoint = "GetConsoleMode", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern bool GetConsoleOutputMode(SafeFileHandle handle, out ConsoleOutputModeFlags flags);
        #endregion

		//#region kernel32!ReadConsoleInput
		//[DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
		//[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		//public static extern bool ReadConsoleInput(
		//    SafeFileHandle hConsoleInput,
		//    InputRecord[] lpBuffer,
		//    int nLength,
		//    ref int lpNumberOfEventsRead
		//);
		//#endregion

        #region kernel32!GetStdHandle
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern SafeFileHandle GetStdHandle(StdHandle nStdHandle);
        #endregion

        #region kernel32!FindFirstVolumeMountPoint
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern SafeVolumeMountPointHandle FindFirstVolumeMountPoint(
            string lpszRootPathName,
            StringBuilder lpszVolumeMountPointName,
            int cchStringBufferLength);
        #endregion

        #region kernel32!FindNextVolumeMountPoint
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool FindNextVolumeMountPoint(
            SafeVolumeMountPointHandle hFindVolume,
            StringBuilder lpszVolumeMountPointName,
            int cchStringBufferLength);
        #endregion

        #region kernel32!FindVolumeMountPointClose
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool FindVolumeMountPointClose(IntPtr hFindVolumeMountPoint);
        #endregion

        #region kernel32!GetVolumeNameForVolumeMountPoint
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetVolumeNameForVolumeMountPoint(
            string lpszVolumeMountPoint,
            StringBuilder lpszVolumeName,
            int cchStringBufferLength);
        #endregion

        #region kernel32!GetCurrentProcess
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetCurrentProcess();
        #endregion

        #region kernel32!GetModuleHandle
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        #endregion

        #region kernel32!IsWow64Process
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process(
             [In] IntPtr hProcess,
             [Out] out bool wow64Process);
        #endregion

        #region kernel32!DeleteVolumeMountPoint
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteVolumeMountPoint(string lpwszVolumeMountPoint);
        #endregion

        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern bool ReadFile(SafeFileHandle hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverLapped);
        [return: MarshalAs(UnmanagedType.Bool)]

        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern bool ReadFile(SafeFileHandle hFile, [MarshalAs(UnmanagedType.LPArray)] byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverLapped);

        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        public static Boolean GetVolumeBroadcast(IntPtr lParam, out DEV_BROADCAST_VOLUME volume)
        {
            try
            {
                volume = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(
                    lParam, typeof(DEV_BROADCAST_VOLUME));
                return true;
            }
            catch
            {
                volume = new DEV_BROADCAST_VOLUME();
                return false;
            }
        }


        //---------------------------------------------------------------------------------------------------
        // Native routines
        //---------------------------------------------------------------------------------------------------





        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr LoadLibraryEx(String lpFileName, IntPtr hFile, uint dwFlags);



        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);


        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr LockResource(IntPtr hResData);


        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FindResourceEx(IntPtr hModule, IntPtr lpType, IntPtr lpName, ushort wLanguage);


        //---------------------------------------------------------------------------------------------------
        //
        //---------------------------------------------------------------------------------------------------
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumResourceNames(IntPtr hModule, IntPtr lpszType,
            EnumResNameDelegate lpEnumFunc, Object lParam);


        //------------------------------------------------------------------------------------------
        // Returns a message from an error code
        //------------------------------------------------------------------------------------------
        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern uint FormatMessage(uint dwFlags, IntPtr lpSource,
            uint dwMessageId, uint dwLanguageId, ref IntPtr lpBuffer,
            uint nSize, IntPtr pArguments);


		#endregion
	}

}