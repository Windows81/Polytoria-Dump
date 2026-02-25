namespace RLD;

[Token(Token = "0x20000A1")]
public class BoxGizmoSettings3D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000249")]
	private float _xSnapStep; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400024A")]
	private float _ySnapStep; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400024B")]
	private float _zSnapStep; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400024C")]
	private float _dragSensitivity; //Field offset: 0x34

	[Token(Token = "0x170001D6")]
	public float DragSensitivity
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E1")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001D3")]
	public float XSnapStep
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005DE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001D4")]
	public float YSnapStep
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005DF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001D5")]
	public float ZSnapStep
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E0")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x4FA620", Offset = "0x4F9820", Length = "0x23")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateBoxGizmo", ReturnType = typeof(BoxGizmo))]
	[CalledBy(Type = typeof(BoxGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60005E6")]
	public BoxGizmoSettings3D() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E1")]
	public float get_DragSensitivity() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005DE")]
	public float get_XSnapStep() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005DF")]
	public float get_YSnapStep() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E0")]
	public float get_ZSnapStep() { }

	[Address(RVA = "0x4FA5A0", Offset = "0x4F97A0", Length = "0x14")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E5")]
	public void SetDragSensitivity(float sensitivity) { }

	[Address(RVA = "0x4FA5C0", Offset = "0x4F97C0", Length = "0x14")]
	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E2")]
	public void SetXSnapStep(float snapStep) { }

	[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E3")]
	public void SetYSnapStep(float snapStep) { }

	[Address(RVA = "0x4FA600", Offset = "0x4F9800", Length = "0x14")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E4")]
	public void SetZSnapStep(float snapStep) { }

}

