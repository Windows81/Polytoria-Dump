namespace Mirror.SimpleWeb;

[Token(Token = "0x2000024")]
internal sealed class MaskHelper : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000071")]
	private readonly Byte[] maskBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000072")]
	private readonly RNGCryptoServiceProvider random; //Field offset: 0x18

	[Address(RVA = "0x1556CA0", Offset = "0x1555EA0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000094")]
	public MaskHelper() { }

	[Address(RVA = "0x1556C00", Offset = "0x1555E00", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000095")]
	public override void Dispose() { }

	[Address(RVA = "0x1556C20", Offset = "0x1555E20", Length = "0x72")]
	[CalledBy(Type = typeof(SendLoop), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000096")]
	public int WriteMask(Byte[] buffer, int offset) { }

}

