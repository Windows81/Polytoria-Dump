namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000120")]
public class AeadParameters : ICipherParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000242")]
	private readonly Byte[] associatedText; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000243")]
	private readonly Byte[] nonce; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000244")]
	private readonly KeyParameter key; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000245")]
	private readonly int macSize; //Field offset: 0x28

	[Token(Token = "0x17000147")]
	public override KeyParameter Key
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B68")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000148")]
	public override int MacSize
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B69")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x11D9D50", Offset = "0x11D8F50", Length = "0xBE")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "CompleteExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", "System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B66")]
	public AeadParameters(KeyParameter key, int macSize, Byte[] nonce) { }

	[Address(RVA = "0x11D9C90", Offset = "0x11D8E90", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B67")]
	public AeadParameters(KeyParameter key, int macSize, Byte[] nonce, Byte[] associatedText) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B68")]
	public override KeyParameter get_Key() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B69")]
	public override int get_MacSize() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6A")]
	public override Byte[] GetAssociatedText() { }

	[Address(RVA = "0x11D9C10", Offset = "0x11D8E10", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B6B")]
	public override Byte[] GetNonce() { }

}

