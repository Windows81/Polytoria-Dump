namespace System.IO;

[DefaultEvent("Changed")]
[IODescription(null)]
[Token(Token = "0x20001E8")]
public class FileSystemWatcher : Component
{
	[CompilerGenerated]
	[Token(Token = "0x20001EA")]
	private sealed class <>c__DisplayClass70_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000756")]
		public FileSystemWatcher <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000757")]
		public string filename; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C48")]
		public <>c__DisplayClass70_0() { }

		[Address(RVA = "0x17CC6B0", Offset = "0x17CB8B0", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FileSystemEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WatcherChangeTypes), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileSystemWatcher), Member = "RaiseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(EventArgs), "System.IO.FileSystemWatcher+EventType"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C49")]
		internal void <DispatchEvents>b__0() { }

		[Address(RVA = "0x17CC760", Offset = "0x17CB960", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FileSystemEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WatcherChangeTypes), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileSystemWatcher), Member = "RaiseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(EventArgs), "System.IO.FileSystemWatcher+EventType"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C4A")]
		internal void <DispatchEvents>b__1() { }

		[Address(RVA = "0x17CC810", Offset = "0x17CBA10", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FileSystemEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WatcherChangeTypes), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileSystemWatcher), Member = "RaiseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(EventArgs), "System.IO.FileSystemWatcher+EventType"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C4B")]
		internal void <DispatchEvents>b__2() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001EB")]
	private sealed class <>c__DisplayClass70_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000758")]
		public RenamedEventArgs renamed_ref; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000759")]
		public <>c__DisplayClass70_0 CS$<>8__locals1; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C4C")]
		public <>c__DisplayClass70_1() { }

		[Address(RVA = "0x17CC8C0", Offset = "0x17CBAC0", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemWatcher), Member = "RaiseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(EventArgs), "System.IO.FileSystemWatcher+EventType"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C4D")]
		internal void <DispatchEvents>b__3() { }

	}

	[Token(Token = "0x20001E9")]
	private enum EventType
	{
		FileSystemEvent = 0,
		ErrorEvent = 1,
		RenameEvent = 2,
	}

	[Token(Token = "0x400074C")]
	private static object lockobj; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400073B")]
	private bool inited; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400073C")]
	private bool start_requested; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x400073D")]
	private bool enableRaisingEvents; //Field offset: 0x2A
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400073E")]
	private string filter; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400073F")]
	private bool includeSubdirectories; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000740")]
	private int internalBufferSize; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000741")]
	private NotifyFilters notifyFilter; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000742")]
	private string path; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000743")]
	private string fullpath; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000744")]
	private ISynchronizeInvoke synchronizingObject; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000745")]
	private WaitForChangedResult lastData; //Field offset: 0x60
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000746")]
	private bool waiting; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000747")]
	private SearchPattern2 pattern; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000748")]
	private bool disposed; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000749")]
	private string mangledFilter; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400074A")]
	private IFileWatcher watcher; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400074B")]
	private object watcher_handle; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400074D")]
	private FileSystemEventHandler Changed; //Field offset: 0xB0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400074E")]
	private FileSystemEventHandler Created; //Field offset: 0xB8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400074F")]
	private FileSystemEventHandler Deleted; //Field offset: 0xC0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000750")]
	private ErrorEventHandler Error; //Field offset: 0xC8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000751")]
	private RenamedEventHandler Renamed; //Field offset: 0xD0

	[IODescription("Occurs when a file/directory change matches the filter")]
	[Token(Token = "0x14000001")]
	public event FileSystemEventHandler Changed
	{
		[Address(RVA = "0x17BA3A0", Offset = "0x17B95A0", Length = "0xA2")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000C45")]
		 add { } //Length: 162
		[Address(RVA = "0x17BA630", Offset = "0x17B9830", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000C46")]
		 remove { } //Length: 162
	}

	[DefaultValue(False)]
	[IODescription("Flag to indicate if this instance is active")]
	[Token(Token = "0x17000260")]
	public bool EnableRaisingEvents
	{
		[Address(RVA = "0x17BA6E0", Offset = "0x17B98E0", Length = "0xAD")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FileSystemWatcher), Member = "Stop", ReturnType = typeof(void))]
		[Calls(Type = typeof(FileSystemWatcher), Member = "Start", ReturnType = typeof(void))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000C35")]
		 set { } //Length: 173
	}

	[DefaultValue("*.*")]
	[IODescription("File name filter pattern")]
	[SettingsBindable(True)]
	[Token(Token = "0x17000261")]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string Filter
	{
		[Address(RVA = "0x17BA790", Offset = "0x17B9990", Length = "0x155")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000C36")]
		 set { } //Length: 341
	}

	[Token(Token = "0x1700025F")]
	internal string FullPath
	{
		[Address(RVA = "0x17BA450", Offset = "0x17B9650", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Environment), Member = "get_CurrentDirectory", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000C34")]
		internal get { } //Length: 190
	}

	[DefaultValue(False)]
	[IODescription("Flag to indicate we want to watch subdirectories")]
	[Token(Token = "0x17000262")]
	public bool IncludeSubdirectories
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C37")]
		 get { } //Length: 5
		[Address(RVA = "0x17BA8F0", Offset = "0x17B9AF0", Length = "0x37")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FileSystemWatcher), Member = "Stop", ReturnType = typeof(void))]
		[Calls(Type = typeof(FileSystemWatcher), Member = "Start", ReturnType = typeof(void))]
		[Token(Token = "0x6000C38")]
		 set { } //Length: 55
	}

	[Token(Token = "0x1700025D")]
	internal string MangledFilter
	{
		[Address(RVA = "0x17BA510", Offset = "0x17B9710", Length = "0x6A")]
		[CalledBy(Type = typeof(DefaultWatcher), Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystemWatcher), Member = "get_Pattern", ReturnType = typeof(SearchPattern2))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000C32")]
		internal get { } //Length: 106
	}

	[DefaultValue(19)]
	[IODescription("Flag to indicate which change event we want to monitor")]
	[Token(Token = "0x17000263")]
	public NotifyFilters NotifyFilter
	{
		[Address(RVA = "0x17BA930", Offset = "0x17B9B30", Length = "0x33")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FileSystemWatcher), Member = "Stop", ReturnType = typeof(void))]
		[Calls(Type = typeof(FileSystemWatcher), Member = "Start", ReturnType = typeof(void))]
		[Token(Token = "0x6000C39")]
		 set { } //Length: 51
	}

	[Token(Token = "0x1700025E")]
	internal SearchPattern2 Pattern
	{
		[Address(RVA = "0x17BA580", Offset = "0x17B9780", Length = "0xAE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FileSystemWatcher), Member = "get_MangledFilter", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SearchPattern2), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000C33")]
		internal get { } //Length: 174
	}

	[Browsable(False)]
	[Token(Token = "0x17000264")]
	public virtual ISite Site
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C3A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700025C")]
	internal bool Waiting
	{
		[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C30")]
		internal get { } //Length: 8
		[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C31")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x17B9F70", Offset = "0x17B9170", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C47")]
	private static FileSystemWatcher() { }

	[Address(RVA = "0x17BA040", Offset = "0x17B9240", Length = "0x294")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileSystemWatcher), Member = "InitWatcher", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000C2E")]
	public FileSystemWatcher(string path, string filter) { }

	[Address(RVA = "0x17BA2E0", Offset = "0x17B94E0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileSystemWatcher), Member = "InitWatcher", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C2C")]
	public FileSystemWatcher() { }

	[Address(RVA = "0x17B9FF0", Offset = "0x17B91F0", Length = "0x4B")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000C2D")]
	public FileSystemWatcher(string path) { }

	[Address(RVA = "0x17BA3A0", Offset = "0x17B95A0", Length = "0xA2")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000C45")]
	public void add_Changed(FileSystemEventHandler value) { }

	[Address(RVA = "0x17B90C0", Offset = "0x17B82C0", Length = "0x478")]
	[CalledBy(Type = typeof(DefaultWatcher), Member = "DispatchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemWatcher), typeof(FileAction), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenamedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WatcherChangeTypes), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(FileSystemWatcher), Member = "RaiseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(EventArgs), typeof(EventType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000C42")]
	internal void DispatchEvents(FileAction act, string filename, ref RenamedEventArgs renamed) { }

	[Address(RVA = "0x17B9540", Offset = "0x17B8740", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C3B")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x17B9660", Offset = "0x17B8860", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C3C")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x17BA450", Offset = "0x17B9650", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Environment), Member = "get_CurrentDirectory", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C34")]
	internal string get_FullPath() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C37")]
	public bool get_IncludeSubdirectories() { }

	[Address(RVA = "0x17BA510", Offset = "0x17B9710", Length = "0x6A")]
	[CalledBy(Type = typeof(DefaultWatcher), Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "get_Pattern", ReturnType = typeof(SearchPattern2))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000C32")]
	internal string get_MangledFilter() { }

	[Address(RVA = "0x17BA580", Offset = "0x17B9780", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FileSystemWatcher), Member = "get_MangledFilter", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SearchPattern2), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C33")]
	internal SearchPattern2 get_Pattern() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C3A")]
	public virtual ISite get_Site() { }

	[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C30")]
	internal bool get_Waiting() { }

	[Address(RVA = "0x17B96E0", Offset = "0x17B88E0", Length = "0x2F0")]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000C2F")]
	private void InitWatcher() { }

	[Address(RVA = "0x17B99E0", Offset = "0x17B8BE0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemWatcher), Member = "RaiseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(EventArgs), typeof(EventType)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C3E")]
	protected void OnChanged(FileSystemEventArgs e) { }

	[Address(RVA = "0x17B9A10", Offset = "0x17B8C10", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemWatcher), Member = "RaiseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(EventArgs), typeof(EventType)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C3F")]
	protected void OnCreated(FileSystemEventArgs e) { }

	[Address(RVA = "0x17B9A40", Offset = "0x17B8C40", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemWatcher), Member = "RaiseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(EventArgs), typeof(EventType)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C40")]
	protected void OnDeleted(FileSystemEventArgs e) { }

	[Address(RVA = "0x17B9A70", Offset = "0x17B8C70", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemWatcher), Member = "RaiseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(EventArgs), typeof(EventType)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C41")]
	protected void OnRenamed(RenamedEventArgs e) { }

	[Address(RVA = "0x17B9AA0", Offset = "0x17B8CA0", Length = "0x3EB")]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "DispatchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileAction), typeof(string), typeof(RenamedEventArgs&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass70_0), Member = "<DispatchEvents>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass70_0), Member = "<DispatchEvents>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass70_0), Member = "<DispatchEvents>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass70_1), Member = "<DispatchEvents>b__3", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "OnChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "OnCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "OnDeleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "OnRenamed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenamedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000C3D")]
	private void RaiseEvent(Delegate ev, EventArgs arg, EventType evtype) { }

	[Address(RVA = "0x17BA630", Offset = "0x17B9830", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000C46")]
	public void remove_Changed(FileSystemEventHandler value) { }

	[Address(RVA = "0x17BA6E0", Offset = "0x17B98E0", Length = "0xAD")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemWatcher), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemWatcher), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000C35")]
	public void set_EnableRaisingEvents(bool value) { }

	[Address(RVA = "0x17BA790", Offset = "0x17B9990", Length = "0x155")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C36")]
	public void set_Filter(string value) { }

	[Address(RVA = "0x17BA8F0", Offset = "0x17B9AF0", Length = "0x37")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemWatcher), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemWatcher), Member = "Start", ReturnType = typeof(void))]
	[Token(Token = "0x6000C38")]
	public void set_IncludeSubdirectories(bool value) { }

	[Address(RVA = "0x17BA930", Offset = "0x17B9B30", Length = "0x33")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemWatcher), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemWatcher), Member = "Start", ReturnType = typeof(void))]
	[Token(Token = "0x6000C39")]
	public void set_NotifyFilter(NotifyFilters value) { }

	[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C31")]
	internal void set_Waiting(bool value) { }

	[Address(RVA = "0x17B9E90", Offset = "0x17B9090", Length = "0x64")]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "set_EnableRaisingEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "set_IncludeSubdirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "set_NotifyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyFilters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Token(Token = "0x6000C43")]
	private void Start() { }

	[Address(RVA = "0x17B9F00", Offset = "0x17B9100", Length = "0x67")]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "set_EnableRaisingEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "set_IncludeSubdirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "set_NotifyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyFilters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Token(Token = "0x6000C44")]
	private void Stop() { }

}

