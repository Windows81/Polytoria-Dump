namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000127")]
public abstract class DsaKeyParameters : AsymmetricKeyParameter
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000255")]
	private readonly DsaParameters parameters; //Field offset: 0x18

	[Token(Token = "0x17000151")]
	public DsaParameters Parameters
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B92")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11E1BD0", Offset = "0x11E0DD0", Length = "0x41")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B91")]
	protected DsaKeyParameters(bool isPrivate, DsaParameters parameters) { }

	[Address(RVA = "0x11E1B20", Offset = "0x11E0D20", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B93")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11DF9C0", Offset = "0x11DEBC0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B94")]
	protected bool Equals(DsaKeyParameters other) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B92")]
	public DsaParameters get_Parameters() { }

	[Address(RVA = "0x11DFAC0", Offset = "0x11DECC0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B95")]
	public virtual int GetHashCode() { }

}

