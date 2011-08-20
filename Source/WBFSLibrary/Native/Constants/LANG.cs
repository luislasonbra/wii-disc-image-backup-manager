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
	
	#region LANG

		public class LANG
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

			public static readonly UInt32	NEUTRAL							=	0x00;
			public static readonly UInt32	INVARIANT						=	0x7f;

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
		};

	#endregion
}
