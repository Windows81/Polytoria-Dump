namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000122")]
public class DHKeyParameters : AsymmetricKeyParameter
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000248")]
	private readonly DHParameters parameters; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000249")]
	private readonly DerObjectIdentifier algorithmOid; //Field offset: 0x20

	[Token(Token = "0x1700014A")]
	public DerObjectIdentifier AlgorithmOid
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B71")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000149")]
	public DHParameters Parameters
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B70")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11DFB30", Offset = "0x11DED30", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B6E")]
	protected DHKeyParameters(bool isPrivate, DHParameters parameters) { }

	[Address(RVA = "0x11DFBE0", Offset = "0x11DEDE0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B6F")]
	protected DHKeyParameters(bool isPrivate, DHParameters parameters, DerObjectIdentifier algorithmOid) { }

	[Address(RVA = "0x11DFA10", Offset = "0x11DEC10", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B72")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11DF9C0", Offset = "0x11DEBC0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B73")]
	protected bool Equals(DHKeyParameters other) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B71")]
	public DerObjectIdentifier get_AlgorithmOid() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B70")]
	public DHParameters get_Parameters() { }

	[Address(RVA = "0x11DFAC0", Offset = "0x11DECC0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B74")]
	public virtual int GetHashCode() { }

}

