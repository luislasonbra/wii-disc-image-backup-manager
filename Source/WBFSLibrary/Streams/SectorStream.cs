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
	//using System.ComponentModel.Composition.Primitives;
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

#endregion

using WBFSLibrary.Plugins;

using WBFSLibrary.IO;
using WBFSLibrary.IO.FileSystems;
using WBFSLibrary.IO.FileOperations;

namespace WBFSLibrary.IO.Streams
{

    public class SectorStream : StreamBase
	{
		#region Fields

			StreamBase stream;
			UInt16[] sectors;
			Int32 sector_index;
			Int32 offset;
			Int64 position;
			Int64 length;

		#endregion

		public override String Name
        {
            get { return this.stream.Name; }
        }

        public override Boolean CanRead
        {
            get { return this.stream.CanRead; }
        }

        public override Boolean CanSeek
        {
            get { return this.stream.CanSeek; }
        }

        public override Boolean CanWrite
        {
            get { return this.stream.CanWrite; }
        }

        public override Int64 Length
        {
            get { return this.length; }
        }

        public override Int64 Position
        {
            get { return this.position; }
            set { Seek(value, SeekOrigin.Begin); }
        }

        public SectorStream(StreamBase Stream, Int32 Sector_Size, UInt16[] Sectors): base(Sector_Size)
        {
            stream = Stream;
            sector_size = Sector_Size;
            sectors = new UInt16[Sectors.Length];
            length = (Int64)Sector_Size * Sectors.Length;
            position = -1;

            sectors.CopyTo(sectors, 0);

            Seek(0, SeekOrigin.Begin);
        }

        public override void Flush()
        {
            this.stream.Flush();
        }

        public override void Close()
        {
            this.stream.Close();
            base.Close();
        }

        public override void SetLength(Int64 value)
        {
            /* TODO */
        }

        public override Int64 Seek(Int64 Offset, SeekOrigin Origin)
        {
            switch (Origin)
            {
                case SeekOrigin.Current: Offset += position; break;
                case SeekOrigin.End: Offset = length - Offset; break;
            }

            if (Offset != position)
            {
                sector_index = (Int32)(offset / sector_size);
                Int64 sector = sectors[sector_index];
                offset = (Int32)(offset % sector_size);
                position = offset;

                this.stream.Seek(sector * sector_size + offset, SeekOrigin.Begin);
            }

            return position;
        }

        public override Int32 Read(Byte[] Buffer, Int32 Offset, Int32 Count)
        {
            if (this.position + Count >= length)
                throw new EndOfStreamException();

            Int32 read = 0;
            while(read != Count)
            {
                Int32 max = sector_size - offset;
                Int32 toread = Count < max ? Count : max;

                if (this.sectors[this.sector_index] == 0) Array.Clear(Buffer, read, toread);
                else this.stream.Read(Buffer, Offset + read, toread);

                read += toread;
                this.offset += toread;

                if (toread == max)
                {
                    this.offset = 0;

                    if ((++sector_index < sectors.Length) && (sectors[sector_index] != 0))
					{
                        stream.Seek((Int64)sectors[sector_index] * sector_size, SeekOrigin.Begin);
					}
                }
            }

            this.position += read;

            return Count;
        }

        public override void Write(Byte[] Buffer, Int32 Offset, Int32 Count)
        {
            if (position + Count >= length)
			{
                throw new EndOfStreamException();
			}

            Int32 written = 0;
            while (written != Count)
            {
                Int32 max = sector_size - Offset;
                Int32 towrite = Count < max ? Count : max;
                
                if (this.sectors[sector_index] == 0)
				{
					throw new ArgumentOutOfRangeException();
				}
                else this.stream.Write(Buffer, Offset + written, towrite);

                written += towrite;
                offset += towrite;

                if (towrite == max)
                {
                    offset = 0;

                    if ((++this.sector_index < sectors.Length) && (sectors[sector_index] != 0))
					{
                        this.stream.Seek((Int64)this.sectors[sector_index] * sector_size, SeekOrigin.Begin);
					}
                }
            }

            this.position += written;
        }

        public override Int32 ReadSector(Int32 Sector, IntPtr Array, Int32 Offset)
        {
            this.sector_index = Sector + 1;
            this.position += sector_size;
            return this.stream.ReadSector(this.sectors[Sector], Array, Offset);
        }

        public override Int32 WriteSector(Int32 sector, IntPtr array, Int32 offset)
        {
            this.sector_index = sector + 1;
            this.position += this.sector_size;
            return this.stream.WriteSector(this.sectors[sector], array, offset);
        }

        public override void WriteEmptyBlock(Int32 count)
        {
            if ((this.position % this.sector_size) != 0)
                throw new ArgumentOutOfRangeException();

            if (this.sectors[this.sector_index] != 0)
            {
                Byte[] zero = new Byte[this.sector_size];
                this.stream.Write(zero, 0, this.sector_size);
            }
            else
            {
                this.offset = 0;
                this.position += this.sector_size;
                this.sector_index += count / this.sector_size;
            }
        }
    }

}
