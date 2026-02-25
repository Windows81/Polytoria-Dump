namespace RLD;

[Token(Token = "0x200002C")]
public struct GizmoDragInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A7")]
	private bool _isDragged; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000A8")]
	private int _handleId; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000A9")]
	private Vector3 _dragBeginPoint; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000AA")]
	private GizmoDragChannel _dragChannel; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000AB")]
	private GizmoDimension _handleDimension; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000AC")]
	private Vector3 _totalOffset; //Field offset: 0x1C
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000AD")]
	private Quaternion _totalRotation; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000AE")]
	private Vector3 _totalScale; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000AF")]
	private Vector3 _relativeOffset; //Field offset: 0x44
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000B0")]
	private Quaternion _relativeRotation; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000B1")]
	private Vector3 _relativeScale; //Field offset: 0x60

	[Token(Token = "0x17000054")]
	public Vector3 DragBeginPoint
	{
		[Address(RVA = "0x3B8780", Offset = "0x3B7980", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000163")]
		 get { } //Length: 19
		[Address(RVA = "0x3B8820", Offset = "0x3B7A20", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000164")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000055")]
	public GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000165")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000166")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000056")]
	public GizmoDimension HandleDimension
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000167")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000168")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000053")]
	public int HandleId
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000161")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000162")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000052")]
	public bool IsDragged
	{
		[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015F")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8840", Offset = "0x3B7A40", Length = "0x3")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000160")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700005A")]
	public Vector3 RelativeOffset
	{
		[Address(RVA = "0x3B87C0", Offset = "0x3B79C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016F")]
		 get { } //Length: 19
		[Address(RVA = "0x3B8850", Offset = "0x3B7A50", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000170")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700005B")]
	public Quaternion RelativeRotation
	{
		[Address(RVA = "0x3B2160", Offset = "0x3B1360", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000171")]
		 get { } //Length: 11
		[Address(RVA = "0x3B21F0", Offset = "0x3B13F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000172")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700005C")]
	public Vector3 RelativeScale
	{
		[Address(RVA = "0x2E7220", Offset = "0x2E6420", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000173")]
		 get { } //Length: 19
		[Address(RVA = "0x2F0C40", Offset = "0x2EFE40", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000174")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000057")]
	public Vector3 TotalOffset
	{
		[Address(RVA = "0x3B87E0", Offset = "0x3B79E0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000169")]
		 get { } //Length: 19
		[Address(RVA = "0x3B8860", Offset = "0x3B7A60", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016A")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000058")]
	public Quaternion TotalRotation
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016B")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000059")]
	public Vector3 TotalScale
	{
		[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016D")]
		 get { } //Length: 19
		[Address(RVA = "0x3B8880", Offset = "0x3B7A80", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016E")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x3B8780", Offset = "0x3B7980", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000163")]
	public Vector3 get_DragBeginPoint() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000165")]
	public GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000167")]
	public GizmoDimension get_HandleDimension() { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000161")]
	public int get_HandleId() { }

	[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015F")]
	public bool get_IsDragged() { }

	[Address(RVA = "0x3B87C0", Offset = "0x3B79C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016F")]
	public Vector3 get_RelativeOffset() { }

	[Address(RVA = "0x3B2160", Offset = "0x3B1360", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000171")]
	public Quaternion get_RelativeRotation() { }

	[Address(RVA = "0x2E7220", Offset = "0x2E6420", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000173")]
	public Vector3 get_RelativeScale() { }

	[Address(RVA = "0x3B87E0", Offset = "0x3B79E0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000169")]
	public Vector3 get_TotalOffset() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016B")]
	public Quaternion get_TotalRotation() { }

	[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016D")]
	public Vector3 get_TotalScale() { }

	[Address(RVA = "0x3B8660", Offset = "0x3B7860", Length = "0x112")]
	[CalledBy(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gizmo), Member = "EndDragSession", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000175")]
	public void Reset() { }

	[Address(RVA = "0x3B8820", Offset = "0x3B7A20", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000164")]
	public void set_DragBeginPoint(Vector3 value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000166")]
	public void set_DragChannel(GizmoDragChannel value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000168")]
	public void set_HandleDimension(GizmoDimension value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000162")]
	public void set_HandleId(int value) { }

	[Address(RVA = "0x3B8840", Offset = "0x3B7A40", Length = "0x3")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000160")]
	public void set_IsDragged(bool value) { }

	[Address(RVA = "0x3B8850", Offset = "0x3B7A50", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000170")]
	public void set_RelativeOffset(Vector3 value) { }

	[Address(RVA = "0x3B21F0", Offset = "0x3B13F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000172")]
	public void set_RelativeRotation(Quaternion value) { }

	[Address(RVA = "0x2F0C40", Offset = "0x2EFE40", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000174")]
	public void set_RelativeScale(Vector3 value) { }

	[Address(RVA = "0x3B8860", Offset = "0x3B7A60", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016A")]
	public void set_TotalOffset(Vector3 value) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016C")]
	public void set_TotalRotation(Quaternion value) { }

	[Address(RVA = "0x3B8880", Offset = "0x3B7A80", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016E")]
	public void set_TotalScale(Vector3 value) { }

}

