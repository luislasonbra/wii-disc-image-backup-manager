#region Using

	using System;
	using System.Collections;
	using System.Collections.Concurrent;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Collections.Specialized;
	using System.ComponentModel;
	using System.ComponentModel.Composition;
	using System.ComponentModel.Composition.AttributedModel;
	using System.ComponentModel.Composition.Diagnostics;
	using System.ComponentModel.Composition.Hosting;
	using System.ComponentModel.Composition.Primitives;
	using System.ComponentModel.Composition.ReflectionModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Resources;
	using System.ComponentModel.Design;
	using System.ComponentModel.Design.Data;
	using System.ComponentModel.Design.Serialization;
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
	using Microsoft.Internal;
	using Microsoft.Internal.Collections;
	using Microsoft.Internal.Performance;
	using Microsoft.Internal.Runtime;
	using Microsoft.Internal.Runtime.Serialization;
	using Microsoft.Win32;
	using Microsoft.Win32.SafeHandles;

	using Trinet.NTFS;

#endregion

using WBFSLibrary.Devices;
using WBFSLibrary.Drives;
using WBFSLibrary.IO;
using WBFSLibrary.IO.FileSystems;
using WBFSLibrary.IO.FileTypes;
using WBFSLibrary.IO.FileOperations;
using WBFSLibrary.IO.Streams;
using WBFSLibrary.Plugins;
using WBFSLibrary.Properties;

namespace WBFSLibrary
{
	#region Unmanaged Type Mapping Aliases Block v0.27

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

	#endregion
	
	#region DBT

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
		};

	#endregion
}
