namespace UnityEngine.UI;

[AddComponentMenu("UI/Scrollbar", 36)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000060")]
public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
{
	[CompilerGenerated]
	[Token(Token = "0x2000064")]
	private sealed class <ClickRepeat>d__59 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001D5")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001D6")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D7")]
		public Scrollbar <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001D8")]
		public Vector2 screenPosition; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001D9")]
		public Camera camera; //Field offset: 0x30

		[Token(Token = "0x170000F6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60003CA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000F7")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60003CC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003C7")]
		public <ClickRepeat>d__59(int <>1__state) { }

		[Address(RVA = "0x1CDCA70", Offset = "0x1CDBC70", Length = "0x161")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Coroutine)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003C9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1CDCBE0", Offset = "0x1CDBDE0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60003CB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003C8")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000063")]
	private enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	[Token(Token = "0x2000061")]
	internal enum Direction
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3,
	}

	[Token(Token = "0x2000062")]
	internal class ScrollEvent : UnityEvent<Single>
	{

		[Address(RVA = "0x1CCCEC0", Offset = "0x1CCC0C0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003C6")]
		public ScrollEvent() { }

	}

	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x40001C1")]
	private RectTransform m_HandleRect; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x40001C2")]
	private Direction m_Direction; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40001C3")]
	private float m_Value; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40001C4")]
	private float m_Size; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Range(0, 11)]
	[SerializeField]
	[Token(Token = "0x40001C5")]
	private int m_NumberOfSteps; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Space(6)]
	[Token(Token = "0x40001C6")]
	private ScrollEvent m_OnValueChanged; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40001C7")]
	private RectTransform m_ContainerRect; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40001C8")]
	private Vector2 m_Offset; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40001C9")]
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40001CA")]
	private Coroutine m_PointerDownRepeat; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40001CB")]
	private bool isPointerDownAndNotDragging; //Field offset: 0x140
	[FieldOffset(Offset = "0x141")]
	[Token(Token = "0x40001CC")]
	private bool m_DelayedUpdateVisuals; //Field offset: 0x141

	[Token(Token = "0x170000F4")]
	private Axis axis
	{
		[Address(RVA = "0x1CD35C0", Offset = "0x1CD27C0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003B1")]
		private get { } //Length: 21
	}

	[Token(Token = "0x170000EE")]
	public Direction direction
	{
		[Address(RVA = "0x4234B0", Offset = "0x4226B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600039B")]
		 get { } //Length: 7
		[Address(RVA = "0x1CD3690", Offset = "0x1CD2890", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[Token(Token = "0x600039C")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000ED")]
	public RectTransform handleRect
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000399")]
		 get { } //Length: 8
		[Address(RVA = "0x1CD36F0", Offset = "0x1CD28F0", Length = "0x65")]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600039A")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170000F1")]
	public int numberOfSteps
	{
		[Address(RVA = "0x4234C0", Offset = "0x4226C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A3")]
		 get { } //Length: 7
		[Address(RVA = "0x1CD3760", Offset = "0x1CD2960", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[Token(Token = "0x60003A4")]
		 set { } //Length: 111
	}

	[Token(Token = "0x170000F2")]
	public ScrollEvent onValueChanged
	{
		[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A5")]
		 get { } //Length: 8
		[Address(RVA = "0x1673E10", Offset = "0x1673010", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A6")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170000F5")]
	private bool reverseValue
	{
		[Address(RVA = "0x1CD35E0", Offset = "0x1CD27E0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003B2")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170000F0")]
	public float size
	{
		[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A1")]
		 get { } //Length: 9
		[Address(RVA = "0x1CD37D0", Offset = "0x1CD29D0", Length = "0x79")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateScrollbar", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[Token(Token = "0x60003A2")]
		 set { } //Length: 121
	}

	[Token(Token = "0x170000F3")]
	private float stepSize
	{
		[Address(RVA = "0x1CD3600", Offset = "0x1CD2800", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60003A7")]
		private get { } //Length: 46
	}

	[Token(Token = "0x170000EF")]
	public float value
	{
		[Address(RVA = "0x1CD3630", Offset = "0x1CD2830", Length = "0x54")]
		[CalledBy(Type = typeof(Scrollbar), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
		[Token(Token = "0x600039E")]
		 get { } //Length: 84
		[Address(RVA = "0x1CD3850", Offset = "0x1CD2A50", Length = "0xB")]
		[CalledBy(Type = "namudev.PropertyGrid", Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateScrollbar", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600039F")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x1CD34C0", Offset = "0x1CD26C0", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600039D")]
	protected Scrollbar() { }

	[Address(RVA = "0x1CD1BF0", Offset = "0x1CD0DF0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003BB")]
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	[Address(RVA = "0x1CD1B50", Offset = "0x1CD0D50", Length = "0x9F")]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ClickRepeat>d__59))]
	[Token(Token = "0x60003BC")]
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	[Address(RVA = "0x1CD1C70", Offset = "0x1CD0E70", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003B6")]
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	[Address(RVA = "0x1CD1D30", Offset = "0x1CD0F30", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
	[Token(Token = "0x60003C2")]
	public virtual Selectable FindSelectableOnDown() { }

	[Address(RVA = "0x1CD1D60", Offset = "0x1CD0F60", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
	[Token(Token = "0x60003BF")]
	public virtual Selectable FindSelectableOnLeft() { }

	[Address(RVA = "0x1CD1D90", Offset = "0x1CD0F90", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
	[Token(Token = "0x60003C0")]
	public virtual Selectable FindSelectableOnRight() { }

	[Address(RVA = "0x1CD1DC0", Offset = "0x1CD0FC0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
	[Token(Token = "0x60003C1")]
	public virtual Selectable FindSelectableOnUp() { }

	[Address(RVA = "0x1CD35C0", Offset = "0x1CD27C0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003B1")]
	private Axis get_axis() { }

	[Address(RVA = "0x4234B0", Offset = "0x4226B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600039B")]
	public Direction get_direction() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000399")]
	public RectTransform get_handleRect() { }

	[Address(RVA = "0x4234C0", Offset = "0x4226C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A3")]
	public int get_numberOfSteps() { }

	[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A5")]
	public ScrollEvent get_onValueChanged() { }

	[Address(RVA = "0x1CD35E0", Offset = "0x1CD27E0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003B2")]
	private bool get_reverseValue() { }

	[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A1")]
	public float get_size() { }

	[Address(RVA = "0x1CD3600", Offset = "0x1CD2800", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60003A7")]
	private float get_stepSize() { }

	[Address(RVA = "0x1CD3630", Offset = "0x1CD2830", Length = "0x54")]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Token(Token = "0x600039E")]
	public float get_value() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003AA")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A9")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x1094120", Offset = "0x1093320", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B7")]
	private bool MayDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CD1DF0", Offset = "0x1CD0FF0", Length = "0x290")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60003B8")]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CD2090", Offset = "0x1CD1290", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003AC")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CD20C0", Offset = "0x1CD12C0", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60003B9")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CD2260", Offset = "0x1CD1460", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003AB")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1094380", Offset = "0x1093580", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C3")]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CD2330", Offset = "0x1CD1530", Length = "0x4EF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scrollbar), Member = "get_value", ReturnType = typeof(float))]
	[Calls(Type = typeof(Selectable), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60003BE")]
	public virtual void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x1CD2820", Offset = "0x1CD1A20", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60003BA")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x1CD2930", Offset = "0x1CD1B30", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003BD")]
	public virtual void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x1CD2970", Offset = "0x1CD1B70", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003B0")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A8")]
	public override void Rebuild(CanvasUpdate executing) { }

	[Address(RVA = "0x1CD2C30", Offset = "0x1CD1E30", Length = "0x129")]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_numberOfSteps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "DoUpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Single>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003AF")]
	private void Set(float input, bool sendCallback = true) { }

	[Address(RVA = "0x1CD3690", Offset = "0x1CD2890", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Token(Token = "0x600039C")]
	public void set_direction(Direction value) { }

	[Address(RVA = "0x1CD36F0", Offset = "0x1CD28F0", Length = "0x65")]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600039A")]
	public void set_handleRect(RectTransform value) { }

	[Address(RVA = "0x1CD3760", Offset = "0x1CD2960", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Token(Token = "0x60003A4")]
	public void set_numberOfSteps(int value) { }

	[Address(RVA = "0x1673E10", Offset = "0x1673010", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A6")]
	public void set_onValueChanged(ScrollEvent value) { }

	[Address(RVA = "0x1CD37D0", Offset = "0x1CD29D0", Length = "0x79")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateScrollbar", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Token(Token = "0x60003A2")]
	public void set_size(float value) { }

	[Address(RVA = "0x1CD3850", Offset = "0x1CD2A50", Length = "0xB")]
	[CalledBy(Type = "namudev.PropertyGrid", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateScrollbar", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600039F")]
	public void set_value(float value) { }

	[Address(RVA = "0x1CD29B0", Offset = "0x1CD1BB0", Length = "0x1C6")]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutOnAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003C4")]
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	[Address(RVA = "0x1CD2B80", Offset = "0x1CD1D80", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003A0")]
	public override void SetValueWithoutNotify(float input) { }

	[Address(RVA = "0x1094810", Offset = "0x1093A10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C5")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x1CD34A0", Offset = "0x1CD26A0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Token(Token = "0x60003AD")]
	protected override void Update() { }

	[Address(RVA = "0x1CD2D60", Offset = "0x1CD1F60", Length = "0xFA")]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_handleRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60003AE")]
	private void UpdateCachedReferences() { }

	[Address(RVA = "0x1CD2E60", Offset = "0x1CD2060", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003B4")]
	private void UpdateDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CD2F70", Offset = "0x1CD2170", Length = "0x2A9")]
	[CalledBy(Type = typeof(<ClickRepeat>d__59), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003B5")]
	private void UpdateDrag(RectTransform containerRect, Vector2 position, Camera camera) { }

	[Address(RVA = "0x1CD3220", Offset = "0x1CD2420", Length = "0x278")]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "SetDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_numberOfSteps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_handleRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60003B3")]
	private void UpdateVisuals() { }

}

