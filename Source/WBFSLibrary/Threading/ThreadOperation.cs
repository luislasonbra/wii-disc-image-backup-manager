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
	/*
  /// <summary>Operation that executes a method in a background thread</summary>
  public abstract class ThreadOperation : Operation {

    /// <summary>
    ///   Initializes a new threaded operation.
    /// </summary>
    /// <remarks>
    ///   Uses a ThreadPool thread to execute the method in a background thread.
    /// </remarks>
    public ThreadOperation() : this(true) { }

    /// <summary>
    ///   Initializes a new threaded operation which optionally uses the ThreadPool.
    /// </summary>
    /// <param name="useThreadPool">Whether to use a ThreadPool thread.</param>
    /// <remarks>
    ///   If useThreadPool is false, a new thread will be created. This guarantees
    ///   that the method will be executed immediately but has an impact on
    ///   performance since the creation of new threads is not a cheap operation.
    /// </remarks>
    public ThreadOperation(bool useThreadPool) {
      this.useThreadPool = useThreadPool;
    }

    /// <summary>Launches the background operation</summary>
    public override void Start() {
      Debug.Assert(
        !Ended,
        "Tried to Start an Operation again that has already ended",
        "Operations cannot be re-run"
      );
      if(useThreadPool) {
        ThreadPool.QueueUserWorkItem(new WaitCallback(callMethod));
      } else {
        Thread thread = new Thread(new ThreadStart(callMethod));
        thread.Name = "Nuclex.Support.Scheduling.ThreadOperation";
        thread.IsBackground = true;
        thread.Start();
      }
    }

    /// <summary>Contains the payload to be executed in the background thread</summary>
    protected abstract void Execute();

    /// <summary>Invokes the delegate passed as an argument</summary>
    /// <param name="state">Not used</param>
    private void callMethod(object state) {
      callMethod();
    }

    /// <summary>Invokes the delegate passed as an argument</summary>
    private void callMethod() {
      try {
        Execute();
        Debug.Assert(
          !Ended,
          "Operation unexpectedly ended during Execute()",
          "Do not call OnAsyncEnded() yourself when deriving from ThreadOperation"
        );
      }
      catch(Exception exception) {
        this.exception = exception;
      }
      finally {
        OnAsyncEnded();
      }
    }

    /// <summary>
    ///   Allows the specific request implementation to re-throw an exception if
    ///   the background process finished unsuccessfully
    /// </summary>
    protected override void ReraiseExceptions() {
      if(this.exception != null)
        throw this.exception;
    }

    /// <summary>Whether to use the ThreadPool for obtaining a background thread</summary>
    private bool useThreadPool;
    /// <summary>Exception that has occured in the background process</summary>
    private volatile Exception exception;

  }
	*/
}
