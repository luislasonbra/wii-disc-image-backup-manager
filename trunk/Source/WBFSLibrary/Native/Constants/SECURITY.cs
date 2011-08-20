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
		};

	#endregion
}
