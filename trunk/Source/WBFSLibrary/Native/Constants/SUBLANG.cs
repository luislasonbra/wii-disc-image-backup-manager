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

			public static readonly UInt32	NEUTRAL							=	0x0047;
			public static readonly UInt32	DEFAULT							=	0x0048;
			public static readonly UInt32	SYS_DEFAULT						=	0x7FFF;
			public static readonly UInt32	CUSTOM_DEFAULT					=	0x8000;
			public static readonly UInt32	CUSTOM_UNSPECIFIED				=	0x8001;
			public static readonly UInt32	SUBLANG_UI_CUSTOM_DEFAULT		=	0x8001;

			/*
				#define SUBLANG_AFRIKAANS_SOUTH_AFRICA              0x01
				#define SUBLANG_ALBANIAN_ALBANIA                    0x01
				#define SUBLANG_ALSATIAN_FRANCE                     0x01
				#define SUBLANG_AMHARIC_ETHIOPIA                    0x01
				#define SUBLANG_ARABIC_SAUDI_ARABIA                 0x01
				#define SUBLANG_ARABIC_IRAQ                         0x02
				#define SUBLANG_ARABIC_EGYPT                        0x03
				#define SUBLANG_ARABIC_LIBYA                        0x04
				#define SUBLANG_ARABIC_ALGERIA                      0x05
				#define SUBLANG_ARABIC_MOROCCO                      0x06
				#define SUBLANG_ARABIC_TUNISIA                      0x07
				#define SUBLANG_ARABIC_OMAN                         0x08
				#define SUBLANG_ARABIC_YEMEN                        0x09
				#define SUBLANG_ARABIC_SYRIA                        0x0a
				#define SUBLANG_ARABIC_JORDAN                       0x0b
				#define SUBLANG_ARABIC_LEBANON                      0x0c
				#define SUBLANG_ARABIC_KUWAIT                       0x0d
				#define SUBLANG_ARABIC_UAE                          0x0e
				#define SUBLANG_ARABIC_BAHRAIN                      0x0f
				#define SUBLANG_ARABIC_QATAR                        0x10
				#define SUBLANG_ARMENIAN_ARMENIA                    0x01
				#define SUBLANG_ASSAMESE_INDIA                      0x01
				#define SUBLANG_AZERI_LATIN                         0x01
				#define SUBLANG_AZERI_CYRILLIC                      0x02
				#define SUBLANG_BASHKIR_RUSSIA                      0x01
				#define SUBLANG_BASQUE_BASQUE                       0x01
				#define SUBLANG_BELARUSIAN_BELARUS                  0x01
				#define SUBLANG_BENGALI_INDIA                       0x01
				#define SUBLANG_BENGALI_BANGLADESH                  0x02
				#define SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_LATIN    0x05
				#define SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_CYRILLIC 0x08
				#define SUBLANG_BRETON_FRANCE                       0x01
				#define SUBLANG_BULGARIAN_BULGARIA                  0x01
				#define SUBLANG_CATALAN_CATALAN                     0x01
				#define SUBLANG_CHINESE_TRADITIONAL                 0x01
				#define SUBLANG_CHINESE_SIMPLIFIED                  0x02
				#define SUBLANG_CHINESE_HONGKONG                    0x03
				#define SUBLANG_CHINESE_SINGAPORE                   0x04
				#define SUBLANG_CHINESE_MACAU                       0x05
				#define SUBLANG_CORSICAN_FRANCE                     0x01
				#define SUBLANG_CZECH_CZECH_REPUBLIC                0x01
				#define SUBLANG_CROATIAN_CROATIA                    0x01
				#define SUBLANG_CROATIAN_BOSNIA_HERZEGOVINA_LATIN   0x04
				#define SUBLANG_DANISH_DENMARK                      0x01
				#define SUBLANG_DARI_AFGHANISTAN                    0x01
				#define SUBLANG_DIVEHI_MALDIVES                     0x01
				#define SUBLANG_DUTCH                               0x01
				#define SUBLANG_DUTCH_BELGIAN                       0x02
				#define SUBLANG_ENGLISH_US                          0x01
				#define SUBLANG_ENGLISH_UK                          0x02
				#define SUBLANG_ENGLISH_AUS                         0x03
				#define SUBLANG_ENGLISH_CAN                         0x04
				#define SUBLANG_ENGLISH_NZ                          0x05
				#define SUBLANG_ENGLISH_EIRE                        0x06
				#define SUBLANG_ENGLISH_SOUTH_AFRICA                0x07
				#define SUBLANG_ENGLISH_JAMAICA                     0x08
				#define SUBLANG_ENGLISH_CARIBBEAN                   0x09
				#define SUBLANG_ENGLISH_BELIZE                      0x0a
				#define SUBLANG_ENGLISH_TRINIDAD                    0x0b
				#define SUBLANG_ENGLISH_ZIMBABWE                    0x0c
				#define SUBLANG_ENGLISH_PHILIPPINES                 0x0d
				#define SUBLANG_ENGLISH_INDIA                       0x10
				#define SUBLANG_ENGLISH_MALAYSIA                    0x11
				#define SUBLANG_ENGLISH_SINGAPORE                   0x12
				#define SUBLANG_ESTONIAN_ESTONIA                    0x01
				#define SUBLANG_FAEROESE_FAROE_ISLANDS              0x01
				#define SUBLANG_FILIPINO_PHILIPPINES                0x01
				#define SUBLANG_FINNISH_FINLAND                     0x01
				#define SUBLANG_FRENCH                              0x01
				#define SUBLANG_FRENCH_BELGIAN                      0x02
				#define SUBLANG_FRENCH_CANADIAN                     0x03
				#define SUBLANG_FRENCH_SWISS                        0x04
				#define SUBLANG_FRENCH_LUXEMBOURG                   0x05
				#define SUBLANG_FRENCH_MONACO                       0x06
				#define SUBLANG_FRISIAN_NETHERLANDS                 0x01
				#define SUBLANG_GALICIAN_GALICIAN                   0x01
				#define SUBLANG_GEORGIAN_GEORGIA                    0x01
				#define SUBLANG_GERMAN                              0x01
				#define SUBLANG_GERMAN_SWISS                        0x02
				#define SUBLANG_GERMAN_AUSTRIAN                     0x03
				#define SUBLANG_GERMAN_LUXEMBOURG                   0x04
				#define SUBLANG_GERMAN_LIECHTENSTEIN                0x05
				#define SUBLANG_GREEK_GREECE                        0x01
				#define SUBLANG_GREENLANDIC_GREENLAND               0x01
				#define SUBLANG_GUJARATI_INDIA                      0x01
				#define SUBLANG_HAUSA_NIGERIA_LATIN                 0x01
				#define SUBLANG_HEBREW_ISRAEL                       0x01
				#define SUBLANG_HINDI_INDIA                         0x01
				#define SUBLANG_HUNGARIAN_HUNGARY                   0x01
				#define SUBLANG_ICELANDIC_ICELAND                   0x01
				#define SUBLANG_IGBO_NIGERIA                        0x01
				#define SUBLANG_INDONESIAN_INDONESIA                0x01
				#define SUBLANG_INUKTITUT_CANADA                    0x01
				#define SUBLANG_INUKTITUT_CANADA_LATIN              0x02
				#define SUBLANG_IRISH_IRELAND                       0x02
				#define SUBLANG_ITALIAN                             0x01
				#define SUBLANG_ITALIAN_SWISS                       0x02
				#define SUBLANG_JAPANESE_JAPAN                      0x01
				#define SUBLANG_KANNADA_INDIA                       0x01
				#define SUBLANG_KASHMIRI_SASIA                      0x02
				#define SUBLANG_KASHMIRI_INDIA                      0x02
				#define SUBLANG_KAZAK_KAZAKHSTAN                    0x01
				#define SUBLANG_KHMER_CAMBODIA                      0x01
				#define SUBLANG_KICHE_GUATEMALA                     0x01
				#define SUBLANG_KINYARWANDA_RWANDA                  0x01
				#define SUBLANG_KONKANI_INDIA                       0x01
				#define SUBLANG_KOREAN                              0x01
				#define SUBLANG_KYRGYZ_KYRGYZSTAN                   0x01
				#define SUBLANG_LAO_LAO                             0x01
				#define SUBLANG_LATVIAN_LATVIA                      0x01
				#define SUBLANG_LITHUANIAN                          0x01
				#define SUBLANG_LOWER_SORBIAN_GERMANY               0x02
				#define SUBLANG_LUXEMBOURGISH_LUXEMBOURG            0x01
				#define SUBLANG_MACEDONIAN_MACEDONIA                0x01
				#define SUBLANG_MALAY_MALAYSIA                      0x01
				#define SUBLANG_MALAY_BRUNEI_DARUSSALAM             0x02
				#define SUBLANG_MALAYALAM_INDIA                     0x01
				#define SUBLANG_MALTESE_MALTA                       0x01
				#define SUBLANG_MAORI_NEW_ZEALAND                   0x01
				#define SUBLANG_MAPUDUNGUN_CHILE                    0x01
				#define SUBLANG_MARATHI_INDIA                       0x01
				#define SUBLANG_MOHAWK_MOHAWK                       0x01
				#define SUBLANG_MONGOLIAN_CYRILLIC_MONGOLIA         0x01
				#define SUBLANG_MONGOLIAN_PRC                       0x02
				#define SUBLANG_NEPALI_INDIA                        0x02
				#define SUBLANG_NEPALI_NEPAL                        0x01
				#define SUBLANG_NORWEGIAN_BOKMAL                    0x01
				#define SUBLANG_NORWEGIAN_NYNORSK                   0x02
				#define SUBLANG_OCCITAN_FRANCE                      0x01
				#define SUBLANG_ORIYA_INDIA                         0x01
				#define SUBLANG_PASHTO_AFGHANISTAN                  0x01
				#define SUBLANG_PERSIAN_IRAN                        0x01
				#define SUBLANG_POLISH_POLAND                       0x01
				#define SUBLANG_PORTUGUESE                          0x02
				#define SUBLANG_PORTUGUESE_BRAZILIAN                0x01
				#define SUBLANG_PUNJABI_INDIA                       0x01
				#define SUBLANG_QUECHUA_BOLIVIA                     0x01
				#define SUBLANG_QUECHUA_ECUADOR                     0x02
				#define SUBLANG_QUECHUA_PERU                        0x03
				#define SUBLANG_ROMANIAN_ROMANIA                    0x01
				#define SUBLANG_ROMANSH_SWITZERLAND                 0x01
				#define SUBLANG_RUSSIAN_RUSSIA                      0x01
				#define SUBLANG_SAMI_NORTHERN_NORWAY                0x01
				#define SUBLANG_SAMI_NORTHERN_SWEDEN                0x02
				#define SUBLANG_SAMI_NORTHERN_FINLAND               0x03
				#define SUBLANG_SAMI_LULE_NORWAY                    0x04
				#define SUBLANG_SAMI_LULE_SWEDEN                    0x05
				#define SUBLANG_SAMI_SOUTHERN_NORWAY                0x06
				#define SUBLANG_SAMI_SOUTHERN_SWEDEN                0x07
				#define SUBLANG_SAMI_SKOLT_FINLAND                  0x08
				#define SUBLANG_SAMI_INARI_FINLAND                  0x09
				#define SUBLANG_SANSKRIT_INDIA                      0x01
				#define SUBLANG_SCOTTISH_GAELIC                     0x01
				#define SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_LATIN    0x06
				#define SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_CYRILLIC 0x07
				#define SUBLANG_SERBIAN_MONTENEGRO_LATIN            0x0b
				#define SUBLANG_SERBIAN_MONTENEGRO_CYRILLIC         0x0c
				#define SUBLANG_SERBIAN_SERBIA_LATIN                0x09
				#define SUBLANG_SERBIAN_SERBIA_CYRILLIC             0x0a
				#define SUBLANG_SERBIAN_CROATIA                     0x01
				#define SUBLANG_SERBIAN_LATIN                       0x02
				#define SUBLANG_SERBIAN_CYRILLIC                    0x03
				#define SUBLANG_SINDHI_INDIA                        0x01
				#define SUBLANG_SINDHI_PAKISTAN                     0x02
				#define SUBLANG_SINDHI_AFGHANISTAN                  0x02
				#define SUBLANG_SINHALESE_SRI_LANKA                 0x01
				#define SUBLANG_SOTHO_NORTHERN_SOUTH_AFRICA         0x01
				#define SUBLANG_SLOVAK_SLOVAKIA                     0x01
				#define SUBLANG_SLOVENIAN_SLOVENIA                  0x01
				#define SUBLANG_SPANISH                             0x01
				#define SUBLANG_SPANISH_MEXICAN                     0x02
				#define SUBLANG_SPANISH_MODERN                      0x03
				#define SUBLANG_SPANISH_GUATEMALA                   0x04
				#define SUBLANG_SPANISH_COSTA_RICA                  0x05
				#define SUBLANG_SPANISH_PANAMA                      0x06
				#define SUBLANG_SPANISH_DOMINICAN_REPUBLIC          0x07
				#define SUBLANG_SPANISH_VENEZUELA                   0x08
				#define SUBLANG_SPANISH_COLOMBIA                    0x09
				#define SUBLANG_SPANISH_PERU                        0x0a
				#define SUBLANG_SPANISH_ARGENTINA                   0x0b
				#define SUBLANG_SPANISH_ECUADOR                     0x0c
				#define SUBLANG_SPANISH_CHILE                       0x0d
				#define SUBLANG_SPANISH_URUGUAY                     0x0e
				#define SUBLANG_SPANISH_PARAGUAY                    0x0f
				#define SUBLANG_SPANISH_BOLIVIA                     0x10
				#define SUBLANG_SPANISH_EL_SALVADOR                 0x11
				#define SUBLANG_SPANISH_HONDURAS                    0x12
				#define SUBLANG_SPANISH_NICARAGUA                   0x13
				#define SUBLANG_SPANISH_PUERTO_RICO                 0x14
				#define SUBLANG_SPANISH_US                          0x15
				#define SUBLANG_SWAHILI_KENYA                       0x01
				#define SUBLANG_SWEDISH                             0x01
				#define SUBLANG_SWEDISH_FINLAND                     0x02
				#define SUBLANG_SYRIAC_SYRIA                        0x01
				#define SUBLANG_TAJIK_TAJIKISTAN                    0x01
				#define SUBLANG_TAMAZIGHT_ALGERIA_LATIN             0x02
				#define SUBLANG_TAMIL_INDIA                         0x01
				#define SUBLANG_TATAR_RUSSIA                        0x01
				#define SUBLANG_TELUGU_INDIA                        0x01
				#define SUBLANG_THAI_THAILAND                       0x01
				#define SUBLANG_TIBETAN_PRC                         0x01
				#define SUBLANG_TIGRIGNA_ERITREA                    0x02
				#define SUBLANG_TSWANA_SOUTH_AFRICA                 0x01
				#define SUBLANG_TURKISH_TURKEY                      0x01
				#define SUBLANG_TURKMEN_TURKMENISTAN                0x01
				#define SUBLANG_UIGHUR_PRC                          0x01
				#define SUBLANG_UKRAINIAN_UKRAINE                   0x01
				#define SUBLANG_UPPER_SORBIAN_GERMANY               0x01
				#define SUBLANG_URDU_PAKISTAN                       0x01
				#define SUBLANG_URDU_INDIA                          0x02
				#define SUBLANG_UZBEK_LATIN                         0x01
				#define SUBLANG_UZBEK_CYRILLIC                      0x02
				#define SUBLANG_VIETNAMESE_VIETNAM                  0x01
				#define SUBLANG_WELSH_UNITED_KINGDOM                0x01
				#define SUBLANG_WOLOF_SENEGAL                       0x01
				#define SUBLANG_XHOSA_SOUTH_AFRICA                  0x01
				#define SUBLANG_YAKUT_RUSSIA                        0x01
				#define SUBLANG_YI_PRC                              0x01
				#define SUBLANG_YORUBA_NIGERIA                      0x01
				#define SUBLANG_ZULU_SOUTH_AFRICA                   0x01
			*/
		};

	#endregion
}
