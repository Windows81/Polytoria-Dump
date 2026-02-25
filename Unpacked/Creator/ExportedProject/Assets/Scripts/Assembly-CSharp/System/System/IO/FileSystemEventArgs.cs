namespace System.IO;

[Token(Token = "0x20001DC")]
public class FileSystemEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000718")]
	private readonly WatcherChangeTypes _changeType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000719")]
	private readonly string _name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400071A")]
	private readonly string _fullPath; //Field offset: 0x20

	[Token(Token = "0x17000256")]
	public string FullPath
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C0D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17B8FF0", Offset = "0x17B81F0", Length = "0xCD")]
	[CalledBy(Type = typeof(RenamedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WatcherChangeTypes), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.FileSystemWatcher+<>c__DisplayClass70_0", Member = "<DispatchEvents>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.FileSystemWatcher+<>c__DisplayClass70_0", Member = "<DispatchEvents>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.FileSystemWatcher+<>c__DisplayClass70_0", Member = "<DispatchEvents>b__2", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileSystemEventArgs), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C0B")]
	public FileSystemEventArgs(WatcherChangeTypes changeType, string directory, string name) { }

	[Address(RVA = "0x17B8EB0", Offset = "0x17B80B0", Length = "0x13E")]
	[CalledBy(Type = typeof(FileSystemEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WatcherChangeTypes), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenamedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WatcherChangeTypes), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C0C")]
	internal static string Combine(string directoryPath, string name) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C0D")]
	public string get_FullPath() { }

}

