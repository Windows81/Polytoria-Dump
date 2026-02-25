namespace RLD;

[Token(Token = "0x20000B2")]
public class GizmoPlaneSlider2DSettings
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40002C3")]
	private float _areaHoverEps; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40002C4")]
	private float _borderLineHoverEps; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40002C5")]
	private float _thickBorderPolyHoverEps; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x40002C6")]
	private float _offsetSnapStepRight; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40002C7")]
	private float _offsetSnapStepUp; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40002C8")]
	private float _rotationSnapStep; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40002C9")]
	private GizmoSnapMode _rotationSnapMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40002CA")]
	private float _scaleSnapStepRight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40002CB")]
	private float _scaleSnapStepUp; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40002CC")]
	private float _proportionalScaleSnapStep; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40002CD")]
	private float _offsetSensitivity; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40002CE")]
	private float _rotationSensitivity; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40002CF")]
	private float _scaleSensitivity; //Field offset: 0x40

	[Token(Token = "0x17000235")]
	public float AreaHoverEps
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006D6")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB20", Offset = "0x4FBD20", Length = "0xF")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006D7")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000236")]
	public float BorderLineHoverEps
	{
		[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006D8")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB10", Offset = "0x4FBD10", Length = "0xF")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006D9")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700023F")]
	public float OffsetSensitivity
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006EA")]
		 get { } //Length: 6
		[Address(RVA = "0x5047F0", Offset = "0x5039F0", Length = "0x14")]
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006EB")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000238")]
	public float OffsetSnapStepRight
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006DC")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB50", Offset = "0x4FBD50", Length = "0x14")]
		[CallerCount(Count = 27)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006DD")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000239")]
	public float OffsetSnapStepUp
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006DE")]
		 get { } //Length: 6
		[Address(RVA = "0x500C30", Offset = "0x4FFE30", Length = "0x14")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006DF")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700023E")]
	public float ProportionalScaleSnapStep
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006E8")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA5A0", Offset = "0x4F97A0", Length = "0x14")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006E9")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000240")]
	public float RotationSensitivity
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006EC")]
		 get { } //Length: 6
		[Address(RVA = "0x504810", Offset = "0x503A10", Length = "0x14")]
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006ED")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700023B")]
	public GizmoSnapMode RotationSnapMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006E2")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006E3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700023A")]
	public float RotationSnapStep
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006E0")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB70", Offset = "0x4FBD70", Length = "0x14")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006E1")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000241")]
	public float ScaleSensitivity
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006EE")]
		 get { } //Length: 6
		[Address(RVA = "0x3F09A0", Offset = "0x3EFBA0", Length = "0x14")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006EF")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700023C")]
	public float ScaleSnapStepRight
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006E4")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006E5")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700023D")]
	public float ScaleSnapStepUp
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006E6")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA600", Offset = "0x4F9800", Length = "0x14")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006E7")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000237")]
	public float ThickBorderPolyHoverEps
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006DA")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006DB")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x504790", Offset = "0x503990", Length = "0x5B")]
	[CalledBy(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoSettings2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoSettings2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F0")]
	public GizmoPlaneSlider2DSettings() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006D6")]
	public float get_AreaHoverEps() { }

	[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006D8")]
	public float get_BorderLineHoverEps() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006EA")]
	public float get_OffsetSensitivity() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006DC")]
	public float get_OffsetSnapStepRight() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006DE")]
	public float get_OffsetSnapStepUp() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E8")]
	public float get_ProportionalScaleSnapStep() { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006EC")]
	public float get_RotationSensitivity() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E2")]
	public GizmoSnapMode get_RotationSnapMode() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E0")]
	public float get_RotationSnapStep() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006EE")]
	public float get_ScaleSensitivity() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E4")]
	public float get_ScaleSnapStepRight() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E6")]
	public float get_ScaleSnapStepUp() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006DA")]
	public float get_ThickBorderPolyHoverEps() { }

	[Address(RVA = "0x4FCB20", Offset = "0x4FBD20", Length = "0xF")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006D7")]
	public void set_AreaHoverEps(float value) { }

	[Address(RVA = "0x4FCB10", Offset = "0x4FBD10", Length = "0xF")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006D9")]
	public void set_BorderLineHoverEps(float value) { }

	[Address(RVA = "0x5047F0", Offset = "0x5039F0", Length = "0x14")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006EB")]
	public void set_OffsetSensitivity(float value) { }

	[Address(RVA = "0x4FCB50", Offset = "0x4FBD50", Length = "0x14")]
	[CallerCount(Count = 27)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006DD")]
	public void set_OffsetSnapStepRight(float value) { }

	[Address(RVA = "0x500C30", Offset = "0x4FFE30", Length = "0x14")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006DF")]
	public void set_OffsetSnapStepUp(float value) { }

	[Address(RVA = "0x4FA5A0", Offset = "0x4F97A0", Length = "0x14")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E9")]
	public void set_ProportionalScaleSnapStep(float value) { }

	[Address(RVA = "0x504810", Offset = "0x503A10", Length = "0x14")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006ED")]
	public void set_RotationSensitivity(float value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E3")]
	public void set_RotationSnapMode(GizmoSnapMode value) { }

	[Address(RVA = "0x4FCB70", Offset = "0x4FBD70", Length = "0x14")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E1")]
	public void set_RotationSnapStep(float value) { }

	[Address(RVA = "0x3F09A0", Offset = "0x3EFBA0", Length = "0x14")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006EF")]
	public void set_ScaleSensitivity(float value) { }

	[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E5")]
	public void set_ScaleSnapStepRight(float value) { }

	[Address(RVA = "0x4FA600", Offset = "0x4F9800", Length = "0x14")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E7")]
	public void set_ScaleSnapStepUp(float value) { }

	[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006DB")]
	public void set_ThickBorderPolyHoverEps(float value) { }

}

