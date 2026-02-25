namespace RLD;

[Token(Token = "0x200008F")]
public class GizmoScaleGuideLookAndFeel
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40001F9")]
	private bool _useZoomFactor; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40001FA")]
	private Color _xAxisColor; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40001FB")]
	private Color _yAxisColor; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40001FC")]
	private Color _zAxisColor; //Field offset: 0x34
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x40001FD")]
	private float _axisLength; //Field offset: 0x44

	[Token(Token = "0x1700018B")]
	public float AxisLength
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000522")]
		 get { } //Length: 6
		[Address(RVA = "0x3D0CB0", Offset = "0x3CFEB0", Length = "0xF")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000523")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000187")]
	public bool UseZoomFactor
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600051A")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600051B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000188")]
	public Color XAxisColor
	{
		[Address(RVA = "0x3BAA40", Offset = "0x3B9C40", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600051C")]
		 get { } //Length: 11
		[Address(RVA = "0x3BAA50", Offset = "0x3B9C50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600051D")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000189")]
	public Color YAxisColor
	{
		[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600051E")]
		 get { } //Length: 11
		[Address(RVA = "0x3D0CC0", Offset = "0x3CFEC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600051F")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700018A")]
	public Color ZAxisColor
	{
		[Address(RVA = "0x2DD270", Offset = "0x2DC470", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000520")]
		 get { } //Length: 11
		[Address(RVA = "0x2DD5E0", Offset = "0x2DC7E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000521")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x3D0C50", Offset = "0x3CFE50", Length = "0x5C")]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_YAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_ZAxisColor", ReturnType = typeof(Color))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000524")]
	public GizmoScaleGuideLookAndFeel() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000522")]
	public float get_AxisLength() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051A")]
	public bool get_UseZoomFactor() { }

	[Address(RVA = "0x3BAA40", Offset = "0x3B9C40", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051C")]
	public Color get_XAxisColor() { }

	[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051E")]
	public Color get_YAxisColor() { }

	[Address(RVA = "0x2DD270", Offset = "0x2DC470", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000520")]
	public Color get_ZAxisColor() { }

	[Address(RVA = "0x3D0CB0", Offset = "0x3CFEB0", Length = "0xF")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000523")]
	public void set_AxisLength(float value) { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051B")]
	public void set_UseZoomFactor(bool value) { }

	[Address(RVA = "0x3BAA50", Offset = "0x3B9C50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051D")]
	public void set_XAxisColor(Color value) { }

	[Address(RVA = "0x3D0CC0", Offset = "0x3CFEC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051F")]
	public void set_YAxisColor(Color value) { }

	[Address(RVA = "0x2DD5E0", Offset = "0x2DC7E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000521")]
	public void set_ZAxisColor(Color value) { }

}

