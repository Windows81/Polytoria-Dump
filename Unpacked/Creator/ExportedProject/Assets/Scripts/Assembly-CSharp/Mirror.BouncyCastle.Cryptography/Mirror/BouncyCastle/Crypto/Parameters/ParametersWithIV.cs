namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000143")]
public class ParametersWithIV : ICipherParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400028F")]
	private readonly ICipherParameters m_parameters; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000290")]
	private readonly Byte[] m_iv; //Field offset: 0x18

	[Token(Token = "0x17000174")]
	public ICipherParameters Parameters
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C2A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2A")]
	public ICipherParameters get_Parameters() { }

	[Address(RVA = "0x11F0B10", Offset = "0x11EFD10", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C29")]
	public Byte[] GetIV() { }

}

