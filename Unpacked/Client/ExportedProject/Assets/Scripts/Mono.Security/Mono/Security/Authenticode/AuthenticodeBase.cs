namespace Mono.Security.Authenticode;

[Token(Token = "0x2000053")]
public class AuthenticodeBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000231")]
	private Byte[] fileblock; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000232")]
	private Stream fs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000233")]
	private int blockNo; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000234")]
	private int blockLength; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000235")]
	private int peOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000236")]
	private int dirSecurityOffset; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000237")]
	private int dirSecuritySize; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000238")]
	private int coffSymbolTableOffset; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000239")]
	private bool pe64; //Field offset: 0x38

	[Token(Token = "0x17000083")]
	internal int PEOffset
	{
		[Address(RVA = "0x12C2230", Offset = "0x12C1430", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
		[Token(Token = "0x60001CF")]
		internal get { } //Length: 40
	}

	[Address(RVA = "0x12C21D0", Offset = "0x12C13D0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001CE")]
	public AuthenticodeBase() { }

	[Address(RVA = "0x12C1700", Offset = "0x12C0900", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D2")]
	internal void Close() { }

	[Address(RVA = "0x12C2230", Offset = "0x12C1430", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
	[Token(Token = "0x60001CF")]
	internal int get_PEOffset() { }

	[Address(RVA = "0x12C1750", Offset = "0x12C0950", Length = "0x4E1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashAlgorithm), Member = "TransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60001D6")]
	internal Byte[] GetHash(HashAlgorithm hash) { }

	[Address(RVA = "0x12C1C40", Offset = "0x12C0E40", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001D5")]
	internal Byte[] GetSecurityEntry() { }

	[Address(RVA = "0x12C1D10", Offset = "0x12C0F10", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D0")]
	internal void Open(string filename) { }

	[Address(RVA = "0x12C1DD0", Offset = "0x12C0FD0", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D1")]
	internal void Open(Byte[] rawdata) { }

	[Address(RVA = "0x12C1E80", Offset = "0x12C1080", Length = "0x279")]
	[CalledBy(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitConverterLE), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D4")]
	internal int ProcessFirstBlock() { }

	[Address(RVA = "0x12C2100", Offset = "0x12C1300", Length = "0xD0")]
	[CalledBy(Type = typeof(AuthenticodeBase), Member = "get_PEOffset", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AuthenticodeBase), Member = "GetSecurityEntry", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(AuthenticodeBase), Member = "GetHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 57)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(AuthenticodeBase), Member = "ProcessFirstBlock", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001D3")]
	internal void ReadFirstBlock() { }

}

