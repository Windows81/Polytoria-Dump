namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001EE")]
internal abstract class LimitedInputStream : BaseInputStream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400049D")]
	protected readonly Stream _in; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400049E")]
	private int _limit; //Field offset: 0x30

	[Token(Token = "0x17000194")]
	internal override int Limit
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001188")]
		internal get { } //Length: 174
	}

	[Address(RVA = "0x110F090", Offset = "0x110E290", Length = "0x42")]
	[CalledBy(Type = typeof(DefiniteLengthInputStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseInputStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001187")]
	internal LimitedInputStream(Stream inStream, int limit) { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001188")]
	internal override int get_Limit() { }

	[Address(RVA = "0x110EFE0", Offset = "0x110E1E0", Length = "0xA6")]
	[CalledBy(Type = typeof(DefiniteLengthInputStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefiniteLengthInputStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefiniteLengthInputStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefiniteLengthInputStream), Member = "ReadAllIntoByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefiniteLengthInputStream), Member = "ToArray", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IndefiniteLengthInputStream), Member = "CheckEndOfContents", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001189")]
	protected void SetParentEofDetect() { }

}

