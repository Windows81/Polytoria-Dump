namespace UnityEngine.InputForUI;

[Token(Token = "0x2000024")]
internal class InputManagerProvider : IEventProviderImpl
{
	[Token(Token = "0x2000025")]
	private struct ButtonEventsIterator : IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CA")]
		private uint _mask; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000CB")]
		private int _bit; //Field offset: 0x4

		[Token(Token = "0x17000033")]
		public bool Current
		{
			[Address(RVA = "0x19CFA10", Offset = "0x19CEC10", Length = "0x9")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60000AC")]
			 get { } //Length: 9
		}

		[Token(Token = "0x17000034")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19CF9E0", Offset = "0x19CEBE0", Length = "0x26")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Token(Token = "0x60000AF")]
			private get { } //Length: 38
		}

		[Address(RVA = "0x19CF930", Offset = "0x19CEB30", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000B0")]
		public static ButtonEventsIterator FromState(bool previous, bool down, bool up, bool current) { }

		[Address(RVA = "0x19CFA10", Offset = "0x19CEC10", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000AC")]
		public bool get_Current() { }

		[Address(RVA = "0x19CF990", Offset = "0x19CEB90", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000AD")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19CF9D0", Offset = "0x19CEBD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000AE")]
		public override void Reset() { }

		[Address(RVA = "0x19CF9E0", Offset = "0x19CEBE0", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Token(Token = "0x60000AF")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x2000026")]
	internal struct Configuration
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CC")]
		public string HorizontalAxis; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000CD")]
		public string VerticalAxis; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CE")]
		public string SubmitButton; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000CF")]
		public string CancelButton; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000D0")]
		public string NavigateNextButton; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000D1")]
		public string NavigatePreviousButton; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000D2")]
		public float InputActionsPerSecond; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40000D3")]
		public float RepeatDelay; //Field offset: 0x34

		[Address(RVA = "0x19CFD20", Offset = "0x19CEF20", Length = "0x149")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000B1")]
		public static Configuration GetDefaultConfiguration() { }

	}

	[Token(Token = "0x2000027")]
	public interface IInput
	{

		[Token(Token = "0x17000035")]
		public string compositionString
		{
			[Token(Token = "0x60000B2")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000039")]
		public Vector3 mousePosition
		{
			[Token(Token = "0x60000BE")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000038")]
		public bool mousePresent
		{
			[Token(Token = "0x60000BA")]
			 get { } //Length: 0
		}

		[Token(Token = "0x1700003A")]
		public Vector2 mouseScrollDelta
		{
			[Token(Token = "0x60000BF")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000037")]
		public int touchCount
		{
			[Token(Token = "0x60000B8")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000036")]
		public bool touchSupported
		{
			[Token(Token = "0x60000B7")]
			 get { } //Length: 0
		}

		[Token(Token = "0x60000B2")]
		public string get_compositionString() { }

		[Token(Token = "0x60000BE")]
		public Vector3 get_mousePosition() { }

		[Token(Token = "0x60000BA")]
		public bool get_mousePresent() { }

		[Token(Token = "0x60000BF")]
		public Vector2 get_mouseScrollDelta() { }

		[Token(Token = "0x60000B8")]
		public int get_touchCount() { }

		[Token(Token = "0x60000B7")]
		public bool get_touchSupported() { }

		[Token(Token = "0x60000B5")]
		public float GetAxisRaw(string axis) { }

		[Token(Token = "0x60000B4")]
		public bool GetButtonDown(string button) { }

		[Token(Token = "0x60000B3")]
		public bool GetKey(KeyCode keyCode) { }

		[Token(Token = "0x60000B6")]
		public PenData GetLastPenContactEvent() { }

		[Token(Token = "0x60000BB")]
		public bool GetMouseButton(int button) { }

		[Token(Token = "0x60000BC")]
		public bool GetMouseButtonDown(int button) { }

		[Token(Token = "0x60000BD")]
		public bool GetMouseButtonUp(int button) { }

		[Token(Token = "0x60000B9")]
		public Touch GetTouch(int index) { }

	}

	[Token(Token = "0x2000028")]
	private class Input : IInput
	{

		[Token(Token = "0x1700003B")]
		public override string compositionString
		{
			[Address(RVA = "0x19D70C0", Offset = "0x19D62C0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C0")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700003F")]
		public override Vector3 mousePosition
		{
			[Address(RVA = "0x488F60", Offset = "0x488160", Length = "0x2C")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
			[DeduplicatedMethod]
			[Token(Token = "0x60000CC")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700003E")]
		public override bool mousePresent
		{
			[Address(RVA = "0x561CB0", Offset = "0x560EB0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C8")]
			 get { } //Length: 7
		}

		[Token(Token = "0x17000040")]
		public override Vector2 mouseScrollDelta
		{
			[Address(RVA = "0x19D70D0", Offset = "0x19D62D0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
			[DeduplicatedMethod]
			[Token(Token = "0x60000CD")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700003D")]
		public override int touchCount
		{
			[Address(RVA = "0x56CE00", Offset = "0x56C000", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C6")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700003C")]
		public override bool touchSupported
		{
			[Address(RVA = "0x5C4CA0", Offset = "0x5C3EA0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C5")]
			 get { } //Length: 7
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CE")]
		public Input() { }

		[Address(RVA = "0x19D70C0", Offset = "0x19D62C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C0")]
		public override string get_compositionString() { }

		[Address(RVA = "0x488F60", Offset = "0x488160", Length = "0x2C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CC")]
		public override Vector3 get_mousePosition() { }

		[Address(RVA = "0x561CB0", Offset = "0x560EB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C8")]
		public override bool get_mousePresent() { }

		[Address(RVA = "0x19D70D0", Offset = "0x19D62D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CD")]
		public override Vector2 get_mouseScrollDelta() { }

		[Address(RVA = "0x56CE00", Offset = "0x56C000", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C6")]
		public override int get_touchCount() { }

		[Address(RVA = "0x5C4CA0", Offset = "0x5C3EA0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C5")]
		public override bool get_touchSupported() { }

		[Address(RVA = "0x19D7050", Offset = "0x19D6250", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C3")]
		public override float GetAxisRaw(string axis) { }

		[Address(RVA = "0x19D7060", Offset = "0x19D6260", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C2")]
		public override bool GetButtonDown(string button) { }

		[Address(RVA = "0x19D7070", Offset = "0x19D6270", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000C1")]
		public override bool GetKey(KeyCode key) { }

		[Address(RVA = "0x19D7080", Offset = "0x19D6280", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetLastPenContactEvent", ReturnType = typeof(PenData))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C4")]
		public override PenData GetLastPenContactEvent() { }

		[Address(RVA = "0x561CC0", Offset = "0x560EC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C9")]
		public override bool GetMouseButton(int button) { }

		[Address(RVA = "0x561D50", Offset = "0x560F50", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CA")]
		public override bool GetMouseButtonDown(int button) { }

		[Address(RVA = "0x561D60", Offset = "0x560F60", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CB")]
		public override bool GetMouseButtonUp(int button) { }

		[Address(RVA = "0x5C4AE0", Offset = "0x5C3CE0", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C7")]
		public override Touch GetTouch(int index) { }

	}

	[Token(Token = "0x2000029")]
	public interface ITime
	{

		[Token(Token = "0x17000041")]
		public RationalTime timeAsRational
		{
			[Token(Token = "0x60000CF")]
			 get { } //Length: 0
		}

		[Token(Token = "0x60000CF")]
		public RationalTime get_timeAsRational() { }

	}

	[Token(Token = "0x200002A")]
	private class Time : ITime
	{

		[Token(Token = "0x17000042")]
		public override RationalTime timeAsRational
		{
			[Address(RVA = "0x19D8CA0", Offset = "0x19D7EA0", Length = "0x24")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
			[Token(Token = "0x60000D0")]
			 get { } //Length: 36
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D1")]
		public Time() { }

		[Address(RVA = "0x19D8CA0", Offset = "0x19D7EA0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
		[Token(Token = "0x60000D0")]
		public override RationalTime get_timeAsRational() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000BB")]
	private InputEventPartialProvider _inputEventPartialProvider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000BC")]
	private string _compositionString; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000BD")]
	private Configuration _configuration; //Field offset: 0x20
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000BE")]
	private IInput _input; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000BF")]
	private ITime _time; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000C0")]
	private NavigationEventRepeatHelper _navigationEventRepeatHelper; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000C1")]
	private PointerState _mouseState; //Field offset: 0x70
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000C2")]
	private bool _isPenPresent; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x40000C3")]
	private bool _seenAtLeastOnePenPosition; //Field offset: 0x99
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40000C4")]
	private Vector2 _lastSeenPenPositionForDetection; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000C5")]
	private PointerState _penState; //Field offset: 0xA8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000C6")]
	private PenData _lastPenData; //Field offset: 0xD0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40000C7")]
	private Dictionary<Int32, Int32> _touchFingerIdToFingerIndex; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40000C8")]
	private int _touchNextFingerIndex; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40000C9")]
	private PointerState _touchState; //Field offset: 0x108

	[Token(Token = "0x17000032")]
	private EventModifiers _eventModifiers
	{
		[Address(RVA = "0x19D7030", Offset = "0x19D6230", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600008E")]
		private get { } //Length: 26
	}

	[Address(RVA = "0x19D6D30", Offset = "0x19D5F30", Length = "0x2FA")]
	[CalledBy(Type = typeof(EventProvider), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600008F")]
	public InputManagerProvider() { }

	[Address(RVA = "0xE68950", Offset = "0xE67B50", Length = "0xA0")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E8B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A6")]
	internal static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	[Address(RVA = "0x19D37A0", Offset = "0x19D29A0", Length = "0x289")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009C")]
	private void CheckIfIMEChanged(DiscreteTime currentTime) { }

	[Address(RVA = "0x19D3A30", Offset = "0x19D2C30", Length = "0x799")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(InputManagerProvider), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerState), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(PointerState), Member = "OnButtonChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000097")]
	private void CheckMouseEvents(DiscreteTime currentTime, bool muted = false) { }

	[Address(RVA = "0x19D41D0", Offset = "0x19D33D0", Length = "0x3FC")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(InputManagerProvider), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000098")]
	private void CheckMouseScroll(DiscreteTime currentTime) { }

	[Address(RVA = "0x19D45D0", Offset = "0x19D37D0", Length = "0x523")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerState), Member = "OnButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerState), Member = "OnButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000096")]
	private bool CheckPenEvent(DiscreteTime currentTime, in PenData currentPenData) { }

	[Address(RVA = "0x19D4B00", Offset = "0x19D3D00", Length = "0x717")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManagerProvider), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerState), Member = "OnButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerState), Member = "OnButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000093")]
	private bool CheckTouchEvents(DiscreteTime currentTime) { }

	[Address(RVA = "0x19D5220", Offset = "0x19D4420", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180051990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000094")]
	private void DetectPen() { }

	[Address(RVA = "0x19D52E0", Offset = "0x19D44E0", Length = "0x428")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetAxisRawOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetButtonDownOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ValueTuple`2<UnityEngine.Vector2, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputManagerProvider), Member = "GetEventSourceFromPressedKey", ReturnType = typeof(EventSource))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009B")]
	private void DirectionNavigation(DiscreteTime currentTime) { }

	[Address(RVA = "0x19D7030", Offset = "0x19D6230", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600008E")]
	private EventModifiers get__eventModifiers() { }

	[Address(RVA = "0x19D5710", Offset = "0x19D4910", Length = "0xF6")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "NextPreviousNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "SubmitCancelNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009E")]
	private EventSource GetEventSourceFromPressedKey() { }

	[Address(RVA = "0x19D5810", Offset = "0x19D4A10", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InputEventPartialProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerState), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000090")]
	public override void Initialize() { }

	[Address(RVA = "0x19D5960", Offset = "0x19D4B60", Length = "0xE3")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "ReadCurrentNavigationMoveVector", ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector2, System.Boolean>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A1")]
	private float InputManagerGetAxisRawOrDefault(string axisName) { }

	[Address(RVA = "0x19D5A50", Offset = "0x19D4C50", Length = "0xE9")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "NextPreviousNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "SubmitCancelNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "ReadCurrentNavigationMoveVector", ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector2, System.Boolean>))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000A2")]
	private bool InputManagerGetButtonDownOrDefault(string axisName) { }

	[Address(RVA = "0x19D5B40", Offset = "0x19D4D40", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009F")]
	private bool InputManagerJoystickWasPressed() { }

	[Address(RVA = "0x19D5BC0", Offset = "0x19D4DC0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A0")]
	private bool InputManagerKeyboardWasPressed() { }

	[Address(RVA = "0x19D5C40", Offset = "0x19D4E40", Length = "0x28A")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000A8")]
	private static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int targetDisplay) { }

	[Address(RVA = "0x19D5ED0", Offset = "0x19D50D0", Length = "0x1AC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000A9")]
	private static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<Int32>& targetDisplay) { }

	[Address(RVA = "0x19D6080", Offset = "0x19D5280", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetButtonDownOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManagerProvider), Member = "GetEventSourceFromPressedKey", ReturnType = typeof(EventSource))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000099")]
	private void NextPreviousNavigation(DiscreteTime currentTime) { }

	[Address(RVA = "0x19D6240", Offset = "0x19D5440", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009D")]
	public override void OnFocusChanged(bool focus) { }

	[Address(RVA = "0x19D6280", Offset = "0x19D5480", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000095")]
	private static Button PenStatusToButton(PenStatus status) { }

	[Address(RVA = "0x19D62A0", Offset = "0x19D54A0", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetAxisRawOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetButtonDownOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ValueTuple`2<UnityEngine.Vector2, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000A3")]
	private ValueTuple<Vector2, Boolean> ReadCurrentNavigationMoveVector() { }

	[Address(RVA = "0x19D63E0", Offset = "0x19D55E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AB")]
	private static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }

	[Address(RVA = "0x19D6400", Offset = "0x19D5600", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000AA")]
	private static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000091")]
	public override void Shutdown() { }

	[Address(RVA = "0x19D64E0", Offset = "0x19D56E0", Length = "0x2A9")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetButtonDownOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManagerProvider), Member = "GetEventSourceFromPressedKey", ReturnType = typeof(EventSource))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009A")]
	private void SubmitCancelNavigation(DiscreteTime currentTime) { }

	[Address(RVA = "0xE6C0A0", Offset = "0xE6B2A0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A7")]
	internal static float TiltToAltitude(Vector2 tilt) { }

	[Address(RVA = "0xE6C0F0", Offset = "0xE6B2F0", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288D90")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A5")]
	internal static float TiltToAzimuth(Vector2 tilt) { }

	[Address(RVA = "0x19D6790", Offset = "0x19D5990", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A4")]
	private IMECompositionEvent ToIMECompositionEvent(DiscreteTime currentTime, string compositionString) { }

	[Address(RVA = "0x19D6820", Offset = "0x19D5A20", Length = "0x507")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputManagerProvider), Member = "SubmitCancelNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "CheckIfIMEChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "CheckMouseScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "CheckMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "CheckPenEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(PenData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerState), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InputManagerProvider), Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180051990")]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetButtonDownOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManagerProvider), Member = "GetEventSourceFromPressedKey", ReturnType = typeof(EventSource))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000092")]
	public override void Update() { }

}

