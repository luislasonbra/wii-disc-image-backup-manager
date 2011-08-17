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
	using System.Drawing;
	using System.Drawing.Design;
	using System.Drawing.Drawing2D;
	using System.Drawing.Imaging;
	using System.Drawing.Printing;
	using System.Drawing.Text;
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

	public interface IPlugin : IPluginMetaData
	{
		#region Fields

		#endregion

		#region Properties

			#region Version

				/* Gets the version */
				Version Version { get; }

				/* Gets the lowest version of the software with which this version of the plugin is compatible */
				Version RequiredVersion { get; }

				/* Gets the highest version of the software with which this version of the plugin is compatible */
				Version VersionLimit { get; }

			#endregion

			#region Identification

				/* Gets a Guid unique to this plugin for easily identifying it and differentiating it from other plugins */
				Guid Guid { get; }

				/* Gets an integer value usually a hash of the Guid for use with automatic updates and other systems needing to combine an id with a base url */
				Int32 Serial { get; }

			#endregion

			#region Settings

				/* */
				UInt32 FeatureFlags { get; }

				/* */
				UInt32 BuildFlags { get; }

				/* */
				UInt32 TypeFlags { get; }

			#endregion

			#region GUI

				/* */
				//Icon[] Icons { get; }

				/* */
				//Image[] Images { get; }

			#endregion

			#region Localization

				/* */
				//String Culture { get; }

				/* */
				//String Language { get; }

				/* */
				//String LanguageFile { get; }

			#endregion

		#endregion

		#region Members

		#endregion
	}

}
