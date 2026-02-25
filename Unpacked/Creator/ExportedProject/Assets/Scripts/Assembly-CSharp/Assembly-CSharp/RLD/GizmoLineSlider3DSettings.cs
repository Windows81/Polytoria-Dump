namespace RLD;

[Token(Token = "0x20000C4")]
public class GizmoLineSlider3DSettings
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400030E")]
	private float _lineHoverEps; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x400030F")]
	private float _boxHoverEps; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000310")]
	private float _cylinderHoverEps; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000311")]
	private float _offsetSnapStep; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000312")]
	private float _rotationSnapStep; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000313")]
	private GizmoSnapMode _rotationSnapMode; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000314")]
	private float _scaleSnapStep; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000315")]
	private float _offsetSensitivity; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000316")]
	private float _rotationSensitivity; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000317")]
	private float _scaleSensitivity; //Field offset: 0x34

	[Token(Token = "0x1700026B")]
	public float BoxHoverEps
	{
		[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600078E")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB10", Offset = "0x4FBD10", Length = "0xF")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600078F")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700026C")]
	public float CylinderHoverEps
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000790")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000791")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700026A")]
	public float LineHoverEps
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600078C")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB20", Offset = "0x4FBD20", Length = "0xF")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x600078D")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000271")]
	public float OffsetSensitivity
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600079A")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x600079B")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700026D")]
	public float OffsetSnapStep
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000792")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB50", Offset = "0x4FBD50", Length = "0x14")]
		[CallerCount(Count = 27)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000793")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000272")]
	public float RotationSensitivity
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600079C")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA600", Offset = "0x4F9800", Length = "0x14")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600079D")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700026F")]
	public GizmoSnapMode RotationSnapMode
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000796")]
		 get { } //Length: 4
		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000797")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700026E")]
	public float RotationSnapStep
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000794")]
		 get { } //Length: 6
		[Address(RVA = "0x500C30", Offset = "0x4FFE30", Length = "0x14")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000795")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000273")]
	public float ScaleSensitivity
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600079E")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA5A0", Offset = "0x4F97A0", Length = "0x14")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600079F")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000270")]
	public float ScaleSnapStep
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000798")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA5C0", Offset = "0x4F97C0", Length = "0x14")]
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000799")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x500BE0", Offset = "0x4FFDE0", Length = "0x46")]
	[CalledBy(Type = typeof(MoveGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007A0")]
	public GizmoLineSlider3DSettings() { }

	[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600078E")]
	public float get_BoxHoverEps() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000790")]
	public float get_CylinderHoverEps() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600078C")]
	public float get_LineHoverEps() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600079A")]
	public float get_OffsetSensitivity() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000792")]
	public float get_OffsetSnapStep() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600079C")]
	public float get_RotationSensitivity() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000796")]
	public GizmoSnapMode get_RotationSnapMode() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000794")]
	public float get_RotationSnapStep() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600079E")]
	public float get_ScaleSensitivity() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000798")]
	public float get_ScaleSnapStep() { }

	[Address(RVA = "0x4FCB10", Offset = "0x4FBD10", Length = "0xF")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600078F")]
	public void set_BoxHoverEps(float value) { }

	[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000791")]
	public void set_CylinderHoverEps(float value) { }

	[Address(RVA = "0x4FCB20", Offset = "0x4FBD20", Length = "0xF")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x600078D")]
	public void set_LineHoverEps(float value) { }

	[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x600079B")]
	public void set_OffsetSensitivity(float value) { }

	[Address(RVA = "0x4FCB50", Offset = "0x4FBD50", Length = "0x14")]
	[CallerCount(Count = 27)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000793")]
	public void set_OffsetSnapStep(float value) { }

	[Address(RVA = "0x4FA600", Offset = "0x4F9800", Length = "0x14")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600079D")]
	public void set_RotationSensitivity(float value) { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000797")]
	public void set_RotationSnapMode(GizmoSnapMode value) { }

	[Address(RVA = "0x500C30", Offset = "0x4FFE30", Length = "0x14")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000795")]
	public void set_RotationSnapStep(float value) { }

	[Address(RVA = "0x4FA5A0", Offset = "0x4F97A0", Length = "0x14")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600079F")]
	public void set_ScaleSensitivity(float value) { }

	[Address(RVA = "0x4FA5C0", Offset = "0x4F97C0", Length = "0x14")]
	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000799")]
	public void set_ScaleSnapStep(float value) { }

}

