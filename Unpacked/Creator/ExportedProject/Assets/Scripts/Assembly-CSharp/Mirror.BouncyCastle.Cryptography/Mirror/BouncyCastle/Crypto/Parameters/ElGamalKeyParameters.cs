namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000138")]
public class ElGamalKeyParameters : AsymmetricKeyParameter
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400027C")]
	private readonly ElGamalParameters parameters; //Field offset: 0x18

	[Token(Token = "0x17000167")]
	public ElGamalParameters Parameters
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11E1BD0", Offset = "0x11E0DD0", Length = "0x41")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF9")]
	protected ElGamalKeyParameters(bool isPrivate, ElGamalParameters parameters) { }

	[Address(RVA = "0x11E6EE0", Offset = "0x11E60E0", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BFB")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11DF9C0", Offset = "0x11DEBC0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFC")]
	protected bool Equals(ElGamalKeyParameters other) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFA")]
	public ElGamalParameters get_Parameters() { }

	[Address(RVA = "0x11DFAC0", Offset = "0x11DECC0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFD")]
	public virtual int GetHashCode() { }

}

