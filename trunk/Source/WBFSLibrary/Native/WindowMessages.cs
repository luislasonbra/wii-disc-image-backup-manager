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

	public class WindowMessages
	{
		#region WM

			public class WM
			{
				/*
					//
					// Window Messages
					//

					#define WM_NULL                         0x0000
					#define WM_CREATE                       0x0001
					#define WM_DESTROY                      0x0002
					#define WM_MOVE                         0x0003
					#define WM_SIZE                         0x0005

					#define WM_ACTIVATE                     0x0006
					//
					// WM_ACTIVATE state values
					//
					#define     WA_INACTIVE     0
					#define     WA_ACTIVE       1
					#define     WA_CLICKACTIVE  2

					#define WM_SETFOCUS                     0x0007
					#define WM_KILLFOCUS                    0x0008
					#define WM_ENABLE                       0x000A
					#define WM_SETREDRAW                    0x000B
					#define WM_SETTEXT                      0x000C
					#define WM_GETTEXT                      0x000D
					#define WM_GETTEXTLENGTH                0x000E
					#define WM_PAINT                        0x000F
					#define WM_CLOSE                        0x0010
					#ifndef _WIN32_WCE
					#define WM_QUERYENDSESSION              0x0011
					#define WM_QUERYOPEN                    0x0013
					#define WM_ENDSESSION                   0x0016
					#endif
					#define WM_QUIT                         0x0012
					#define WM_ERASEBKGND                   0x0014
					#define WM_SYSCOLORCHANGE               0x0015
					#define WM_SHOWWINDOW                   0x0018
					#define WM_WININICHANGE                 0x001A
					#if(WINVER >= 0x0400)
					#define WM_SETTINGCHANGE                WM_WININICHANGE
					#endif // WINVER >= 0x0400 


					#define WM_DEVMODECHANGE                0x001B
					#define WM_ACTIVATEAPP                  0x001C
					#define WM_FONTCHANGE                   0x001D
					#define WM_TIMECHANGE                   0x001E
					#define WM_CANCELMODE                   0x001F
					#define WM_SETCURSOR                    0x0020
					#define WM_MOUSEACTIVATE                0x0021
					#define WM_CHILDACTIVATE                0x0022
					#define WM_QUEUESYNC                    0x0023

					#define WM_GETMINMAXINFO                0x0024
					#define WM_PAINTICON                    0x0026
					#define WM_ICONERASEBKGND               0x0027
					#define WM_NEXTDLGCTL                   0x0028
					#define WM_SPOOLERSTATUS                0x002A
					#define WM_DRAWITEM                     0x002B
					#define WM_MEASUREITEM                  0x002C
					#define WM_DELETEITEM                   0x002D
					#define WM_VKEYTOITEM                   0x002E
					#define WM_CHARTOITEM                   0x002F
					#define WM_SETFONT                      0x0030
					#define WM_GETFONT                      0x0031
					#define WM_SETHOTKEY                    0x0032
					#define WM_GETHOTKEY                    0x0033
					#define WM_QUERYDRAGICON                0x0037
					#define WM_COMPAREITEM                  0x0039
					#if(WINVER >= 0x0500)
					#ifndef _WIN32_WCE
					#define WM_GETOBJECT                    0x003D
					#endif
					#endif // WINVER >= 0x0500 
					#define WM_COMPACTING                   0x0041
					#define WM_COMMNOTIFY                   0x0044  // no longer suported 
					#define WM_WINDOWPOSCHANGING            0x0046
					#define WM_WINDOWPOSCHANGED             0x0047

					#define WM_POWER                        0x0048
					//
					// wParam for WM_POWER window message and DRV_POWER driver notification
					//
					#define PWR_OK              1
					#define PWR_FAIL            (-1)
					#define PWR_SUSPENDREQUEST  1
					#define PWR_SUSPENDRESUME   2
					#define PWR_CRITICALRESUME  3

					#define WM_COPYDATA                     0x004A
					#define WM_CANCELJOURNAL                0x004B


					#if(WINVER >= 0x0400)
					#define WM_NOTIFY                       0x004E
					#define WM_INPUTLANGCHANGEREQUEST       0x0050
					#define WM_INPUTLANGCHANGE              0x0051
					#define WM_TCARD                        0x0052
					#define WM_HELP                         0x0053
					#define WM_USERCHANGED                  0x0054
					#define WM_NOTIFYFORMAT                 0x0055

					#define NFR_ANSI                             1
					#define NFR_UNICODE                          2
					#define NF_QUERY                             3
					#define NF_REQUERY                           4

					#define WM_CONTEXTMENU                  0x007B
					#define WM_STYLECHANGING                0x007C
					#define WM_STYLECHANGED                 0x007D
					#define WM_DISPLAYCHANGE                0x007E
					#define WM_GETICON                      0x007F
					#define WM_SETICON                      0x0080
					#endif // WINVER >= 0x0400

					#define WM_NCCREATE                     0x0081
					#define WM_NCDESTROY                    0x0082
					#define WM_NCCALCSIZE                   0x0083
					#define WM_NCHITTEST                    0x0084
					#define WM_NCPAINT                      0x0085
					#define WM_NCACTIVATE                   0x0086
					#define WM_GETDLGCODE                   0x0087
					#ifndef _WIN32_WCE
					#define WM_SYNCPAINT                    0x0088
					#endif
					#define WM_NCMOUSEMOVE                  0x00A0
					#define WM_NCLBUTTONDOWN                0x00A1
					#define WM_NCLBUTTONUP                  0x00A2
					#define WM_NCLBUTTONDBLCLK              0x00A3
					#define WM_NCRBUTTONDOWN                0x00A4
					#define WM_NCRBUTTONUP                  0x00A5
					#define WM_NCRBUTTONDBLCLK              0x00A6
					#define WM_NCMBUTTONDOWN                0x00A7
					#define WM_NCMBUTTONUP                  0x00A8
					#define WM_NCMBUTTONDBLCLK              0x00A9



					#if(_WIN32_WINNT >= 0x0500)
					#define WM_NCXBUTTONDOWN                0x00AB
					#define WM_NCXBUTTONUP                  0x00AC
					#define WM_NCXBUTTONDBLCLK              0x00AD
					#endif // _WIN32_WINNT >= 0x0500


					#if(_WIN32_WINNT >= 0x0501)
					#define WM_INPUT_DEVICE_CHANGE          0x00FE
					#endif // _WIN32_WINNT >= 0x0501

					#if(_WIN32_WINNT >= 0x0501)
					#define WM_INPUT                        0x00FF
					#endif // _WIN32_WINNT >= 0x0501

					#define WM_KEYFIRST                     0x0100
					#define WM_KEYDOWN                      0x0100
					#define WM_KEYUP                        0x0101
					#define WM_CHAR                         0x0102
					#define WM_DEADCHAR                     0x0103
					#define WM_SYSKEYDOWN                   0x0104
					#define WM_SYSKEYUP                     0x0105
					#define WM_SYSCHAR                      0x0106
					#define WM_SYSDEADCHAR                  0x0107
					#if(_WIN32_WINNT >= 0x0501)
					#define WM_UNICHAR                      0x0109
					#define WM_KEYLAST                      0x0109
					#define UNICODE_NOCHAR                  0xFFFF
					#else
					#define WM_KEYLAST                      0x0108
					#endif // _WIN32_WINNT >= 0x0501

					#if(WINVER >= 0x0400)
					#define WM_IME_STARTCOMPOSITION         0x010D
					#define WM_IME_ENDCOMPOSITION           0x010E
					#define WM_IME_COMPOSITION              0x010F
					#define WM_IME_KEYLAST                  0x010F
					#endif // WINVER >= 0x0400

					#define WM_INITDIALOG                   0x0110
					#define WM_COMMAND                      0x0111
					#define WM_SYSCOMMAND                   0x0112
					#define WM_TIMER                        0x0113
					#define WM_HSCROLL                      0x0114
					#define WM_VSCROLL                      0x0115
					#define WM_INITMENU                     0x0116
					#define WM_INITMENUPOPUP                0x0117
					#if(WINVER >= 0x0601)
					#define WM_GESTURE                      0x0119
					#define WM_GESTURENOTIFY                0x011A
					#endif // WINVER >= 0x0601
					#define WM_MENUSELECT                   0x011F
					#define WM_MENUCHAR                     0x0120
					#define WM_ENTERIDLE                    0x0121
					#if(WINVER >= 0x0500)
					#ifndef _WIN32_WCE
					#define WM_MENURBUTTONUP                0x0122
					#define WM_MENUDRAG                     0x0123
					#define WM_MENUGETOBJECT                0x0124
					#define WM_UNINITMENUPOPUP              0x0125
					#define WM_MENUCOMMAND                  0x0126

					#ifndef _WIN32_WCE
					#if(_WIN32_WINNT >= 0x0500)
					#define WM_CHANGEUISTATE                0x0127
					#define WM_UPDATEUISTATE                0x0128
					#define WM_QUERYUISTATE                 0x0129

					//
					// LOWORD(wParam) values in WM_*UISTATE*
					///
					#define UIS_SET                         1
					#define UIS_CLEAR                       2
					#define UIS_INITIALIZE                  3

					//
					// HIWORD(wParam) values in WM_*UISTATE*
					//
					#define UISF_HIDEFOCUS                  0x1
					#define UISF_HIDEACCEL                  0x2
					#if(_WIN32_WINNT >= 0x0501)
					#define UISF_ACTIVE                     0x4
					#endif // _WIN32_WINNT >= 0x0501
					#endif // _WIN32_WINNT >= 0x0500
					#endif

					#endif
					#endif // WINVER >= 0x0500

					#define WM_CTLCOLORMSGBOX               0x0132
					#define WM_CTLCOLOREDIT                 0x0133
					#define WM_CTLCOLORLISTBOX              0x0134
					#define WM_CTLCOLORBTN                  0x0135
					#define WM_CTLCOLORDLG                  0x0136
					#define WM_CTLCOLORSCROLLBAR            0x0137
					#define WM_CTLCOLORSTATIC               0x0138
					#define MN_GETHMENU                     0x01E1

					#define WM_MOUSEFIRST                   0x0200
					#define WM_MOUSEMOVE                    0x0200
					#define WM_LBUTTONDOWN                  0x0201
					#define WM_LBUTTONUP                    0x0202
					#define WM_LBUTTONDBLCLK                0x0203
					#define WM_RBUTTONDOWN                  0x0204
					#define WM_RBUTTONUP                    0x0205
					#define WM_RBUTTONDBLCLK                0x0206
					#define WM_MBUTTONDOWN                  0x0207
					#define WM_MBUTTONUP                    0x0208
					#define WM_MBUTTONDBLCLK                0x0209
					#if (_WIN32_WINNT >= 0x0400) || (_WIN32_WINDOWS > 0x0400)
					#define WM_MOUSEWHEEL                   0x020A
					#endif
					#if (_WIN32_WINNT >= 0x0500)
					#define WM_XBUTTONDOWN                  0x020B
					#define WM_XBUTTONUP                    0x020C
					#define WM_XBUTTONDBLCLK                0x020D
					#endif
					#if (_WIN32_WINNT >= 0x0600)
					#define WM_MOUSEHWHEEL                  0x020E
					#endif

					#if (_WIN32_WINNT >= 0x0600)
					#define WM_MOUSELAST                    0x020E
					#elif (_WIN32_WINNT >= 0x0500)
					#define WM_MOUSELAST                    0x020D
					#elif (_WIN32_WINNT >= 0x0400) || (_WIN32_WINDOWS > 0x0400)
					#define WM_MOUSELAST                    0x020A
					#else
					#define WM_MOUSELAST                    0x0209
					#endif // (_WIN32_WINNT >= 0x0600)


					#if(_WIN32_WINNT >= 0x0400)
					// Value for rolling one detent
					#define WHEEL_DELTA                     120
					#define GET_WHEEL_DELTA_WPARAM(wParam)  ((short)HIWORD(wParam))

					// Setting to scroll one page for SPI_GET/SETWHEELSCROLLLINES
					#define WHEEL_PAGESCROLL                (UINT_MAX)
					#endif // _WIN32_WINNT >= 0x0400

					#if(_WIN32_WINNT >= 0x0500)
					#define GET_KEYSTATE_WPARAM(wParam)     (LOWORD(wParam))
					#define GET_NCHITTEST_WPARAM(wParam)    ((short)LOWORD(wParam))
					#define GET_XBUTTON_WPARAM(wParam)      (HIWORD(wParam))

					// XButton values are WORD flags
					#define XBUTTON1      0x0001
					#define XBUTTON2      0x0002
					// Were there to be an XBUTTON3, its value would be 0x0004
					#endif // _WIN32_WINNT >= 0x0500

					#define WM_PARENTNOTIFY                 0x0210
					#define WM_ENTERMENULOOP                0x0211
					#define WM_EXITMENULOOP                 0x0212

					#if(WINVER >= 0x0400)
					#define WM_NEXTMENU                     0x0213
					#define WM_SIZING                       0x0214
					#define WM_CAPTURECHANGED               0x0215
					#define WM_MOVING                       0x0216
					#define WM_POWERBROADCAST               0x0218
					#endif // WINVER >= 0x0400
					#if(WINVER >= 0x0400)
					#define WM_DEVICECHANGE                 0x0219
					#endif // WINVER >= 0x0400

					#define WM_MDICREATE                    0x0220
					#define WM_MDIDESTROY                   0x0221
					#define WM_MDIACTIVATE                  0x0222
					#define WM_MDIRESTORE                   0x0223
					#define WM_MDINEXT                      0x0224
					#define WM_MDIMAXIMIZE                  0x0225
					#define WM_MDITILE                      0x0226
					#define WM_MDICASCADE                   0x0227
					#define WM_MDIICONARRANGE               0x0228
					#define WM_MDIGETACTIVE                 0x0229


					#define WM_MDISETMENU                   0x0230
					#define WM_ENTERSIZEMOVE                0x0231
					#define WM_EXITSIZEMOVE                 0x0232
					#define WM_DROPFILES                    0x0233
					#define WM_MDIREFRESHMENU               0x0234

					#if(WINVER >= 0x0601)
					#define WM_TOUCH                        0x0240
					#endif // WINVER >= 0x0601


					#if(WINVER >= 0x0400)
					#define WM_IME_SETCONTEXT               0x0281
					#define WM_IME_NOTIFY                   0x0282
					#define WM_IME_CONTROL                  0x0283
					#define WM_IME_COMPOSITIONFULL          0x0284
					#define WM_IME_SELECT                   0x0285
					#define WM_IME_CHAR                     0x0286
					#endif // WINVER >= 0x0400
					#if(WINVER >= 0x0500)
					#define WM_IME_REQUEST                  0x0288
					#endif // WINVER >= 0x0500
					#if(WINVER >= 0x0400)
					#define WM_IME_KEYDOWN                  0x0290
					#define WM_IME_KEYUP                    0x0291
					#endif // WINVER >= 0x0400

					#if((_WIN32_WINNT >= 0x0400) || (WINVER >= 0x0500))
					#define WM_MOUSEHOVER                   0x02A1
					#define WM_MOUSELEAVE                   0x02A3
					#endif
					#if(WINVER >= 0x0500)
					#define WM_NCMOUSEHOVER                 0x02A0
					#define WM_NCMOUSELEAVE                 0x02A2
					#endif // WINVER >= 0x0500

					#if(_WIN32_WINNT >= 0x0501)
					#define WM_WTSSESSION_CHANGE            0x02B1

					#define WM_TABLET_FIRST                 0x02c0
					#define WM_TABLET_LAST                  0x02df
					#endif // _WIN32_WINNT >= 0x0501

					#define WM_CUT                          0x0300
					#define WM_COPY                         0x0301
					#define WM_PASTE                        0x0302
					#define WM_CLEAR                        0x0303
					#define WM_UNDO                         0x0304
					#define WM_RENDERFORMAT                 0x0305
					#define WM_RENDERALLFORMATS             0x0306
					#define WM_DESTROYCLIPBOARD             0x0307
					#define WM_DRAWCLIPBOARD                0x0308
					#define WM_PAINTCLIPBOARD               0x0309
					#define WM_VSCROLLCLIPBOARD             0x030A
					#define WM_SIZECLIPBOARD                0x030B
					#define WM_ASKCBFORMATNAME              0x030C
					#define WM_CHANGECBCHAIN                0x030D
					#define WM_HSCROLLCLIPBOARD             0x030E
					#define WM_QUERYNEWPALETTE              0x030F
					#define WM_PALETTEISCHANGING            0x0310
					#define WM_PALETTECHANGED               0x0311
					#define WM_HOTKEY                       0x0312

					#if(WINVER >= 0x0400)
					#define WM_PRINT                        0x0317
					#define WM_PRINTCLIENT                  0x0318
					#endif // WINVER >= 0x0400

					#if(_WIN32_WINNT >= 0x0500)
					#define WM_APPCOMMAND                   0x0319
					#endif // _WIN32_WINNT >= 0x0500

					#if(_WIN32_WINNT >= 0x0501)
					#define WM_THEMECHANGED                 0x031A
					#endif // _WIN32_WINNT >= 0x0501


					#if(_WIN32_WINNT >= 0x0501)
					#define WM_CLIPBOARDUPDATE              0x031D
					#endif /* _WIN32_WINNT >= 0x0501

					#if(_WIN32_WINNT >= 0x0600)
					#define WM_DWMCOMPOSITIONCHANGED        0x031E
					#define WM_DWMNCRENDERINGCHANGED        0x031F
					#define WM_DWMCOLORIZATIONCOLORCHANGED  0x0320
					#define WM_DWMWINDOWMAXIMIZEDCHANGE     0x0321
					#endif // _WIN32_WINNT >= 0x0600

					#if(_WIN32_WINNT >= 0x0601)
					#define WM_DWMSENDICONICTHUMBNAIL           0x0323
					#define WM_DWMSENDICONICLIVEPREVIEWBITMAP   0x0326
					#endif // _WIN32_WINNT >= 0x0601


					#if(WINVER >= 0x0600)
					#define WM_GETTITLEBARINFOEX            0x033F
					#endif // WINVER >= 0x0600

					#if(WINVER >= 0x0400)

					#define WM_HANDHELDFIRST                0x0358
					#define WM_HANDHELDLAST                 0x035F

					#define WM_AFXFIRST                     0x0360
					#define WM_AFXLAST                      0x037F
					#endif // WINVER >= 0x0400

					#define WM_PENWINFIRST                  0x0380
					#define WM_PENWINLAST                   0x038F


					#if(WINVER >= 0x0400)
					#define WM_APP                          0x8000
					#endif // WINVER >= 0x0400


					//
					// NOTE: All Message Numbers below 0x0400 are RESERVED.
					//
					// Private Window Messages Start Here:
					//
					#define WM_USER                         0x0400
				*/

				public static readonly UInt32	NULL							=	0x0000;
				public static readonly UInt32	CREATE							=	0x0001;
				public static readonly UInt32	DESTROY							=	0x0002;
				public static readonly UInt32	MOVE							=	0x0003;
				public static readonly UInt32	SIZE							=	0x0005;
				public static readonly UInt32	ACTIVATE						=	0x0006;
				public static readonly UInt32	SETFOCUS						=	0x0007;
				public static readonly UInt32	KILLFOCUS						=	0x0008;
				public static readonly UInt32	ENABLE							=	0x000A;
				public static readonly UInt32	SETREDRAW						=	0x000B;
				public static readonly UInt32	SETTEXT							=	0x000C;
				public static readonly UInt32	GETTEXT							=	0x000D;
				public static readonly UInt32	GETTEXTLENGTH					=	0x000E;
				public static readonly UInt32	PAINT							=	0x000F;
				public static readonly UInt32	CLOSE							=	0x0010;
				public static readonly UInt32	QUERYENDSESSION					=	0x0011;
				public static readonly UInt32	QUIT							=	0x0012;
				public static readonly UInt32	QUERYOPEN						=	0x0013;
				public static readonly UInt32	ERASEBKGND						=	0x0014;
				public static readonly UInt32	SYSCOLORCHANGE					=	0x0015;
				public static readonly UInt32	ENDSESSION						=	0x0016;
				public static readonly UInt32	SHOWWINDOW						=	0x0018;
				public static readonly UInt32	WININICHANGE					=	0x001A;
				public static readonly UInt32	SETTINGCHANGE					=	WININICHANGE;
				public static readonly UInt32	DEVMODECHANGE					=	0x001B;
				public static readonly UInt32	ACTIVATEAPP						=	0x001C;
				public static readonly UInt32	FONTCHANGE						=	0x001D;
				public static readonly UInt32	TIMECHANGE						=	0x001E;
				public static readonly UInt32	CANCELMODE						=	0x001F;
				public static readonly UInt32	SETCURSOR						=	0x0020;
				public static readonly UInt32	MOUSEACTIVATE					=	0x0021;
				public static readonly UInt32	CHILDACTIVATE					=	0x0022;
				public static readonly UInt32	QUEUESYNC						=	0x0023;
				public static readonly UInt32	GETMINMAXINFO					=	0x0024;
				public static readonly UInt32	PAINTICON						=	0x0026;
				public static readonly UInt32	ICONERASEBKGND					=	0x0027;
				public static readonly UInt32	NEXTDLGCTL						=	0x0028;
				public static readonly UInt32	SPOOLERSTATUS					=	0x002A;
				public static readonly UInt32	DRAWITEM						=	0x002B;
				public static readonly UInt32	MEASUREITEM						=	0x002C;
				public static readonly UInt32	DELETEITEM						=	0x002D;
				public static readonly UInt32	VKEYTOITEM						=	0x002E;
				public static readonly UInt32	CHARTOITEM						=	0x002F;
				public static readonly UInt32	SETFONT							=	0x0030;
				public static readonly UInt32	GETFONT							=	0x0031;
				public static readonly UInt32	SETHOTKEY						=	0x0032;
				public static readonly UInt32	GETHOTKEY						=	0x0033;
				public static readonly UInt32	QUERYDRAGICON					=	0x0037;
				public static readonly UInt32	COMPAREITEM						=	0x0039;
				public static readonly UInt32	GETOBJECT						=	0x003D;
				public static readonly UInt32	COMPACTING						=	0x0041;
				public static readonly UInt32	COMMNOTIFY						=	0x0044;
				public static readonly UInt32	WINDOWPOSCHANGING				=	0x0046;
				public static readonly UInt32	WINDOWPOSCHANGED				=	0x0047;
				public static readonly UInt32	POWER							=	0x0048;
				public static readonly UInt32	COPYDATA						=	0x004A;
				public static readonly UInt32	CANCELJOURNAL					=	0x004B;
				public static readonly UInt32	NOTIFY							=	0x004E;
				public static readonly UInt32	INPUTLANGCHANGEREQUEST			=	0x0050;
				public static readonly UInt32	INPUTLANGCHANGE					=	0x0051;
				public static readonly UInt32	TCARD							=	0x0052;
				public static readonly UInt32	HELP							=	0x0053;
				public static readonly UInt32	USERCHANGED						=	0x0054;
				public static readonly UInt32	NOTIFYFORMAT					=	0x0055;
				public static readonly UInt32	CONTEXTMENU						=	0x007B;
				public static readonly UInt32	STYLECHANGING					=	0x007C;
				public static readonly UInt32	STYLECHANGED					=	0x007D;
				public static readonly UInt32	DISPLAYCHANGE					=	0x007E;
				public static readonly UInt32	GETICON							=	0x007F;
				public static readonly UInt32	SETICON							=	0x0080;
				public static readonly UInt32	NCCREATE						=	0x0081;
				public static readonly UInt32	NCDESTROY						=	0x0082;
				public static readonly UInt32	NCCALCSIZE						=	0x0083;
				public static readonly UInt32	NCHITTEST						=	0x0084;
				public static readonly UInt32	NCPAINT							=	0x0085;
				public static readonly UInt32	NCACTIVATE						=	0x0086;
				public static readonly UInt32	GETDLGCODE						=	0x0087;
				public static readonly UInt32	SYNCPAINT						=	0x0088;
				public static readonly UInt32	NCMOUSEMOVE						=	0x00A0;
				public static readonly UInt32	NCLBUTTONDOWN					=	0x00A1;
				public static readonly UInt32	NCLBUTTONUP						=	0x00A2;
				public static readonly UInt32	NCLBUTTONDBLCLK					=	0x00A3;
				public static readonly UInt32	NCRBUTTONDOWN					=	0x00A4;
				public static readonly UInt32	NCRBUTTONUP						=	0x00A5;
				public static readonly UInt32	NCRBUTTONDBLCLK					=	0x00A6;
				public static readonly UInt32	NCMBUTTONDOWN					=	0x00A7;
				public static readonly UInt32	NCMBUTTONUP						=	0x00A8;
				public static readonly UInt32	NCMBUTTONDBLCLK					=	0x00A9;
				public static readonly UInt32	NCXBUTTONDOWN					=	0x00AB;
				public static readonly UInt32	NCXBUTTONUP						=	0x00AC;
				public static readonly UInt32	NCXBUTTONDBLCLK					=	0x00AD;
				public static readonly UInt32	INPUT_DEVICE_CHANGE				=	0x00FE;
				public static readonly UInt32	INPUT							=	0x00FF;
				public static readonly UInt32	KEYFIRST						=	0x0100;
				public static readonly UInt32	KEYDOWN							=	0x0100;
				public static readonly UInt32	KEYUP							=	0x0101;
				public static readonly UInt32	CHAR							=	0x0102;
				public static readonly UInt32	DEADCHAR						=	0x0103;
				public static readonly UInt32	SYSKEYDOWN						=	0x0104;
				public static readonly UInt32	SYSKEYUP						=	0x0105;
				public static readonly UInt32	SYSCHAR							=	0x0106;
				public static readonly UInt32	SYSDEADCHAR						=	0x0107;
				public static readonly UInt32	UNICHAR							=	0x0109;
				public static readonly UInt32	KEYLAST							=	0x0109;
				public static readonly UInt32	IME_STARTCOMPOSITION			=	0x010D;
				public static readonly UInt32	IME_ENDCOMPOSITION				=	0x010E;
				public static readonly UInt32	IME_COMPOSITION					=	0x010F;
				public static readonly UInt32	IME_KEYLAST						=	0x010F;
				public static readonly UInt32	INITDIALOG						=	0x0110;
				public static readonly UInt32	COMMAND							=	0x0111;
				public static readonly UInt32	SYSCOMMAND						=	0x0112;
				public static readonly UInt32	TIMER							=	0x0113;
				public static readonly UInt32	HSCROLL							=	0x0114;
				public static readonly UInt32	VSCROLL							=	0x0115;
				public static readonly UInt32	INITMENU						=	0x0116;
				public static readonly UInt32	INITMENUPOPUP					=	0x0117;
				public static readonly UInt32	GESTURE							=	0x0119;
				public static readonly UInt32	GESTURENOTIFY					=	0x011A;
				public static readonly UInt32	MENUSELECT						=	0x011F;
				public static readonly UInt32	MENUCHAR						=	0x0120;
				public static readonly UInt32	ENTERIDLE						=	0x0121;
				public static readonly UInt32	MENURBUTTONUP					=	0x0122;
				public static readonly UInt32	MENUDRAG						=	0x0123;
				public static readonly UInt32	MENUGETOBJECT					=	0x0124;
				public static readonly UInt32	UNINITMENUPOPUP					=	0x0125;
				public static readonly UInt32	MENUCOMMAND						=	0x0126;
				public static readonly UInt32	CHANGEUISTATE					=	0x0127;
				public static readonly UInt32	UPDATEUISTATE					=	0x0128;
				public static readonly UInt32	QUERYUISTATE					=	0x0129;
				public static readonly UInt32	CTLCOLORMSGBOX					=	0x0132;
				public static readonly UInt32	CTLCOLOREDIT					=	0x0133;
				public static readonly UInt32	CTLCOLORLISTBOX					=	0x0134;
				public static readonly UInt32	CTLCOLORBTN						=	0x0135;
				public static readonly UInt32	CTLCOLORDLG						=	0x0136;
				public static readonly UInt32	CTLCOLORSCROLLBAR				=	0x0137;
				public static readonly UInt32	CTLCOLORSTATIC					=	0x0138;
				public static readonly UInt32	MOUSEFIRST						=	0x0200;
				public static readonly UInt32	MOUSEMOVE						=	0x0200;
				public static readonly UInt32	LBUTTONDOWN						=	0x0201;
				public static readonly UInt32	LBUTTONUP						=	0x0202;
				public static readonly UInt32	LBUTTONDBLCLK					=	0x0203;
				public static readonly UInt32	RBUTTONDOWN						=	0x0204;
				public static readonly UInt32	RBUTTONUP						=	0x0205;
				public static readonly UInt32	RBUTTONDBLCLK					=	0x0206;
				public static readonly UInt32	MBUTTONDOWN						=	0x0207;
				public static readonly UInt32	MBUTTONUP						=	0x0208;
				public static readonly UInt32	MBUTTONDBLCLK					=	0x0209;
				public static readonly UInt32	MOUSEWHEEL						=	0x020A;
				public static readonly UInt32	XBUTTONDOWN						=	0x020B;
				public static readonly UInt32	XBUTTONUP						=	0x020C;
				public static readonly UInt32	XBUTTONDBLCLK					=	0x020D;
				public static readonly UInt32	MOUSELAST						=	0x020D;
				public static readonly UInt32	PARENTNOTIFY					=	0x0210;
				public static readonly UInt32	ENTERMENULOOP					=	0x0211;
				public static readonly UInt32	EXITMENULOOP					=	0x0212;
				public static readonly UInt32	NEXTMENU						=	0x0213;
				public static readonly UInt32	SIZING							=	0x0214;
				public static readonly UInt32	CAPTURECHANGED					=	0x0215;
				public static readonly UInt32	MOVING							=	0x0216;
				public static readonly UInt32	POWERBROADCAST					=	0x0218;
				public static readonly UInt32	DEVICECHANGE					=	0x0219;
				public static readonly UInt32	MDICREATE						=	0x0220;
				public static readonly UInt32	MDIDESTROY						=	0x0221;
				public static readonly UInt32	MDIACTIVATE						=	0x0222;
				public static readonly UInt32	MDIRESTORE						=	0x0223;
				public static readonly UInt32	MDINEXT							=	0x0224;
				public static readonly UInt32	MDIMAXIMIZE						=	0x0225;
				public static readonly UInt32	MDITILE							=	0x0226;
				public static readonly UInt32	MDICASCADE						=	0x0227;
				public static readonly UInt32	MDIICONARRANGE					=	0x0228;
				public static readonly UInt32	MDIGETACTIVE					=	0x0229;
				public static readonly UInt32	MDISETMENU						=	0x0230;
				public static readonly UInt32	ENTERSIZEMOVE					=	0x0231;
				public static readonly UInt32	EXITSIZEMOVE					=	0x0232;
				public static readonly UInt32	DROPFILES						=	0x0233;
				public static readonly UInt32	MDIREFRESHMENU					=	0x0234;
				public static readonly UInt32	TOUCH							=	0x0240;
				public static readonly UInt32	IME_SETCONTEXT					=	0x0281;
				public static readonly UInt32	IME_NOTIFY						=	0x0282;
				public static readonly UInt32	IME_CONTROL						=	0x0283;
				public static readonly UInt32	IME_COMPOSITIONFULL				=	0x0284;
				public static readonly UInt32	IME_SELECT						=	0x0285;
				public static readonly UInt32	IME_CHAR						=	0x0286;
				public static readonly UInt32	IME_REQUEST						=	0x0288;
				public static readonly UInt32	IME_KEYDOWN						=	0x0290;
				public static readonly UInt32	IME_KEYUP						=	0x0291;
				public static readonly UInt32	MOUSEHOVER						=	0x02A1;
				public static readonly UInt32	MOUSELEAVE						=	0x02A3;
				public static readonly UInt32	NCMOUSEHOVER					=	0x02A0;
				public static readonly UInt32	NCMOUSELEAVE					=	0x02A2;
				public static readonly UInt32	WTSSESSION_CHANGE				=	0x02B1;
				public static readonly UInt32	TABLET_FIRST					=	0x02c0;
				public static readonly UInt32	TABLET_LAST						=	0x02df;
				public static readonly UInt32	CUT								=	0x0300;
				public static readonly UInt32	COPY							=	0x0301;
				public static readonly UInt32	PASTE							=	0x0302;
				public static readonly UInt32	CLEAR							=	0x0303;
				public static readonly UInt32	UNDO							=	0x0304;
				public static readonly UInt32	RENDERFORMAT					=	0x0305;
				public static readonly UInt32	RENDERALLFORMATS				=	0x0306;
				public static readonly UInt32	DESTROYCLIPBOARD				=	0x0307;
				public static readonly UInt32	DRAWCLIPBOARD					=	0x0308;
				public static readonly UInt32	PAINTCLIPBOARD					=	0x0309;
				public static readonly UInt32	VSCROLLCLIPBOARD				=	0x030A;
				public static readonly UInt32	SIZECLIPBOARD					=	0x030B;
				public static readonly UInt32	ASKCBFORMATNAME					=	0x030C;
				public static readonly UInt32	CHANGECBCHAIN					=	0x030D;
				public static readonly UInt32	HSCROLLCLIPBOARD				=	0x030E;
				public static readonly UInt32	QUERYNEWPALETTE					=	0x030F;
				public static readonly UInt32	PALETTEISCHANGING				=	0x0310;
				public static readonly UInt32	PALETTECHANGED					=	0x0311;
				public static readonly UInt32	HOTKEY							=	0x0312;
				public static readonly UInt32	PRINT							=	0x0317;
				public static readonly UInt32	PRINTCLIENT						=	0x0318;
				public static readonly UInt32	APPCOMMAND						=	0x0319;
				public static readonly UInt32	THEMECHANGED					=	0x031A;
				public static readonly UInt32	CLIPBOARDUPDATE					=	0x031D;
				public static readonly UInt32	DWMCOMPOSITIONCHANGED			=	0x031E;
				public static readonly UInt32	DWMNCRENDERINGCHANGED			=	0x031F;
				public static readonly UInt32	DWMCOLORIZATIONCOLORCHANGED		=	0x0320;
				public static readonly UInt32	DWMWINDOWMAXIMIZEDCHANGE		=	0x0321;
				public static readonly UInt32	DWMSENDICONICTHUMBNAIL			=	0x0323;
				public static readonly UInt32	DWMSENDICONICLIVEPREVIEWBITMAP	=	0x0326;
				public static readonly UInt32	GETTITLEBARINFOEX				=	0x033F;
				public static readonly UInt32	HANDHELDFIRST					=	0x0358;
				public static readonly UInt32	HANDHELDLAST					=	0x035F;
				public static readonly UInt32	AFXFIRST						=	0x0360;
				public static readonly UInt32	AFXLAST							=	0x037F;
				public static readonly UInt32	PENWINFIRST						=	0x0380;
				public static readonly UInt32	PENWINLAST						=	0x038F;
				public static readonly UInt32	APP								=	0x8000;
				public static readonly UInt32	USER							=	0x0400;
			}

		#endregion

		#region ShowWindow Commands

			///*
			// * ShowWindow() Commands
			// */
			//#define SW_HIDE             0
			//#define SW_SHOWNORMAL       1
			//#define SW_NORMAL           1
			//#define SW_SHOWMINIMIZED    2
			//#define SW_SHOWMAXIMIZED    3
			//#define SW_MAXIMIZE         3
			//#define SW_SHOWNOACTIVATE   4
			//#define SW_SHOW             5
			//#define SW_MINIMIZE         6
			//#define SW_SHOWMINNOACTIVE  7
			//#define SW_SHOWNA           8
			//#define SW_RESTORE          9
			//#define SW_SHOWDEFAULT      10
			//#define SW_FORCEMINIMIZE    11
			//#define SW_MAX              11


			///*
			// * Old ShowWindow() Commands
			// */
			//#define HIDE_WINDOW         0
			//#define SHOW_OPENWINDOW     1
			//#define SHOW_ICONWINDOW     2
			//#define SHOW_FULLSCREEN     3
			//#define SHOW_OPENNOACTIVATE 4

		#endregion

		#region WM_SHOWWINDOW Identifiers

			///*
			// * Identifiers for the WM_SHOWWINDOW message
			// */
			//#define SW_PARENTCLOSING    1
			//#define SW_OTHERZOOM        2
			//#define SW_PARENTOPENING    3
			//#define SW_OTHERUNZOOM      4

		#endregion

		#region WM_ACTIVATE State

			//
			// WM_ACTIVATE state values
			//
			//#define     WA_INACTIVE     0
			//#define     WA_ACTIVE       1
			//#define     WA_CLICKACTIVE  2

		#endregion

		#region WM_POWER & DRV_POWER wParam

			//
			// wParam for WM_POWER window message and DRV_POWER driver notification
			//
			//#define PWR_OK              1
			//#define PWR_FAIL            (-1)
			//#define PWR_SUSPENDREQUEST  1
			//#define PWR_SUSPENDRESUME   2
			//#define PWR_CRITICALRESUME  3

		#endregion

		#region NFR

			//#define NFR_ANSI                             1
			//#define NFR_UNICODE                          2

		#endregion

		#region NF

			//#define NF_QUERY                             3
			//#define NF_REQUERY                           4

		#endregion

		#region UIS

			//
			// LOWORD(wParam) values in WM_*UISTATE*
			//
			//#define UIS_SET                         1
			//#define UIS_CLEAR                       2
			//#define UIS_INITIALIZE                  3

		#endregion

		#region UISF

			//
			// HIWORD(wParam) values in WM_*UISTATE*
			//
			//#define UISF_HIDEFOCUS                  0x1
			//#define UISF_HIDEACCEL                  0x2
			//#define UISF_ACTIVE                     0x4

		#endregion

		#region XBUTTON

			// XButton values are WORD flags
			//#define XBUTTON1      0x0001
			//#define XBUTTON2      0x0002

		#endregion

		#region WHEEL

			// Setting to scroll one page for SPI_GET/SETWHEELSCROLLLINES
			//#define WHEEL_PAGESCROLL                (UINT_MAX)
			//#define WHEEL_DELTA                     120

		#endregion
	}

}