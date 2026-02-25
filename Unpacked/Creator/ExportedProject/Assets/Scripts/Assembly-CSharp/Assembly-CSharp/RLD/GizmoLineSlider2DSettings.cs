namespace RLD;

[Token(Token = "0x20000A9")]
public class GizmoLineSlider2DSettings
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400027D")]
	private float _lineHoverEps; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x400027E")]
	private float _boxHoverEps; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400027F")]
	private float _offsetSnapStep; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000280")]
	private float _rotationSnapStep; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000281")]
	private GizmoSnapMode _rotationSnapMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000282")]
	private float _scaleSnapStep; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000283")]
	private float _offsetSensitivity; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000284")]
	private float _rotationSensitivity; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000285")]
	private float _scaleSensitivity; //Field offset: 0x30

	[Token(Token = "0x17000200")]
	public float BoxHoverEps
	{
		[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000655")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB10", Offset = "0x4FBD10", Length = "0xF")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000656")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170001FF")]
	public float LineHoverEps
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000653")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB20", Offset = "0x4FBD20", Length = "0xF")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000654")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000205")]
	public float OffsetSensitivity
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600065F")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA5C0", Offset = "0x4F97C0", Length = "0x14")]
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000660")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000201")]
	public float OffsetSnapStep
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000657")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB30", Offset = "0x4FBD30", Length = "0x14")]
		[CalledBy(Type = typeof(MoveGizmoSettings2D), Member = "SetXSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoSettings2D), Member = "SetYSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoSettings2D), Member = "SetMvXSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoSettings2D), Member = "SetMvYSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoSettings2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Token(Token = "0x6000658")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000206")]
	public float RotationSensitivity
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000661")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000662")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000203")]
	public GizmoSnapMode RotationSnapMode
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600065B")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600065C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000202")]
	public float RotationSnapStep
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000659")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB50", Offset = "0x4FBD50", Length = "0x14")]
		[CallerCount(Count = 27)]
		[DeduplicatedMethod]
		[Token(Token = "0x600065A")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000207")]
	public float ScaleSensitivity
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000663")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA600", Offset = "0x4F9800", Length = "0x14")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000664")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000204")]
	public float ScaleSnapStep
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600065D")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB70", Offset = "0x4FBD70", Length = "0x14")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600065E")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x4FCAB0", Offset = "0x4FBCB0", Length = "0x3F")]
	[CalledBy(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoSettings2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoSettings2D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000665")]
	public GizmoLineSlider2DSettings() { }

	[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000655")]
	public float get_BoxHoverEps() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000653")]
	public float get_LineHoverEps() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600065F")]
	public float get_OffsetSensitivity() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000657")]
	public float get_OffsetSnapStep() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000661")]
	public float get_RotationSensitivity() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600065B")]
	public GizmoSnapMode get_RotationSnapMode() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000659")]
	public float get_RotationSnapStep() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000663")]
	public float get_ScaleSensitivity() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600065D")]
	public float get_ScaleSnapStep() { }

	[Address(RVA = "0x4FCB10", Offset = "0x4FBD10", Length = "0xF")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000656")]
	public void set_BoxHoverEps(float value) { }

	[Address(RVA = "0x4FCB20", Offset = "0x4FBD20", Length = "0xF")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000654")]
	public void set_LineHoverEps(float value) { }

	[Address(RVA = "0x4FA5C0", Offset = "0x4F97C0", Length = "0x14")]
	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000660")]
	public void set_OffsetSensitivity(float value) { }

	[Address(RVA = "0x4FCB30", Offset = "0x4FBD30", Length = "0x14")]
	[CalledBy(Type = typeof(MoveGizmoSettings2D), Member = "SetXSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoSettings2D), Member = "SetYSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoSettings2D), Member = "SetMvXSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoSettings2D), Member = "SetMvYSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoSettings2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Token(Token = "0x6000658")]
	public void set_OffsetSnapStep(float value) { }

	[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000662")]
	public void set_RotationSensitivity(float value) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600065C")]
	public void set_RotationSnapMode(GizmoSnapMode value) { }

	[Address(RVA = "0x4FCB50", Offset = "0x4FBD50", Length = "0x14")]
	[CallerCount(Count = 27)]
	[DeduplicatedMethod]
	[Token(Token = "0x600065A")]
	public void set_RotationSnapStep(float value) { }

	[Address(RVA = "0x4FA600", Offset = "0x4F9800", Length = "0x14")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000664")]
	public void set_ScaleSensitivity(float value) { }

	[Address(RVA = "0x4FCB70", Offset = "0x4FBD70", Length = "0x14")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600065E")]
	public void set_ScaleSnapStep(float value) { }

}

