namespace RLD;

[Token(Token = "0x200002F")]
public struct GizmoHoverInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B9")]
	private bool _isHovered; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000BA")]
	private int _handleId; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BB")]
	private GizmoDimension _handleDimension; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000BC")]
	private Vector3 _hoverPoint; //Field offset: 0xC

	[Token(Token = "0x1700005F")]
	public GizmoDimension HandleDimension
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017A")]
		 get { } //Length: 4
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700005E")]
	public int HandleId
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000178")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000179")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000060")]
	public Vector3 HoverPoint
	{
		[Address(RVA = "0x3B9440", Offset = "0x3B8640", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017C")]
		 get { } //Length: 19
		[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017D")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700005D")]
	public bool IsHovered
	{
		[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000176")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8840", Offset = "0x3B7A40", Length = "0x3")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000177")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017A")]
	public GizmoDimension get_HandleDimension() { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000178")]
	public int get_HandleId() { }

	[Address(RVA = "0x3B9440", Offset = "0x3B8640", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017C")]
	public Vector3 get_HoverPoint() { }

	[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000176")]
	public bool get_IsHovered() { }

	[Address(RVA = "0x3B93D0", Offset = "0x3B85D0", Length = "0x5C")]
	[CalledBy(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gizmo), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gizmo), Member = "UpdateHandleHoverInfo_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoHoverInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600017E")]
	public void Reset() { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017B")]
	public void set_HandleDimension(GizmoDimension value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000179")]
	public void set_HandleId(int value) { }

	[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017D")]
	public void set_HoverPoint(Vector3 value) { }

	[Address(RVA = "0x3B8840", Offset = "0x3B7A40", Length = "0x3")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000177")]
	public void set_IsHovered(bool value) { }

}

