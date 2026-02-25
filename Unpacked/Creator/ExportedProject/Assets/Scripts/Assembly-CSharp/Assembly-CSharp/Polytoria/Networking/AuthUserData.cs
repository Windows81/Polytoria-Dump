namespace Polytoria.Networking;

[Token(Token = "0x20002FF")]
public struct AuthUserData
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BA6")]
	private int <ID>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BA7")]
	private string <Username>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BA8")]
	private string <Token>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170008D9")]
	public int ID
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6001BA1")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BA2")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170008DB")]
	public string Token
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6001BA5")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BA6")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170008DA")]
	public string Username
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6001BA3")]
		 get { } //Length: 5
		[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BA4")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x4004F0", Offset = "0x3FF6F0", Length = "0x3C")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BA7")]
	public AuthUserData(int id, string username, string token) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6001BA1")]
	public int get_ID() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6001BA5")]
	public string get_Token() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6001BA3")]
	public string get_Username() { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BA2")]
	public void set_ID(int value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BA6")]
	public void set_Token(string value) { }

	[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BA4")]
	public void set_Username(string value) { }

}

