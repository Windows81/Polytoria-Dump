namespace Mirror.Discovery;

[Token(Token = "0x200005D")]
public struct ServerResponse : NetworkMessage
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021B")]
	private IPEndPoint <EndPoint>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400021C")]
	public Uri uri; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400021D")]
	public long serverId; //Field offset: 0x10

	[Token(Token = "0x1700003B")]
	public IPEndPoint EndPoint
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600032A")]
		 get { } //Length: 4
		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600032B")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600032A")]
	public IPEndPoint get_EndPoint() { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600032B")]
	public void set_EndPoint(IPEndPoint value) { }

}

