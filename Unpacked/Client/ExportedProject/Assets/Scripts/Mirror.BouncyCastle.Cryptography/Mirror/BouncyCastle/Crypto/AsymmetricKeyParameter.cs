namespace Mirror.BouncyCastle.Crypto;

[Token(Token = "0x200010E")]
public abstract class AsymmetricKeyParameter : ICipherParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000236")]
	private readonly bool privateKey; //Field offset: 0x10

	[Token(Token = "0x17000144")]
	public bool IsPrivate
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B10")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11DDC80", Offset = "0x11DCE80", Length = "0x26")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B0F")]
	protected AsymmetricKeyParameter(bool privateKey) { }

	[Address(RVA = "0x11DDBC0", Offset = "0x11DCDC0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B11")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11DDBA0", Offset = "0x11DCDA0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B12")]
	protected bool Equals(AsymmetricKeyParameter other) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B10")]
	public bool get_IsPrivate() { }

	[Address(RVA = "0x11DDC40", Offset = "0x11DCE40", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B13")]
	public virtual int GetHashCode() { }

}

