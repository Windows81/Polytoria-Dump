namespace System.Runtime.Remoting;

[Token(Token = "0x2000338")]
internal class EnvoyInfo : IEnvoyInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DC1")]
	private IMessageSink envoySinks; //Field offset: 0x10

	[Token(Token = "0x170002BB")]
	public override IMessageSink EnvoySinks
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019C8")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019C7")]
	public EnvoyInfo(IMessageSink sinks) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019C8")]
	public override IMessageSink get_EnvoySinks() { }

}

