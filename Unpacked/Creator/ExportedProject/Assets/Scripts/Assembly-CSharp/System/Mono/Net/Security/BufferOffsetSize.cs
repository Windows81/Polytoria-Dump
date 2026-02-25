namespace Mono.Net.Security;

[Token(Token = "0x2000046")]
internal class BufferOffsetSize
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000099")]
	public Byte[] Buffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400009A")]
	public int Offset; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400009B")]
	public int Size; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009C")]
	public int TotalBytes; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400009D")]
	public bool Complete; //Field offset: 0x24

	[Token(Token = "0x17000018")]
	public int EndOffset
	{
		[Address(RVA = "0x15EDF20", Offset = "0x15ED120", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000AB")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000019")]
	public int Remaining
	{
		[Address(RVA = "0x15EDF30", Offset = "0x15ED130", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000AC")]
		 get { } //Length: 32
	}

	[Address(RVA = "0x15EDDC0", Offset = "0x15ECFC0", Length = "0x152")]
	[CalledBy(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(bool), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000AD")]
	public BufferOffsetSize(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x15EDF20", Offset = "0x15ED120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000AB")]
	public int get_EndOffset() { }

	[Address(RVA = "0x15EDF30", Offset = "0x15ED130", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000AC")]
	public int get_Remaining() { }

	[Address(RVA = "0x15EDD40", Offset = "0x15ECF40", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60000AE")]
	public virtual string ToString() { }

}

