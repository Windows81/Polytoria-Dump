namespace UnityEngine.UIElements;

[Token(Token = "0x2000245")]
internal struct FilterParameterDeclaration
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40008D1")]
	private string m_Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40008D2")]
	private FilterParameter m_InterpolationDefaultValue; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008D3")]
	internal FilterParameter defaultValue; //Field offset: 0x20

	[Token(Token = "0x170002D1")]
	public FilterParameter interpolationDefaultValue
	{
		[Address(RVA = "0x1C52DB0", Offset = "0x1C51FB0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000F9A")]
		 set { } //Length: 18
	}

	[Address(RVA = "0x1C52DB0", Offset = "0x1C51FB0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000F9A")]
	public void set_interpolationDefaultValue(FilterParameter value) { }

}

