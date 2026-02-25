namespace System.IO;

[Token(Token = "0x2000620")]
internal struct DisableMediaInsertionPrompt : IDisposable
{
	[Token(Token = "0x40018EC")]
	private static bool useUWPFallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40018EA")]
	private bool _disableSuccess; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40018EB")]
	private uint _oldMode; //Field offset: 0x4

	[Address(RVA = "0x14545C0", Offset = "0x14537C0", Length = "0x79")]
	[CalledBy(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Kernel32), Member = "SetThreadErrorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6002C95")]
	public static DisableMediaInsertionPrompt Create() { }

	[Address(RVA = "0x1454640", Offset = "0x1453840", Length = "0x26")]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Kernel32), Member = "SetThreadErrorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002C96")]
	public override void Dispose() { }

}

