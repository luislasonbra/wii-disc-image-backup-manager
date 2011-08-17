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

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct LARGE_INTEGER
	{
		[FieldOffset(0)]public s64 QuadPart;
		[FieldOffset(0)]public u32 LowPart;
		[FieldOffset(4)]public s32 HighPart;
	}

}
