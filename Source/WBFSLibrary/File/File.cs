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

namespace WBFSLibrary.IO
{

    public class File : IFile, INullOrEmpty
    {
		#region Fields

			FileInfo info;

		#endregion

		#region Properties

			#region File

				/* Provides attributes for files and directories. */
				public String Path { get; protected set; }

			#endregion

			#region FileInfo

				/* Provides instance methods for the creation, copying, deletion, moving, and opening of files, and aids in the creation of System.IO.FileStream objects. This class cannot be inherited. */
				public FileInfo FileInfo { get; protected set; }

				#region FileInfo Accessors

					/*  Gets or sets the creation time of the current file or directory. */
					public DateTime CreationTime { get { return FileInfo.CreationTime; } }

				#endregion

			#endregion

			#region FileAttributes

				/* Provides attributes for files and directories. */
				public FileAttributes FileAttributes { get; protected set; }

				#region FileAttributes Accessors

					/* The file's archive status. Applications use this attribute to mark files for backup or removal. */
					public Boolean IsArchived { get { return FileAttributes.HasFlag(FileAttributes.Archive); } }

					/* The file is compressed. */
					public Boolean IsCompressed { get { return FileAttributes.HasFlag(FileAttributes.Compressed); } }

					/*  Reserved for future use. */
					public Boolean IsDevice { get { return FileAttributes.HasFlag(FileAttributes.Device); } }

					/* The file is a directory. */
					public Boolean IsDirectory { get { return FileAttributes.HasFlag(FileAttributes.Directory); } }

					/* The file or directory is encrypted. For a file, this means that all data in the file is encrypted. For a directory, this means that encryption is the default for newly created files and directories. */
					public Boolean IsEncrypted { get { return FileAttributes.HasFlag(FileAttributes.Directory); } }

					/* The file is hidden, and thus is not included in an ordinary directory listing. */
					public Boolean IsHidden { get; set; }

					/* The file is normal and has no other attributes set. This attribute is valid only if used alone. */
					public Boolean IsNormal { get; set; }

					/* The file will not be indexed by the operating system's content indexing service. */
					public Boolean IsNotContentIndexed { get; set; }

					/* The file is offline. The data of the file is not immediately available. */
					public Boolean IsOffline { get; set; }

					/* The file is read-only. */
					public Boolean IsReadOnly { get; set; }

					/* The file contains a reparse point, which is a block of user-defined data associated with a file or a directory. */
					public Boolean IsReparsePoint { get; set; }

					/* The file is a sparse file. Sparse files are typically large files whose data are mostly zeros. */
					public Boolean IsSparseFile { get; set; }

					/* The file is a system file. The file is part of the operating system or is used exclusively by the operating system. */
					public Boolean IsSystem { get; set; }

					/* The file is temporary. File systems attempt to keep all of the data in memory for quicker access rather than flushing the data back to mass storage. A temporary file should be deleted by the application as soon as it is no longer needed. */
					public Boolean IsTemporary { get; set; }

				#endregion

			#endregion

			#region FileSecurity

				/* Provides attributes for files and directories. */
				public FileSecurity FileSecurity { get; protected set; }

				#region FileSecurity Accessors

				#endregion

			#endregion

		#endregion

		#region Members

			#region Construction

				public File()
				{
				}

				public File(String path)
				{
					this.FileInfo = new FileInfo(path);
					if(this.FileInfo.Exists)
					{
						this.FileAttributes = this.FileInfo.Attributes;
						if(this.FileAttributes != null)
						{
							if(this.FileAttributes.HasFlag(FileAttributes.Directory))
							{

							}
							else
							{
								this.FileSecurity = this.FileInfo.GetAccessControl();
								if(this.FileSecurity != null)
								{

								}
								else
								{

								}
							}
						}
						else
						{

						}
					}
					else
					{

					}
				}

			#endregion

			#region Members


			#endregion

		#endregion
    }

}
