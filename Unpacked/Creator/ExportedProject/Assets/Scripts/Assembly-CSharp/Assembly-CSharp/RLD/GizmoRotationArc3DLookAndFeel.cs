namespace RLD;

[Token(Token = "0x20000FC")]
public class GizmoRotationArc3DLookAndFeel
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000417")]
	private bool _useShortestRotation; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000418")]
	private GizmoRotationArcFillFlags _fillFlags; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000419")]
	private Color _color; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400041A")]
	private Color _borderColor; //Field offset: 0x28

	[Token(Token = "0x170002DA")]
	public Color BorderColor
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000924")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000925")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002D9")]
	public Color Color
	{
		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000922")]
		 get { } //Length: 11
		[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000923")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002D8")]
	public GizmoRotationArcFillFlags FillFlags
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000920")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000921")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002D7")]
	public bool UseShortestRotation
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091E")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091F")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x513180", Offset = "0x512380", Length = "0x49")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(RTSystemValues), Member = "get_GuideFillColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_GuideBorderColor", ReturnType = typeof(Color))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000926")]
	public GizmoRotationArc3DLookAndFeel() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000924")]
	public Color get_BorderColor() { }

	[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000922")]
	public Color get_Color() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000920")]
	public GizmoRotationArcFillFlags get_FillFlags() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091E")]
	public bool get_UseShortestRotation() { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000925")]
	public void set_BorderColor(Color value) { }

	[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000923")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000921")]
	public void set_FillFlags(GizmoRotationArcFillFlags value) { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091F")]
	public void set_UseShortestRotation(bool value) { }

}

