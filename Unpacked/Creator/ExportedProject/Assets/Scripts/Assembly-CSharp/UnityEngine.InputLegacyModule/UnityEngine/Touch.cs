namespace UnityEngine;

[NativeHeader("Runtime/Input/InputBindings.h")]
[Token(Token = "0x2000005")]
public struct Touch
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000F")]
	private int m_FingerId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000010")]
	private Vector2 m_Position; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000011")]
	private Vector2 m_RawPosition; //Field offset: 0xC
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000012")]
	private Vector2 m_PositionDelta; //Field offset: 0x14
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000013")]
	private float m_TimeDelta; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000014")]
	private int m_TapCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000015")]
	private TouchPhase m_Phase; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000016")]
	private TouchType m_Type; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000017")]
	private float m_Pressure; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000018")]
	private float m_maximumPossiblePressure; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000019")]
	private float m_Radius; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400001A")]
	private float m_RadiusVariance; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400001B")]
	private float m_AltitudeAngle; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400001C")]
	private float m_AzimuthAngle; //Field offset: 0x40

	[Token(Token = "0x1700000B")]
	public float altitudeAngle
	{
		[Address(RVA = "0x1875550", Offset = "0x1874750", Length = "0x8")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000C")]
	public float azimuthAngle
	{
		[Address(RVA = "0x19DC110", Offset = "0x19DB310", Length = "0x8")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000004")]
	public Vector2 deltaPosition
	{
		[Address(RVA = "0xB1EEB0", Offset = "0xB1E0B0", Length = "0x13")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000006")]
		 get { } //Length: 19
		[Address(RVA = "0x19D8BF0", Offset = "0x19D7DF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000007")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000005")]
	public float deltaTime
	{
		[Address(RVA = "0x2C0B00", Offset = "0x2BFD00", Length = "0x8")]
		[CallerCount(Count = 66)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000008")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000001")]
	public int fingerId
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000001")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000009")]
	public float maximumPossiblePressure
	{
		[Address(RVA = "0x19DC120", Offset = "0x19DB320", Length = "0x8")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000007")]
	public TouchPhase phase
	{
		[Address(RVA = "0x19DC130", Offset = "0x19DB330", Length = "0x6")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(int), "UnityEngine.EventModifiers", typeof(int)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<ProcessTouchEvents>b__31_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), "System.ValueTuple`3<Touch, Int32, Nullable`1<Int32>>"}, ReturnType = "UnityEngine.UIElements.EventBase")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "MakeTouchEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(int), "UnityEngine.EventModifiers", typeof(int)}, ReturnType = "UnityEngine.UIElements.EventBase")]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasButtonPressedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasButtonReleasedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasMoved", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(Boolean&), typeof(Boolean&)}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 18)]
		[Token(Token = "0x600000A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000002")]
	public Vector2 position
	{
		[Address(RVA = "0x19DC140", Offset = "0x19DB340", Length = "0x13")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000002")]
		 get { } //Length: 19
		[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000003")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000008")]
	public float pressure
	{
		[Address(RVA = "0x19DC160", Offset = "0x19DB360", Length = "0x8")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000D")]
	public float radius
	{
		[Address(RVA = "0x19DC170", Offset = "0x19DB370", Length = "0x8")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000010")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000E")]
	public float radiusVariance
	{
		[Address(RVA = "0x18756A0", Offset = "0x18748A0", Length = "0x8")]
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000011")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000003")]
	public Vector2 rawPosition
	{
		[Address(RVA = "0x19DC180", Offset = "0x19DB380", Length = "0x13")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000004")]
		 get { } //Length: 19
		[Address(RVA = "0x19DC1A0", Offset = "0x19DB3A0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000005")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000006")]
	public int tapCount
	{
		[Address(RVA = "0xFE9830", Offset = "0xFE8A30", Length = "0x6")]
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000009")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700000A")]
	public TouchType type
	{
		[Address(RVA = "0xFE9850", Offset = "0xFE8A50", Length = "0x96C")]
		[CallerCount(Count = 33)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "System.Threading.ThreadLocal`1+IdManager", Member = "GetId", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_method_get_class")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600000D")]
		 get { } //Length: 2412
	}

	[Address(RVA = "0x1875550", Offset = "0x1874750", Length = "0x8")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000E")]
	public float get_altitudeAngle() { }

	[Address(RVA = "0x19DC110", Offset = "0x19DB310", Length = "0x8")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	public float get_azimuthAngle() { }

	[Address(RVA = "0xB1EEB0", Offset = "0xB1E0B0", Length = "0x13")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public Vector2 get_deltaPosition() { }

	[Address(RVA = "0x2C0B00", Offset = "0x2BFD00", Length = "0x8")]
	[CallerCount(Count = 66)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public float get_deltaTime() { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000001")]
	public int get_fingerId() { }

	[Address(RVA = "0x19DC120", Offset = "0x19DB320", Length = "0x8")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000C")]
	public float get_maximumPossiblePressure() { }

	[Address(RVA = "0x19DC130", Offset = "0x19DB330", Length = "0x6")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(int), "UnityEngine.EventModifiers", typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<ProcessTouchEvents>b__31_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), "System.ValueTuple`3<Touch, Int32, Nullable`1<Int32>>"}, ReturnType = "UnityEngine.UIElements.EventBase")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "MakeTouchEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(int), "UnityEngine.EventModifiers", typeof(int)}, ReturnType = "UnityEngine.UIElements.EventBase")]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasButtonPressedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasButtonReleasedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasMoved", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(Boolean&), typeof(Boolean&)}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 18)]
	[Token(Token = "0x600000A")]
	public TouchPhase get_phase() { }

	[Address(RVA = "0x19DC140", Offset = "0x19DB340", Length = "0x13")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000002")]
	public Vector2 get_position() { }

	[Address(RVA = "0x19DC160", Offset = "0x19DB360", Length = "0x8")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	public float get_pressure() { }

	[Address(RVA = "0x19DC170", Offset = "0x19DB370", Length = "0x8")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000010")]
	public float get_radius() { }

	[Address(RVA = "0x18756A0", Offset = "0x18748A0", Length = "0x8")]
	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000011")]
	public float get_radiusVariance() { }

	[Address(RVA = "0x19DC180", Offset = "0x19DB380", Length = "0x13")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000004")]
	public Vector2 get_rawPosition() { }

	[Address(RVA = "0xFE9830", Offset = "0xFE8A30", Length = "0x6")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public int get_tapCount() { }

	[Address(RVA = "0xFE9850", Offset = "0xFE8A50", Length = "0x96C")]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
	[Calls(Type = "System.Threading.ThreadLocal`1+IdManager", Member = "GetId", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_method_get_class")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	public TouchType get_type() { }

	[Address(RVA = "0x19D8BF0", Offset = "0x19D7DF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	public void set_deltaPosition(Vector2 value) { }

	[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public void set_position(Vector2 value) { }

	[Address(RVA = "0x19DC1A0", Offset = "0x19DB3A0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public void set_rawPosition(Vector2 value) { }

}

