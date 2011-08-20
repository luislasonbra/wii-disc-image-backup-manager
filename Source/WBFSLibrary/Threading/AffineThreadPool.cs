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

	/// <summary>Alternative Thread pool providing one thread for each core</summary>
	/// <remarks>
	///   <para>
	///     Unlike the normal thread pool, the affine thread pool provides only as many
	///     threads as there are CPU cores available on the current platform. This makes
	///     it more suitable for tasks you want to spread across all available cpu cores
	///     explicitely.
	///   </para>
	///   <para>
	///     However, it's not a good match if you want to run blocking or waiting tasks
	///     inside the thread pool because the limited available threads will become
	///     congested quickly. It is encouraged to use this class in parallel with
	///     .NET's own thread pool, putting tasks that can block into the .NET thread
	///     pool and task that perform pure processing into the affine thread pool.
	///   </para>
	///   <para>
	///     Implementation based on original code provided by Stephen Toub
	///     (stoub at microsoft ignorethis dot com)
	///   </para>
	/// </remarks>
	public static class AffineThreadPool
	{

		/// <summary>Number of CPU cores available on the system</summary>
		public static readonly int Processors = Environment.ProcessorCount;

		/// <summary>Delegate used by the thread pool to report unhandled exceptions</summary>
		/// <param name="exception">Exception that has not been handled</param>
		public delegate void ExceptionDelegate(Exception exception);

		#region class UserWorkItem

			/// <summary>Used to hold a callback delegate and the state for that delegate.</summary>
			private struct UserWorkItem
			{

				/// <summary>Initialize the callback holding object.</summary>
				/// <param name="callback">Callback delegate for the callback.</param>
				/// <param name="state">State with which to call the callback delegate.</param>
				public UserWorkItem(WaitCallback callback, object state)
				{
					this.Callback = callback;
					this.State = state;
				}

				/// <summary>Callback delegate for the callback.</summary>
				public WaitCallback Callback;

				/// <summary>State with which to call the callback delegate.</summary>
				public object State;

			}

		#endregion // class UserWorkItem

		/// <summary>Initializes the thread pool</summary>
		static AffineThreadPool()
		{
			// Create our thread stores; we handle synchronization ourself
			// as we may run into situations where multiple operations need to be atomic.
			// We keep track of the threads we've created just for good measure; not actually
			// needed for any core functionality.
			workAvailable = new Semaphore(Processors, Processors * 4);
			userWorkItems = new Queue<UserWorkItem>(Processors * 4);
			workerThreads = new List<Thread>(Processors);

			inUseThreads = 0;

			// We can use all cores in the PC, starting from index 1
			hardwareThreads = new Queue<int>(Processors);

			for(int core = Processors; core >= 1; --core)
			{
				hardwareThreads.Enqueue(core);
			}

			// Create all of the worker threads
			for(int index = 0; index < Processors; index++)
			{

				// Create a new thread and add it to the list of threads.
				Thread newThread = new Thread(new ThreadStart(ProcessQueuedItems));
				workerThreads.Add(newThread);

				// Configure the new thread and start it
				newThread.Name = "Nuclex.Support.AffineThreadPool Thread #" + index.ToString();
				newThread.IsBackground = true;
				newThread.Start();

			}

		}

		/// <summary>Queues a user work item to the thread pool</summary>
		/// <param name="callback">
		///   A WaitCallback representing the delegate to invoke when a thread in the 
		///   thread pool picks up the work item
		/// </param>
		public static void QueueUserWorkItem(WaitCallback callback)
		{
			// Queue the delegate with no state
			QueueUserWorkItem(callback, null);
		}

		/// <summary>Queues a user work item to the thread pool.</summary>
		/// <param name="callback">
		///   A WaitCallback representing the delegate to invoke when a thread in the 
		///   thread pool picks up the work item
		/// </param>
		/// <param name="state">
		///   The object that is passed to the delegate when serviced from the thread pool
		/// </param>
		public static void QueueUserWorkItem(WaitCallback callback, object state)
		{

			// Create a waiting callback that contains the delegate and its state.
			// Add it to the processing queue, and signal that data is waiting.
			UserWorkItem waiting = new UserWorkItem(callback, state);
			lock(userWorkItems)
			{
				userWorkItems.Enqueue(waiting);
			}

			// Wake up one of the worker threads so this task will be processed
			workAvailable.Release();

		}

		/// <summary>Gets the number of threads at the disposal of the thread pool</summary>
		public static int MaxThreads { get { return Processors; } }

		/// <summary>Gets the number of currently active threads in the thread pool</summary>
		public static int ActiveThreads { get { return inUseThreads; } }

		/// <summary>
		///   Gets the number of callback delegates currently waiting in the thread pool
		/// </summary>
		public static int WaitingWorkItems
		{
			get
			{
				lock(userWorkItems)
				{
					return userWorkItems.Count;
				}
			}
		}

		/// <summary>
		///   Default handler used to respond to unhandled exceptions in ThreadPool threads
		/// </summary>
		/// <param name="exception">Exception that has occurred</param>
		internal static void DefaultExceptionHandler(Exception exception)
		{
			throw exception;
		}

		/// <summary>A thread worker function that processes items from the work queue</summary>
		private static void ProcessQueuedItems()
		{

			// Get the system/hardware thread index this thread is going to use. We hope that
			// the threads more or less start after each other, but there is no guarantee that
			// tasks will be handled by the CPU cores in the order the queue was filled with.
			// This could be added, though, by using a WaitHandle so the thread creator could
			// wait for each thread to take one entry out of the queue.
			int hardwareThreadIndex;
			lock(hardwareThreads)
			{
				hardwareThreadIndex = hardwareThreads.Dequeue();
			}

			if(Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				// Prevent this managed thread from impersonating another system thread.
				// In .NET, managed threads can supposedly be moved to different system threads
				// and, more worryingly, even fibers. This should make sure we're sitting on
				// a normal system thread and stay with that thread during our lifetime.
				Thread.BeginThreadAffinity();

				// Assign the ideal processor, but don't force it. It's not a good idea to
				// circumvent the thread scheduler of a desktop machine, so we try to play nice.
				uint threadId = Kernel32.GetCurrentThreadId();
				ProcessThread thread = GetProcessThread((int)threadId);
				if(thread != null)
				{
					thread.IdealProcessor = hardwareThreadIndex;
				}
			}

			// Keep processing tasks indefinitely
			for(; ; )
			{
				UserWorkItem workItem = getNextWorkItem();

				// Execute the work item we just picked up. Make sure to accurately
				// record how many callbacks are currently executing.
				try
				{
					Interlocked.Increment(ref inUseThreads);
					workItem.Callback(workItem.State);
				}
				catch(Exception exception)
				{ // Make sure we don't throw here.
					ExceptionDelegate exceptionHandler = ExceptionHandler;
					if(exceptionHandler != null)
					{
						exceptionHandler(exception);
					}
				}
				finally
				{
					Interlocked.Decrement(ref inUseThreads);
				}
			}
		}

		/// <summary>Retrieves the ProcessThread for the calling thread</summary>
		/// <returns>The ProcessThread for the calling thread</returns>
		internal static ProcessThread GetProcessThread(int threadId)
		{
			ProcessThreadCollection threads = Process.GetCurrentProcess().Threads;
			for(int index = 0; index < threads.Count; ++index)
			{
				if(threads[index].Id == threadId)
				{
					return threads[index];
				}
			}

			return null;
		}

		/// <summary>Obtains the next work item from the queue</summary>
		/// <returns>The next work item in the queue</returns>
		/// <remarks>
		///   If the queue is empty, the call will block until an item is added to
		///   the queue and the calling thread was the one picking it up.
		/// </remarks>
		private static UserWorkItem getNextWorkItem()
		{
			// Get the next item in the queue. If there is nothing there, go to sleep
			// for a while until we're woken up when a callback is waiting.
			for(; ; )
			{

				// Try to get the next callback available.  We need to lock on the 
				// queue in order to make our count check and retrieval atomic.
				lock(userWorkItems)
				{
					if(userWorkItems.Count > 0)
					{
						return userWorkItems.Dequeue();
					}
				}

				// If we can't get one, go to sleep.
				workAvailable.WaitOne();

			}

		}

		/// <summary>Delegate used to handle assertion checks in the code</summary>
		public static volatile ExceptionDelegate ExceptionHandler = DefaultExceptionHandler;

		/// <summary>Available hardware threads the thread pool threads pick from</summary>
		private static Queue<int> hardwareThreads;

		/// <summary>Queue of all the callbacks waiting to be executed.</summary>
		private static Queue<UserWorkItem> userWorkItems;

		/// <summary>
		///   Used to let the threads in the thread pool wait for new work to appear.
		/// </summary>
		private static Semaphore workAvailable;

		/// <summary>List of all worker threads at the disposal of the thread pool.</summary>
		private static List<Thread> workerThreads;

		/// <summary>Number of threads currently active.</summary>
		private static int inUseThreads;
	}

}
