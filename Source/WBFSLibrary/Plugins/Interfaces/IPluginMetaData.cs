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

	public interface IPluginMetaData
	{
		#region Fields

		#endregion

		#region Properties

			#region Name

				/* Gets the name used internally for identifying this plugin */
				String InternalName { get; }

				/* Gets the name of this plugin for display in the software */
				String DisplayName { get; }

			#endregion

			#region Description

				/* Gets a brief or condensed statement giving a general overview of this plugin and what it does */
				String Synopsis { get; }

				/* Gets a highly detailed and informative description of this plugin and what it does */
				String Description { get; }

			#endregion

			#region Internet Presence

				/* Gets an url that when visited provides information related to this plugin such as source code, changelogs, release dates, alternative versions and more */
				String URL { get; }

				/* Gets an optional URL that links to the developer, company, group, team homepage */
				String DeveloperURL { get; }

			#endregion

			#region Developer Information

				/* Gets the name of the developer, company, group, studio or team who created this plugin */
				String DeveloperName { get; }

				/* Gets a list of names for the people who wrote the code for this plugin */
				List<String> DeveloperCoders { get; }

				/* Gets a list of names for the people who created any graphical resources for this plugin */
				List<String> DeveloperArtists { get; }

				/* Gets a list of names for the people who discovered, analysed, verified and documented any defects during development of this plugin */
				List<String> DeveloperQualityAssurance { get; }

				/* Gets a list of names for the people who contributed in any other ways to the development of this plugin */
				List<String> DeveloperContributors { get; }

			#endregion

			#region License

				/* Gets the name of the license this plugin was released under */
				String Licensee { get; }

				/* Gets the copy which is a block of text that contains the text comprising the license this plugin was released under */
				String LicenseCopy { get; }

				/* Gets an optional URL that links to the homepage for this license */
				String LicenseURL { get; }

			#endregion

			#region Downloads & Automatic Updates

				/* Gets an URL that this exact version and any subsequent versions of this plugin can be manually downloaded from additionally sometimes prior versions can be downloaded from this location also */
				String DownloadURL { get; }

				/* Gets an URL that can be used as the base to download the update catalog when combined with the version, update catalogs contain changelogs, file sizes, versions and release dates */
				String AutomaticUpdatesCatalogURL { get; }

				/* Gets an URL that can be used as the base to download automatic updates when combined with the serial and version */
				String AutomaticUpdatesDownloadURL { get; }

			#endregion

		#endregion
	}

}
