namespace UnityEngine.InputForUI;

[Token(Token = "0x2000018")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct PointerEvent : IEventProperties
{
	[Flags]
	[Token(Token = "0x200001A")]
	internal enum Button
	{
		None = 0,
		Primary = 1,
		FingerInTouch = 1,
		PenTipInTouch = 1,
		PenEraserInTouch = 2,
		PenBarrelButton = 4,
		MouseLeft = 1,
		MouseRight = 2,
		MouseMiddle = 4,
		MouseForward = 8,
		MouseBack = 16,
	}

	[Token(Token = "0x200001B")]
	internal struct ButtonsState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A1")]
		private uint _state; //Field offset: 0x0

		[Address(RVA = "0x19CFAE0", Offset = "0x19CECE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000064")]
		public bool Get(Button button) { }

		[Address(RVA = "0x1308BB0", Offset = "0x1307DB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000065")]
		public void Reset() { }

		[Address(RVA = "0x19CFB90", Offset = "0x19CED90", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000063")]
		public void Set(Button button, bool pressed) { }

		[Address(RVA = "0x19CFC20", Offset = "0x19CEE20", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000066")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000019")]
	internal enum Type
	{
		PointerMoved = 1,
		Scroll = 2,
		ButtonPressed = 3,
		ButtonReleased = 4,
		State = 5,
		TouchCanceled = 6,
		TrackedCanceled = 6,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000079")]
	public Type type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400007A")]
	public int pointerIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400007B")]
	public Vector2 position; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007C")]
	public Vector2 deltaPosition; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007D")]
	public Vector3 worldPosition; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400007E")]
	public Quaternion worldOrientation; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400007F")]
	public float maxDistance; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000080")]
	public Vector2 scroll; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000081")]
	public int displayIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000082")]
	public Vector2 tilt; //Field offset: 0x44
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000083")]
	public float twist; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000084")]
	public float pressure; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000085")]
	public bool isInverted; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000086")]
	public Button button; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000087")]
	public ButtonsState buttonsState; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000088")]
	public int clickCount; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000089")]
	private DiscreteTime <timestamp>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400008A")]
	private EventSource <eventSource>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400008B")]
	private uint <playerId>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400008C")]
	private EventModifiers <eventModifiers>k__BackingField; //Field offset: 0x78

	[Token(Token = "0x17000029")]
	public float altitude
	{
		[Address(RVA = "0x19D84B0", Offset = "0x19D76B0", Length = "0x4B")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
		[Token(Token = "0x6000059")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000028")]
	public float azimuth
	{
		[Address(RVA = "0x19D8500", Offset = "0x19D7700", Length = "0xD4")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
		[CalledBy(Type = typeof(PointerEvent), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288D90")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000058")]
		 get { } //Length: 212
	}

	[Token(Token = "0x1700002D")]
	public override EventModifiers eventModifiers
	{
		[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600005F")]
		 get { } //Length: 4
		[Address(RVA = "0x504780", Offset = "0x503980", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000060")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002B")]
	public override EventSource eventSource
	{
		[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600005C")]
		 get { } //Length: 4
		[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600005D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000026")]
	public bool isPrimaryPointer
	{
		[Address(RVA = "0x19D85E0", Offset = "0x19D77E0", Length = "0x8")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000056")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700002C")]
	public uint playerId
	{
		[Address(RVA = "0x16BC6C0", Offset = "0x16BB8C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600005E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002A")]
	public override DiscreteTime timestamp
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600005A")]
		 get { } //Length: 5
		[Address(RVA = "0x96AEB0", Offset = "0x96A0B0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600005B")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000027")]
	public Ray worldRay
	{
		[Address(RVA = "0x19D85F0", Offset = "0x19D77F0", Length = "0x19F")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000057")]
		 get { } //Length: 415
	}

	[Address(RVA = "0x19D75D0", Offset = "0x19D67D0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000062")]
	internal static Button ButtonFromButtonIndex(int index) { }

	[Address(RVA = "0x19D84B0", Offset = "0x19D76B0", Length = "0x4B")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[Token(Token = "0x6000059")]
	public float get_altitude() { }

	[Address(RVA = "0x19D8500", Offset = "0x19D7700", Length = "0xD4")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEvent), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288D90")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000058")]
	public float get_azimuth() { }

	[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600005F")]
	public override EventModifiers get_eventModifiers() { }

	[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600005C")]
	public override EventSource get_eventSource() { }

	[Address(RVA = "0x19D85E0", Offset = "0x19D77E0", Length = "0x8")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000056")]
	public bool get_isPrimaryPointer() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600005A")]
	public override DiscreteTime get_timestamp() { }

	[Address(RVA = "0x19D85F0", Offset = "0x19D77F0", Length = "0x19F")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000057")]
	public Ray get_worldRay() { }

	[Address(RVA = "0x504780", Offset = "0x503980", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000060")]
	public void set_eventModifiers(EventModifiers value) { }

	[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600005D")]
	public void set_eventSource(EventSource value) { }

	[Address(RVA = "0x16BC6C0", Offset = "0x16BB8C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600005E")]
	public void set_playerId(uint value) { }

	[Address(RVA = "0x96AEB0", Offset = "0x96A0B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600005B")]
	public void set_timestamp(DiscreteTime value) { }

	[Address(RVA = "0x19D75E0", Offset = "0x19D67E0", Length = "0xEC1")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PointerEvent), Member = "get_azimuth", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000061")]
	public virtual string ToString() { }

}

