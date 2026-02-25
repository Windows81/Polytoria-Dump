namespace RLD;

[Token(Token = "0x2000159")]
public class ColorRef
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000635")]
	private Color _value; //Field offset: 0x10

	[Token(Token = "0x17000551")]
	public Color Value
	{
		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA3")]
		 get { } //Length: 11
		[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA4")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x53EC20", Offset = "0x53DE20", Length = "0x13")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FA5")]
	public ColorRef() { }

	[Address(RVA = "0x53EBE0", Offset = "0x53DDE0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FA6")]
	public ColorRef(Color color) { }

	[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA3")]
	public Color get_Value() { }

	[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA4")]
	public void set_Value(Color value) { }

}

