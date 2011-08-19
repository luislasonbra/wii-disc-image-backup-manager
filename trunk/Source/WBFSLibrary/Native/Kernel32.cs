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
	
	#region Kernel32 Specific Unmanaged Type Mapping Aliases Block

	    using _SECURITY_ATTRIBUTES = SECURITY_ATTRIBUTES;
	    using PSECURITY_ATTRIBUTES = SECURITY_ATTRIBUTES;
	    using LPSECURITY_ATTRIBUTES = SECURITY_ATTRIBUTES;

	#endregion

	public class Kernel32
	{
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

				[DllImport("kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
				public static extern HANDLE CreateFile
				(
					[In][MarshalAs(UnmanagedType.LPTStr)]	LPCTSTR lpFileName,
					[In]									DWORD dwDesiredAccess,
					[In]									DWORD dwShareMode,
					[In][Opt]							ref SECURITY_ATTRIBUTES lpSecurityAttributes,
					[In]									DWORD dwCreationDisposition,
					[In]									DWORD dwFlagsAndAttributes,
					[In][Opt]								HANDLE hTemplateFile
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
					[In][Opt][MarshalAs(UnmanagedType.LPTStr)]	LPCTSTR RootPathName,
					[Out][MarshalAs(UnmanagedType.LPTStr)]		LPTSTR VolumeNameBuffer,
					[In]										DWORD VolumeNameSize,
					[Out][Opt]								ref DWORD VolumeSerialNumber,
					[Out][Opt]								ref DWORD MaximumComponentLength,
					[Out][Opt]								ref DWORD FileSystemFlags,
					[Out]										LPTSTR FileSystemNameBuffer,
					[In]										DWORD nFileSystemNameSize
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
					[In][MarshalAs(UnmanagedType.LPTStr)]	LPCTSTR lpFileName
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
					[In][MarshalAs(UnmanagedType.LPTStr)]	LPCTSTR lpFileName,
					/*Reserved*/							HANDLE hFile,
					[In]									DWORD dwFlags
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

			#region GetCurrentThreadId

				/*
					DWORD WINAPI GetCurrentThreadId(void);
				*/

				[SuppressUnmanagedCodeSecurity]
				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				public static extern DWORD GetCurrentThreadId();

			#endregion

			#region FindVolumeMountPointClose

				/*
					BOOL WINAPI FindVolumeMountPointClose
					(
						__in  HANDLE hFindVolumeMountPoint
					);
				*/

				[SuppressUnmanagedCodeSecurity]
				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL FindVolumeMountPointClose
				(
					[In]	SafeVolumeMountPointHandle hFindVolumeMountPoint
				);

			#endregion

			#region GetShortPathName

				/*
					DWORD WINAPI GetShortPathName
					(
						__in   LPCTSTR lpszLongPath,
						__out  LPTSTR lpszShortPath,
						__in   DWORD cchBuffer
					);
				*/

				[SuppressUnmanagedCodeSecurity]
				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				public static extern DWORD GetShortPathName
				(
					[In][MarshalAs(UnmanagedType.LPTStr)]	LPCTSTR lpszLongPath,
					[Out][MarshalAs(UnmanagedType.LPTStr)]	LPTSTR lpszShortPath,
					[In]									DWORD cchBuffer
				);

			#endregion

			#region CreateHardLink

				/*
					BOOL WINAPI CreateHardLink
					(
						__in        LPCTSTR lpFileName,
						__in        LPCTSTR lpExistingFileName,
						__reserved  LPSECURITY_ATTRIBUTES lpSecurityAttributes
					);
				*/

				[SuppressUnmanagedCodeSecurity]
				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOL CreateHardLink
				(
					[In][MarshalAs(UnmanagedType.LPTStr)]	LPCTSTR lpFileName,
					[In][MarshalAs(UnmanagedType.LPTStr)]	LPCTSTR lpExistingFileName,
					/*Reserved*/							LPSECURITY_ATTRIBUTES lpSecurityAttributes
				);

			#endregion

			#region CreateSymbolicLink

				/*
					BOOLEAN WINAPI CreateSymbolicLink
					(
						__in  LPTSTR lpSymlinkFileName,
						__in  LPTSTR lpTargetFileName,
						__in  DWORD dwFlags
					);
				*/

				[SuppressUnmanagedCodeSecurity]
				[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
				[DllImport("kernel32.dll",
						CallingConvention = CallingConvention.Winapi,
						CharSet = CharSet.Auto,
						SetLastError = true)]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern BOOLEAN CreateSymbolicLink
				(
					[In][MarshalAs(UnmanagedType.LPTStr)]	LPCTSTR lpSymlinkFileName,
					[In][MarshalAs(UnmanagedType.LPTStr)]	LPCTSTR lpTargetFileName,
					[In]									DWORD dwFlags
				);

			#endregion






        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, int dwFlags);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern bool DeleteFile(string lpFileName);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern bool RemoveDirectory(string lpPathName);





        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        //[DllImport("kernel32.dll")]
        //public static extern Size GetConsoleFontSize(SafeFileHandle hConsoleOutput, int nFont);

        //[DllImport("kernel32.dll")]
        //public static extern bool GetCurrentConsoleFont(SafeFileHandle hConsoleOutput, bool bMaximumWindow, out ConsoleFontInfo lpConsoleCurrentFont);




		//[DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
		//[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		//public static extern SafeFileHandle CreateConsoleScreenBuffer(
		//    FileAccess dwDesiredAccess,
		//    FileShare dwShareMode,
		//    IntPtr lpSecurityAttributes,
		//    ConsoleScreenBufferFlags dwFlags,
		//    IntPtr lpScreenBufferData
		//);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static extern bool SetConsoleActiveScreenBuffer(SafeFileHandle hConsoleOutput);

		//[DllImport("kernel32.dll", EntryPoint = "GetConsoleMode", SetLastError = true, CharSet = CharSet.Unicode)]
		//[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		//public static extern bool GetConsoleInputMode(SafeFileHandle handle, out ConsoleInputModeFlags flags);

		//[DllImport("kernel32.dll", EntryPoint = "GetConsoleMode", SetLastError = true, CharSet = CharSet.Unicode)]
		//[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		//public static extern bool GetConsoleOutputMode(SafeFileHandle handle, out ConsoleOutputModeFlags flags);

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

		//#region kernel32!GetStdHandle
		//[DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
		//[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		//public static extern SafeFileHandle GetStdHandle(StdHandle nStdHandle);
		//#endregion

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

       
		/*
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
	    */

        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr LoadLibraryEx(String lpFileName, IntPtr hFile, uint dwFlags);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr LockResource(IntPtr hResData);


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FindResourceEx(IntPtr hModule, IntPtr lpType, IntPtr lpName, ushort wLanguage);



		//[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		//public static extern bool EnumResourceNames(IntPtr hModule, IntPtr lpszType,
		//    EnumResNameDelegate lpEnumFunc, Object lParam);


        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern uint FormatMessage(uint dwFlags, IntPtr lpSource,
            uint dwMessageId, uint dwLanguageId, ref IntPtr lpBuffer,
            uint nSize, IntPtr pArguments);


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

		#endregion
	}

}
