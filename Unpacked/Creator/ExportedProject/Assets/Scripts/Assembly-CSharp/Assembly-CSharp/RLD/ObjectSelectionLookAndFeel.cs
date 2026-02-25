namespace RLD;

[Token(Token = "0x20002A6")]
public class ObjectSelectionLookAndFeel : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000A39")]
	private bool _drawHighlight; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000A3A")]
	private SelectionBoxBorderStyle _selectionBoxBorderStyle; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000A3B")]
	private float _wireCornerLinePercentage; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000A3C")]
	private SelectionBoxRenderMode _selectionBoxRenderMode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000A3D")]
	private Color _selectionBoxBorderColor; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000A3E")]
	private float _selectionBoxInflateAmount; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000A3F")]
	private Color _selectionRectBorderColor; //Field offset: 0x4C
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x4000A40")]
	private Color _selectionRectFillColor; //Field offset: 0x5C

	[Token(Token = "0x17000860")]
	public bool DrawHighlight
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001943")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001944")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000861")]
	public SelectionBoxBorderStyle SelBoxBorderStyle
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001945")]
		 get { } //Length: 4
		[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001946")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000863")]
	public SelectionBoxRenderMode SelBoxRenderMode
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001949")]
		 get { } //Length: 4
		[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600194A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000864")]
	public Color SelectionBoxBorderColor
	{
		[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600194B")]
		 get { } //Length: 11
		[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600194C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000865")]
	public float SelectionBoxInflateAmount
	{
		[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600194D")]
		 get { } //Length: 6
		[Address(RVA = "0x3EAB50", Offset = "0x3E9D50", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600194E")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000866")]
	public Color SelectionRectBorderColor
	{
		[Address(RVA = "0x3B91B0", Offset = "0x3B83B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600194F")]
		 get { } //Length: 11
		[Address(RVA = "0x3EAB60", Offset = "0x3E9D60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001950")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000867")]
	public Color SelectionRectFillColor
	{
		[Address(RVA = "0x3EAB20", Offset = "0x3E9D20", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001951")]
		 get { } //Length: 11
		[Address(RVA = "0x3EAB70", Offset = "0x3E9D70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001952")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000862")]
	public float WireCornerLinePercentage
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001947")]
		 get { } //Length: 6
		[Address(RVA = "0x3EAB80", Offset = "0x3E9D80", Length = "0x26")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001948")]
		 set { } //Length: 38
	}

	[Address(RVA = "0x3EAA80", Offset = "0x3E9C80", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001953")]
	public ObjectSelectionLookAndFeel() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001943")]
	public bool get_DrawHighlight() { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001945")]
	public SelectionBoxBorderStyle get_SelBoxBorderStyle() { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001949")]
	public SelectionBoxRenderMode get_SelBoxRenderMode() { }

	[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600194B")]
	public Color get_SelectionBoxBorderColor() { }

	[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600194D")]
	public float get_SelectionBoxInflateAmount() { }

	[Address(RVA = "0x3B91B0", Offset = "0x3B83B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600194F")]
	public Color get_SelectionRectBorderColor() { }

	[Address(RVA = "0x3EAB20", Offset = "0x3E9D20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001951")]
	public Color get_SelectionRectFillColor() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001947")]
	public float get_WireCornerLinePercentage() { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001944")]
	public void set_DrawHighlight(bool value) { }

	[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001946")]
	public void set_SelBoxBorderStyle(SelectionBoxBorderStyle value) { }

	[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600194A")]
	public void set_SelBoxRenderMode(SelectionBoxRenderMode value) { }

	[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600194C")]
	public void set_SelectionBoxBorderColor(Color value) { }

	[Address(RVA = "0x3EAB50", Offset = "0x3E9D50", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600194E")]
	public void set_SelectionBoxInflateAmount(float value) { }

	[Address(RVA = "0x3EAB60", Offset = "0x3E9D60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001950")]
	public void set_SelectionRectBorderColor(Color value) { }

	[Address(RVA = "0x3EAB70", Offset = "0x3E9D70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001952")]
	public void set_SelectionRectFillColor(Color value) { }

	[Address(RVA = "0x3EAB80", Offset = "0x3E9D80", Length = "0x26")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001948")]
	public void set_WireCornerLinePercentage(float value) { }

}

