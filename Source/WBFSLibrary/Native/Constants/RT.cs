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

using WBFSLibrary.IO;
using WBFSLibrary.IO.Drives;
using WBFSLibrary.IO.FileSystems;
using WBFSLibrary.IO.FileTypes;
using WBFSLibrary.IO.FileOperations;
using WBFSLibrary.IO.Partitions;
using WBFSLibrary.IO.Streams;
using WBFSLibrary.Plugins;
using WBFSLibrary.Network;
using WBFSLibrary.Network.Internet;
using WBFSLibrary.Network.Local;
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
	
	#region RT

		public class RT
		{
			/*
				//
				//Predefined Resource Types
				//
				#define RT_CURSOR           MAKEINTRESOURCE(1)
				#define RT_BITMAP           MAKEINTRESOURCE(2)
				#define RT_ICON             MAKEINTRESOURCE(3)
				#define RT_MENU             MAKEINTRESOURCE(4)
				#define RT_DIALOG           MAKEINTRESOURCE(5)
				#define RT_STRING           MAKEINTRESOURCE(6)
				#define RT_FONTDIR          MAKEINTRESOURCE(7)
				#define RT_FONT             MAKEINTRESOURCE(8)
				#define RT_ACCELERATOR      MAKEINTRESOURCE(9)
				#define RT_RCDATA           MAKEINTRESOURCE(10)
				#define RT_MESSAGETABLE     MAKEINTRESOURCE(11)

				#define DIFFERENCE     11

				#define RT_GROUP_CURSOR MAKEINTRESOURCE((ULONG_PTR)(RT_CURSOR) + DIFFERENCE)
				#define RT_GROUP_ICON   MAKEINTRESOURCE((ULONG_PTR)(RT_ICON) + DIFFERENCE)
				#define RT_VERSION      MAKEINTRESOURCE(16)
				#define RT_DLGINCLUDE   MAKEINTRESOURCE(17)
				#if(WINVER >= 0x0400)
				#define RT_PLUGPLAY     MAKEINTRESOURCE(19)
				#define RT_VXD          MAKEINTRESOURCE(20)
				#define RT_ANICURSOR    MAKEINTRESOURCE(21)
				#define RT_ANIICON      MAKEINTRESOURCE(22)
				#endif // WINVER >= 0x0400
				#define RT_HTML         MAKEINTRESOURCE(23)
				#ifdef RC_INVOKED
				#define RT_MANIFEST                        24
				#else  // RC_INVOKED
				#define RT_MANIFEST                        MAKEINTRESOURCE(24)
				#endif // RC_INVOKED
			*/

			public static readonly UInt32	CURSOR						=	0x00000001;
			public static readonly UInt32	BITMAP						=	0x00000002;
			public static readonly UInt32	ICON  						=	0x00000003;
			public static readonly UInt32	MENU  						=	0x00000004;
			public static readonly UInt32	DIALOG						=	0x00000005;
			public static readonly UInt32	STRING						=	0x00000006;
			public static readonly UInt32	FONTDIR						=	0x00000007;
			public static readonly UInt32	FONT  						=	0x00000008;
			public static readonly UInt32	ACCELERATOR					=	0x00000009;
			public static readonly UInt32	RCDATA						=	0x0000000A;
			public static readonly UInt32	MESSAGETABLE				=	0x0000000B;
			public static readonly UInt32	DIFFERENCE					=	0x0000000B;
			public static readonly UInt32	GROUP_CURSOR				=	DIFFERENCE + CURSOR;
			public static readonly UInt32	GROUP_ICON					=	DIFFERENCE + ICON;
			public static readonly UInt32	VERSION						=	0x00000010;
			public static readonly UInt32	DLGINCLUDE					=	0x00000011;
			public static readonly UInt32	PLUGPLAY					=	0x00000013;
			public static readonly UInt32	VXD							=	0x00000014;
			public static readonly UInt32	ANICURSOR  					=	0x00000015;
			public static readonly UInt32	ANIICON						=	0x00000016;
			public static readonly UInt32	HTML						=	0x00000017;
			public static readonly UInt32	MANIFEST					=	0x00000018;
		};
			
	#endregion
}
