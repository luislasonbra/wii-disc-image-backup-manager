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
					return dbch.dbch_devicetype == DBT.DEVTYP_VOLUME; }
				};

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
				};

			#endregion

		#endregion

		#region Enumerations

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

			#region EnumResNameDelegate

				//public delegate bool EnumResNameDelegate(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, Object lParam);

			#endregion

		#endregion

		#region Constants

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
				}
			
			#endregion

			#region MANIFEST_RESOURCE_ID

				public class MANIFEST_RESOURCE_ID
				{
					/*
						#ifdef RC_INVOKED
						#define CREATEPROCESS_MANIFEST_RESOURCE_ID  1
						#define ISOLATIONAWARE_MANIFEST_RESOURCE_ID 2
						#define ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID 3
						#define MINIMUM_RESERVED_MANIFEST_RESOURCE_ID 1   // inclusive
						#define MAXIMUM_RESERVED_MANIFEST_RESOURCE_ID 16  // inclusive
						#else  // RC_INVOKED
						#define CREATEPROCESS_MANIFEST_RESOURCE_ID MAKEINTRESOURCE( 1)
						#define ISOLATIONAWARE_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(2)
						#define ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(3)
						#define MINIMUM_RESERVED_MANIFEST_RESOURCE_ID MAKEINTRESOURCE( 1 ) // inclusive
						#define MAXIMUM_RESERVED_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(16 ) // inclusive
						#endif // RC_INVOKED
					*/

					public static readonly UInt32	CREATEPROCESS					=	1;
					public static readonly UInt32	ISOLATIONAWARE					=	2;
					public static readonly UInt32	ISOLATIONAWARE_NOSTATICIMPORT	=	3;
					public static readonly UInt32	MINIMUM_RESERVED				=	1;
					public static readonly UInt32	MAXIMUM_RESERVED				=	16;
				}

			#endregion

			#region LANG

				public static class LANG
				{
					/*
						//
						//  Language IDs.
						//
						//  Note that the named locale APIs (eg GetLocaleInfoEx) are preferred.
						//
						//  Not all locales have unique Language IDs
						//
						//  The following two combinations of primary language ID and
						//  sublanguage ID have special semantics:
						//
						//    Primary Language ID   Sublanguage ID      Result
						//    -------------------   ---------------     ------------------------
						//    LANG_NEUTRAL          SUBLANG_NEUTRAL     Language neutral
						//    LANG_NEUTRAL          SUBLANG_DEFAULT     User default language
						//    LANG_NEUTRAL          SUBLANG_SYS_DEFAULT System default language
						//    LANG_INVARIANT        SUBLANG_NEUTRAL     Invariant locale
						//
						//  It is recommended that applications test for locale names instead of
						//  Language IDs / LCIDs.

						//
						//  Primary language IDs.
						//
						//  WARNING: These aren't always unique.  Bosnian, Serbian & Croation for example.
						//
						//  It is recommended that applications test for locale names or actual LCIDs.
						//
						//  Note that the LANG, SUBLANG construction is not always consistent.
						//  The named locale APIs (eg GetLocaleInfoEx) are recommended.
						//
						#define LANG_NEUTRAL                     0x00
						#define LANG_INVARIANT                   0x7f

						#define LANG_AFRIKAANS                   0x36
						#define LANG_ALBANIAN                    0x1c
						#define LANG_ALSATIAN                    0x84
						#define LANG_AMHARIC                     0x5e
						#define LANG_ARABIC                      0x01
						#define LANG_ARMENIAN                    0x2b
						#define LANG_ASSAMESE                    0x4d
						#define LANG_AZERI                       0x2c
						#define LANG_BASHKIR                     0x6d
						#define LANG_BASQUE                      0x2d
						#define LANG_BELARUSIAN                  0x23
						#define LANG_BENGALI                     0x45
						#define LANG_BRETON                      0x7e
						#define LANG_BOSNIAN                     0x1a   // Use with SUBLANG_BOSNIAN_* Sublanguage IDs
						#define LANG_BOSNIAN_NEUTRAL           0x781a   // Use with the ConvertDefaultLocale function
						#define LANG_BULGARIAN                   0x02
						#define LANG_CATALAN                     0x03
						#define LANG_CHINESE                     0x04   // Use with SUBLANG_CHINESE_* Sublanguage IDs
						#define LANG_CHINESE_SIMPLIFIED          0x04   // Use with the ConvertDefaultLocale function
						#define LANG_CHINESE_TRADITIONAL       0x7c04   // Use with the ConvertDefaultLocale function
						#define LANG_CORSICAN                    0x83
						#define LANG_CROATIAN                    0x1a
						#define LANG_CZECH                       0x05
						#define LANG_DANISH                      0x06
						#define LANG_DARI                        0x8c
						#define LANG_DIVEHI                      0x65
						#define LANG_DUTCH                       0x13
						#define LANG_ENGLISH                     0x09
						#define LANG_ESTONIAN                    0x25
						#define LANG_FAEROESE                    0x38
						#define LANG_FARSI                       0x29   // Deprecated: use LANG_PERSIAN instead
						#define LANG_FILIPINO                    0x64
						#define LANG_FINNISH                     0x0b
						#define LANG_FRENCH                      0x0c
						#define LANG_FRISIAN                     0x62
						#define LANG_GALICIAN                    0x56
						#define LANG_GEORGIAN                    0x37
						#define LANG_GERMAN                      0x07
						#define LANG_GREEK                       0x08
						#define LANG_GREENLANDIC                 0x6f
						#define LANG_GUJARATI                    0x47
						#define LANG_HAUSA                       0x68
						#define LANG_HEBREW                      0x0d
						#define LANG_HINDI                       0x39
						#define LANG_HUNGARIAN                   0x0e
						#define LANG_ICELANDIC                   0x0f
						#define LANG_IGBO                        0x70
						#define LANG_INDONESIAN                  0x21
						#define LANG_INUKTITUT                   0x5d
						#define LANG_IRISH                       0x3c   // Use with the SUBLANG_IRISH_IRELAND Sublanguage ID
						#define LANG_ITALIAN                     0x10
						#define LANG_JAPANESE                    0x11
						#define LANG_KANNADA                     0x4b
						#define LANG_KASHMIRI                    0x60
						#define LANG_KAZAK                       0x3f
						#define LANG_KHMER                       0x53
						#define LANG_KICHE                       0x86
						#define LANG_KINYARWANDA                 0x87
						#define LANG_KONKANI                     0x57
						#define LANG_KOREAN                      0x12
						#define LANG_KYRGYZ                      0x40
						#define LANG_LAO                         0x54
						#define LANG_LATVIAN                     0x26
						#define LANG_LITHUANIAN                  0x27
						#define LANG_LOWER_SORBIAN               0x2e
						#define LANG_LUXEMBOURGISH               0x6e
						#define LANG_MACEDONIAN                  0x2f   // the Former Yugoslav Republic of Macedonia
						#define LANG_MALAY                       0x3e
						#define LANG_MALAYALAM                   0x4c
						#define LANG_MALTESE                     0x3a
						#define LANG_MANIPURI                    0x58
						#define LANG_MAORI                       0x81
						#define LANG_MAPUDUNGUN                  0x7a
						#define LANG_MARATHI                     0x4e
						#define LANG_MOHAWK                      0x7c
						#define LANG_MONGOLIAN                   0x50
						#define LANG_NEPALI                      0x61
						#define LANG_NORWEGIAN                   0x14
						#define LANG_OCCITAN                     0x82
						#define LANG_ORIYA                       0x48
						#define LANG_PASHTO                      0x63
						#define LANG_PERSIAN                     0x29
						#define LANG_POLISH                      0x15
						#define LANG_PORTUGUESE                  0x16
						#define LANG_PUNJABI                     0x46
						#define LANG_QUECHUA                     0x6b
						#define LANG_ROMANIAN                    0x18
						#define LANG_ROMANSH                     0x17
						#define LANG_RUSSIAN                     0x19
						#define LANG_SAMI                        0x3b
						#define LANG_SANSKRIT                    0x4f
						#define LANG_SCOTTISH_GAELIC             0x91
						#define LANG_SERBIAN                     0x1a   // Use with the SUBLANG_SERBIAN_* Sublanguage IDs
						#define LANG_SERBIAN_NEUTRAL           0x7c1a   // Use with the ConvertDefaultLocale function
						#define LANG_SINDHI                      0x59
						#define LANG_SINHALESE                   0x5b
						#define LANG_SLOVAK                      0x1b
						#define LANG_SLOVENIAN                   0x24
						#define LANG_SOTHO                       0x6c
						#define LANG_SPANISH                     0x0a
						#define LANG_SWAHILI                     0x41
						#define LANG_SWEDISH                     0x1d
						#define LANG_SYRIAC                      0x5a
						#define LANG_TAJIK                       0x28
						#define LANG_TAMAZIGHT                   0x5f
						#define LANG_TAMIL                       0x49
						#define LANG_TATAR                       0x44
						#define LANG_TELUGU                      0x4a
						#define LANG_THAI                        0x1e
						#define LANG_TIBETAN                     0x51
						#define LANG_TIGRIGNA                    0x73
						#define LANG_TSWANA                      0x32
						#define LANG_TURKISH                     0x1f
						#define LANG_TURKMEN                     0x42
						#define LANG_UIGHUR                      0x80
						#define LANG_UKRAINIAN                   0x22
						#define LANG_UPPER_SORBIAN               0x2e
						#define LANG_URDU                        0x20
						#define LANG_UZBEK                       0x43
						#define LANG_VIETNAMESE                  0x2a
						#define LANG_WELSH                       0x52
						#define LANG_WOLOF                       0x88
						#define LANG_XHOSA                       0x34
						#define LANG_YAKUT                       0x85
						#define LANG_YI                          0x78
						#define LANG_YORUBA                      0x6a
						#define LANG_ZULU                        0x35
					*/
					
					/*
					#define LANG_BOSNIAN                     0x1a   // Use with SUBLANG_BOSNIAN_* Sublanguage IDs
					#define LANG_BOSNIAN_NEUTRAL           0x781a   // Use with the ConvertDefaultLocale function
					#define LANG_CHINESE                     0x04   // Use with SUBLANG_CHINESE_* Sublanguage IDs
					#define LANG_CHINESE_SIMPLIFIED          0x04   // Use with the ConvertDefaultLocale function
					#define LANG_CHINESE_TRADITIONAL       0x7c04   // Use with the ConvertDefaultLocale function
					#define LANG_IRISH                       0x3c   // Use with the SUBLANG_IRISH_IRELAND Sublanguage ID
					#define LANG_SERBIAN                     0x1a   // Use with the SUBLANG_SERBIAN_* Sublanguage IDs
					#define LANG_SERBIAN_NEUTRAL           0x7c1a   // Use with the ConvertDefaultLocale function


					#define LANG_FARSI                       0x29   // Deprecated: use LANG_PERSIAN instead


					#define LANG_NEUTRAL                     0x00
					#define LANG_INVARIANT                   0x7f
					#define LANG_AFRIKAANS                   0x36
					#define LANG_ALBANIAN                    0x1c
					#define LANG_ALSATIAN                    0x84
					#define LANG_AMHARIC                     0x5e
					#define LANG_ARABIC                      0x01
					#define LANG_ARMENIAN                    0x2b
					#define LANG_ASSAMESE                    0x4d
					#define LANG_AZERI                       0x2c
					#define LANG_BASHKIR                     0x6d
					#define LANG_BASQUE                      0x2d
					#define LANG_BELARUSIAN                  0x23
					#define LANG_BENGALI                     0x45
					#define LANG_BRETON                      0x7e
					#define LANG_BULGARIAN                   0x02
					#define LANG_CATALAN                     0x03
					#define LANG_CORSICAN                    0x83
					#define LANG_CROATIAN                    0x1a
					#define LANG_CZECH                       0x05
					#define LANG_DANISH                      0x06
					#define LANG_DARI                        0x8c
					#define LANG_DIVEHI                      0x65
					#define LANG_DUTCH                       0x13
					#define LANG_ENGLISH                     0x09
					#define LANG_ESTONIAN                    0x25
					#define LANG_FAEROESE                    0x38
					#define LANG_FILIPINO                    0x64
					#define LANG_FINNISH                     0x0b
					#define LANG_FRENCH                      0x0c
					#define LANG_FRISIAN                     0x62
					#define LANG_GALICIAN                    0x56
					#define LANG_GEORGIAN                    0x37
					#define LANG_GERMAN                      0x07
					#define LANG_GREEK                       0x08
					#define LANG_GREENLANDIC                 0x6f
					#define LANG_GUJARATI                    0x47
					#define LANG_HAUSA                       0x68
					#define LANG_HEBREW                      0x0d
					#define LANG_HINDI                       0x39
					#define LANG_HUNGARIAN                   0x0e
					#define LANG_ICELANDIC                   0x0f
					#define LANG_IGBO                        0x70
					#define LANG_INDONESIAN                  0x21
					#define LANG_INUKTITUT                   0x5d
					#define LANG_ITALIAN                     0x10
					#define LANG_JAPANESE                    0x11
					#define LANG_KANNADA                     0x4b
					#define LANG_KASHMIRI                    0x60
					#define LANG_KAZAK                       0x3f
					#define LANG_KHMER                       0x53
					#define LANG_KICHE                       0x86
					#define LANG_KINYARWANDA                 0x87
					#define LANG_KONKANI                     0x57
					#define LANG_KOREAN                      0x12
					#define LANG_KYRGYZ                      0x40
					#define LANG_LAO                         0x54
					#define LANG_LATVIAN                     0x26
					#define LANG_LITHUANIAN                  0x27
					#define LANG_LOWER_SORBIAN               0x2e
					#define LANG_LUXEMBOURGISH               0x6e
					#define LANG_MACEDONIAN                  0x2f
					#define LANG_MALAY                       0x3e
					#define LANG_MALAYALAM                   0x4c
					#define LANG_MALTESE                     0x3a
					#define LANG_MANIPURI                    0x58
					#define LANG_MAORI                       0x81
					#define LANG_MAPUDUNGUN                  0x7a
					#define LANG_MARATHI                     0x4e
					#define LANG_MOHAWK                      0x7c
					#define LANG_MONGOLIAN                   0x50
					#define LANG_NEPALI                      0x61
					#define LANG_NORWEGIAN                   0x14
					#define LANG_OCCITAN                     0x82
					#define LANG_ORIYA                       0x48
					#define LANG_PASHTO                      0x63
					#define LANG_PERSIAN                     0x29
					#define LANG_POLISH                      0x15
					#define LANG_PORTUGUESE                  0x16
					#define LANG_PUNJABI                     0x46
					#define LANG_QUECHUA                     0x6b
					#define LANG_ROMANIAN                    0x18
					#define LANG_ROMANSH                     0x17
					#define LANG_RUSSIAN                     0x19
					#define LANG_SAMI                        0x3b
					#define LANG_SANSKRIT                    0x4f
					#define LANG_SCOTTISH_GAELIC             0x91
					#define LANG_SINDHI                      0x59
					#define LANG_SINHALESE                   0x5b
					#define LANG_SLOVAK                      0x1b
					#define LANG_SLOVENIAN                   0x24
					#define LANG_SOTHO                       0x6c
					#define LANG_SPANISH                     0x0a
					#define LANG_SWAHILI                     0x41
					#define LANG_SWEDISH                     0x1d
					#define LANG_SYRIAC                      0x5a
					#define LANG_TAJIK                       0x28
					#define LANG_TAMAZIGHT                   0x5f
					#define LANG_TAMIL                       0x49
					#define LANG_TATAR                       0x44
					#define LANG_TELUGU                      0x4a
					#define LANG_THAI                        0x1e
					#define LANG_TIBETAN                     0x51
					#define LANG_TIGRIGNA                    0x73
					#define LANG_TSWANA                      0x32
					#define LANG_TURKISH                     0x1f
					#define LANG_TURKMEN                     0x42
					#define LANG_UIGHUR                      0x80
					#define LANG_UKRAINIAN                   0x22
					#define LANG_UPPER_SORBIAN               0x2e
					#define LANG_URDU                        0x20
					#define LANG_UZBEK                       0x43
					#define LANG_VIETNAMESE                  0x2a
					#define LANG_WELSH                       0x52
					#define LANG_WOLOF                       0x88
					#define LANG_XHOSA                       0x34
					#define LANG_YAKUT                       0x85
					#define LANG_YI                          0x78
					#define LANG_YORUBA                      0x6a
					#define LANG_ZULU                        0x35
					*/
				}

			#endregion

			#region SUBLANG

				public class SUBLANG
				{
					/*
						//
						//  Sublanguage IDs.
						//
						//  The name immediately following SUBLANG_ dictates which primary
						//  language ID that sublanguage ID can be combined with to form a
						//  valid language ID.
						//
						//  Note that the LANG, SUBLANG construction is not always consistent.
						//  The named locale APIs (eg GetLocaleInfoEx) are recommended.
						//

						#define SUBLANG_NEUTRAL                             0x00    // language neutral
						#define SUBLANG_DEFAULT                             0x01    // user default
						#define SUBLANG_SYS_DEFAULT                         0x02    // system default
						#define SUBLANG_CUSTOM_DEFAULT                      0x03    // default custom language/locale
						#define SUBLANG_CUSTOM_UNSPECIFIED                  0x04    // custom language/locale
						#define SUBLANG_UI_CUSTOM_DEFAULT                   0x05    // Default custom MUI language/locale


						#define SUBLANG_AFRIKAANS_SOUTH_AFRICA              0x01    // Afrikaans (South Africa) 0x0436 af-ZA
						#define SUBLANG_ALBANIAN_ALBANIA                    0x01    // Albanian (Albania) 0x041c sq-AL
						#define SUBLANG_ALSATIAN_FRANCE                     0x01    // Alsatian (France) 0x0484
						#define SUBLANG_AMHARIC_ETHIOPIA                    0x01    // Amharic (Ethiopia) 0x045e
						#define SUBLANG_ARABIC_SAUDI_ARABIA                 0x01    // Arabic (Saudi Arabia)
						#define SUBLANG_ARABIC_IRAQ                         0x02    // Arabic (Iraq)
						#define SUBLANG_ARABIC_EGYPT                        0x03    // Arabic (Egypt)
						#define SUBLANG_ARABIC_LIBYA                        0x04    // Arabic (Libya)
						#define SUBLANG_ARABIC_ALGERIA                      0x05    // Arabic (Algeria)
						#define SUBLANG_ARABIC_MOROCCO                      0x06    // Arabic (Morocco)
						#define SUBLANG_ARABIC_TUNISIA                      0x07    // Arabic (Tunisia)
						#define SUBLANG_ARABIC_OMAN                         0x08    // Arabic (Oman)
						#define SUBLANG_ARABIC_YEMEN                        0x09    // Arabic (Yemen)
						#define SUBLANG_ARABIC_SYRIA                        0x0a    // Arabic (Syria)
						#define SUBLANG_ARABIC_JORDAN                       0x0b    // Arabic (Jordan)
						#define SUBLANG_ARABIC_LEBANON                      0x0c    // Arabic (Lebanon)
						#define SUBLANG_ARABIC_KUWAIT                       0x0d    // Arabic (Kuwait)
						#define SUBLANG_ARABIC_UAE                          0x0e    // Arabic (U.A.E)
						#define SUBLANG_ARABIC_BAHRAIN                      0x0f    // Arabic (Bahrain)
						#define SUBLANG_ARABIC_QATAR                        0x10    // Arabic (Qatar)
						#define SUBLANG_ARMENIAN_ARMENIA                    0x01    // Armenian (Armenia) 0x042b hy-AM
						#define SUBLANG_ASSAMESE_INDIA                      0x01    // Assamese (India) 0x044d
						#define SUBLANG_AZERI_LATIN                         0x01    // Azeri (Latin)
						#define SUBLANG_AZERI_CYRILLIC                      0x02    // Azeri (Cyrillic)
						#define SUBLANG_BASHKIR_RUSSIA                      0x01    // Bashkir (Russia) 0x046d ba-RU
						#define SUBLANG_BASQUE_BASQUE                       0x01    // Basque (Basque) 0x042d eu-ES
						#define SUBLANG_BELARUSIAN_BELARUS                  0x01    // Belarusian (Belarus) 0x0423 be-BY
						#define SUBLANG_BENGALI_INDIA                       0x01    // Bengali (India)
						#define SUBLANG_BENGALI_BANGLADESH                  0x02    // Bengali (Bangladesh)
						#define SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_LATIN    0x05    // Bosnian (Bosnia and Herzegovina - Latin) 0x141a bs-BA-Latn
						#define SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_CYRILLIC 0x08    // Bosnian (Bosnia and Herzegovina - Cyrillic) 0x201a bs-BA-Cyrl
						#define SUBLANG_BRETON_FRANCE                       0x01    // Breton (France) 0x047e
						#define SUBLANG_BULGARIAN_BULGARIA                  0x01    // Bulgarian (Bulgaria) 0x0402
						#define SUBLANG_CATALAN_CATALAN                     0x01    // Catalan (Catalan) 0x0403
						#define SUBLANG_CHINESE_TRADITIONAL                 0x01    // Chinese (Taiwan) 0x0404 zh-TW
						#define SUBLANG_CHINESE_SIMPLIFIED                  0x02    // Chinese (PR China) 0x0804 zh-CN
						#define SUBLANG_CHINESE_HONGKONG                    0x03    // Chinese (Hong Kong S.A.R., P.R.C.) 0x0c04 zh-HK
						#define SUBLANG_CHINESE_SINGAPORE                   0x04    // Chinese (Singapore) 0x1004 zh-SG
						#define SUBLANG_CHINESE_MACAU                       0x05    // Chinese (Macau S.A.R.) 0x1404 zh-MO
						#define SUBLANG_CORSICAN_FRANCE                     0x01    // Corsican (France) 0x0483
						#define SUBLANG_CZECH_CZECH_REPUBLIC                0x01    // Czech (Czech Republic) 0x0405
						#define SUBLANG_CROATIAN_CROATIA                    0x01    // Croatian (Croatia)
						#define SUBLANG_CROATIAN_BOSNIA_HERZEGOVINA_LATIN   0x04    // Croatian (Bosnia and Herzegovina - Latin) 0x101a hr-BA
						#define SUBLANG_DANISH_DENMARK                      0x01    // Danish (Denmark) 0x0406
						#define SUBLANG_DARI_AFGHANISTAN                    0x01    // Dari (Afghanistan)
						#define SUBLANG_DIVEHI_MALDIVES                     0x01    // Divehi (Maldives) 0x0465 div-MV
						#define SUBLANG_DUTCH                               0x01    // Dutch
						#define SUBLANG_DUTCH_BELGIAN                       0x02    // Dutch (Belgian)
						#define SUBLANG_ENGLISH_US                          0x01    // English (USA)
						#define SUBLANG_ENGLISH_UK                          0x02    // English (UK)
						#define SUBLANG_ENGLISH_AUS                         0x03    // English (Australian)
						#define SUBLANG_ENGLISH_CAN                         0x04    // English (Canadian)
						#define SUBLANG_ENGLISH_NZ                          0x05    // English (New Zealand)
						#define SUBLANG_ENGLISH_EIRE                        0x06    // English (Irish)
						#define SUBLANG_ENGLISH_SOUTH_AFRICA                0x07    // English (South Africa)
						#define SUBLANG_ENGLISH_JAMAICA                     0x08    // English (Jamaica)
						#define SUBLANG_ENGLISH_CARIBBEAN                   0x09    // English (Caribbean)
						#define SUBLANG_ENGLISH_BELIZE                      0x0a    // English (Belize)
						#define SUBLANG_ENGLISH_TRINIDAD                    0x0b    // English (Trinidad)
						#define SUBLANG_ENGLISH_ZIMBABWE                    0x0c    // English (Zimbabwe)
						#define SUBLANG_ENGLISH_PHILIPPINES                 0x0d    // English (Philippines)
						#define SUBLANG_ENGLISH_INDIA                       0x10    // English (India)
						#define SUBLANG_ENGLISH_MALAYSIA                    0x11    // English (Malaysia)
						#define SUBLANG_ENGLISH_SINGAPORE                   0x12    // English (Singapore)
						#define SUBLANG_ESTONIAN_ESTONIA                    0x01    // Estonian (Estonia) 0x0425 et-EE
						#define SUBLANG_FAEROESE_FAROE_ISLANDS              0x01    // Faroese (Faroe Islands) 0x0438 fo-FO
						#define SUBLANG_FILIPINO_PHILIPPINES                0x01    // Filipino (Philippines) 0x0464 fil-PH
						#define SUBLANG_FINNISH_FINLAND                     0x01    // Finnish (Finland) 0x040b
						#define SUBLANG_FRENCH                              0x01    // French
						#define SUBLANG_FRENCH_BELGIAN                      0x02    // French (Belgian)
						#define SUBLANG_FRENCH_CANADIAN                     0x03    // French (Canadian)
						#define SUBLANG_FRENCH_SWISS                        0x04    // French (Swiss)
						#define SUBLANG_FRENCH_LUXEMBOURG                   0x05    // French (Luxembourg)
						#define SUBLANG_FRENCH_MONACO                       0x06    // French (Monaco)
						#define SUBLANG_FRISIAN_NETHERLANDS                 0x01    // Frisian (Netherlands) 0x0462 fy-NL
						#define SUBLANG_GALICIAN_GALICIAN                   0x01    // Galician (Galician) 0x0456 gl-ES
						#define SUBLANG_GEORGIAN_GEORGIA                    0x01    // Georgian (Georgia) 0x0437 ka-GE
						#define SUBLANG_GERMAN                              0x01    // German
						#define SUBLANG_GERMAN_SWISS                        0x02    // German (Swiss)
						#define SUBLANG_GERMAN_AUSTRIAN                     0x03    // German (Austrian)
						#define SUBLANG_GERMAN_LUXEMBOURG                   0x04    // German (Luxembourg)
						#define SUBLANG_GERMAN_LIECHTENSTEIN                0x05    // German (Liechtenstein)
						#define SUBLANG_GREEK_GREECE                        0x01    // Greek (Greece)
						#define SUBLANG_GREENLANDIC_GREENLAND               0x01    // Greenlandic (Greenland) 0x046f kl-GL
						#define SUBLANG_GUJARATI_INDIA                      0x01    // Gujarati (India (Gujarati Script)) 0x0447 gu-IN
						#define SUBLANG_HAUSA_NIGERIA_LATIN                 0x01    // Hausa (Latin, Nigeria) 0x0468 ha-NG-Latn
						#define SUBLANG_HEBREW_ISRAEL                       0x01    // Hebrew (Israel) 0x040d
						#define SUBLANG_HINDI_INDIA                         0x01    // Hindi (India) 0x0439 hi-IN
						#define SUBLANG_HUNGARIAN_HUNGARY                   0x01    // Hungarian (Hungary) 0x040e
						#define SUBLANG_ICELANDIC_ICELAND                   0x01    // Icelandic (Iceland) 0x040f
						#define SUBLANG_IGBO_NIGERIA                        0x01    // Igbo (Nigeria) 0x0470 ig-NG
						#define SUBLANG_INDONESIAN_INDONESIA                0x01    // Indonesian (Indonesia) 0x0421 id-ID
						#define SUBLANG_INUKTITUT_CANADA                    0x01    // Inuktitut (Syllabics) (Canada) 0x045d iu-CA-Cans
						#define SUBLANG_INUKTITUT_CANADA_LATIN              0x02    // Inuktitut (Canada - Latin)
						#define SUBLANG_IRISH_IRELAND                       0x02    // Irish (Ireland)
						#define SUBLANG_ITALIAN                             0x01    // Italian
						#define SUBLANG_ITALIAN_SWISS                       0x02    // Italian (Swiss)
						#define SUBLANG_JAPANESE_JAPAN                      0x01    // Japanese (Japan) 0x0411
						#define SUBLANG_KANNADA_INDIA                       0x01    // Kannada (India (Kannada Script)) 0x044b kn-IN
						#define SUBLANG_KASHMIRI_SASIA                      0x02    // Kashmiri (South Asia)
						#define SUBLANG_KASHMIRI_INDIA                      0x02    // For app compatibility only
						#define SUBLANG_KAZAK_KAZAKHSTAN                    0x01    // Kazakh (Kazakhstan) 0x043f kk-KZ
						#define SUBLANG_KHMER_CAMBODIA                      0x01    // Khmer (Cambodia) 0x0453 kh-KH
						#define SUBLANG_KICHE_GUATEMALA                     0x01    // K'iche (Guatemala)
						#define SUBLANG_KINYARWANDA_RWANDA                  0x01    // Kinyarwanda (Rwanda) 0x0487 rw-RW
						#define SUBLANG_KONKANI_INDIA                       0x01    // Konkani (India) 0x0457 kok-IN
						#define SUBLANG_KOREAN                              0x01    // Korean (Extended Wansung)
						#define SUBLANG_KYRGYZ_KYRGYZSTAN                   0x01    // Kyrgyz (Kyrgyzstan) 0x0440 ky-KG
						#define SUBLANG_LAO_LAO                             0x01    // Lao (Lao PDR) 0x0454 lo-LA
						#define SUBLANG_LATVIAN_LATVIA                      0x01    // Latvian (Latvia) 0x0426 lv-LV
						#define SUBLANG_LITHUANIAN                          0x01    // Lithuanian
						#define SUBLANG_LOWER_SORBIAN_GERMANY               0x02    // Lower Sorbian (Germany) 0x082e wee-DE
						#define SUBLANG_LUXEMBOURGISH_LUXEMBOURG            0x01    // Luxembourgish (Luxembourg) 0x046e lb-LU
						#define SUBLANG_MACEDONIAN_MACEDONIA                0x01    // Macedonian (Macedonia (FYROM)) 0x042f mk-MK
						#define SUBLANG_MALAY_MALAYSIA                      0x01    // Malay (Malaysia)
						#define SUBLANG_MALAY_BRUNEI_DARUSSALAM             0x02    // Malay (Brunei Darussalam)
						#define SUBLANG_MALAYALAM_INDIA                     0x01    // Malayalam (India (Malayalam Script) ) 0x044c ml-IN
						#define SUBLANG_MALTESE_MALTA                       0x01    // Maltese (Malta) 0x043a mt-MT
						#define SUBLANG_MAORI_NEW_ZEALAND                   0x01    // Maori (New Zealand) 0x0481 mi-NZ
						#define SUBLANG_MAPUDUNGUN_CHILE                    0x01    // Mapudungun (Chile) 0x047a arn-CL
						#define SUBLANG_MARATHI_INDIA                       0x01    // Marathi (India) 0x044e mr-IN
						#define SUBLANG_MOHAWK_MOHAWK                       0x01    // Mohawk (Mohawk) 0x047c moh-CA
						#define SUBLANG_MONGOLIAN_CYRILLIC_MONGOLIA         0x01    // Mongolian (Cyrillic, Mongolia)
						#define SUBLANG_MONGOLIAN_PRC                       0x02    // Mongolian (PRC)
						#define SUBLANG_NEPALI_INDIA                        0x02    // Nepali (India)
						#define SUBLANG_NEPALI_NEPAL                        0x01    // Nepali (Nepal) 0x0461 ne-NP
						#define SUBLANG_NORWEGIAN_BOKMAL                    0x01    // Norwegian (Bokmal)
						#define SUBLANG_NORWEGIAN_NYNORSK                   0x02    // Norwegian (Nynorsk)
						#define SUBLANG_OCCITAN_FRANCE                      0x01    // Occitan (France) 0x0482 oc-FR
						#define SUBLANG_ORIYA_INDIA                         0x01    // Oriya (India (Oriya Script)) 0x0448 or-IN
						#define SUBLANG_PASHTO_AFGHANISTAN                  0x01    // Pashto (Afghanistan)
						#define SUBLANG_PERSIAN_IRAN                        0x01    // Persian (Iran) 0x0429 fa-IR
						#define SUBLANG_POLISH_POLAND                       0x01    // Polish (Poland) 0x0415
						#define SUBLANG_PORTUGUESE                          0x02    // Portuguese
						#define SUBLANG_PORTUGUESE_BRAZILIAN                0x01    // Portuguese (Brazilian)
						#define SUBLANG_PUNJABI_INDIA                       0x01    // Punjabi (India (Gurmukhi Script)) 0x0446 pa-IN
						#define SUBLANG_QUECHUA_BOLIVIA                     0x01    // Quechua (Bolivia)
						#define SUBLANG_QUECHUA_ECUADOR                     0x02    // Quechua (Ecuador)
						#define SUBLANG_QUECHUA_PERU                        0x03    // Quechua (Peru)
						#define SUBLANG_ROMANIAN_ROMANIA                    0x01    // Romanian (Romania) 0x0418
						#define SUBLANG_ROMANSH_SWITZERLAND                 0x01    // Romansh (Switzerland) 0x0417 rm-CH
						#define SUBLANG_RUSSIAN_RUSSIA                      0x01    // Russian (Russia) 0x0419
						#define SUBLANG_SAMI_NORTHERN_NORWAY                0x01    // Northern Sami (Norway)
						#define SUBLANG_SAMI_NORTHERN_SWEDEN                0x02    // Northern Sami (Sweden)
						#define SUBLANG_SAMI_NORTHERN_FINLAND               0x03    // Northern Sami (Finland)
						#define SUBLANG_SAMI_LULE_NORWAY                    0x04    // Lule Sami (Norway)
						#define SUBLANG_SAMI_LULE_SWEDEN                    0x05    // Lule Sami (Sweden)
						#define SUBLANG_SAMI_SOUTHERN_NORWAY                0x06    // Southern Sami (Norway)
						#define SUBLANG_SAMI_SOUTHERN_SWEDEN                0x07    // Southern Sami (Sweden)
						#define SUBLANG_SAMI_SKOLT_FINLAND                  0x08    // Skolt Sami (Finland)
						#define SUBLANG_SAMI_INARI_FINLAND                  0x09    // Inari Sami (Finland)
						#define SUBLANG_SANSKRIT_INDIA                      0x01    // Sanskrit (India) 0x044f sa-IN
						#define SUBLANG_SCOTTISH_GAELIC                     0x01    // Scottish Gaelic (United Kingdom) 0x0491 gd-GB
						#define SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_LATIN    0x06    // Serbian (Bosnia and Herzegovina - Latin)
						#define SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_CYRILLIC 0x07    // Serbian (Bosnia and Herzegovina - Cyrillic)
						#define SUBLANG_SERBIAN_MONTENEGRO_LATIN            0x0b    // Serbian (Montenegro - Latn)
						#define SUBLANG_SERBIAN_MONTENEGRO_CYRILLIC         0x0c    // Serbian (Montenegro - Cyrillic)
						#define SUBLANG_SERBIAN_SERBIA_LATIN                0x09    // Serbian (Serbia - Latin)
						#define SUBLANG_SERBIAN_SERBIA_CYRILLIC             0x0a    // Serbian (Serbia - Cyrillic)
						#define SUBLANG_SERBIAN_CROATIA                     0x01    // Croatian (Croatia) 0x041a hr-HR
						#define SUBLANG_SERBIAN_LATIN                       0x02    // Serbian (Latin)
						#define SUBLANG_SERBIAN_CYRILLIC                    0x03    // Serbian (Cyrillic)
						#define SUBLANG_SINDHI_INDIA                        0x01    // Sindhi (India) reserved 0x0459
						#define SUBLANG_SINDHI_PAKISTAN                     0x02    // Sindhi (Pakistan) reserved 0x0859
						#define SUBLANG_SINDHI_AFGHANISTAN                  0x02    // For app compatibility only
						#define SUBLANG_SINHALESE_SRI_LANKA                 0x01    // Sinhalese (Sri Lanka)
						#define SUBLANG_SOTHO_NORTHERN_SOUTH_AFRICA         0x01    // Northern Sotho (South Africa)
						#define SUBLANG_SLOVAK_SLOVAKIA                     0x01    // Slovak (Slovakia) 0x041b sk-SK
						#define SUBLANG_SLOVENIAN_SLOVENIA                  0x01    // Slovenian (Slovenia) 0x0424 sl-SI
						#define SUBLANG_SPANISH                             0x01    // Spanish (Castilian)
						#define SUBLANG_SPANISH_MEXICAN                     0x02    // Spanish (Mexican)
						#define SUBLANG_SPANISH_MODERN                      0x03    // Spanish (Modern)
						#define SUBLANG_SPANISH_GUATEMALA                   0x04    // Spanish (Guatemala)
						#define SUBLANG_SPANISH_COSTA_RICA                  0x05    // Spanish (Costa Rica)
						#define SUBLANG_SPANISH_PANAMA                      0x06    // Spanish (Panama)
						#define SUBLANG_SPANISH_DOMINICAN_REPUBLIC          0x07    // Spanish (Dominican Republic)
						#define SUBLANG_SPANISH_VENEZUELA                   0x08    // Spanish (Venezuela)
						#define SUBLANG_SPANISH_COLOMBIA                    0x09    // Spanish (Colombia)
						#define SUBLANG_SPANISH_PERU                        0x0a    // Spanish (Peru)
						#define SUBLANG_SPANISH_ARGENTINA                   0x0b    // Spanish (Argentina)
						#define SUBLANG_SPANISH_ECUADOR                     0x0c    // Spanish (Ecuador)
						#define SUBLANG_SPANISH_CHILE                       0x0d    // Spanish (Chile)
						#define SUBLANG_SPANISH_URUGUAY                     0x0e    // Spanish (Uruguay)
						#define SUBLANG_SPANISH_PARAGUAY                    0x0f    // Spanish (Paraguay)
						#define SUBLANG_SPANISH_BOLIVIA                     0x10    // Spanish (Bolivia)
						#define SUBLANG_SPANISH_EL_SALVADOR                 0x11    // Spanish (El Salvador)
						#define SUBLANG_SPANISH_HONDURAS                    0x12    // Spanish (Honduras)
						#define SUBLANG_SPANISH_NICARAGUA                   0x13    // Spanish (Nicaragua)
						#define SUBLANG_SPANISH_PUERTO_RICO                 0x14    // Spanish (Puerto Rico)
						#define SUBLANG_SPANISH_US                          0x15    // Spanish (United States)
						#define SUBLANG_SWAHILI_KENYA                       0x01    // Swahili (Kenya) 0x0441 sw-KE
						#define SUBLANG_SWEDISH                             0x01    // Swedish
						#define SUBLANG_SWEDISH_FINLAND                     0x02    // Swedish (Finland)
						#define SUBLANG_SYRIAC_SYRIA                        0x01    // Syriac (Syria) 0x045a syr-SY
						#define SUBLANG_TAJIK_TAJIKISTAN                    0x01    // Tajik (Tajikistan) 0x0428 tg-TJ-Cyrl
						#define SUBLANG_TAMAZIGHT_ALGERIA_LATIN             0x02    // Tamazight (Latin, Algeria) 0x085f tmz-DZ-Latn
						#define SUBLANG_TAMIL_INDIA                         0x01    // Tamil (India)
						#define SUBLANG_TATAR_RUSSIA                        0x01    // Tatar (Russia) 0x0444 tt-RU
						#define SUBLANG_TELUGU_INDIA                        0x01    // Telugu (India (Telugu Script)) 0x044a te-IN
						#define SUBLANG_THAI_THAILAND                       0x01    // Thai (Thailand) 0x041e th-TH
						#define SUBLANG_TIBETAN_PRC                         0x01    // Tibetan (PRC)
						#define SUBLANG_TIGRIGNA_ERITREA                    0x02    // Tigrigna (Eritrea)
						#define SUBLANG_TSWANA_SOUTH_AFRICA                 0x01    // Setswana / Tswana (South Africa) 0x0432 tn-ZA
						#define SUBLANG_TURKISH_TURKEY                      0x01    // Turkish (Turkey) 0x041f tr-TR
						#define SUBLANG_TURKMEN_TURKMENISTAN                0x01    // Turkmen (Turkmenistan) 0x0442 tk-TM
						#define SUBLANG_UIGHUR_PRC                          0x01    // Uighur (PRC) 0x0480 ug-CN
						#define SUBLANG_UKRAINIAN_UKRAINE                   0x01    // Ukrainian (Ukraine) 0x0422 uk-UA
						#define SUBLANG_UPPER_SORBIAN_GERMANY               0x01    // Upper Sorbian (Germany) 0x042e wen-DE
						#define SUBLANG_URDU_PAKISTAN                       0x01    // Urdu (Pakistan)
						#define SUBLANG_URDU_INDIA                          0x02    // Urdu (India)
						#define SUBLANG_UZBEK_LATIN                         0x01    // Uzbek (Latin)
						#define SUBLANG_UZBEK_CYRILLIC                      0x02    // Uzbek (Cyrillic)
						#define SUBLANG_VIETNAMESE_VIETNAM                  0x01    // Vietnamese (Vietnam) 0x042a vi-VN
						#define SUBLANG_WELSH_UNITED_KINGDOM                0x01    // Welsh (United Kingdom) 0x0452 cy-GB
						#define SUBLANG_WOLOF_SENEGAL                       0x01    // Wolof (Senegal)
						#define SUBLANG_XHOSA_SOUTH_AFRICA                  0x01    // isiXhosa / Xhosa (South Africa) 0x0434 xh-ZA
						#define SUBLANG_YAKUT_RUSSIA                        0x01    // Yakut (Russia) 0x0485 sah-RU
						#define SUBLANG_YI_PRC                              0x01    // Yi (PRC)) 0x0478
						#define SUBLANG_YORUBA_NIGERIA                      0x01    // Yoruba (Nigeria) 046a yo-NG
						#define SUBLANG_ZULU_SOUTH_AFRICA                   0x01    // isiZulu / Zulu (South Africa) 0x0435 zu-ZA
					*/

				}

			#endregion

			#region SORT

				public class SORT
				{
					/*
						//
						//  Sorting IDs.
						//
						//  Note that the named locale APIs (eg CompareStringExEx) are recommended.
						//

						#define SORT_DEFAULT                     0x0     // sorting default

						#define SORT_INVARIANT_MATH              0x1     // Invariant (Mathematical Symbols)

						#define SORT_JAPANESE_XJIS               0x0     // Japanese XJIS order
						#define SORT_JAPANESE_UNICODE            0x1     // Japanese Unicode order (no longer supported)
						#define SORT_JAPANESE_RADICALSTROKE      0x4     // Japanese radical/stroke order

						#define SORT_CHINESE_BIG5                0x0     // Chinese BIG5 order
						#define SORT_CHINESE_PRCP                0x0     // PRC Chinese Phonetic order
						#define SORT_CHINESE_UNICODE             0x1     // Chinese Unicode order (no longer supported)
						#define SORT_CHINESE_PRC                 0x2     // PRC Chinese Stroke Count order
						#define SORT_CHINESE_BOPOMOFO            0x3     // Traditional Chinese Bopomofo order
						#define SORT_CHINESE_RADICALSTROKE       0x4     // Traditional Chinese radical/stroke order.

						#define SORT_KOREAN_KSC                  0x0     // Korean KSC order
						#define SORT_KOREAN_UNICODE              0x1     // Korean Unicode order (no longer supported)

						#define SORT_GERMAN_PHONE_BOOK           0x1     // German Phone Book order

						#define SORT_HUNGARIAN_DEFAULT           0x0     // Hungarian Default order
						#define SORT_HUNGARIAN_TECHNICAL         0x1     // Hungarian Technical order

						#define SORT_GEORGIAN_TRADITIONAL        0x0     // Georgian Traditional order
						#define SORT_GEORGIAN_MODERN             0x1     // Georgian Modern order
					*/

				}

			#endregion

			#region Uncategorised

				public class Uncategorised
				{
					public static readonly UInt32	LOAD_LIBRARY_AS_DATAFILE		=	0x00000002;

					public static readonly UInt32	SUBLANG_DEFAULT					=	0x01;
					public static readonly UInt32	LANG_NEUTRAL					=	0x00;
					public static readonly UInt32	LANGID							=	(UInt32)((((ushort)(SUBLANG_DEFAULT)) << 10) | (ushort)(LANG_NEUTRAL));

					public static readonly UInt32	WM_DEVICECHANGE					=	537;
				}

			#endregion
			
			#region SECURITY

				public class SECURITY
				{
					/*
						/////////////////////////////////////////////////////////////////////////////
						//                                                                         //
						// Universal well-known SIDs                                               //
						//                                                                         //
						//     Null SID                     S-1-0-0                                //
						//     World                        S-1-1-0                                //
						//     Local                        S-1-2-0                                //
						//     Creator Owner ID             S-1-3-0                                //
						//     Creator Group ID             S-1-3-1                                //
						//     Creator Owner Server ID      S-1-3-2                                //
						//     Creator Group Server ID      S-1-3-3                                //
						//                                                                         //
						//     (Non-unique IDs)             S-1-4                                  //
						//                                                                         //
						/////////////////////////////////////////////////////////////////////////////

						#define SECURITY_NULL_SID_AUTHORITY         {0,0,0,0,0,0}
						#define SECURITY_WORLD_SID_AUTHORITY        {0,0,0,0,0,1}
						#define SECURITY_LOCAL_SID_AUTHORITY        {0,0,0,0,0,2}
						#define SECURITY_CREATOR_SID_AUTHORITY      {0,0,0,0,0,3}
						#define SECURITY_NON_UNIQUE_AUTHORITY       {0,0,0,0,0,4}
						#define SECURITY_RESOURCE_MANAGER_AUTHORITY {0,0,0,0,0,9}


						#define SECURITY_NULL_RID                 (0x00000000L)
						#define SECURITY_WORLD_RID                (0x00000000L)
						#define SECURITY_LOCAL_RID                (0x00000000L)
						#define SECURITY_LOCAL_LOGON_RID          (0x00000001L)

						#define SECURITY_CREATOR_OWNER_RID        (0x00000000L)
						#define SECURITY_CREATOR_GROUP_RID        (0x00000001L)

						#define SECURITY_CREATOR_OWNER_SERVER_RID (0x00000002L)
						#define SECURITY_CREATOR_GROUP_SERVER_RID (0x00000003L)

						#define SECURITY_CREATOR_OWNER_RIGHTS_RID (0x00000004L)

						///////////////////////////////////////////////////////////////////////////////
						//                                                                           //
						// NT well-known SIDs                                                        //
						//                                                                           //
						//     NT Authority            S-1-5                                         //
						//     Dialup                  S-1-5-1                                       //
						//                                                                           //
						//     Network                 S-1-5-2                                       //
						//     Batch                   S-1-5-3                                       //
						//     Interactive             S-1-5-4                                       //
						//     (Logon IDs)             S-1-5-5-X-Y                                   //
						//     Service                 S-1-5-6                                       //
						//     AnonymousLogon          S-1-5-7       (aka null logon session)        //
						//     Proxy                   S-1-5-8                                       //
						//     Enterprise DC (EDC)     S-1-5-9       (aka domain controller account) //
						//     Self                    S-1-5-10      (self RID)                      //
						//     Authenticated User      S-1-5-11      (Authenticated user somewhere)  //
						//     Restricted Code         S-1-5-12      (Running restricted code)       //
						//     Terminal Server         S-1-5-13      (Running on Terminal Server)    //
						//     Remote Logon            S-1-5-14      (Remote Interactive Logon)      //
						//     This Organization       S-1-5-15                                      //
						//                                                                           //
						//     IUser                   S-1-5-17
						//     Local System            S-1-5-18                                      //
						//     Local Service           S-1-5-19                                      //
						//     Network Service         S-1-5-20                                      //
						//                                                                           //
						//     (NT non-unique IDs)     S-1-5-0x15-... (NT Domain Sids)               //
						//                                                                           //
						//     (Built-in domain)       S-1-5-0x20                                    //
						//                                                                           //
						//     (Security Package IDs)  S-1-5-0x40                                    //
						//     NTLM Authentication     S-1-5-0x40-10                                 //
						//     SChannel Authentication S-1-5-0x40-14                                 //
						//     Digest Authentication   S-1-5-0x40-21                                 //
						//                                                                           //
						//     Other Organization      S-1-5-1000    (>=1000 can not be filtered)    //
						//                                                                           //
						//                                                                           //
						// NOTE: the relative identifier values (RIDs) determine which security      //
						//       boundaries the SID is allowed to cross.  Before adding new RIDs,    //
						//       a determination needs to be made regarding which range they should  //
						//       be added to in order to ensure proper "SID filtering"               //
						//                                                                           //
						///////////////////////////////////////////////////////////////////////////////


						#define SECURITY_NT_AUTHORITY           {0,0,0,0,0,5}   // ntifs

						#define SECURITY_DIALUP_RID             (0x00000001L)
						#define SECURITY_NETWORK_RID            (0x00000002L)
						#define SECURITY_BATCH_RID              (0x00000003L)
						#define SECURITY_INTERACTIVE_RID        (0x00000004L)
						#define SECURITY_LOGON_IDS_RID          (0x00000005L)
						#define SECURITY_LOGON_IDS_RID_COUNT    (3L)
						#define SECURITY_SERVICE_RID            (0x00000006L)
						#define SECURITY_ANONYMOUS_LOGON_RID    (0x00000007L)
						#define SECURITY_PROXY_RID              (0x00000008L)
						#define SECURITY_ENTERPRISE_CONTROLLERS_RID (0x00000009L)
						#define SECURITY_SERVER_LOGON_RID       SECURITY_ENTERPRISE_CONTROLLERS_RID
						#define SECURITY_PRINCIPAL_SELF_RID     (0x0000000AL)
						#define SECURITY_AUTHENTICATED_USER_RID (0x0000000BL)
						#define SECURITY_RESTRICTED_CODE_RID    (0x0000000CL)
						#define SECURITY_TERMINAL_SERVER_RID    (0x0000000DL)
						#define SECURITY_REMOTE_LOGON_RID       (0x0000000EL)
						#define SECURITY_THIS_ORGANIZATION_RID  (0x0000000FL)
						#define SECURITY_IUSER_RID              (0x00000011L)
						#define SECURITY_LOCAL_SYSTEM_RID       (0x00000012L)
						#define SECURITY_LOCAL_SERVICE_RID      (0x00000013L)
						#define SECURITY_NETWORK_SERVICE_RID    (0x00000014L)

						#define SECURITY_NT_NON_UNIQUE          (0x00000015L)
						#define SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT  (3L)

						#define SECURITY_ENTERPRISE_READONLY_CONTROLLERS_RID (0x00000016L)

						#define SECURITY_BUILTIN_DOMAIN_RID     (0x00000020L)
						#define SECURITY_WRITE_RESTRICTED_CODE_RID (0x00000021L)


						#define SECURITY_PACKAGE_BASE_RID       (0x00000040L)
						#define SECURITY_PACKAGE_RID_COUNT      (2L)
						#define SECURITY_PACKAGE_NTLM_RID       (0x0000000AL)
						#define SECURITY_PACKAGE_SCHANNEL_RID   (0x0000000EL)
						#define SECURITY_PACKAGE_DIGEST_RID     (0x00000015L)

						#define SECURITY_CRED_TYPE_BASE_RID             (0x00000041L)
						#define SECURITY_CRED_TYPE_RID_COUNT            (2L)
						#define SECURITY_CRED_TYPE_THIS_ORG_CERT_RID    (0x00000001L)

						#define SECURITY_MIN_BASE_RID           (0x00000050L)

						#define SECURITY_SERVICE_ID_BASE_RID    (0x00000050L)
						#define SECURITY_SERVICE_ID_RID_COUNT   (6L)

						#define SECURITY_RESERVED_ID_BASE_RID   (0x00000051L)

						#define SECURITY_APPPOOL_ID_BASE_RID    (0x00000052L)
						#define SECURITY_APPPOOL_ID_RID_COUNT   (6L)

						#define SECURITY_VIRTUALSERVER_ID_BASE_RID    (0x00000053L)
						#define SECURITY_VIRTUALSERVER_ID_RID_COUNT   (6L)

						#define SECURITY_USERMODEDRIVERHOST_ID_BASE_RID  (0x00000054L)
						#define SECURITY_USERMODEDRIVERHOST_ID_RID_COUNT (6L)

						#define SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_BASE_RID  (0x00000055L)
						#define SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_RID_COUNT (6L)

						#define SECURITY_WMIHOST_ID_BASE_RID  (0x00000056L)
						#define SECURITY_WMIHOST_ID_RID_COUNT (6L)

						#define SECURITY_TASK_ID_BASE_RID                 (0x00000057L)

						#define SECURITY_NFS_ID_BASE_RID        (0x00000058L)

						#define SECURITY_COM_ID_BASE_RID        (0x00000059L)

						#define SECURITY_VIRTUALACCOUNT_ID_RID_COUNT   (6L)

						#define SECURITY_MAX_BASE_RID		(0x0000006FL)
						#define SECURITY_MAX_ALWAYS_FILTERED    (0x000003E7L)
						#define SECURITY_MIN_NEVER_FILTERED     (0x000003E8L)

						#define SECURITY_OTHER_ORGANIZATION_RID (0x000003E8L)

						//
						//Service SID type RIDs are in the range 0x50- 0x6F.  Therefore, we are giving  the next available RID to Windows Mobile team.
						//
						#define SECURITY_WINDOWSMOBILE_ID_BASE_RID (0x00000070L)
					*/

					public static readonly Byte[]	NULL_SID_AUTHORITY								=	{0,0,0,0,0,0};
					public static readonly Byte[]	WORLD_SID_AUTHORITY								=	{0,0,0,0,0,1};
					public static readonly Byte[]	LOCAL_SID_AUTHORITY								=	{0,0,0,0,0,2};
					public static readonly Byte[]	CREATOR_SID_AUTHORITY							=	{0,0,0,0,0,3};
					public static readonly Byte[]	NON_UNIQUE_AUTHORITY							=	{0,0,0,0,0,4};
					public static readonly Byte[]	RESOURCE_MANAGER_AUTHORITY						=	{0,0,0,0,0,9};
					public static readonly UInt32	NULL_RID										=	0x00000000;
					public static readonly UInt32	WORLD_RID										=	0x00000000;
					public static readonly UInt32	LOCAL_RID										=	0x00000000;
					public static readonly UInt32	LOCAL_LOGON_RID									=	0x00000001;
					public static readonly UInt32	CREATOR_OWNER_RID								=	0x00000000;
					public static readonly UInt32	CREATOR_GROUP_RID								=	0x00000001;
					public static readonly UInt32	CREATOR_OWNER_SERVER_RID						=	0x00000002;
					public static readonly UInt32	CREATOR_GROUP_SERVER_RID						=	0x00000003;
					public static readonly UInt32	CREATOR_OWNER_RIGHTS_RID						=	0x00000004;
					public static readonly Byte[]	NT_AUTHORITY									=	{0,0,0,0,0,5};
					public static readonly UInt32	DIALUP_RID										=	0x00000001;
					public static readonly UInt32	NETWORK_RID										=	0x00000002;
					public static readonly UInt32	BATCH_RID										=	0x00000003;
					public static readonly UInt32	INTERACTIVE_RID									=	0x00000004;
					public static readonly UInt32	LOGON_IDS_RID									=	0x00000005;
					public static readonly UInt32	LOGON_IDS_RID_COUNT								=	3;
					public static readonly UInt32	SERVICE_RID										=	0x00000006;
					public static readonly UInt32	ANONYMOUS_LOGON_RID								=	0x00000007;
					public static readonly UInt32	PROXY_RID										=	0x00000008;
					public static readonly UInt32	ENTERPRISE_CONTROLLERS_RID						=	0x00000009;
					public static readonly UInt32	SERVER_LOGON_RID								=	ENTERPRISE_CONTROLLERS_RID;
					public static readonly UInt32	PRINCIPAL_SELF_RID								=	0x0000000A;
					public static readonly UInt32	AUTHENTICATED_USER_RID							=	0x0000000B;
					public static readonly UInt32	RESTRICTED_CODE_RID								=	0x0000000C;
					public static readonly UInt32	TERMINAL_SERVER_RID								=	0x0000000D;
					public static readonly UInt32	REMOTE_LOGON_RID								=	0x0000000E;
					public static readonly UInt32	THIS_ORGANIZATION_RID							=	0x0000000F;
					public static readonly UInt32	IUSER_RID										=	0x00000011;
					public static readonly UInt32	LOCAL_SYSTEM_RID								=	0x00000012;
					public static readonly UInt32	LOCAL_SERVICE_RID								=	0x00000013;
					public static readonly UInt32	NETWORK_SERVICE_RID								=	0x00000014;
					public static readonly UInt32	NT_NON_UNIQUE									=	0x00000015;
					public static readonly UInt32	NT_NON_UNIQUE_SUB_AUTH_COUNT					=	3;
					public static readonly UInt32	ENTERPRISE_READONLY_CONTROLLERS_RID				=	0x00000016;
					public static readonly UInt32	BUILTIN_DOMAIN_RID								=	0x00000020;
					public static readonly UInt32	WRITE_RESTRICTED_CODE_RID						=	0x00000021;
					public static readonly UInt32	PACKAGE_BASE_RID								=	0x00000040;
					public static readonly UInt32	PACKAGE_RID_COUNT								=	2;
					public static readonly UInt32	PACKAGE_NTLM_RID								=	0x0000000A;
					public static readonly UInt32	PACKAGE_SCHANNEL_RID							=	0x0000000E;
					public static readonly UInt32	PACKAGE_DIGEST_RID								=	0x00000015;
					public static readonly UInt32	CRED_TYPE_BASE_RID								=	0x00000041;
					public static readonly UInt32	CRED_TYPE_RID_COUNT								=	2;
					public static readonly UInt32	CRED_TYPE_THIS_ORG_CERT_RID						=	0x00000001;
					public static readonly UInt32	MIN_BASE_RID									=	0x00000050;
					public static readonly UInt32	SERVICE_ID_BASE_RID								=	0x00000050;
					public static readonly UInt32	SERVICE_ID_RID_COUNT							=	6;
					public static readonly UInt32	RESERVED_ID_BASE_RID							=	0x00000051;
					public static readonly UInt32	APPPOOL_ID_BASE_RID								=	0x00000052;
					public static readonly UInt32	APPPOOL_ID_RID_COUNT							=	6;
					public static readonly UInt32	VIRTUALSERVER_ID_BASE_RID						=	0x00000053;
					public static readonly UInt32	VIRTUALSERVER_ID_RID_COUNT						=	6;
					public static readonly UInt32	USERMODEDRIVERHOST_ID_BASE_RID					=	0x00000054;
					public static readonly UInt32	USERMODEDRIVERHOST_ID_RID_COUNT					=	6;
					public static readonly UInt32	CLOUD_INFRASTRUCTURE_SERVICES_ID_BASE_RID		=	0x00000055;
					public static readonly UInt32	CLOUD_INFRASTRUCTURE_SERVICES_ID_RID_COUNT		=	6;
					public static readonly UInt32	WMIHOST_ID_BASE_RID								=	0x00000056;
					public static readonly UInt32	WMIHOST_ID_RID_COUNT							=	6;
					public static readonly UInt32	TASK_ID_BASE_RID								=	0x00000057;
					public static readonly UInt32	NFS_ID_BASE_RID									=	0x00000058;
					public static readonly UInt32	COM_ID_BASE_RID									=	0x00000059;
					public static readonly UInt32	VIRTUALACCOUNT_ID_RID_COUNT						=	6;
					public static readonly UInt32	MAX_BASE_RID									=	0x0000006F;
					public static readonly UInt32	MAX_ALWAYS_FILTERED								=	0x000003E7;
					public static readonly UInt32	MIN_NEVER_FILTERED								=	0x000003E8;
					public static readonly UInt32	OTHER_ORGANIZATION_RID							=	0x000003E8;
					public static readonly UInt32	WINDOWSMOBILE_ID_BASE_RID						=	0x00000070;
				}

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
				}

			#endregion

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