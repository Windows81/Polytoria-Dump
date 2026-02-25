namespace SimpleFileBrowser;

[Token(Token = "0x2000017")]
public struct FileSystemEntry
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B4")]
	public readonly string Path; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000B5")]
	public readonly string Name; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B6")]
	public readonly string Extension; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B7")]
	public readonly FileAttributes Attributes; //Field offset: 0x18

	[Token(Token = "0x17000021")]
	public bool IsDirectory
	{
		[Address(RVA = "0x154EC60", Offset = "0x154DE60", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000C6")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x154EBF0", Offset = "0x154DDF0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000C7")]
	public FileSystemEntry(string path, string name, string extension, bool isDirectory) { }

	[Address(RVA = "0x154EB50", Offset = "0x154DD50", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_Attributes", ReturnType = typeof(FileAttributes))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000C8")]
	public FileSystemEntry(FileSystemInfo fileInfo, string extension) { }

	[Address(RVA = "0x154EC60", Offset = "0x154DE60", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000C6")]
	public bool get_IsDirectory() { }

}

