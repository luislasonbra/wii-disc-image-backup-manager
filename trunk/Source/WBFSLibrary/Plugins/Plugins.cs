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

using WBFSLibrary.Plugins;

using WBFSLibrary.IO;
using WBFSLibrary.IO.FileSystems;
using WBFSLibrary.IO.FileTypes;
using WBFSLibrary.IO.FileOperations;

namespace WBFSLibrary.Plugins
{

    public class Plugins
    {
        #region Fields

            public String directoryPath;

            public DirectoryInfo directoryInfo;

            public AssemblyCatalog assemblyCatalog;

            public DirectoryCatalog directoryCatalog;

            public AggregateCatalog aggregateCatalog;

            public CompositionContainer compositionContainer;

            public CompositionBatch compositionBatch;

            [ImportMany("FileSystems", typeof(IFileSystemPlugin), AllowRecomposition = true)]
            public IEnumerable<IFileSystemPlugin> file_system_plugins { get; private set; }

            [ImportMany("FileTypes", typeof(IFileTypePlugin), AllowRecomposition = true)]
            public IEnumerable<IFileTypePlugin> file_type_plugins { get; private set; }

            [ImportMany("FileOperations", typeof(IFileOperationPlugin), AllowRecomposition = true)]
            public IEnumerable<IFileOperationPlugin> file_operation_plugins { get; private set; }

			//[Import("Input Managment", typeof(IInputManagerPlugin), AllowRecomposition = true)]
			//public IInputManagerPlugin inputManagerPlugin { get; private set; }

        #endregion

        #region Public Methods

            #region Methods

                public void Compose(String directory)
                {
                    //Debugging.AddTextListener("Composition", "Composition.log");

                    Trace.WriteLine("Composing IOC container...", "Working.Title");
                    Trace.Indent();

                    directoryPath = directory;

                    directoryInfo = new DirectoryInfo(directory);
                    directoryInfo.Unblock(true);
   
                    directoryCatalog = new DirectoryCatalog(directory);

                    if(directoryCatalog.LoadedFiles.Count() > 0)
                    {
                        Trace.WriteLine("Found plugin assemblies...", "Working.Title.Plugins");
                        Trace.Indent();
                        foreach(String assembly in directoryCatalog.LoadedFiles)
                        {
                            Trace.WriteLine("Assembly: " + assembly.ToLower(), "Working.Title.Plugins");
                            Trace.Indent();
                            if(directoryCatalog.Parts.Count() > 0)
                            {
                                Trace.WriteLine("Assembly contains parts...", "Working.Title.Plugins");
                                Trace.Indent();
                                foreach(ComposablePartDefinition part in directoryCatalog.Parts)
                                {
                                    Trace.WriteLine("Part: " + part, "Working.Title.Plugins");
                                    Trace.Indent();
                                    if(part.ExportDefinitions.Count() > 0)
                                    {
                                        Trace.WriteLine("Part contains exports...", "Working.Title.Plugins");
                                        Trace.Indent();
                                        foreach(ExportDefinition export in part.ExportDefinitions)
                                        {
                                            Trace.WriteLine("Export: " + export.ContractName, "Working.Title.Plugins");
                                        }
                                        Trace.Unindent();
                                    }
                                    Trace.Unindent();
                                }
                                Trace.Unindent();
                            }
                            Trace.Unindent();
                        }
                        Trace.Unindent();
                    }

                    assemblyCatalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());

                    if(assemblyCatalog.Parts.Count() > 0)
                    {
                        Trace.WriteLine("Executing Assembly contains parts...", "Working.Title.Plugins");
                        Trace.Indent();
                        foreach(ComposablePartDefinition part in directoryCatalog.Parts)
                        {
                            Trace.WriteLine("Part: " + part, "Working.Title.Plugins");
                            Trace.Indent();
                            if(part.ExportDefinitions.Count() > 0)
                            {
                                Trace.WriteLine("Part contains exports...", "Working.Title.Plugins");
                                Trace.Indent();
                                foreach(ExportDefinition export in part.ExportDefinitions)
                                {
                                    Trace.WriteLine("Export: " + export.ContractName, "Working.Title.Plugins");
                                }
                                Trace.Unindent();
                            }
                            Trace.Unindent();
                        }
                        Trace.Unindent();
                    }

                    aggregateCatalog = new AggregateCatalog(assemblyCatalog, directoryCatalog);

                    compositionContainer = new CompositionContainer(aggregateCatalog);

                    compositionBatch = new CompositionBatch();
                    compositionBatch.AddPart(this);

                    compositionContainer.Compose(compositionBatch);
                        
                    Trace.Unindent();

                    //Debugging.RemoveListener("Composition");
                }

				//public void Update(GameTime gameTime)
				//{
				//    inputManagerPlugin.Update(gameTime);
				//    foreach (IUpdatePlugin plugin in updatePlugins)
				//    {
				//        plugin.Update(gameTime);
				//    }
				//}

				//public void Draw(GameTime gameTime)
				//{
				//    foreach (IDrawPlugin plugin in drawPlugins)
				//    {
				//        plugin.Draw(gameTime);
				//    }
				//}

            #endregion

        #endregion
    }

}
