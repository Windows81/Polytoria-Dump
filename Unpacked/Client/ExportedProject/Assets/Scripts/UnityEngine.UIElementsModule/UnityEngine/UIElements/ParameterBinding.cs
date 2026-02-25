namespace UnityEngine.UIElements;

[Token(Token = "0x2000247")]
internal struct ParameterBinding
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40008D7")]
	private int m_Index; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40008D8")]
	private string m_Name; //Field offset: 0x8

	[Token(Token = "0x170002D5")]
	public int index
	{
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA2")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170002D6")]
	public string name
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA3")]
		 get { } //Length: 5
		[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA4")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA3")]
	public string get_name() { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA2")]
	public void set_index(int value) { }

	[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA4")]
	public void set_name(string value) { }

}

