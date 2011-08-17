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
using System.Data;
using System.IO;

namespace WBFSLibrary.Plugins
{

    [Flags]
	public enum PluginTypeFlags : uint
    {
		None					=			0x00000000,

		FileType				=			0x00010000,
		FileSystem				=			0x00020000,
		FileOperation			=			0x00040000,
		Device					=			0x00080000,

		HashingAlgorithm		=			0x00100000,
		EncryptionAlgorithm		=			0x00200000,
		CompressionAlgorithm	=			0x00400000,
		//x						=			0x00800000,

		//HashingAlgorithm		=			0x01000000,
		//EncryptionAlgorithm		=			0x02000000,
		//CompressionAlgorithm	=			0x04000000,
		//x						=			0x08000000,
    };

}
