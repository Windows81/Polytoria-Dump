namespace Mirror.BouncyCastle.Utilities.Encoders;

[Token(Token = "0x2000013")]
public class HexEncoder
{
	[Token(Token = "0x4000014")]
	private static readonly Char[] CharsLower; //Field offset: 0x0
	[Token(Token = "0x4000015")]
	private static readonly Char[] CharsUpper; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000016")]
	protected readonly Byte[] encodingTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000017")]
	protected readonly Byte[] decodingTable; //Field offset: 0x18

	[Address(RVA = "0x10BC720", Offset = "0x10BB920", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600007A")]
	private static HexEncoder() { }

	[Address(RVA = "0x10BC810", Offset = "0x10BBA10", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HexEncoder), Member = "InitialiseDecodingTable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000076")]
	public HexEncoder() { }

	[Address(RVA = "0x10BBFD0", Offset = "0x10BB1D0", Length = "0x2A3")]
	[CalledBy(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000079")]
	internal Byte[] DecodeStrict(string str, int off, int len) { }

	[Address(RVA = "0x10BC280", Offset = "0x10BB480", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000077")]
	public int Encode(Byte[] inBuf, int inOff, int inLen, Byte[] outBuf, int outOff) { }

	[Address(RVA = "0x10BC390", Offset = "0x10BB590", Length = "0x1E9")]
	[CalledBy(Type = typeof(Hex), Member = "ToHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Hex), Member = "ToHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Hex), Member = "ToHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Hex), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000078")]
	public override int Encode(Byte[] buf, int off, int len, Stream outStream) { }

	[Address(RVA = "0x10BC580", Offset = "0x10BB780", Length = "0x19C")]
	[CalledBy(Type = typeof(Hex), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HexEncoder), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000075")]
	protected void InitialiseDecodingTable() { }

}

