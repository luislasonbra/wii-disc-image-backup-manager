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
	public enum PluginBuildFlags : uint
    {
		None					=			0x00000000,

		Alpha					=			0x00000001,
		Beta					=			0x00000002,
		ReleaseCandiate			=			0x00000004,
		Release					=			0x00000008,

		Experimental			=			0x00000010,
		Debug					=			0x00000020,
		QFE						=			0x00000040,
		Internal				=			0x00000080,

		Final					=			0x00000010,
		Gamma					=			0x00000020,
		Demo					=			0x00000040,
		Trial					=			0x00000080,
    };

}
