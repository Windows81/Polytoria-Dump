namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Pointer (1))]
[Token(Token = "0x200021D")]
public abstract class PointerEventBase : EventBase<T>, IPointerEvent, IPointerEventInternal, IPointerOrMouseEvent
{
	[Token(Token = "0x4000896")]
	private const float k_DefaultButtonPressure = 0.5; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008AE")]
	private IMouseEvent <compatibilityMouseEvent>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008AD")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008AC")]
	private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008AB")]
	private Vector2 <radius>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008AA")]
	private PenStatus <penStatus>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A9")]
	private float <twist>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A8")]
	private float <tangentialPressure>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A7")]
	private float <pressure>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A6")]
	private int <clickCount>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A5")]
	private float <deltaTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A4")]
	private Vector3 <deltaPosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008AF")]
	private int <displayIndex>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A3")]
	private Vector3 <localPosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A1")]
	private int <pressedButtons>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A0")]
	private int <button>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400089F")]
	private bool <isPrimary>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400089E")]
	private string <pointerType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400089D")]
	private int <pointerId>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400089C")]
	private Vector2 m_Tilt; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400089B")]
	private bool m_TiltNeeded; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400089A")]
	private float m_AzimuthAngle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000899")]
	private float m_AltitudeAngle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000898")]
	private bool m_AzimuthNeedsConversion; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000897")]
	private bool m_AltitudeNeedsConversion; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A2")]
	private Vector3 <position>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008B0")]
	private bool <recomputeTopElementUnderPointer>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170002BE")]
	public override bool actionKey
	{
		[Address(RVA = "0xE6C2B0", Offset = "0xE6B4B0", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED3")]
		 get { } //Length: 138
	}

	[Token(Token = "0x170002B2")]
	public override float altitudeAngle
	{
		[Address(RVA = "0xE6C350", Offset = "0xE6B550", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800EBBC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EBF")]
		 get { } //Length: 128
		[Address(RVA = "0xE6C7A0", Offset = "0xE6B9A0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC0")]
		 set { } //Length: 10
	}

	[Token(Token = "0x170002BD")]
	public override bool altKey
	{
		[Address(RVA = "0xE6C340", Offset = "0xE6B540", Length = "0xD")]
		[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "UpdateValueOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED2")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170002B3")]
	public override float azimuthAngle
	{
		[Address(RVA = "0xE6C3D0", Offset = "0xE6B5D0", Length = "0x112")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800EBBC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288D90")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC1")]
		 get { } //Length: 274
		[Address(RVA = "0xE6C7B0", Offset = "0xE6B9B0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC2")]
		 set { } //Length: 10
	}

	[Token(Token = "0x170002A9")]
	public override int button
	{
		[Address(RVA = "0x508E50", Offset = "0x508050", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAD")]
		 get { } //Length: 7
		[Address(RVA = "0x508EF0", Offset = "0x5080F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAE")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002AF")]
	public override int clickCount
	{
		[Address(RVA = "0xE6C4F0", Offset = "0xE6B6F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB9")]
		 get { } //Length: 7
		[Address(RVA = "0xE6C7C0", Offset = "0xE6B9C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EBA")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002BC")]
	public override bool commandKey
	{
		[Address(RVA = "0xE6C500", Offset = "0xE6B700", Length = "0xD")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED1")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170002BF")]
	internal IMouseEvent compatibilityMouseEvent
	{
		[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED4")]
		internal get { } //Length: 8
		[Address(RVA = "0x3CBD80", Offset = "0x3CAF80", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED5")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170002BB")]
	public override bool ctrlKey
	{
		[Address(RVA = "0xE6C510", Offset = "0xE6B710", Length = "0xD")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED0")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170002C4")]
	public internal virtual IEventHandler currentTarget
	{
		[Address(RVA = "0xE0C210", Offset = "0xE0B410", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EDD")]
		 get { } //Length: 25
		[Address(RVA = "0xE6C7D0", Offset = "0xE6B9D0", Length = "0x117")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(EventBase), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EDE")]
		internal set { } //Length: 279
	}

	[Token(Token = "0x170002AD")]
	public override Vector3 deltaPosition
	{
		[Address(RVA = "0xE6C520", Offset = "0xE6B720", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB5")]
		 get { } //Length: 25
		[Address(RVA = "0xE6C200", Offset = "0xE6B400", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB6")]
		 set { } //Length: 22
	}

	[Token(Token = "0x170002AE")]
	public override float deltaTime
	{
		[Address(RVA = "0x3B8230", Offset = "0x3B7430", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB7")]
		 get { } //Length: 9
		[Address(RVA = "0xE6C8F0", Offset = "0xE6BAF0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB8")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170002C0")]
	internal int displayIndex
	{
		[Address(RVA = "0xE6C900", Offset = "0xE6BB00", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED6")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002A8")]
	public override bool isPrimary
	{
		[Address(RVA = "0xE6C540", Offset = "0xE6B740", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAB")]
		 get { } //Length: 8
		[Address(RVA = "0xE6C910", Offset = "0xE6BB10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAC")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002AC")]
	public override Vector3 localPosition
	{
		[Address(RVA = "0xE6C550", Offset = "0xE6B750", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB3")]
		 get { } //Length: 25
		[Address(RVA = "0xE6C920", Offset = "0xE6BB20", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB4")]
		 set { } //Length: 22
	}

	[Token(Token = "0x170002B9")]
	public override EventModifiers modifiers
	{
		[Address(RVA = "0x3D6530", Offset = "0x3D5730", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ECD")]
		 get { } //Length: 7
		[Address(RVA = "0xE6C940", Offset = "0xE6BB40", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ECE")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002B6")]
	public override PenStatus penStatus
	{
		[Address(RVA = "0x3D6540", Offset = "0x3D5740", Length = "0x7")]
		[CallerCount(Count = 20)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC7")]
		 get { } //Length: 7
		[Address(RVA = "0xE6C950", Offset = "0xE6BB50", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC8")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002A6")]
	public override int pointerId
	{
		[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA7")]
		 get { } //Length: 7
		[Address(RVA = "0x504770", Offset = "0x503970", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA8")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002A7")]
	public override string pointerType
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA9")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAA")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170002AB")]
	public override Vector3 position
	{
		[Address(RVA = "0xE6C570", Offset = "0xE6B770", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB1")]
		 get { } //Length: 25
		[Address(RVA = "0xE6C960", Offset = "0xE6BB60", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB2")]
		 set { } //Length: 22
	}

	[Token(Token = "0x170002AA")]
	public override int pressedButtons
	{
		[Address(RVA = "0x508E80", Offset = "0x508080", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAF")]
		 get { } //Length: 7
		[Address(RVA = "0x508F40", Offset = "0x508140", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB0")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002B0")]
	public override float pressure
	{
		[Address(RVA = "0xE6C590", Offset = "0xE6B790", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EBB")]
		 get { } //Length: 9
		[Address(RVA = "0xE6C980", Offset = "0xE6BB80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EBC")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170002B7")]
	public override Vector2 radius
	{
		[Address(RVA = "0xE6C5C0", Offset = "0xE6B7C0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC9")]
		 get { } //Length: 25
		[Address(RVA = "0xE6C9A0", Offset = "0xE6BBA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ECA")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002B8")]
	public override Vector2 radiusVariance
	{
		[Address(RVA = "0xE6C5A0", Offset = "0xE6B7A0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ECB")]
		 get { } //Length: 25
		[Address(RVA = "0xE6C990", Offset = "0xE6BB90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ECC")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002C1")]
	internal bool recomputeTopElementUnderPointer
	{
		[Address(RVA = "0xE6C5E0", Offset = "0xE6B7E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED7")]
		internal get { } //Length: 8
		[Address(RVA = "0xE6C9B0", Offset = "0xE6BBB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED8")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002BA")]
	public override bool shiftKey
	{
		[Address(RVA = "0xE6C5F0", Offset = "0xE6B7F0", Length = "0xD")]
		[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "UpdateValueOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ECF")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170002B1")]
	public override float tangentialPressure
	{
		[Address(RVA = "0xE6C600", Offset = "0xE6B800", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EBD")]
		 get { } //Length: 9
		[Address(RVA = "0xE6C9C0", Offset = "0xE6BBC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EBE")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170002B5")]
	public override Vector2 tilt
	{
		[Address(RVA = "0xE6C610", Offset = "0xE6B810", Length = "0x173")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E8B0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC5")]
		 get { } //Length: 371
		[Address(RVA = "0xE6C9D0", Offset = "0xE6BBD0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC6")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170002B4")]
	public override float twist
	{
		[Address(RVA = "0xE6C790", Offset = "0xE6B990", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC3")]
		 get { } //Length: 9
		[Address(RVA = "0xE6C9E0", Offset = "0xE6BBE0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EC4")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170002C2")]
	private override IMouseEvent UnityEngine.UIElements.IPointerEventInternal.compatibilityMouseEvent
	{
		[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED9")]
		private get { } //Length: 8
	}

	[Token(Token = "0x170002C3")]
	private override Vector3 UnityEngine.UIElements.IPointerOrMouseEvent.deltaPosition
	{
		[Address(RVA = "0xE6C200", Offset = "0xE6B400", Length = "0x16")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EDA")]
		private set { } //Length: 22
	}

	[Address(RVA = "0xE6C220", Offset = "0xE6B420", Length = "0x90")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "LocalInit", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EEF")]
	protected PointerEventBase`1() { }

	[Address(RVA = "0xE68950", Offset = "0xE67B50", Length = "0xA0")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E8B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE2")]
	private static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	[Address(RVA = "0xE689F0", Offset = "0xE67BF0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToCapturingElementOrElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EEE")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0xE6C2B0", Offset = "0xE6B4B0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED3")]
	public override bool get_actionKey() { }

	[Address(RVA = "0xE6C350", Offset = "0xE6B550", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800EBBC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBF")]
	public override float get_altitudeAngle() { }

	[Address(RVA = "0xE6C340", Offset = "0xE6B540", Length = "0xD")]
	[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "UpdateValueOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED2")]
	public override bool get_altKey() { }

	[Address(RVA = "0xE6C3D0", Offset = "0xE6B5D0", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800EBBC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288D90")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC1")]
	public override float get_azimuthAngle() { }

	[Address(RVA = "0x508E50", Offset = "0x508050", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAD")]
	public override int get_button() { }

	[Address(RVA = "0xE6C4F0", Offset = "0xE6B6F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB9")]
	public override int get_clickCount() { }

	[Address(RVA = "0xE6C500", Offset = "0xE6B700", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED1")]
	public override bool get_commandKey() { }

	[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED4")]
	internal IMouseEvent get_compatibilityMouseEvent() { }

	[Address(RVA = "0xE6C510", Offset = "0xE6B710", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED0")]
	public override bool get_ctrlKey() { }

	[Address(RVA = "0xE0C210", Offset = "0xE0B410", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EDD")]
	public virtual IEventHandler get_currentTarget() { }

	[Address(RVA = "0xE6C520", Offset = "0xE6B720", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB5")]
	public override Vector3 get_deltaPosition() { }

	[Address(RVA = "0x3B8230", Offset = "0x3B7430", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB7")]
	public override float get_deltaTime() { }

	[Address(RVA = "0xE6C540", Offset = "0xE6B740", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAB")]
	public override bool get_isPrimary() { }

	[Address(RVA = "0xE6C550", Offset = "0xE6B750", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB3")]
	public override Vector3 get_localPosition() { }

	[Address(RVA = "0x3D6530", Offset = "0x3D5730", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ECD")]
	public override EventModifiers get_modifiers() { }

	[Address(RVA = "0x3D6540", Offset = "0x3D5740", Length = "0x7")]
	[CallerCount(Count = 20)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC7")]
	public override PenStatus get_penStatus() { }

	[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA7")]
	public override int get_pointerId() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA9")]
	public override string get_pointerType() { }

	[Address(RVA = "0xE6C570", Offset = "0xE6B770", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB1")]
	public override Vector3 get_position() { }

	[Address(RVA = "0x508E80", Offset = "0x508080", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAF")]
	public override int get_pressedButtons() { }

	[Address(RVA = "0xE6C590", Offset = "0xE6B790", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBB")]
	public override float get_pressure() { }

	[Address(RVA = "0xE6C5C0", Offset = "0xE6B7C0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC9")]
	public override Vector2 get_radius() { }

	[Address(RVA = "0xE6C5A0", Offset = "0xE6B7A0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ECB")]
	public override Vector2 get_radiusVariance() { }

	[Address(RVA = "0xE6C5E0", Offset = "0xE6B7E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED7")]
	internal bool get_recomputeTopElementUnderPointer() { }

	[Address(RVA = "0xE6C5F0", Offset = "0xE6B7F0", Length = "0xD")]
	[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "UpdateValueOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ECF")]
	public override bool get_shiftKey() { }

	[Address(RVA = "0xE6C600", Offset = "0xE6B800", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBD")]
	public override float get_tangentialPressure() { }

	[Address(RVA = "0xE6C610", Offset = "0xE6B810", Length = "0x173")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E8B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC5")]
	public override Vector2 get_tilt() { }

	[Address(RVA = "0xE6C790", Offset = "0xE6B990", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC3")]
	public override float get_twist() { }

	[Address(RVA = "0xE6A990", Offset = "0xE69B90", Length = "0x3D0")]
	[CalledBy(Type = typeof(PointerEventHelper), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<ProcessMouseEvents>b__29_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(System.ValueTuple`2<UnityEngine.EventModifiers, System.Nullable`1<System.Int32>>)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PointerDeviceState), Member = "ReleaseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "PressButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPressedButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE5")]
	internal static T GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers, int displayIndex) { }

	[Address(RVA = "0xE69510", Offset = "0xE68710", Length = "0x5ED")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerUpLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerUpLinkTagEvent))]
	[CalledBy(Type = typeof(PointerDownLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerDownLinkTagEvent))]
	[CalledBy(Type = typeof(PointerOutLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string)}, ReturnType = typeof(PointerOutLinkTagEvent))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerOverLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerOverLinkTagEvent))]
	[CalledBy(Type = typeof(ClickEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(int)}, ReturnType = typeof(ClickEvent))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(Vector2), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerMoveLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerMoveLinkTagEvent))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EEA")]
	public static T GetPooled(IPointerEvent triggerEvent) { }

	[Address(RVA = "0xE6A7A0", Offset = "0xE699A0", Length = "0x1E0")]
	[CalledBy(Type = typeof(PointerEventsHelper), Member = "SendEnterLeave", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TLeaveEvent", "TEnterEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IPointerEvent), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventsHelper), Member = "SendOverOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IPointerEvent), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(PointerType), Member = "GetPointerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE9")]
	internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

	[Address(RVA = "0xE69B00", Offset = "0xE68D00", Length = "0xC90")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessPointerEvent>b__9_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessPointerEvent>b__9_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessPointerEvent>b__9_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessPointerEvent>b__9_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.InputForUI.PointerEvent", Member = "get_altitude", ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.InputForUI.PointerEvent", Member = "get_azimuth", ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isShiftPressed", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isCtrlPressed", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isAltPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPressedButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isMetaPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerDeviceState), Member = "PressButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.PointerEvent", Member = "get_isPrimaryPointer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPointerDeltaPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerDeviceState), Member = "ReleaseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE8")]
	internal static T GetPooled(PointerEvent pointerEvent, Vector3 position, int pointerId, float deltaTime) { }

	[Address(RVA = "0xE6B350", Offset = "0xE6A550", Length = "0x5FB")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<ProcessPenEvents>b__32_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(PenData)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "MakePenEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PenData), typeof(EventModifiers), typeof(int)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PointerDeviceState), Member = "ReleaseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "PressButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPressedButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE7")]
	internal static T GetPooled(PenData pen, EventModifiers modifiers, int displayIndex) { }

	[Address(RVA = "0xE6AD70", Offset = "0xE69F70", Length = "0x5D4")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<ProcessTouchEvents>b__31_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(System.ValueTuple`3<UnityEngine.Touch, System.Int32, System.Nullable`1<System.Int32>>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "MakeTouchEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPressedButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PointerDeviceState), Member = "PressButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[Calls(Type = typeof(PointerDeviceState), Member = "ReleaseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE6")]
	internal static T GetPooled(Touch touch, int pointerId, EventModifiers modifiers, int displayIndex) { }

	[Address(RVA = "0xE68A30", Offset = "0xE67C30", Length = "0xADF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_pressure", ReturnType = typeof(float))]
	[Calls(Type = typeof(Event), Member = "get_twist", ReturnType = typeof(float))]
	[Calls(Type = typeof(Event), Member = "get_tilt", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(Event), Member = "get_clickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Event), Member = "get_delta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPressedButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Event), Member = "get_button", ReturnType = typeof(int))]
	[Calls(Type = typeof(EventBase), Member = "set_imguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "PressButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "ReleaseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_penStatus", ReturnType = typeof(PenStatus))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_pointerType", ReturnType = typeof(PointerType))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE4")]
	public static T GetPooled(Event systemEvent) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EEB")]
	internal override IMouseEvent GetPooledCompatibilityMouseEvent() { }

	[Address(RVA = "0xE6B950", Offset = "0xE6AB50", Length = "0x4F")]
	[CalledBy(Type = typeof(PointerLeaveEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerDownEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerMoveEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerUpEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerCancelEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClickEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEnterEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerOverLinkTagEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerMoveLinkTagEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerOutLinkTagEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerDownLinkTagEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerUpLinkTagEvent), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "LocalInit", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EDB")]
	protected virtual void Init() { }

	[Address(RVA = "0xE6B9A0", Offset = "0xE6ABA0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EDF")]
	private static bool IsMouse(Event systemEvent) { }

	[Address(RVA = "0xE6B9E0", Offset = "0xE6ABE0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE0")]
	private static bool IsTouch(Event systemEvent) { }

	[Address(RVA = "0xE6BA20", Offset = "0xE6AC20", Length = "0x309")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EDC")]
	private void LocalInit() { }

	[Address(RVA = "0xE6BD30", Offset = "0xE6AF30", Length = "0x142")]
	[CalledBy(Type = typeof(PointerDownEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerMoveEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerUpEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerCancelEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ProcessPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "CommitElementUnderPointers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EED")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0xE6BE80", Offset = "0xE6B080", Length = "0x213")]
	[CalledBy(Type = typeof(PointerLeaveEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerDownEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerMoveEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerUpEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerCancelEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEnterEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PointerDeviceState), Member = "SavePointerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector3), typeof(IPanel), typeof(ContextType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "RecomputeTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2), typeof(EventBase)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ShouldSendCompatibilityMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EEC")]
	protected private virtual void PreDispatch(IPanel panel) { }

	[Address(RVA = "0xE6C7A0", Offset = "0xE6B9A0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC0")]
	protected void set_altitudeAngle(float value) { }

	[Address(RVA = "0xE6C7B0", Offset = "0xE6B9B0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC2")]
	protected void set_azimuthAngle(float value) { }

	[Address(RVA = "0x508EF0", Offset = "0x5080F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAE")]
	protected void set_button(int value) { }

	[Address(RVA = "0xE6C7C0", Offset = "0xE6B9C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBA")]
	protected void set_clickCount(int value) { }

	[Address(RVA = "0x3CBD80", Offset = "0x3CAF80", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED5")]
	internal void set_compatibilityMouseEvent(IMouseEvent value) { }

	[Address(RVA = "0xE6C7D0", Offset = "0xE6B9D0", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EDE")]
	internal virtual void set_currentTarget(IEventHandler value) { }

	[Address(RVA = "0xE6C200", Offset = "0xE6B400", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB6")]
	protected void set_deltaPosition(Vector3 value) { }

	[Address(RVA = "0xE6C8F0", Offset = "0xE6BAF0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB8")]
	protected void set_deltaTime(float value) { }

	[Address(RVA = "0xE6C900", Offset = "0xE6BB00", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED6")]
	internal void set_displayIndex(int value) { }

	[Address(RVA = "0xE6C910", Offset = "0xE6BB10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAC")]
	protected void set_isPrimary(bool value) { }

	[Address(RVA = "0xE6C920", Offset = "0xE6BB20", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB4")]
	protected void set_localPosition(Vector3 value) { }

	[Address(RVA = "0xE6C940", Offset = "0xE6BB40", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ECE")]
	protected void set_modifiers(EventModifiers value) { }

	[Address(RVA = "0xE6C950", Offset = "0xE6BB50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC8")]
	protected void set_penStatus(PenStatus value) { }

	[Address(RVA = "0x504770", Offset = "0x503970", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA8")]
	protected void set_pointerId(int value) { }

	[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAA")]
	protected void set_pointerType(string value) { }

	[Address(RVA = "0xE6C960", Offset = "0xE6BB60", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB2")]
	protected void set_position(Vector3 value) { }

	[Address(RVA = "0x508F40", Offset = "0x508140", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB0")]
	protected void set_pressedButtons(int value) { }

	[Address(RVA = "0xE6C980", Offset = "0xE6BB80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBC")]
	protected void set_pressure(float value) { }

	[Address(RVA = "0xE6C9A0", Offset = "0xE6BBA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ECA")]
	protected void set_radius(Vector2 value) { }

	[Address(RVA = "0xE6C990", Offset = "0xE6BB90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ECC")]
	protected void set_radiusVariance(Vector2 value) { }

	[Address(RVA = "0xE6C9B0", Offset = "0xE6BBB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED8")]
	internal void set_recomputeTopElementUnderPointer(bool value) { }

	[Address(RVA = "0xE6C9C0", Offset = "0xE6BBC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBE")]
	protected void set_tangentialPressure(float value) { }

	[Address(RVA = "0xE6C9D0", Offset = "0xE6BBD0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC6")]
	protected void set_tilt(Vector2 value) { }

	[Address(RVA = "0xE6C9E0", Offset = "0xE6BBE0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC4")]
	protected void set_twist(float value) { }

	[Address(RVA = "0xE6C0A0", Offset = "0xE6B2A0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE3")]
	private static float TiltToAltitude(Vector2 tilt) { }

	[Address(RVA = "0xE6C0F0", Offset = "0xE6B2F0", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288D90")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE1")]
	private static float TiltToAzimuth(Vector2 tilt) { }

	[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED9")]
	private override IMouseEvent UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent() { }

	[Address(RVA = "0xE6C200", Offset = "0xE6B400", Length = "0x16")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EDA")]
	private override void UnityEngine.UIElements.IPointerOrMouseEvent.set_deltaPosition(Vector3 value) { }

}

