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
	public enum PluginFeatureFlags : uint
    {
		None							=			0x00000000,

		AutomaticUpdates				=			0x00000001,
		LimitedVersionCompatability		=			0x00000002,
		AutomaticUpdate					=			0x00000004,
		VersionCompatability			=			0x00000008,

    };

}
