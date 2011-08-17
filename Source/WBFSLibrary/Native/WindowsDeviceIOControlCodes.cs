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

	#region Constants

		public class GLOBAL
		{
			public static readonly UInt32			DELETE						=	0x10000000;
			public static readonly UInt32			READ_CONTROL				=	0x20000000;
			public static readonly UInt32			WRITE_DAC					=	0x40000000;
			public static readonly UInt32			WRITE_OWNER					=	0x80000000;
			public static readonly UInt32			SYNCHRONIZE					=	0x40000000;

			public static readonly UInt32			CREATE_NEW					=	1;
			public static readonly UInt32			CREATE_ALWAYS				=	2;
			public static readonly UInt32			OPEN_EXISTING				=	3;
			public static readonly UInt32			OPEN_ALWAYS					=	4;
			public static readonly UInt32			TRUNCATE_EXISTING			=	5;

			public static readonly UInt32			VALID_NTFT					=	0xC0;
			public static readonly UInt32			PARTITION_NTFT				=	0x80;

			public static readonly SafeFileHandle	HANDLE_INVALID_VALUE		=	new SafeFileHandle(new IntPtr(-1), true);
		}

		public class GENERIC
		{
			public static readonly UInt32	ALL						=	0x10000000;
			public static readonly UInt32	EXECUTE					=	0x20000000;
			public static readonly UInt32	WRITE					=	0x40000000;
			public static readonly UInt32	READ					=	0x80000000;
		}

		public class STANDARD_RIGHTS
		{
			public static readonly UInt32	REQUIRED				=	0x000F0000;
			public static readonly UInt32	READ					=	GLOBAL.READ_CONTROL;
			public static readonly UInt32	WRITE					=	GLOBAL.READ_CONTROL;
			public static readonly UInt32	EXECUTE					=	GLOBAL.READ_CONTROL;
			public static readonly UInt32	ALL						=	0x001F0000;
		}

		public class SPECIFIC_RIGHTS
		{
			public static readonly UInt32	ALL						=	0x0000FFFF;
		}

		public class FILE_SHARE
		{
			public static readonly UInt32	READ					=	0x00000001;
			public static readonly UInt32	WRITE					=	0x00000002;
			public static readonly UInt32	DELETE					=	0x00000004;
		}

		public class FILE_ATTRIBUTE
		{
			public static readonly UInt32	READONLY				=	0x00000001;
			public static readonly UInt32	HIDDEN					=	0x00000002;
			public static readonly UInt32	SYSTEM					=	0x00000004;
			public static readonly UInt32	DIRECTORY				=	0x00000010;
			public static readonly UInt32	ARCHIVE					=	0x00000020;
			public static readonly UInt32	DEVICE					=	0x00000040;
			public static readonly UInt32	NORMAL					=	0x00000080;
			public static readonly UInt32	TEMPORARY				=	0x00000100;
			public static readonly UInt32	SPARSE_FILE				=	0x00000200;
			public static readonly UInt32	REPARSE_POINT			=	0x00000400;
			public static readonly UInt32	COMPRESSED				=	0x00000800;
			public static readonly UInt32	OFFLINE					=	0x00001000;
			public static readonly UInt32	NOT_CONTENT_INDEXED		=	0x00002000;
			public static readonly UInt32	ENCRYPTED				=	0x00004000;
			public static readonly UInt32	VIRTUAL					=	0x00010000;
		}

		public class FILE_NOTIFY
		{
			public static readonly UInt32	CHANGE_FILE_NAME		=	0x00000001;
			public static readonly UInt32	CHANGE_DIR_NAME			=	0x00000002;
			public static readonly UInt32	CHANGE_ATTRIBUTES		=	0x00000004;
			public static readonly UInt32	CHANGE_SIZE				=	0x00000008;
			public static readonly UInt32	CHANGE_LAST_WRITE		=	0x00000010;
			public static readonly UInt32	CHANGE_LAST_ACCESS		=	0x00000020;
			public static readonly UInt32	CHANGE_CREATION			=	0x00000040;
			public static readonly UInt32	CHANGE_SECURITY			=	0x00000100;
		}

		public class FILE_ACTION
		{
			public static readonly UInt32	ADDED					=	0x00000001;
			public static readonly UInt32	REMOVED					=	0x00000002;
			public static readonly UInt32	MODIFIED				=	0x00000003;
			public static readonly UInt32	RENAMED_OLD_NAME		=	0x00000004;
			public static readonly UInt32	RENAMED_NEW_NAME		=	0x00000005;
		}

		public class MAILSLOT
		{
			public static readonly Int32		NO_MESSAGE				=	-1;
			public static readonly Int32		WAIT_FOREVER			=	-1;
		}
		
		public class GUID_DEVINTERFACE
		{
			public static readonly Guid		DISK						=	new	Guid(0x53f56307, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		CDROM						=	new	Guid(0x53f56308, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		PARTITION					=	new	Guid(0x53f5630a, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		TAPE						=	new	Guid(0x53f5630b, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		WRITEONCEDISK				=	new	Guid(0x53f5630c, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		VOLUME						=	new	Guid(0x53f5630d, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		MEDIUMCHANGER				=	new	Guid(0x53f56310, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		FLOPPY						=	new	Guid(0x53f56311, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		CDCHANGER					=	new	Guid(0x53f56312, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		STORAGEPORT					=	new	Guid(0x2accfe60, 0xc130, 0x11d2, 0xb0, 0x82, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		HIDDEN_VOLUME				=	new	Guid(0x53f56311, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		COMPORT						=	new	Guid(0x53f56312, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
			public static readonly Guid		SERENUM_BUS_ENUMERATOR		=	new	Guid(0x2accfe60, 0xc130, 0x11d2, 0xb0, 0x82, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);

			public static readonly Guid		DiskClassGuid					=		DISK;
			public static readonly Guid		CdRomClassGuid					=		CDROM;
			public static readonly Guid		PartitionClassGuid				=		PARTITION;
			public static readonly Guid		TapeClassGuid					=		TAPE;
			public static readonly Guid		WriteOnceDiskClassGuid			=		WRITEONCEDISK;
			public static readonly Guid		VolumeClassGuid					=		VOLUME;
			public static readonly Guid		MediumChangerClassGuid			=		MEDIUMCHANGER;
			public static readonly Guid		FloppyClassGuid					=		FLOPPY;
			public static readonly Guid		CdChangerClassGuid				=		CDCHANGER;
			public static readonly Guid		StoragePortClassGuid			=		STORAGEPORT;
			public static readonly Guid		HiddenVolumeClassGuid			=		HIDDEN_VOLUME;
			public static readonly Guid		GUID_CLASS_COMPORT				=		COMPORT;
			public static readonly Guid		GUID_SERENUM_BUS_ENUMERATOR		=		SERENUM_BUS_ENUMERATOR;
		}

		public class FILE_TYPE_NOTIFICATION_GUID
		{
			public static readonly Guid		PAGE_FILE					=	new	Guid(0x0d0a64a1, 0x38fc, 0x4db8, 0x9f, 0xe7, 0x3f, 0x43, 0x52, 0xcd, 0x7c, 0x5c);
			public static readonly Guid		HIBERNATION_FILE			=	new	Guid(0xb7624d64, 0xb9a3, 0x4cf8, 0x80, 0x11, 0x5b, 0x86, 0xc9, 0x40, 0xe7, 0xb7);
			public static readonly Guid		CRASHDUMP_FILE				=	new	Guid(0x9d453eb7, 0xd2a6, 0x4dbd, 0xa2, 0xe3, 0xfb, 0xd0, 0xed, 0x91, 0x09, 0xa9);
		}

		public class WDI_STORAGE
		{
			public static readonly Guid		PREDICT_FAILURE_DPS_GUID	=	new	Guid(0xe9f2d03a, 0x747c, 0x41c2, 0xbb, 0x9a, 0x02, 0xc6, 0x2b, 0x6d, 0x5f, 0xcb);
		}
	
		public class WMI_DISK
		{
			public static readonly Guid		GEOMETRY_GUID				=	new	Guid(0x25007f51, 0x57c2, 0x11d1, 0xa5, 0x28, 0x0, 0xa0, 0xc9, 0x6, 0x29, 0x10);
		}

		public class FILE
		{
			public static readonly UInt32	ANY_ACCESS						=	0x0000;
			public static readonly UInt32	SPECIAL_ACCESS					=	ANY_ACCESS;
			public static readonly UInt32	READ_ACCESS						=	0x0001;
			public static readonly UInt32	WRITE_ACCESS					=	0x0002;

			public static readonly UInt32	CASE_SENSITIVE_SEARCH			=	0x00000001;
			public static readonly UInt32	CASE_PRESERVED_NAMES			=	0x00000002;
			public static readonly UInt32	UNICODE_ON_DISK					=	0x00000004;
			public static readonly UInt32	PERSISTENT_ACLS					=	0x00000008;
			public static readonly UInt32	FILE_COMPRESSION				=	0x00000010;
			public static readonly UInt32	VOLUME_QUOTAS					=	0x00000020;
			public static readonly UInt32	SUPPORTS_SPARSE_FILES			=	0x00000040;
			public static readonly UInt32	SUPPORTS_REPARSE_POINTS			=	0x00000080;
			public static readonly UInt32	SUPPORTS_REMOTE_STORAGE			=	0x00000100;
			public static readonly UInt32	VOLUME_IS_COMPRESSED			=	0x00008000;
			public static readonly UInt32	SUPPORTS_OBJECT_IDS				=	0x00010000;
			public static readonly UInt32	SUPPORTS_ENCRYPTION				=	0x00020000;
			public static readonly UInt32	NAMED_STREAMS					=	0x00040000;
			public static readonly UInt32	READ_ONLY_VOLUME				=	0x00080000;
			public static readonly UInt32	SEQUENTIAL_WRITE_ONCE			=	0x00100000;
			public static readonly UInt32	SUPPORTS_TRANSACTIONS			=	0x00200000;
			public static readonly UInt32	SUPPORTS_HARD_LINKS				=	0x00400000;
			public static readonly UInt32	SUPPORTS_EXTENDED_ATTRIBUTES	=	0x00800000;
			public static readonly UInt32	SUPPORTS_OPEN_BY_FILE_ID		=	0x01000000;
			public static readonly UInt32	SUPPORTS_USN_JOURNAL			=	0x02000000;

			public static readonly UInt32	READ_DATA						=	0x0001;
			public static readonly UInt32	LIST_DIRECTORY					=	0x0001;
			public static readonly UInt32	WRITE_DATA						=	0x0002;
			public static readonly UInt32	ADD_FILE						=	0x0002;
			public static readonly UInt32	APPEND_DATA						=	0x0004;
			public static readonly UInt32	ADD_SUBDIRECTORY				=	0x0004;
			public static readonly UInt32	CREATE_PIPE_INSTANCE			=	0x0004;
			public static readonly UInt32	READ_EA							=	0x0008;
			public static readonly UInt32	WRITE_EA						=	0x0010;
			public static readonly UInt32	EXECUTE							=	0x0020;
			public static readonly UInt32	TRAVERSE						=	0x0020;
			public static readonly UInt32	DELETE_CHILD					=	0x0040;
			public static readonly UInt32	READ_ATTRIBUTES					=	0x0080;
			public static readonly UInt32	WRITE_ATTRIBUTES				=	0x0100;

			public static readonly UInt32	FILE_ALL_ACCESS					=	(STANDARD_RIGHTS.REQUIRED | GLOBAL.SYNCHRONIZE | 0x1FF);
			public static readonly UInt32	FILE_GENERIC_READ				=	(STANDARD_RIGHTS.READ | FILE.READ_DATA | FILE.READ_ATTRIBUTES | FILE.READ_EA |  GLOBAL.SYNCHRONIZE);
			public static readonly UInt32	FILE_GENERIC_WRITE				=	(STANDARD_RIGHTS.WRITE | FILE.WRITE_DATA | FILE.WRITE_ATTRIBUTES | FILE.WRITE_EA | FILE.APPEND_DATA | GLOBAL.SYNCHRONIZE);
			public static readonly UInt32	FILE_GENERIC_EXECUTE			=	(STANDARD_RIGHTS.EXECUTE | FILE.READ_ATTRIBUTES | FILE.EXECUTE | GLOBAL.SYNCHRONIZE);
		}

		public class FILE_DEVICE
		{
			public static readonly UInt32	BEEP					=	0x00000001;
			public static readonly UInt32	CD_ROM					=	0x00000002;
			public static readonly UInt32	CD_ROM_FILE_SYSTEM		=	0x00000003;
			public static readonly UInt32	CONTROLLER				=	0x00000004;
			public static readonly UInt32	DATALINK				=	0x00000005;
			public static readonly UInt32	DFS						=	0x00000006;
			public static readonly UInt32	DISK					=	0x00000007;
			public static readonly UInt32	DISK_FILE_SYSTEM		=	0x00000008;
			public static readonly UInt32	FILE_SYSTEM				=	0x00000009;
			public static readonly UInt32	INPORT_PORT				=	0x0000000a;
			public static readonly UInt32	KEYBOARD				=	0x0000000b;
			public static readonly UInt32	MAILSLOT				=	0x0000000c;
			public static readonly UInt32	MIDI_IN					=	0x0000000d;
			public static readonly UInt32	MIDI_OUT				=	0x0000000e;
			public static readonly UInt32	MOUSE					=	0x0000000f;
			public static readonly UInt32	MULTI_UNC_PROVIDER		=	0x00000010;
			public static readonly UInt32	NAMED_PIPE				=	0x00000011;
			public static readonly UInt32	NETWORK					=	0x00000012;
			public static readonly UInt32	NETWORK_BROWSER			=	0x00000013;
			public static readonly UInt32	NETWORK_FILE_SYSTEM		=	0x00000014;
			public static readonly UInt32	NULL					=	0x00000015;
			public static readonly UInt32	PARALLEL_PORT			=	0x00000016;
			public static readonly UInt32	PHYSICAL_NETCARD		=	0x00000017;
			public static readonly UInt32	PRINTER					=	0x00000018;
			public static readonly UInt32	SCANNER					=	0x00000019;
			public static readonly UInt32	SERIAL_MOUSE_PORT		=	0x0000001a;
			public static readonly UInt32	SERIAL_PORT				=	0x0000001b;
			public static readonly UInt32	SCREEN					=	0x0000001c;
			public static readonly UInt32	SOUND					=	0x0000001d;
			public static readonly UInt32	STREAMS					=	0x0000001e;
			public static readonly UInt32	TAPE					=	0x0000001f;
			public static readonly UInt32	TAPE_FILE_SYSTEM		=	0x00000020;
			public static readonly UInt32	TRANSPORT				=	0x00000021;
			public static readonly UInt32	UNKNOWN					=	0x00000022;
			public static readonly UInt32	VIDEO					=	0x00000023;
			public static readonly UInt32	VIRTUAL_DISK			=	0x00000024;
			public static readonly UInt32	WAVE_IN					=	0x00000025;
			public static readonly UInt32	WAVE_OUT				=	0x00000026;
			public static readonly UInt32	PORT_8042				=	0x00000027;
			public static readonly UInt32	NETWORK_REDIRECTOR		=	0x00000028;
			public static readonly UInt32	BATTERY					=	0x00000029;
			public static readonly UInt32	BUS_EXTENDER			=	0x0000002a;
			public static readonly UInt32	MODEM					=	0x0000002b;
			public static readonly UInt32	VDM						=	0x0000002c;
			public static readonly UInt32	MASS_STORAGE			=	0x0000002d;
			public static readonly UInt32	SMB						=	0x0000002e;
			public static readonly UInt32	KS						=	0x0000002f;
			public static readonly UInt32	CHANGER					=	0x00000030;
			public static readonly UInt32	SMARTCARD				=	0x00000031;
			public static readonly UInt32	ACPI					=	0x00000032;
			public static readonly UInt32	DVD						=	0x00000033;
			public static readonly UInt32	FULLSCREEN_VIDEO		=	0x00000034;
			public static readonly UInt32	DFS_FILE_SYSTEM			=	0x00000035;
			public static readonly UInt32	DFS_VOLUME				=	0x00000036;
			public static readonly UInt32	SERENUM					=	0x00000037;
			public static readonly UInt32	TERMSRV					=	0x00000038;
			public static readonly UInt32	KSEC					=	0x00000039;
			public static readonly UInt32	FIPS					=	0x0000003A;
			public static readonly UInt32	INFINIBAND				=	0x0000003B;
			public static readonly UInt32	VMBUS					=	0x0000003E;
			public static readonly UInt32	CRYPT_PROVIDER			=	0x0000003F;
			public static readonly UInt32	WPD						=	0x00000040;
			public static readonly UInt32	BLUETOOTH				=	0x00000041;
			public static readonly UInt32	MT_COMPOSITE			=	0x00000042;
			public static readonly UInt32	MT_TRANSPORT			=	0x00000043;
			public static readonly UInt32	BIOMETRIC				=	0x00000044;
			public static readonly UInt32	PMI						=	0x00000045;
		}

		public class METHOD
		{
			public static readonly UInt32	BUFFERED				=	0x00000000;
			public static readonly UInt32	IN_DIRECT				=	0x00000001;
			public static readonly UInt32	OUT_DIRECT				=	0x00000002;
			public static readonly UInt32	NEITHER					=	0x00000003;
			public static readonly UInt32	DIRECT_TO_HARDWARE		=	IN_DIRECT;
			public static readonly UInt32	DIRECT_FROM_HARDWARE	=	OUT_DIRECT;
		}

		public class IOCTL_DISK
		{
			public static uint CTL_CODE(uint deviceType, uint function, uint method, uint access)
			{
				return ( ((deviceType) << 16) | ((access) << 14) | ((function) << 2) | (method) );
			}

			public static readonly UInt32	BASE					=		FILE_DEVICE.DISK;
			public static readonly UInt32	GET_DRIVE_GEOMETRY		=		CTL_CODE(BASE, 0x0000, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_PARTITION_INFO		=		CTL_CODE(BASE, 0x0001, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	SET_PARTITION_INFO		=		CTL_CODE(BASE, 0x0002, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	GET_DRIVE_LAYOUT		=		CTL_CODE(BASE, 0x0003, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	SET_DRIVE_LAYOUT		=		CTL_CODE(BASE, 0x0004, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	VERIFY					=		CTL_CODE(BASE, 0x0005, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	FORMAT_TRACKS			=		CTL_CODE(BASE, 0x0006, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	REASSIGN_BLOCKS			=		CTL_CODE(BASE, 0x0007, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	PERFORMANCE				=		CTL_CODE(BASE, 0x0008, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	IS_WRITABLE				=		CTL_CODE(BASE, 0x0009, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	LOGGING					=		CTL_CODE(BASE, 0x000a, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	FORMAT_TRACKS_EX		=		CTL_CODE(BASE, 0x000b, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	HISTOGRAM_STRUCTURE		=		CTL_CODE(BASE, 0x000c, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	HISTOGRAM_DATA			=		CTL_CODE(BASE, 0x000d, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	HISTOGRAM_RESET			=		CTL_CODE(BASE, 0x000e, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	REQUEST_STRUCTURE		=		CTL_CODE(BASE, 0x000f, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	REQUEST_DATA			=		CTL_CODE(BASE, 0x0010, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	PERFORMANCE_OFF			=		CTL_CODE(BASE, 0x0018, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	CONTROLLER_NUMBER		=		CTL_CODE(BASE, 0x0011, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_PARTITION_INFO_EX	=		CTL_CODE(BASE, 0x0012, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	SET_PARTITION_INFO_EX	=		CTL_CODE(BASE, 0x0013, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	GET_DRIVE_LAYOUT_EX		=		CTL_CODE(BASE, 0x0014, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	SET_DRIVE_LAYOUT_EX		=		CTL_CODE(BASE, 0x0015, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	CREATE_DISK				=		CTL_CODE(BASE, 0x0016, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	GET_LENGTH_INFO			=		CTL_CODE(BASE, 0x0017, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	GET_DRIVE_GEOMETRY_EX	=		CTL_CODE(BASE, 0x0028, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	REASSIGN_BLOCKS_EX		=		CTL_CODE(BASE, 0x0029, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	UPDATE_DRIVE_SIZE		=		CTL_CODE(BASE, 0x0032, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	GROW_PARTITION			=		CTL_CODE(BASE, 0x0034, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	GET_CACHE_INFORMATION	=		CTL_CODE(BASE, 0x0035, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	SET_CACHE_INFORMATION	=		CTL_CODE(BASE, 0x0036, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	GET_WRITE_CACHE_STATE	=		CTL_CODE(BASE, 0x0037, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	DELETE_DRIVE_LAYOUT		=		CTL_CODE(BASE, 0x0040, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	UPDATE_PROPERTIES		=		CTL_CODE(BASE, 0x0050, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	FORMAT_DRIVE			=		CTL_CODE(BASE, 0x00f3, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	SENSE_DEVICE			=		CTL_CODE(BASE, 0x00f8, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	CHECK_VERIFY			=		CTL_CODE(BASE, 0x0200, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	MEDIA_REMOVAL			=		CTL_CODE(BASE, 0x0201, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	EJECT_MEDIA				=		CTL_CODE(BASE, 0x0202, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	LOAD_MEDIA				=		CTL_CODE(BASE, 0x0203, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	RESERVE					=		CTL_CODE(BASE, 0x0204, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	RELEASE					=		CTL_CODE(BASE, 0x0205, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	FIND_NEW_DEVICES		=		CTL_CODE(BASE, 0x0206, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	GET_MEDIA_TYPES			=		CTL_CODE(BASE, 0x0300, METHOD.BUFFERED, FILE.ANY_ACCESS);
		}

		public class OBSOLETE_IOCTL_DISK
		{
			public static uint CTL_CODE(uint deviceType, uint function, uint method, uint access)  
			{
				return ( ((deviceType) << 16) | ((access) << 14) | ((function) << 2) | (method) );
			}

			public static readonly UInt32	BASE					=		FILE_DEVICE.MASS_STORAGE;
			public static readonly UInt32	GET_WRITE_CACHE_STATE	=		CTL_CODE(BASE, 0x0037, METHOD.BUFFERED, FILE.READ_ACCESS);
		}

		public class SMART
		{
			public static uint CTL_CODE(uint deviceType, uint function, uint method, uint access)  
			{
				return ( ((deviceType) << 16) | ((access) << 14) | ((function) << 2) | (method) );
			}

			public static readonly UInt32	BASE					=		FILE_DEVICE.MASS_STORAGE;
			public static readonly UInt32	GET_VERSION				=		CTL_CODE(BASE, 0x0020, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	SEND_DRIVE_COMMAND		=		CTL_CODE(BASE, 0x0021, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	RCV_DRIVE_DATA			=		CTL_CODE(BASE, 0x0022, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
		}

		public class PARTITION
		{
			public static readonly UInt32	ENTRY_UNUSED			=		0x00;
			public static readonly UInt32	FAT_12					=		0x01;
			public static readonly UInt32	XENIX_1					=		0x02;
			public static readonly UInt32	XENIX_2					=		0x03;
			public static readonly UInt32	FAT_16					=		0x04;
			public static readonly UInt32	EXTENDED				=		0x05;
			public static readonly UInt32	HUGE					=		0x06;
			public static readonly UInt32	IFS						=		0x07;
			public static readonly UInt32	OS2BOOTMGR				=		0x0A;
			public static readonly UInt32	FAT32					=		0x0B;
			public static readonly UInt32	FAT32_XINT13			=		0x0C;
			public static readonly UInt32	XINT13					=		0x0E;
			public static readonly UInt32	XINT13_EXTENDED			=		0x0F;
			public static readonly UInt32	PREP					=		0x41;
			public static readonly UInt32	LDM						=		0x42;
			public static readonly UInt32	UNIX					=		0x63;

			public static readonly UInt32	LINUX_SWAP				=		0x82;
			public static readonly UInt32	LINUX_NATIVE			=		0x83;
			public static readonly UInt32	HIBERNATION				=		0x84;
			public static readonly UInt32	EXTENDED_LINUX			=		0x85;
		}

		public class IOCTL_STORAGE
		{
			public static uint CTL_CODE(uint deviceType, uint function, uint method, uint access)
			{
				return ( ((deviceType) << 16) | ((access) << 14) | ((function) << 2) | (method) );
			}

			public static readonly UInt32	BASE							=		FILE_DEVICE.MASS_STORAGE;
			public static readonly UInt32	CHECK_VERIFY					=		CTL_CODE(BASE, 0x0200, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	CHECK_VERIFY2					=		CTL_CODE(BASE, 0x0200, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	MEDIA_REMOVAL					=		CTL_CODE(BASE, 0x0201, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	EJECT_MEDIA						=		CTL_CODE(BASE, 0x0202, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	LOAD_MEDIA						=		CTL_CODE(BASE, 0x0203, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	LOAD_MEDIA2						=		CTL_CODE(BASE, 0x0203, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	RESERVE							=		CTL_CODE(BASE, 0x0204, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	RELEASE							=		CTL_CODE(BASE, 0x0205, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	FIND_NEW_DEVICES				=		CTL_CODE(BASE, 0x0206, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	EJECTION_CONTROL				=		CTL_CODE(BASE, 0x0250, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	MCN_CONTROL						=		CTL_CODE(BASE, 0x0251, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_MEDIA_TYPES					=		CTL_CODE(BASE, 0x0300, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_MEDIA_TYPES_EX				=		CTL_CODE(BASE, 0x0301, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_MEDIA_SERIAL_NUMBER			=		CTL_CODE(BASE, 0x0304, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_HOTPLUG_INFO				=		CTL_CODE(BASE, 0x0305, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	SET_HOTPLUG_INFO				=		CTL_CODE(BASE, 0x0306, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	RESET_BUS						=		CTL_CODE(BASE, 0x0400, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	RESET_DEVICE					=		CTL_CODE(BASE, 0x0401, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	BREAK_RESERVATION				=		CTL_CODE(BASE, 0x0405, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	PERSISTENT_RESERVE_IN			=		CTL_CODE(BASE, 0x0406, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	PERSISTENT_RESERVE_OUT			=		CTL_CODE(BASE, 0x0407, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	GET_DEVICE_NUMBER				=		CTL_CODE(BASE, 0x0420, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	PREDICT_FAILURE					=		CTL_CODE(BASE, 0x0440, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	READ_CAPACITY					=		CTL_CODE(BASE, 0x0450, METHOD.BUFFERED, FILE.READ_ACCESS);

			public static readonly UInt32	QUERY_PROPERTY					=		CTL_CODE(BASE, 0x0500, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	MANAGE_DATA_SET_ATTRIBUTES		=		CTL_CODE(BASE, 0x0501, METHOD.BUFFERED, FILE.WRITE_ACCESS);

			public static readonly UInt32	GET_BC_PROPERTIES				=		CTL_CODE(BASE, 0x0600, METHOD.BUFFERED, FILE.READ_ACCESS);
			public static readonly UInt32	ALLOCATE_BC_STREAM				=		CTL_CODE(BASE, 0x0601, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	FREE_BC_STREAM					=		CTL_CODE(BASE, 0x0602, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);

			public static readonly UInt32	CHECK_PRIORITY_HINT_SUPPORT		=		CTL_CODE(BASE, 0x0620, METHOD.BUFFERED, FILE.ANY_ACCESS);
		}

		public class OBSOLETE_IOCTL_STORAGE
		{
			public static uint CTL_CODE(uint deviceType, uint function, uint method, uint access)  
			{
				return ( ((deviceType) << 16) | ((access) << 14) | ((function) << 2) | (method) );
			}

			public static readonly UInt32	BASE							=		FILE_DEVICE.MASS_STORAGE;
			public static readonly UInt32	RESET_BUS						=		CTL_CODE(BASE, 0x0400, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
			public static readonly UInt32	RESET_DEVICE					=		CTL_CODE(BASE, 0x0401, METHOD.BUFFERED, FILE.READ_ACCESS | FILE.WRITE_ACCESS);
		}

		public class MEDIA
		{
			public static readonly UInt32	ERASEABLE				=	0x00000001;
			public static readonly UInt32	WRITE_ONCE				=	0x00000002;
			public static readonly UInt32	READ_ONLY				=	0x00000004;
			public static readonly UInt32	READ_WRITE				=	0x00000002;
			public static readonly UInt32	WRITE_PROTECTED			=	0x00000100;
			public static readonly UInt32	CURRENTLY_MOUNTED		=	0x80000000;
		}

		public class TAPE
		{
			public static readonly UInt32	STATISTICS				=	0x00000000;
			public static readonly UInt32	RETURN_ENV_INFO			=	0x00000001;
			public static readonly UInt32	RESET_STATISTIC			=	0x00000002;
		}

		public class VALID
		{
			public static readonly UInt32	RECOVERED_WRITES		=	0x00000001;
			public static readonly UInt32	UNRECOVERED_WRITES		=	0x00000002;
			public static readonly UInt32	RECOVERED_READS			=	0x00000004;
			public static readonly UInt32	UNRECOVERED_READS		=	0x00000008;
			public static readonly UInt32	WRITE_COMPRESSION_INFO	=	0x00000010;
			public static readonly UInt32	READ_COMPRESSION_INFO	=	0x00000020;
		}

		public class FSCTL
		{
			public static uint CTL_CODE(uint deviceType, uint function, uint method, uint access)
			{
				return ( ((deviceType) << 16) | ((access) << 14) | ((function) << 2) | (method) );
			}

			public static readonly UInt32	REQUEST_OPLOCK_LEVEL_1							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 0, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	REQUEST_OPLOCK_LEVEL_2							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 1, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	REQUEST_BATCH_OPLOCK							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 2, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	OPLOCK_BREAK_ACKNOWLEDGE						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 3, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	OPBATCH_ACK_CLOSE_PENDING 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 4, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	OPLOCK_BREAK_NOTIFY								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 5, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	LOCK_VOLUME										=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 6, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	UNLOCK_VOLUME			 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 7, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	DISMOUNT_VOLUME									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 8, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	IS_VOLUME_MOUNTED		 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 10, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	IS_PATHNAME_VALID		 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 11, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	MARK_VOLUME_DIRTY		 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 12, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	QUERY_RETRIEVAL_POINTERS						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 14, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_COMPRESSION									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 15, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	SET_COMPRESSION									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 16, METHOD.BUFFERED, FILE.READ_DATA | FILE.WRITE_DATA);

			public static readonly UInt32	SET_BOOTLOADER_ACCESSED							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 19, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	OPLOCK_BREAK_ACK_NO_2	 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 20, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	INVALIDATE_VOLUMES								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 21, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	QUERY_FAT_BPB			 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 22, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	REQUEST_FILTER_OPLOCK	 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 23, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	FILESYSTEM_GET_STATISTICS 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 24, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	GET_NTFS_VOLUME_DATA							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 25, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_NTFS_FILE_RECORD							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 26, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_VOLUME_BITMAP		 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 27, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_RETRIEVAL_POINTERS							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 28, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	MOVE_FILE				 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 29, METHOD.BUFFERED, FILE.SPECIAL_ACCESS);
			public static readonly UInt32	IS_VOLUME_DIRTY									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 30, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	ALLOW_EXTENDED_DASD_IO							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 32, METHOD.NEITHER, FILE.ANY_ACCESS);

			public static readonly UInt32	FIND_FILES_BY_SID		 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 35, METHOD.NEITHER, FILE.ANY_ACCESS);

			public static readonly UInt32	SET_OBJECT_ID			 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 38, METHOD.BUFFERED, FILE.SPECIAL_ACCESS);
			public static readonly UInt32	GET_OBJECT_ID			 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 39, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	DELETE_OBJECT_ID								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 40, METHOD.BUFFERED, FILE.SPECIAL_ACCESS);
			public static readonly UInt32	SET_REPARSE_POINT		 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 41, METHOD.BUFFERED, FILE.SPECIAL_ACCESS);
			public static readonly UInt32	GET_REPARSE_POINT		 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 42, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	DELETE_REPARSE_POINT							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 43, METHOD.BUFFERED, FILE.SPECIAL_ACCESS);
			public static readonly UInt32	ENUM_USN_DATA			 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 44, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	SECURITY_ID_CHECK		 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 45, METHOD.NEITHER, FILE.READ_DATA);
			public static readonly UInt32	READ_USN_JOURNAL								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 46, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	SET_OBJECT_ID_EXTENDED							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 47, METHOD.BUFFERED, FILE.SPECIAL_ACCESS);
			public static readonly UInt32	CREATE_OR_GET_OBJECT_ID							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 48, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	SET_SPARSE										=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 49, METHOD.BUFFERED, FILE.SPECIAL_ACCESS);
			public static readonly UInt32	SET_ZERO_DATA			 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 50, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	QUERY_ALLOCATED_RANGES							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 51, METHOD.NEITHER, FILE.READ_DATA);
			public static readonly UInt32	ENABLE_UPGRADE									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 52, METHOD.BUFFERED, FILE.WRITE_DATA);

			public static readonly UInt32	SET_ENCRYPTION									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 53, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	ENCRYPTION_FSCTL_IO								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 54, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	WRITE_RAW_ENCRYPTED								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 55, METHOD.NEITHER, FILE.SPECIAL_ACCESS); 
			public static readonly UInt32	READ_RAW_ENCRYPTED								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 56, METHOD.NEITHER, FILE.SPECIAL_ACCESS);
			public static readonly UInt32	CREATE_USN_JOURNAL								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 57, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	READ_FILE_USN_DATA								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 58, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	WRITE_USN_CLOSE_RECORD							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 59, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	EXTEND_VOLUME			 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 60, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	QUERY_USN_JOURNAL		 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 61, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	DELETE_USN_JOURNAL								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 62, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	MARK_HANDLE										=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 63, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	SIS_COPYFILE									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 64, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	SIS_LINK_FILES									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 65, METHOD.BUFFERED, FILE.READ_DATA | FILE.WRITE_DATA);

			public static readonly UInt32	RECALL_FILE										=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 69, METHOD.NEITHER, FILE.ANY_ACCESS);

			public static readonly UInt32	READ_FROM_PLEX									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 71, METHOD.OUT_DIRECT, FILE.READ_DATA);
			public static readonly UInt32	FILE_PREFETCH			 						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 72, METHOD.BUFFERED, FILE.SPECIAL_ACCESS);

			public static readonly UInt32	MAKE_MEDIA_COMPATIBLE		 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 76, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	SET_DEFECT_MANAGEMENT		 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 77, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	QUERY_SPARING_INFO								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 78, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	QUERY_ON_DISK_VOLUME_INFO	 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 79, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	SET_VOLUME_COMPRESSION_STATE					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 80, METHOD.BUFFERED, FILE.SPECIAL_ACCESS);

			public static readonly UInt32	TXFS_MODIFY_RM									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 81, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	TXFS_QUERY_RM_INFORMATION	 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 82, METHOD.BUFFERED, FILE.WRITE_DATA);

			public static readonly UInt32	TXFS_ROLLFORWARD_REDO		 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 84, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	TXFS_ROLLFORWARD_UNDO		 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 85, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	TXFS_START_RM				 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 86, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	TXFS_SHUTDOWN_RM								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 87, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	TXFS_READ_BACKUP_INFORMATION					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 88, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	TXFS_WRITE_BACKUP_INFORMATION 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 89, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	TXFS_CREATE_SECONDARY_RM						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 90, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	TXFS_GET_METADATA_INFO							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 91, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	TXFS_GET_TRANSACTED_VERSION						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 92, METHOD.BUFFERED, FILE.WRITE_DATA);

			public static readonly UInt32	TXFS_SAVEPOINT_INFORMATION						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 94, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	TXFS_CREATE_MINIVERSION							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 95, METHOD.BUFFERED, FILE.WRITE_DATA);

			public static readonly UInt32	TXFS_TRANSACTION_ACTIVE							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 99, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	SET_ZERO_ON_DEALLOCATION						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 101, METHOD.BUFFERED, FILE.SPECIAL_ACCESS);
			public static readonly UInt32	SET_REPAIR										=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 102, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_REPAIR										=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 103, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	WAIT_FOR_REPAIR									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 104, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	INITIATE_REPAIR									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 106, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	CSC_INTERNAL									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 107, METHOD.NEITHER, FILE.ANY_ACCESS);
			public static readonly UInt32	SHRINK_VOLUME				 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 108, METHOD.BUFFERED, FILE.SPECIAL_ACCESS);
			public static readonly UInt32	SET_SHORT_NAME_BEHAVIOR							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 109, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	DFSR_SET_GHOST_HANDLE_STATE						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 110, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	TXFS_LIST_TRANSACTION_LOCKED_FILES				=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 120, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	TXFS_LIST_TRANSACTIONS							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 121, METHOD.BUFFERED, FILE.WRITE_DATA);
			public static readonly UInt32	QUERY_PAGEFILE_ENCRYPTION	 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 122, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	RESET_VOLUME_ALLOCATION_HINTS 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 123, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	QUERY_DEPENDENT_VOLUME							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 124, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	SD_GLOBAL_CHANGE								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 125, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	TXFS_READ_BACKUP_INFORMATION2 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 126, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	LOOKUP_STREAM_FROM_CLUSTER						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 127, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	TXFS_WRITE_BACKUP_INFORMATION2 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 128, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	FILE_TYPE_NOTIFICATION							=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 129, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	GET_BOOT_AREA_INFO								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 140, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	GET_RETRIEVAL_POINTER_BASE						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 141, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	SET_PERSISTENT_VOLUME_STATE						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 142, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	QUERY_PERSISTENT_VOLUME_STATE 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 143, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	REQUEST_OPLOCK									=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 144, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	CSV_TUNNEL_REQUEST								=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 145, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	IS_CSV_FILE										=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 146, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	QUERY_FILE_SYSTEM_RECOGNITION 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 147, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	CSV_GET_VOLUME_PATH_NAME						=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 148, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	CSV_GET_VOLUME_NAME_FOR_VOLUME_MOUNT_POINT		=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 149, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	CSV_GET_VOLUME_PATH_NAMES_FOR_VOLUME_NAME		=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 150, METHOD.BUFFERED, FILE.ANY_ACCESS);
			public static readonly UInt32	IS_FILE_ON_CSV_VOLUME		 					=		CTL_CODE(FILE_DEVICE.FILE_SYSTEM, 151, METHOD.BUFFERED, FILE.ANY_ACCESS);

			public static readonly UInt32	MARK_AS_SYSTEM_HIV								=		FSCTL.SET_BOOTLOADER_ACCESSED;
		}

	#endregion

	#region Enumerations

		#region STORAGE_BUS_TYPE

			/*
				typedef enum _STORAGE_BUS_TYPE {
					BusTypeUnknown = 0x00,
					BusTypeScsi,
					BusTypeAtapi,
					BusTypeAta,
					BusType1394,
					BusTypeSsa,
					BusTypeFibre,
					BusTypeUsb,
					BusTypeRAID,
					BusTypeiScsi,
					BusTypeSas,
					BusTypeSata,
					BusTypeSd,
					BusTypeMmc,
					BusTypeVirtual,
					BusTypeFileBackedVirtual,
					BusTypeMax,
					BusTypeMaxReserved = 0x7F
				} STORAGE_BUS_TYPE, *PSTORAGE_BUS_TYPE;
			*/

			public enum STORAGE_BUS_TYPE
			{
				BusTypeUnknown = 0x00,
				BusTypeScsi,
				BusTypeAtapi,
				BusTypeAta,
				BusType1394,
				BusTypeSsa,
				BusTypeFibre,
				BusTypeUsb,
				BusTypeRAID,
				BusTypeiScsi,
				BusTypeSas,
				BusTypeSata,
				BusTypeSd,
				BusTypeMmc,
				BusTypeVirtual,
				BusTypeFileBackedVirtual,
				BusTypeMax,
				BusTypeMaxReserved = 0x7F
			};

		#endregion

		#region STORAGE_BUS_TYPE

			/*
				typedef enum _MEDIA_TYPE {
					Unknown,                // Format is unknown
					F5_1Pt2_512,            // 5.25", 1.2MB,  512 bytes/sector
					F3_1Pt44_512,           // 3.5",  1.44MB, 512 bytes/sector
					F3_2Pt88_512,           // 3.5",  2.88MB, 512 bytes/sector
					F3_20Pt8_512,           // 3.5",  20.8MB, 512 bytes/sector
					F3_720_512,             // 3.5",  720KB,  512 bytes/sector
					F5_360_512,             // 5.25", 360KB,  512 bytes/sector
					F5_320_512,             // 5.25", 320KB,  512 bytes/sector
					F5_320_1024,            // 5.25", 320KB,  1024 bytes/sector
					F5_180_512,             // 5.25", 180KB,  512 bytes/sector
					F5_160_512,             // 5.25", 160KB,  512 bytes/sector
					RemovableMedia,         // Removable media other than floppy
					FixedMedia,             // Fixed hard disk media
					F3_120M_512,            // 3.5", 120M Floppy
					F3_640_512,             // 3.5" ,  640KB,  512 bytes/sector
					F5_640_512,             // 5.25",  640KB,  512 bytes/sector
					F5_720_512,             // 5.25",  720KB,  512 bytes/sector
					F3_1Pt2_512,            // 3.5" ,  1.2Mb,  512 bytes/sector
					F3_1Pt23_1024,          // 3.5" ,  1.23Mb, 1024 bytes/sector
					F5_1Pt23_1024,          // 5.25",  1.23MB, 1024 bytes/sector
					F3_128Mb_512,           // 3.5" MO 128Mb   512 bytes/sector
					F3_230Mb_512,           // 3.5" MO 230Mb   512 bytes/sector
					F8_256_128,             // 8",     256KB,  128 bytes/sector
					F3_200Mb_512,           // 3.5",   200M Floppy (HiFD)
					F3_240M_512,            // 3.5",   240Mb Floppy (HiFD)
					F3_32M_512              // 3.5",   32Mb Floppy
				} MEDIA_TYPE, *PMEDIA_TYPE;
			*/

			public enum MEDIA_TYPE
			{
				Unknown,
				F5_1Pt2_512,
				F3_1Pt44_512,
				F3_2Pt88_512,
				F3_20Pt8_512,
				F3_720_512,
				F5_360_512,
				F5_320_512,
				F5_320_1024,
				F5_180_512,
				F5_160_512,
				RemovableMedia,
				FixedMedia,
				F3_120M_512,
				F3_640_512,
				F5_640_512,
				F5_720_512,
				F3_1Pt2_512,
				F3_1Pt23_1024,
				F5_1Pt23_1024,
				F3_128Mb_512,
				F3_230Mb_512,
				F8_256_128,
				F3_200Mb_512,
				F3_240M_512,
				F3_32M_512
			};

		#endregion

		#region STORAGE_MEDIA_TYPE

			/*
				typedef enum _STORAGE_MEDIA_TYPE {
					//
					// Following are defined in ntdddisk.h in the MEDIA_TYPE enum
					//
					// Unknown,                // Format is unknown
					// F5_1Pt2_512,            // 5.25", 1.2MB,  512 bytes/sector
					// F3_1Pt44_512,           // 3.5",  1.44MB, 512 bytes/sector
					// F3_2Pt88_512,           // 3.5",  2.88MB, 512 bytes/sector
					// F3_20Pt8_512,           // 3.5",  20.8MB, 512 bytes/sector
					// F3_720_512,             // 3.5",  720KB,  512 bytes/sector
					// F5_360_512,             // 5.25", 360KB,  512 bytes/sector
					// F5_320_512,             // 5.25", 320KB,  512 bytes/sector
					// F5_320_1024,            // 5.25", 320KB,  1024 bytes/sector
					// F5_180_512,             // 5.25", 180KB,  512 bytes/sector
					// F5_160_512,             // 5.25", 160KB,  512 bytes/sector
					// RemovableMedia,         // Removable media other than floppy
					// FixedMedia,             // Fixed hard disk media
					// F3_120M_512,            // 3.5", 120M Floppy
					// F3_640_512,             // 3.5" ,  640KB,  512 bytes/sector
					// F5_640_512,             // 5.25",  640KB,  512 bytes/sector
					// F5_720_512,             // 5.25",  720KB,  512 bytes/sector
					// F3_1Pt2_512,            // 3.5" ,  1.2Mb,  512 bytes/sector
					// F3_1Pt23_1024,          // 3.5" ,  1.23Mb, 1024 bytes/sector
					// F5_1Pt23_1024,          // 5.25",  1.23MB, 1024 bytes/sector
					// F3_128Mb_512,           // 3.5" MO 128Mb   512 bytes/sector
					// F3_230Mb_512,           // 3.5" MO 230Mb   512 bytes/sector
					// F8_256_128,             // 8",     256KB,  128 bytes/sector
					// F3_200Mb_512,           // 3.5",   200M Floppy (HiFD)
					//

					DDS_4mm = 0x20,            // Tape - DAT DDS1,2,... (all vendors)
					MiniQic,                   // Tape - miniQIC Tape
					Travan,                    // Tape - Travan TR-1,2,3,...
					QIC,                       // Tape - QIC
					MP_8mm,                    // Tape - 8mm Exabyte Metal Particle
					AME_8mm,                   // Tape - 8mm Exabyte Advanced Metal Evap
					AIT1_8mm,                  // Tape - 8mm Sony AIT
					DLT,                       // Tape - DLT Compact IIIxt, IV
					NCTP,                      // Tape - Philips NCTP
					IBM_3480,                  // Tape - IBM 3480
					IBM_3490E,                 // Tape - IBM 3490E
					IBM_Magstar_3590,          // Tape - IBM Magstar 3590
					IBM_Magstar_MP,            // Tape - IBM Magstar MP
					STK_DATA_D3,               // Tape - STK Data D3
					SONY_DTF,                  // Tape - Sony DTF
					DV_6mm,                    // Tape - 6mm Digital Video
					DMI,                       // Tape - Exabyte DMI and compatibles
					SONY_D2,                   // Tape - Sony D2S and D2L
					CLEANER_CARTRIDGE,         // Cleaner - All Drive types that support Drive Cleaners
					CD_ROM,                    // Opt_Disk - CD
					CD_R,                      // Opt_Disk - CD-Recordable (Write Once)
					CD_RW,                     // Opt_Disk - CD-Rewriteable
					DVD_ROM,                   // Opt_Disk - DVD-ROM
					DVD_R,                     // Opt_Disk - DVD-Recordable (Write Once)
					DVD_RW,                    // Opt_Disk - DVD-Rewriteable
					MO_3_RW,                   // Opt_Disk - 3.5" Rewriteable MO Disk
					MO_5_WO,                   // Opt_Disk - MO 5.25" Write Once
					MO_5_RW,                   // Opt_Disk - MO 5.25" Rewriteable (not LIMDOW)
					MO_5_LIMDOW,               // Opt_Disk - MO 5.25" Rewriteable (LIMDOW)
					PC_5_WO,                   // Opt_Disk - Phase Change 5.25" Write Once Optical
					PC_5_RW,                   // Opt_Disk - Phase Change 5.25" Rewriteable
					PD_5_RW,                   // Opt_Disk - PhaseChange Dual Rewriteable
					ABL_5_WO,                  // Opt_Disk - Ablative 5.25" Write Once Optical
					PINNACLE_APEX_5_RW,        // Opt_Disk - Pinnacle Apex 4.6GB Rewriteable Optical
					SONY_12_WO,                // Opt_Disk - Sony 12" Write Once
					PHILIPS_12_WO,             // Opt_Disk - Philips/LMS 12" Write Once
					HITACHI_12_WO,             // Opt_Disk - Hitachi 12" Write Once
					CYGNET_12_WO,              // Opt_Disk - Cygnet/ATG 12" Write Once
					KODAK_14_WO,               // Opt_Disk - Kodak 14" Write Once
					MO_NFR_525,                // Opt_Disk - Near Field Recording (Terastor)
					NIKON_12_RW,               // Opt_Disk - Nikon 12" Rewriteable
					IOMEGA_ZIP,                // Mag_Disk - Iomega Zip
					IOMEGA_JAZ,                // Mag_Disk - Iomega Jaz
					SYQUEST_EZ135,             // Mag_Disk - Syquest EZ135
					SYQUEST_EZFLYER,           // Mag_Disk - Syquest EzFlyer
					SYQUEST_SYJET,             // Mag_Disk - Syquest SyJet
					AVATAR_F2,                 // Mag_Disk - 2.5" Floppy
					MP2_8mm,                   // Tape - 8mm Hitachi
					DST_S,                     // Ampex DST Small Tapes
					DST_M,                     // Ampex DST Medium Tapes
					DST_L,                     // Ampex DST Large Tapes
					VXATape_1,                 // Ecrix 8mm Tape
					VXATape_2,                 // Ecrix 8mm Tape
				#if (NTDDI_VERSION < NTDDI_WINXP)
					STK_EAGLE,                 // STK Eagle
				#else
					STK_9840,                  // STK 9840
				#endif
					LTO_Ultrium,               // IBM, HP, Seagate LTO Ultrium
					LTO_Accelis,               // IBM, HP, Seagate LTO Accelis
					DVD_RAM,                   // Opt_Disk - DVD-RAM
					AIT_8mm,                   // AIT2 or higher
					ADR_1,                     // OnStream ADR Mediatypes
					ADR_2,
					STK_9940,                  // STK 9940
					SAIT,                      // SAIT Tapes
					VXATape                    // VXA (Ecrix 8mm) Tape
				}STORAGE_MEDIA_TYPE, *PSTORAGE_MEDIA_TYPE;
			*/

			public enum STORAGE_MEDIA_TYPE
			{
				DDS_4mm = 0x20,
				MiniQic,
				Travan,
				QIC,
				MP_8mm,
				AME_8mm,
				AIT1_8mm,
				DLT,
				NCTP,
				IBM_3480,
				IBM_3490E,
				IBM_Magstar_3590,
				IBM_Magstar_MP,
				STK_DATA_D3,
				SONY_DTF,
				DV_6mm,
				DMI,
				SONY_D2,
				CLEANER_CARTRIDGE,
				CD_ROM,
				CD_R,
				CD_RW,
				DVD_ROM,
				DVD_R,
				DVD_RW,
				MO_3_RW,
				MO_5_WO,
				MO_5_RW,
				MO_5_LIMDOW,
				PC_5_WO,
				PC_5_RW,
				PD_5_RW,
				ABL_5_WO,
				PINNACLE_APEX_5_RW,
				SONY_12_WO,
				PHILIPS_12_WO,
				HITACHI_12_WO,
				CYGNET_12_WO,
				KODAK_14_WO,
				MO_NFR_525,
				NIKON_12_RW,
				IOMEGA_ZIP,
				IOMEGA_JAZ,
				SYQUEST_EZ135,
				SYQUEST_EZFLYER,
				SYQUEST_SYJET,
				AVATAR_F2,
				MP2_8mm,
				DST_S,
				DST_M,
				DST_L,
				VXATape_1,
				VXATape_2,
				STK_9840,
				STK_EAGLE = STK_9840,
				LTO_Ultrium,
				LTO_Accelis,
				DVD_RAM,
				AIT_8mm,
				ADR_1,
				ADR_2,
				STK_9940,
				SAIT,
				VXATape
			};

		#endregion

	#endregion

	#region Structures

		#region DEVICE_MEDIA_INFO

			/*
				typedef struct _DEVICE_MEDIA_INFO {
					union {
						struct {
							LARGE_INTEGER Cylinders;
							STORAGE_MEDIA_TYPE MediaType;
							DWORD TracksPerCylinder;
							DWORD SectorsPerTrack;
							DWORD BytesPerSector;
							DWORD NumberMediaSides;
							DWORD MediaCharacteristics; // Bitmask of MEDIA_XXX values.
						} DiskInfo;

						struct {
							LARGE_INTEGER Cylinders;
							STORAGE_MEDIA_TYPE MediaType;
							DWORD TracksPerCylinder;
							DWORD SectorsPerTrack;
							DWORD BytesPerSector;
							DWORD NumberMediaSides;
							DWORD MediaCharacteristics; // Bitmask of MEDIA_XXX values.
						} RemovableDiskInfo;

						struct {
							STORAGE_MEDIA_TYPE MediaType;
							DWORD   MediaCharacteristics; // Bitmask of MEDIA_XXX values.
							DWORD   CurrentBlockSize;
							STORAGE_BUS_TYPE BusType;

							//
							// Bus specific information describing the medium supported.
							//

							union {
								struct {
									BYTE  MediumType;
									BYTE  DensityCode;
								} ScsiInformation;
							} BusSpecificData;

						} TapeInfo;
					} DeviceSpecific;
				} DEVICE_MEDIA_INFO, *PDEVICE_MEDIA_INFO;
			*/

			[StructLayout(LayoutKind.Explicit)]
			public struct DEVICE_MEDIA_INFO
			{
				[FieldOffset(0)]
				[StructLayout(LayoutKind.Sequential)]
				public struct DiskInfo
				{
					LARGE_INTEGER Cylinders;
					STORAGE_MEDIA_TYPE MediaType;
					DWORD TracksPerCylinder;
					DWORD SectorsPerTrack;
					DWORD BytesPerSector;
					DWORD NumberMediaSides;
					DWORD MediaCharacteristics; // Bitmask of MEDIA_XXX values.
				};
				[FieldOffset(0)]
				[StructLayout(LayoutKind.Sequential)]
				public struct RemovableDiskInfo
				{
					LARGE_INTEGER Cylinders;
					STORAGE_MEDIA_TYPE MediaType;
					DWORD TracksPerCylinder;
					DWORD SectorsPerTrack;
					DWORD BytesPerSector;
					DWORD NumberMediaSides;
					DWORD MediaCharacteristics; // Bitmask of MEDIA_XXX values.
				};
				[FieldOffset(0)]
				[StructLayout(LayoutKind.Sequential)]
				public struct TapeInfo
				{
					STORAGE_MEDIA_TYPE MediaType;
					DWORD   MediaCharacteristics; // Bitmask of MEDIA_XXX values.
					DWORD   CurrentBlockSize;
					STORAGE_BUS_TYPE BusType;
					//
					// Bus specific information describing the medium supported.
					//
					[StructLayout(LayoutKind.Explicit)]
					public struct ScsiInformation
					{
						[FieldOffset(0)]
						BYTE  MediumType;
						[FieldOffset(0)]
						BYTE  DensityCode;
					};
				};
			};
	
		#endregion

		#region GET_MEDIA_TYPES

			[StructLayout(LayoutKind.Sequential)]
			public struct GET_MEDIA_TYPES
			{
				DWORD				DeviceType;              // FILE_DEVICE_XXX values
				DWORD				MediaInfoCount;
				DEVICE_MEDIA_INFO	MediaInfo;
			};

		#endregion

		#region STORAGE_HOTPLUG_INFO

			[StructLayout(LayoutKind.Sequential)]
			public struct STORAGE_HOTPLUG_INFO
			{
				public DWORD			Size;						// version
				public BOOLEAN			MediaRemovable;				// ie. zip, jaz, cdrom, mo, etc. vs hdd
				public BOOLEAN			MediaHotplug;				// ie. does the device succeed a lock even though its not lockable media?
				public BOOLEAN			DeviceHotplug;				// ie. 1394, USB, etc.
				public BOOLEAN			WriteCacheEnableOverride;	// This field should not be relied upon because it is no longer used
			};

		#endregion

		#region STORAGE_DEVICE_NUMBER

			[StructLayout(LayoutKind.Sequential)]
			public struct STORAGE_DEVICE_NUMBER
			{
				public DEVICE_TYPE		DeviceType;					// The FILE_DEVICE_XXX type for this device.
				public DWORD			DeviceNumber;				// The number of this device
				public DWORD			PartitionNumber;			// If the device is partitionable, the partition number of the device otherwise -1
			};

		#endregion

		#region STORAGE_BUS_RESET_REQUEST

			[StructLayout(LayoutKind.Sequential)]
			public struct STORAGE_BUS_RESET_REQUEST
			{
				public BYTE				PathId;
			};

		#endregion

		#region STORAGE_BREAK_RESERVATION_REQUEST

			[StructLayout(LayoutKind.Sequential)]
			public struct STORAGE_BREAK_RESERVATION_REQUEST
			{
				public DWORD			Length;
				public BYTE				_unused;
				public BYTE				PathId;
				public BYTE				TargetId;
				public BYTE				Lun;
			};

		#endregion

		#region CLASS_MEDIA_CHANGE_CONTEXT

			[StructLayout(LayoutKind.Sequential)]
			public struct CLASS_MEDIA_CHANGE_CONTEXT
			{
				public DWORD			MediaChangeCount;
				public DWORD			NewState;					// see MEDIA_CHANGE_DETECTION_STATE enum in classpnp.h in DDK
			};

		#endregion

		#region TAPE_STATISTICS

			[StructLayout(LayoutKind.Sequential)]
			public struct TAPE_STATISTICS
			{
				public DWORD			Version;
				public DWORD			Flags;
				public LARGE_INTEGER	RecoveredWrites;
				public LARGE_INTEGER	UnrecoveredWrites;
				public LARGE_INTEGER	RecoveredReads;
				public LARGE_INTEGER	UnrecoveredReads;
				public BYTE				CompressionRatioReads;
				public BYTE				CompressionRatioWrites;
			};

		#endregion

		#region TAPE_GET_STATISTICS

			[StructLayout(LayoutKind.Sequential)]
			public struct TAPE_GET_STATISTICS
			{
				DWORD					Operation;
			};
	
		#endregion

		#region DISK_GEOMETRY

			[StructLayout(LayoutKind.Sequential)]
			public struct DISK_GEOMETRY
			{
				public LARGE_INTEGER	Cylinders;
				public MEDIA_TYPE		MediaType;
				public DWORD			TracksPerCylinder;
				public DWORD			SectorsPerTrack;
				public DWORD			BytesPerSector;
			};

		#endregion

		#region PARTITION_INFORMATION

			[StructLayout(LayoutKind.Sequential)]
			public struct PARTITION_INFORMATION
			{
				public LARGE_INTEGER	StartingOffset;
				public LARGE_INTEGER	PartitionLength;
				public DWORD			HiddenSectors;
				public DWORD			PartitionNumber;
				public BYTE				PartitionType;
				public BOOLEAN			BootIndicator;
				public BOOLEAN			RecognizedPartition;
				public BOOLEAN			RewritePartition;
			};

		#endregion

		#region FILE_ZERO_DATA_INFORMATION

			[StructLayout(LayoutKind.Sequential)]
			public struct FILE_ZERO_DATA_INFORMATION
			{
				public LARGE_INTEGER	FileOffset;
				public LARGE_INTEGER	BeyondFinalZero;
			};

		#endregion

	#endregion
}
