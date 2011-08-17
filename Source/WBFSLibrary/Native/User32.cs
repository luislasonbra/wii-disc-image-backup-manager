﻿#region Using

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

	public class User32
	{
		#region Structs 

		#endregion

		#region Callback Function Pointer Delegates

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

				//[DllImport("kernel32.dll",
				//    CallingConvention = CallingConvention.Winapi,
				//    CharSet = CharSet.Auto,
				//    SetLastError = true)]
				//public static extern HANDLE CreateFile
				//(
				//    [In]			LPCTSTR lpFileName,
				//    [In]			DWORD dwDesiredAccess,
				//    [In]			DWORD dwShareMode,
				//    [In][Opt]	ref SECURITY_ATTRIBUTES lpSecurityAttributes,
				//    [In]			DWORD dwCreationDisposition,
				//    [In]			DWORD dwFlagsAndAttributes,
				//    [In][Opt]		HANDLE hTemplateFile
				//);

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

				//[DllImport("kernel32.dll",
				//    CallingConvention = CallingConvention.Winapi,
				//    CharSet = CharSet.Auto,
				//    SetLastError = true)]
				//[return: MarshalAs(UnmanagedType.Bool)]
				//public static extern BOOL DeviceIoControl
				//(
				//    [In]				HANDLE hDevice,
				//    [In]				DWORD dwIoControlCode,
				//    [In][Opt]			LPVOID lpInBuffer,
				//    [In]				DWORD nInBufferSize,
				//    [Out][Opt]			LPVOID lpOutBuffer,
				//    [In]				DWORD nOutBufferSize,
				//    [Out][Opt]		ref DWORD lpBytesReturned,
				//    [In][Out][Opt]		LPOVERLAPPED lpOverlapped
				//);

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

				//[DllImport("kernel32.dll",
				//    CallingConvention = CallingConvention.Winapi,
				//    CharSet = CharSet.Auto,
				//    SetLastError = true)]
				//[return: MarshalAs(UnmanagedType.Bool)]
				//public static extern BOOL GetVolumeInformation
				//(
				//    [In][Opt]		LPCTSTR RootPathName,
				//    [Out]			LPTSTR VolumeNameBuffer,
				//    [In]			DWORD VolumeNameSize,
				//    [Out][Opt]	ref DWORD VolumeSerialNumber,
				//    [Out][Opt]	ref DWORD MaximumComponentLength,
				//    [Out][Opt]	ref DWORD FileSystemFlags,
				//    [Out]			LPTSTR FileSystemNameBuffer,
				//    [In]			DWORD nFileSystemNameSize
				//);

			#endregion

            [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            static public extern IntPtr LoadCursorFromFile(String lpFileName);

            [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            static public extern IntPtr CreateCursor(IntPtr hInst, Int32 xHotSpot, Int32 yHotSpot, Int32 nWidth, Int32 nHeight, Byte[] pvANDPlane, Byte[] pvXORPlane);

            [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            static public extern IntPtr GetCursor();

            [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            static public extern Boolean DestroyCursor(IntPtr hCursor);

			//[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
			//static public extern Boolean GetCursorInfo(out WIN32_CURSOR_INFO lpInfo);

			//[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
			//static public extern Boolean GetCursorPos(out WIN32_CURSOR_POINT lpPoint);

		#endregion

	}

}