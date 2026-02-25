namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
[Token(Token = "0x2000092")]
public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent, IPointerClickHandler
{
	[Token(Token = "0x2000094")]
	private class PointerEvent : IPointerEvent
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000298")]
		private int <pointerId>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000299")]
		private string <pointerType>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400029A")]
		private bool <isPrimary>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400029B")]
		private int <button>k__BackingField; //Field offset: 0x24
		[CompilerGenerated]
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400029C")]
		private int <pressedButtons>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400029D")]
		private Vector3 <position>k__BackingField; //Field offset: 0x2C
		[CompilerGenerated]
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400029E")]
		private Vector3 <localPosition>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400029F")]
		private Vector3 <deltaPosition>k__BackingField; //Field offset: 0x44
		[CompilerGenerated]
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40002A0")]
		private float <deltaTime>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40002A1")]
		private int <clickCount>k__BackingField; //Field offset: 0x54
		[CompilerGenerated]
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40002A2")]
		private float <pressure>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x40002A3")]
		private float <tangentialPressure>k__BackingField; //Field offset: 0x5C
		[CompilerGenerated]
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40002A4")]
		private float <altitudeAngle>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x40002A5")]
		private float <azimuthAngle>k__BackingField; //Field offset: 0x64
		[CompilerGenerated]
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40002A6")]
		private float <twist>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40002A7")]
		private Vector2 <tilt>k__BackingField; //Field offset: 0x6C
		[CompilerGenerated]
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x40002A8")]
		private PenStatus <penStatus>k__BackingField; //Field offset: 0x74
		[CompilerGenerated]
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40002A9")]
		private Vector2 <radius>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40002AA")]
		private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40002AB")]
		private EventModifiers <modifiers>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		[FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x40002AC")]
		private Vector3 <screenPosition>k__BackingField; //Field offset: 0x8C
		[CompilerGenerated]
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40002AD")]
		private Vector3 <screenDelta>k__BackingField; //Field offset: 0x98
		[CompilerGenerated]
		[FieldOffset(Offset = "0xA4")]
		[Token(Token = "0x40002AE")]
		private Ray <worldRay>k__BackingField; //Field offset: 0xA4
		[CompilerGenerated]
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x40002AF")]
		private UIDocument <document>k__BackingField; //Field offset: 0xC0
		[CompilerGenerated]
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40002B0")]
		private VisualElement <elementTarget>k__BackingField; //Field offset: 0xC8
		[CompilerGenerated]
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x40002B1")]
		private VisualElement <elementUnderPointer>k__BackingField; //Field offset: 0xD0

		[Token(Token = "0x17000187")]
		public override bool actionKey
		{
			[Address(RVA = "0x1CEB1C0", Offset = "0x1CEA3C0", Length = "0x86")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x60005E5")]
			 get { } //Length: 134
		}

		[Token(Token = "0x1700017B")]
		public private override float altitudeAngle
		{
			[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005D1")]
			 get { } //Length: 6
			[Address(RVA = "0x18184E0", Offset = "0x18176E0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005D2")]
			private set { } //Length: 6
		}

		[Token(Token = "0x17000186")]
		public override bool altKey
		{
			[Address(RVA = "0x1CEB250", Offset = "0x1CEA450", Length = "0xB")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x60005E4")]
			 get { } //Length: 11
		}

		[Token(Token = "0x1700017C")]
		public private override float azimuthAngle
		{
			[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005D3")]
			 get { } //Length: 6
			[Address(RVA = "0x1CEB330", Offset = "0x1CEA530", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60005D4")]
			private set { } //Length: 6
		}

		[Token(Token = "0x17000172")]
		public private override int button
		{
			[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005BF")]
			 get { } //Length: 4
			[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005C0")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000178")]
		public private override int clickCount
		{
			[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
			[CallerCount(Count = 7)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005CB")]
			 get { } //Length: 4
			[Address(RVA = "0x1818510", Offset = "0x1817710", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005CC")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000185")]
		public override bool commandKey
		{
			[Address(RVA = "0x1CEB260", Offset = "0x1CEA460", Length = "0xB")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x60005E3")]
			 get { } //Length: 11
		}

		[Token(Token = "0x17000184")]
		public override bool ctrlKey
		{
			[Address(RVA = "0x1CEB270", Offset = "0x1CEA470", Length = "0xB")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x60005E2")]
			 get { } //Length: 11
		}

		[Token(Token = "0x17000176")]
		public private override Vector3 deltaPosition
		{
			[Address(RVA = "0x3B87C0", Offset = "0x3B79C0", Length = "0x13")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005C7")]
			 get { } //Length: 19
			[Address(RVA = "0x3B8850", Offset = "0x3B7A50", Length = "0x10")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005C8")]
			private set { } //Length: 16
		}

		[Token(Token = "0x17000177")]
		public private override float deltaTime
		{
			[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005C9")]
			 get { } //Length: 6
			[Address(RVA = "0x1A793B0", Offset = "0x1A785B0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005CA")]
			private set { } //Length: 6
		}

		[Token(Token = "0x1700018B")]
		public private UIDocument document
		{
			[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005EC")]
			 get { } //Length: 8
			[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005ED")]
			private set { } //Length: 19
		}

		[Token(Token = "0x1700018C")]
		public private VisualElement elementTarget
		{
			[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005EE")]
			 get { } //Length: 8
			[Address(RVA = "0x2DD450", Offset = "0x2DC650", Length = "0x13")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005EF")]
			private set { } //Length: 19
		}

		[Token(Token = "0x1700018D")]
		public private VisualElement elementUnderPointer
		{
			[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005F0")]
			 get { } //Length: 8
			[Address(RVA = "0x2DD470", Offset = "0x2DC670", Length = "0x13")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005F1")]
			private set { } //Length: 19
		}

		[Token(Token = "0x17000171")]
		public private override bool isPrimary
		{
			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005BD")]
			 get { } //Length: 5
			[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005BE")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000175")]
		public private override Vector3 localPosition
		{
			[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005C5")]
			 get { } //Length: 19
			[Address(RVA = "0x3B8880", Offset = "0x3B7A80", Length = "0x10")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005C6")]
			private set { } //Length: 16
		}

		[Token(Token = "0x17000182")]
		public private override EventModifiers modifiers
		{
			[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005DF")]
			 get { } //Length: 7
			[Address(RVA = "0xE0C2B0", Offset = "0xE0B4B0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005E0")]
			private set { } //Length: 7
		}

		[Token(Token = "0x1700017F")]
		public private override PenStatus penStatus
		{
			[Address(RVA = "0x16BC4E0", Offset = "0x16BB6E0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005D9")]
			 get { } //Length: 4
			[Address(RVA = "0x16BC6C0", Offset = "0x16BB8C0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005DA")]
			private set { } //Length: 4
		}

		[Token(Token = "0x1700016F")]
		public private override int pointerId
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005B9")]
			 get { } //Length: 4
			[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005BA")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000170")]
		public private override string pointerType
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005BB")]
			 get { } //Length: 5
			[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005BC")]
			private set { } //Length: 13
		}

		[Token(Token = "0x17000174")]
		public private override Vector3 position
		{
			[Address(RVA = "0x573970", Offset = "0x572B70", Length = "0x13")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005C3")]
			 get { } //Length: 19
			[Address(RVA = "0x1818500", Offset = "0x1817700", Length = "0x10")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005C4")]
			private set { } //Length: 16
		}

		[Token(Token = "0x17000173")]
		public private override int pressedButtons
		{
			[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005C1")]
			 get { } //Length: 4
			[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
			[CallerCount(Count = 6)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005C2")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000179")]
		public private override float pressure
		{
			[Address(RVA = "0x1BC5790", Offset = "0x1BC4990", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005CD")]
			 get { } //Length: 6
			[Address(RVA = "0x1BC57A0", Offset = "0x1BC49A0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005CE")]
			private set { } //Length: 6
		}

		[Token(Token = "0x17000180")]
		public private override Vector2 radius
		{
			[Address(RVA = "0x1CEB2A0", Offset = "0x1CEA4A0", Length = "0x13")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60005DB")]
			 get { } //Length: 19
			[Address(RVA = "0x17DA190", Offset = "0x17D9390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005DC")]
			private set { } //Length: 5
		}

		[Token(Token = "0x17000181")]
		public private override Vector2 radiusVariance
		{
			[Address(RVA = "0x1CEB280", Offset = "0x1CEA480", Length = "0x19")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60005DD")]
			 get { } //Length: 25
			[Address(RVA = "0x1CEB340", Offset = "0x1CEA540", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60005DE")]
			private set { } //Length: 8
		}

		[Token(Token = "0x17000189")]
		public private Vector3 screenDelta
		{
			[Address(RVA = "0x1CEB2C0", Offset = "0x1CEA4C0", Length = "0x19")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60005E8")]
			 get { } //Length: 25
			[Address(RVA = "0x1CEB350", Offset = "0x1CEA550", Length = "0x16")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60005E9")]
			private set { } //Length: 22
		}

		[Token(Token = "0x17000188")]
		public private Vector3 screenPosition
		{
			[Address(RVA = "0x1CEB2E0", Offset = "0x1CEA4E0", Length = "0x19")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60005E6")]
			 get { } //Length: 25
			[Address(RVA = "0x1CEB370", Offset = "0x1CEA570", Length = "0x16")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60005E7")]
			private set { } //Length: 22
		}

		[Token(Token = "0x17000183")]
		public override bool shiftKey
		{
			[Address(RVA = "0x1CEB300", Offset = "0x1CEA500", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60005E1")]
			 get { } //Length: 10
		}

		[Token(Token = "0x1700017A")]
		public private override float tangentialPressure
		{
			[Address(RVA = "0x58DEC0", Offset = "0x58D0C0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005CF")]
			 get { } //Length: 6
			[Address(RVA = "0x1818520", Offset = "0x1817720", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005D0")]
			private set { } //Length: 6
		}

		[Token(Token = "0x1700017E")]
		public private override Vector2 tilt
		{
			[Address(RVA = "0xE0C270", Offset = "0xE0B470", Length = "0x13")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005D7")]
			 get { } //Length: 19
			[Address(RVA = "0xE0C400", Offset = "0xE0B600", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005D8")]
			private set { } //Length: 5
		}

		[Token(Token = "0x1700017D")]
		public private override float twist
		{
			[Address(RVA = "0x96AC20", Offset = "0x969E20", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005D5")]
			 get { } //Length: 6
			[Address(RVA = "0x96AED0", Offset = "0x96A0D0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60005D6")]
			private set { } //Length: 6
		}

		[Token(Token = "0x1700018A")]
		public private Ray worldRay
		{
			[Address(RVA = "0x1CEB310", Offset = "0x1CEA510", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60005EA")]
			 get { } //Length: 27
			[Address(RVA = "0x1CEB390", Offset = "0x1CEA590", Length = "0x18")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60005EB")]
			private set { } //Length: 24
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F5")]
		public PointerEvent() { }

		[Address(RVA = "0x1CEB1A0", Offset = "0x1CEA3A0", Length = "0x11")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005F6")]
		internal static bool <Read>g__InRange|114_0(int i, int start, int count) { }

		[Address(RVA = "0x1CEA4C0", Offset = "0x1CE96C0", Length = "0x3F1")]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "TransformRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Ray)}, ReturnType = typeof(Ray))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "ScreenToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector3&), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "GetPointerDeltaPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60005F3")]
		public bool ComputeTarget(BaseRuntimePanel panel) { }

		[Address(RVA = "0x1CEB1C0", Offset = "0x1CEA3C0", Length = "0x86")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005E5")]
		public override bool get_actionKey() { }

		[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D1")]
		public override float get_altitudeAngle() { }

		[Address(RVA = "0x1CEB250", Offset = "0x1CEA450", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005E4")]
		public override bool get_altKey() { }

		[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D3")]
		public override float get_azimuthAngle() { }

		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BF")]
		public override int get_button() { }

		[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005CB")]
		public override int get_clickCount() { }

		[Address(RVA = "0x1CEB260", Offset = "0x1CEA460", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005E3")]
		public override bool get_commandKey() { }

		[Address(RVA = "0x1CEB270", Offset = "0x1CEA470", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005E2")]
		public override bool get_ctrlKey() { }

		[Address(RVA = "0x3B87C0", Offset = "0x3B79C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C7")]
		public override Vector3 get_deltaPosition() { }

		[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C9")]
		public override float get_deltaTime() { }

		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005EC")]
		public UIDocument get_document() { }

		[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005EE")]
		public VisualElement get_elementTarget() { }

		[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F0")]
		public VisualElement get_elementUnderPointer() { }

		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BD")]
		public override bool get_isPrimary() { }

		[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C5")]
		public override Vector3 get_localPosition() { }

		[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005DF")]
		public override EventModifiers get_modifiers() { }

		[Address(RVA = "0x16BC4E0", Offset = "0x16BB6E0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D9")]
		public override PenStatus get_penStatus() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B9")]
		public override int get_pointerId() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BB")]
		public override string get_pointerType() { }

		[Address(RVA = "0x573970", Offset = "0x572B70", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C3")]
		public override Vector3 get_position() { }

		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C1")]
		public override int get_pressedButtons() { }

		[Address(RVA = "0x1BC5790", Offset = "0x1BC4990", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005CD")]
		public override float get_pressure() { }

		[Address(RVA = "0x1CEB2A0", Offset = "0x1CEA4A0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005DB")]
		public override Vector2 get_radius() { }

		[Address(RVA = "0x1CEB280", Offset = "0x1CEA480", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005DD")]
		public override Vector2 get_radiusVariance() { }

		[Address(RVA = "0x1CEB2C0", Offset = "0x1CEA4C0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005E8")]
		public Vector3 get_screenDelta() { }

		[Address(RVA = "0x1CEB2E0", Offset = "0x1CEA4E0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005E6")]
		public Vector3 get_screenPosition() { }

		[Address(RVA = "0x1CEB300", Offset = "0x1CEA500", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005E1")]
		public override bool get_shiftKey() { }

		[Address(RVA = "0x58DEC0", Offset = "0x58D0C0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005CF")]
		public override float get_tangentialPressure() { }

		[Address(RVA = "0xE0C270", Offset = "0xE0B470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D7")]
		public override Vector2 get_tilt() { }

		[Address(RVA = "0x96AC20", Offset = "0x969E20", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D5")]
		public override float get_twist() { }

		[Address(RVA = "0x1CEB310", Offset = "0x1CEA510", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005EA")]
		public Ray get_worldRay() { }

		[Address(RVA = "0x1CEA8C0", Offset = "0x1CE9AC0", Length = "0x174")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "TransformRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Ray)}, ReturnType = typeof(Ray))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005F4")]
		private Vector3 GetPanelPosition(VisualElement pickedElement, UIDocument document, Ray worldRay) { }

		[Address(RVA = "0x1CEAA40", Offset = "0x1CE9C40", Length = "0x752")]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "PressButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "ReleaseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
		[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "GetPressedButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005F2")]
		public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType) { }

		[Address(RVA = "0x18184E0", Offset = "0x18176E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D2")]
		private void set_altitudeAngle(float value) { }

		[Address(RVA = "0x1CEB330", Offset = "0x1CEA530", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005D4")]
		private void set_azimuthAngle(float value) { }

		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C0")]
		private void set_button(int value) { }

		[Address(RVA = "0x1818510", Offset = "0x1817710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005CC")]
		private void set_clickCount(int value) { }

		[Address(RVA = "0x3B8850", Offset = "0x3B7A50", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C8")]
		private void set_deltaPosition(Vector3 value) { }

		[Address(RVA = "0x1A793B0", Offset = "0x1A785B0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005CA")]
		private void set_deltaTime(float value) { }

		[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005ED")]
		private void set_document(UIDocument value) { }

		[Address(RVA = "0x2DD450", Offset = "0x2DC650", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005EF")]
		private void set_elementTarget(VisualElement value) { }

		[Address(RVA = "0x2DD470", Offset = "0x2DC670", Length = "0x13")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F1")]
		private void set_elementUnderPointer(VisualElement value) { }

		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BE")]
		private void set_isPrimary(bool value) { }

		[Address(RVA = "0x3B8880", Offset = "0x3B7A80", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C6")]
		private void set_localPosition(Vector3 value) { }

		[Address(RVA = "0xE0C2B0", Offset = "0xE0B4B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E0")]
		private void set_modifiers(EventModifiers value) { }

		[Address(RVA = "0x16BC6C0", Offset = "0x16BB8C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005DA")]
		private void set_penStatus(PenStatus value) { }

		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BA")]
		private void set_pointerId(int value) { }

		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BC")]
		private void set_pointerType(string value) { }

		[Address(RVA = "0x1818500", Offset = "0x1817700", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C4")]
		private void set_position(Vector3 value) { }

		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C2")]
		private void set_pressedButtons(int value) { }

		[Address(RVA = "0x1BC57A0", Offset = "0x1BC49A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005CE")]
		private void set_pressure(float value) { }

		[Address(RVA = "0x17DA190", Offset = "0x17D9390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005DC")]
		private void set_radius(Vector2 value) { }

		[Address(RVA = "0x1CEB340", Offset = "0x1CEA540", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005DE")]
		private void set_radiusVariance(Vector2 value) { }

		[Address(RVA = "0x1CEB350", Offset = "0x1CEA550", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005E9")]
		private void set_screenDelta(Vector3 value) { }

		[Address(RVA = "0x1CEB370", Offset = "0x1CEA570", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005E7")]
		private void set_screenPosition(Vector3 value) { }

		[Address(RVA = "0x1818520", Offset = "0x1817720", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D0")]
		private void set_tangentialPressure(float value) { }

		[Address(RVA = "0xE0C400", Offset = "0xE0B600", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D8")]
		private void set_tilt(Vector2 value) { }

		[Address(RVA = "0x96AED0", Offset = "0x96A0D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D6")]
		private void set_twist(float value) { }

		[Address(RVA = "0x1CEB390", Offset = "0x1CEA590", Length = "0x18")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005EB")]
		private void set_worldRay(Ray value) { }

	}

	[Token(Token = "0x2000093")]
	private enum PointerEventType
	{
		Default = 0,
		Down = 1,
		Up = 2,
	}

	[Token(Token = "0x4000293")]
	private static EventModifiers s_Modifiers; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400028D")]
	private BaseRuntimePanel m_Panel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400028E")]
	private readonly PointerEvent m_PointerEvent; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400028F")]
	private readonly List<PointerEventData> m_ContainedPointers; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000290")]
	private float m_LastClickTime; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000291")]
	private bool m_Selecting; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000292")]
	private Event m_Event; //Field offset: 0x40

	[Token(Token = "0x1700016E")]
	private Focusable currentFocusedElement
	{
		[Address(RVA = "0x1CE74B0", Offset = "0x1CE66B0", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000596")]
		private get { } //Length: 63
	}

	[Token(Token = "0x1700016C")]
	private EventSystem eventSystem
	{
		[Address(RVA = "0x1CE74F0", Offset = "0x1CE66F0", Length = "0xCC")]
		[CalledBy(Type = typeof(PointerEvent), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelEventHandler), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "get_isCurrentFocusedPanel", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "GetDeviceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "UnityEngine.UIElements.NavigationDeviceType")]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000594")]
		private get { } //Length: 204
	}

	[Token(Token = "0x1700016D")]
	private bool isCurrentFocusedPanel
	{
		[Address(RVA = "0x1CE75C0", Offset = "0x1CE67C0", Length = "0xCA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000595")]
		private get { } //Length: 202
	}

	[Token(Token = "0x1700016A")]
	public override IPanel panel
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000591")]
		 get { } //Length: 5
		[Address(RVA = "0x1CE76B0", Offset = "0x1CE68B0", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(PanelEventHandler), Member = "UnregisterCallbacks", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(PanelEventHandler), Member = "RegisterCallbacks", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000592")]
		 set { } //Length: 153
	}

	[Token(Token = "0x1700016B")]
	private GameObject selectableGameObject
	{
		[Address(RVA = "0x1CE7690", Offset = "0x1CE6890", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000593")]
		private get { } //Length: 18
	}

	[Address(RVA = "0x1CE73C0", Offset = "0x1CE65C0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60005B8")]
	public PanelEventHandler() { }

	[Address(RVA = "0x1CE74B0", Offset = "0x1CE66B0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000596")]
	private Focusable get_currentFocusedElement() { }

	[Address(RVA = "0x1CE74F0", Offset = "0x1CE66F0", Length = "0xCC")]
	[CalledBy(Type = typeof(PointerEvent), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelEventHandler), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "get_isCurrentFocusedPanel", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "GetDeviceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "UnityEngine.UIElements.NavigationDeviceType")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000594")]
	private EventSystem get_eventSystem() { }

	[Address(RVA = "0x1CE75C0", Offset = "0x1CE67C0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000595")]
	private bool get_isCurrentFocusedPanel() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000591")]
	public override IPanel get_panel() { }

	[Address(RVA = "0x1CE7690", Offset = "0x1CE6890", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000593")]
	private GameObject get_selectableGameObject() { }

	[Address(RVA = "0x1CE4EB0", Offset = "0x1CE40B0", Length = "0xF2")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005B6")]
	private NavigationDeviceType GetDeviceType(BaseEventData eventData) { }

	[Address(RVA = "0x1CE4FB0", Offset = "0x1CE41B0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005AD")]
	private void LateUpdate() { }

	[Address(RVA = "0x1CE4FC0", Offset = "0x1CE41C0", Length = "0x1D3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "GetDeviceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "UnityEngine.UIElements.NavigationDeviceType")]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.NavigationDeviceType", typeof(EventModifiers)}, ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60005A7")]
	public override void OnCancel(BaseEventData eventData) { }

	[Address(RVA = "0x1CE51A0", Offset = "0x1CE43A0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.Panel", Member = "Blur", ReturnType = typeof(void))]
	[Token(Token = "0x600059F")]
	public override void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x1CE51C0", Offset = "0x1CE43C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "UnregisterCallbacks", ReturnType = typeof(void))]
	[Token(Token = "0x6000598")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600059D")]
	private void OnElementBlur(BlurEvent e) { }

	[Address(RVA = "0x1CE51D0", Offset = "0x1CE43D0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600059C")]
	private void OnElementFocus(FocusEvent e) { }

	[Address(RVA = "0x1CE5280", Offset = "0x1CE4480", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "RegisterCallbacks", ReturnType = typeof(void))]
	[Token(Token = "0x6000597")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CE5290", Offset = "0x1CE4490", Length = "0x231")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "GetDeviceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "UnityEngine.UIElements.NavigationDeviceType")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "UnityEngine.UIElements.NavigationDeviceType", typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60005A8")]
	public override void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x1CE54D0", Offset = "0x1CE46D0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelEventHandler), Member = "UnregisterCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PanelEventHandler), Member = "RegisterCallbacks", ReturnType = typeof(void))]
	[Token(Token = "0x600059B")]
	private void OnPanelDestroyed() { }

	[Address(RVA = "0x1CE5530", Offset = "0x1CE4730", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Token(Token = "0x60005A5")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x1CE5550", Offset = "0x1CE4750", Length = "0x2F3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "UpdatePointerEventTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent", typeof(PointerEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "SetElementWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005A2")]
	public override void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x1CE5850", Offset = "0x1CE4A50", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "PointerEntersPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60005A4")]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x1CE5960", Offset = "0x1CE4B60", Length = "0x357")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "SetElementWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "UpdatePointerEventTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent", typeof(PointerEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "PointerLeavesPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005A3")]
	public override void OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x1CE5CC0", Offset = "0x1CE4EC0", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = typeof(PanelEventHandler), Member = "UpdatePointerEventTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent", typeof(PointerEvent)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005A0")]
	public override void OnPointerMove(PointerEventData eventData) { }

	[Address(RVA = "0x1CE5E20", Offset = "0x1CE5020", Length = "0x1D0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = typeof(PanelEventHandler), Member = "UpdatePointerEventTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent", typeof(PointerEvent)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "SetElementWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005A1")]
	public override void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x1CE6000", Offset = "0x1CE5200", Length = "0x224")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WheelEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(IPointerEvent)}, ReturnType = typeof(WheelEvent))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60005A9")]
	public override void OnScroll(PointerEventData eventData) { }

	[Address(RVA = "0x1CE6230", Offset = "0x1CE5430", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.Panel", Member = "Focus", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600059E")]
	public override void OnSelect(BaseEventData eventData) { }

	[Address(RVA = "0x1CE62A0", Offset = "0x1CE54A0", Length = "0x1D3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "GetDeviceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "UnityEngine.UIElements.NavigationDeviceType")]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.NavigationDeviceType", typeof(EventModifiers)}, ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60005A6")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x1CE6480", Offset = "0x1CE5680", Length = "0x1A9")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_shift", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.KeyboardEventExtensions", Member = "ShouldSendNavigationMoveEventRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessKeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "PopEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelEventHandler), Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Token(Token = "0x60005AE")]
	private void ProcessImguiEvents(Focusable target) { }

	[Address(RVA = "0x1CE6630", Offset = "0x1CE5830", Length = "0x81")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(PanelEventHandler), Member = "SendKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "SendKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005AF")]
	private void ProcessKeyboardEvent(Event e, Focusable target) { }

	[Address(RVA = "0x1CE66C0", Offset = "0x1CE58C0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.KeyboardEventExtensions", Member = "ShouldSendNavigationMoveEventRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_shift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelEventHandler), Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005B0")]
	private void ProcessTabEvent(Event e, Focusable target) { }

	[Address(RVA = "0x1CE6730", Offset = "0x1CE5930", Length = "0x111")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PointerEvent), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelEventHandler), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEvent), Member = "ComputeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Token(Token = "0x60005B4")]
	private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType = 0) { }

	[Address(RVA = "0x1CE6850", Offset = "0x1CE5A50", Length = "0x1A1")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPanelDestroyed", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000599")]
	private void RegisterCallbacks() { }

	[Address(RVA = "0x1CE6A00", Offset = "0x1CE5C00", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005AA")]
	private void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	[Address(RVA = "0x1CE6A70", Offset = "0x1CE5C70", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005AB")]
	private void SendEvent(EventBase e, Event sourceEvent) { }

	[Address(RVA = "0x1CE6AA0", Offset = "0x1CE5CA0", Length = "0x156")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessKeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EventBase))]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60005B3")]
	private void SendKeyDownEvent(Event e, Focusable target) { }

	[Address(RVA = "0x1CE6C00", Offset = "0x1CE5E00", Length = "0x156")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessKeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EventBase))]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60005B2")]
	private void SendKeyUpEvent(Event e, Focusable target) { }

	[Address(RVA = "0x1CE6D60", Offset = "0x1CE5F60", Length = "0x135")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60005B1")]
	private void SendTabEvent(Event e, Direction direction, Focusable target) { }

	[Address(RVA = "0x1CE76B0", Offset = "0x1CE68B0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelEventHandler), Member = "UnregisterCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PanelEventHandler), Member = "RegisterCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000592")]
	public override void set_panel(IPanel value) { }

	[Address(RVA = "0x1CE6EA0", Offset = "0x1CE60A0", Length = "0x1A1")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPanelDestroyed", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "remove_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600059A")]
	private void UnregisterCallbacks() { }

	[Address(RVA = "0x1CE7280", Offset = "0x1CE6480", Length = "0x13B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60005AC")]
	public void Update() { }

	[Address(RVA = "0x71CF50", Offset = "0x71C150", Length = "0x79")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005B5")]
	private void UpdatePointerEventTarget(TPointerEvent e, PointerEvent eventData) { }

	[Address(RVA = "0x1CE7050", Offset = "0x1CE6250", Length = "0x222")]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "CommitElementUnderPointers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60005B7")]
	private void UpdateWorldSpacePointers() { }

}

