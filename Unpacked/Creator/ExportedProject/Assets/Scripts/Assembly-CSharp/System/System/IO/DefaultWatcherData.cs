namespace System.IO;

[Token(Token = "0x20001E2")]
internal class DefaultWatcherData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000723")]
	public FileSystemWatcher FSW; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000724")]
	public string Directory; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000725")]
	public string FileMask; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000726")]
	public bool IncludeSubdirs; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000727")]
	public bool Enabled; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000728")]
	public bool NoWildcards; //Field offset: 0x2A
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000729")]
	public DateTime DisabledTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400072A")]
	public object FilesLock; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400072B")]
	public Dictionary<String, FileData> Files; //Field offset: 0x40

	[Address(RVA = "0x17B4100", Offset = "0x17B3300", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000C1C")]
	public DefaultWatcherData() { }

}

