namespace System.IO;

[Token(Token = "0x20001DF")]
public class RenamedEventArgs : FileSystemEventArgs
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400071C")]
	private readonly string _oldName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400071D")]
	private readonly string _oldFullPath; //Field offset: 0x30

	[Address(RVA = "0x17CB490", Offset = "0x17CA690", Length = "0x65")]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "DispatchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileAction), typeof(string), typeof(RenamedEventArgs&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileSystemEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WatcherChangeTypes), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileSystemEventArgs), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C13")]
	public RenamedEventArgs(WatcherChangeTypes changeType, string directory, string name, string oldName) { }

}

