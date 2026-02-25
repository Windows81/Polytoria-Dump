namespace TMPro;

[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html")]
[Token(Token = "0x2000061")]
public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICancelHandler, ICanvasElement, ILayoutElement, IScrollHandler
{
	[CompilerGenerated]
	[Token(Token = "0x200006D")]
	private sealed class <CaretBlink>d__293 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400030C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400030D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400030E")]
		public TMP_InputField <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000D5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60003F9")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000D6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60003FB")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003F6")]
		public <CaretBlink>d__293(int <>1__state) { }

		[Address(RVA = "0x18F20E0", Offset = "0x18F12E0", Length = "0x151")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
		[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003F8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003F9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003FB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x18F2240", Offset = "0x18F1440", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60003FA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003F7")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006E")]
	private sealed class <MouseDragOutsideRect>d__314 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400030F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000310")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000311")]
		public TMP_InputField <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000312")]
		public PointerEventData eventData; //Field offset: 0x28

		[Token(Token = "0x170000D7")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60003FF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000D8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000401")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003FC")]
		public <MouseDragOutsideRect>d__314(int <>1__state) { }

		[Address(RVA = "0x18F2FE0", Offset = "0x18F21E0", Length = "0x292")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_multiLine", ReturnType = typeof(bool))]
		[Calls(Type = typeof(WaitForSecondsRealtime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "MoveLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TMP_InputField), Member = "MoveRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60003FE")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003FF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000401")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x18F3280", Offset = "0x18F2480", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000400")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003FD")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000064")]
	internal enum CharacterValidation
	{
		None = 0,
		Digit = 1,
		Integer = 2,
		Decimal = 3,
		Alphanumeric = 4,
		Name = 5,
		Regex = 6,
		EmailAddress = 7,
		CustomValidator = 8,
	}

	[Token(Token = "0x2000062")]
	internal enum ContentType
	{
		Standard = 0,
		Autocorrected = 1,
		IntegerNumber = 2,
		DecimalNumber = 3,
		Alphanumeric = 4,
		Name = 5,
		EmailAddress = 6,
		Password = 7,
		Pin = 8,
		Custom = 9,
	}

	[Token(Token = "0x200006C")]
	internal enum EditState
	{
		Continue = 0,
		Finish = 1,
	}

	[Token(Token = "0x2000063")]
	internal enum InputType
	{
		Standard = 0,
		AutoCorrect = 1,
		Password = 2,
	}

	[Token(Token = "0x2000065")]
	internal enum LineType
	{
		SingleLine = 0,
		MultiLineSubmit = 1,
		MultiLineNewline = 2,
	}

	[Token(Token = "0x2000068")]
	internal class OnChangeEvent : UnityEvent<String>
	{

		[Address(RVA = "0x18DE310", Offset = "0x18DD510", Length = "0x39")]
		[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003F2")]
		public OnChangeEvent() { }

	}

	[Token(Token = "0x2000066")]
	internal sealed class OnValidateInput : MulticastDelegate
	{

		[Address(RVA = "0x18DE3F0", Offset = "0x18DD5F0", Length = "0xB5")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003ED")]
		public OnValidateInput(object object, IntPtr method) { }

		[Address(RVA = "0x18DE350", Offset = "0x18DD550", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EF")]
		public override IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

		[Address(RVA = "0x18DE3C0", Offset = "0x18DD5C0", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003F0")]
		public override char EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EE")]
		public override char Invoke(string text, int charIndex, char addedChar) { }

	}

	[Token(Token = "0x2000069")]
	internal class SelectionEvent : UnityEvent<String>
	{

		[Address(RVA = "0x18DE4B0", Offset = "0x18DD6B0", Length = "0x39")]
		[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003F3")]
		public SelectionEvent() { }

	}

	[Token(Token = "0x2000067")]
	internal class SubmitEvent : UnityEvent<String>
	{

		[Address(RVA = "0x18E1B60", Offset = "0x18E0D60", Length = "0x39")]
		[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003F1")]
		public SubmitEvent() { }

	}

	[Token(Token = "0x200006A")]
	internal class TextSelectionEvent : UnityEvent<String, Int32, Int32>
	{

		[Address(RVA = "0x18F2060", Offset = "0x18F1260", Length = "0x39")]
		[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003F4")]
		public TextSelectionEvent() { }

	}

	[Token(Token = "0x200006B")]
	internal class TouchScreenKeyboardEvent : UnityEvent<Status>
	{

		[Address(RVA = "0x18F20A0", Offset = "0x18F12A0", Length = "0x39")]
		[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003F5")]
		public TouchScreenKeyboardEvent() { }

	}

	[Token(Token = "0x40002C0")]
	private const float kHScrollSpeed = 0.05; //Field offset: 0x0
	[Token(Token = "0x4000287")]
	private static readonly Char[] kSeparators; //Field offset: 0x0
	[Token(Token = "0x40002D2")]
	private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~"; //Field offset: 0x0
	[Token(Token = "0x40002D3")]
	private const string kOculusQuestDeviceModel = "Oculus Quest"; //Field offset: 0x0
	[Token(Token = "0x40002C1")]
	private const float kVScrollSpeed = 0.1; //Field offset: 0x0
	[Token(Token = "0x4000288")]
	private static bool s_IsQuestDevice; //Field offset: 0x8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000286")]
	protected TouchScreenKeyboard m_SoftKeyboard; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000289")]
	protected RectTransform m_RectTransform; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x400028A")]
	protected RectTransform m_TextViewport; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400028B")]
	protected RectMask2D m_TextComponentRectMask; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400028C")]
	protected RectMask2D m_TextViewportRectMask; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x400028D")]
	protected TMP_Text m_TextComponent; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400028E")]
	protected RectTransform m_TextComponentRectTransform; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x400028F")]
	protected Graphic m_Placeholder; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4000290")]
	protected Scrollbar m_VerticalScrollbar; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x4000291")]
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000292")]
	private bool m_IsDrivenByLayoutComponents; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x4000293")]
	private LayoutGroup m_LayoutGroup; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000294")]
	private IScrollHandler m_IScrollHandlerParent; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000295")]
	private float m_ScrollPosition; //Field offset: 0x168
	[FieldOffset(Offset = "0x16C")]
	[SerializeField]
	[Token(Token = "0x4000296")]
	protected float m_ScrollSensitivity; //Field offset: 0x16C
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	[Token(Token = "0x4000297")]
	private ContentType m_ContentType; //Field offset: 0x170
	[FieldOffset(Offset = "0x174")]
	[SerializeField]
	[Token(Token = "0x4000298")]
	private InputType m_InputType; //Field offset: 0x174
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	[Token(Token = "0x4000299")]
	private char m_AsteriskChar; //Field offset: 0x178
	[FieldOffset(Offset = "0x17C")]
	[SerializeField]
	[Token(Token = "0x400029A")]
	private TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x17C
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x400029B")]
	private LineType m_LineType; //Field offset: 0x180
	[FieldOffset(Offset = "0x184")]
	[SerializeField]
	[Token(Token = "0x400029C")]
	private bool m_HideMobileInput; //Field offset: 0x184
	[FieldOffset(Offset = "0x185")]
	[SerializeField]
	[Token(Token = "0x400029D")]
	private bool m_HideSoftKeyboard; //Field offset: 0x185
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[Token(Token = "0x400029E")]
	private CharacterValidation m_CharacterValidation; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	[Token(Token = "0x400029F")]
	private string m_RegexValue; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	[Token(Token = "0x40002A0")]
	private float m_GlobalPointSize; //Field offset: 0x198
	[FieldOffset(Offset = "0x19C")]
	[SerializeField]
	[Token(Token = "0x40002A1")]
	private int m_CharacterLimit; //Field offset: 0x19C
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	[Token(Token = "0x40002A2")]
	private SubmitEvent m_OnEndEdit; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	[Token(Token = "0x40002A3")]
	private SubmitEvent m_OnSubmit; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x40002A4")]
	private SelectionEvent m_OnSelect; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x40002A5")]
	private SelectionEvent m_OnDeselect; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x40002A6")]
	private TextSelectionEvent m_OnTextSelection; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	[Token(Token = "0x40002A7")]
	private TextSelectionEvent m_OnEndTextSelection; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x40002A8")]
	private OnChangeEvent m_OnValueChanged; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Token(Token = "0x40002A9")]
	private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	[Token(Token = "0x40002AA")]
	private OnValidateInput m_OnValidateInput; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	[Token(Token = "0x40002AB")]
	private Color m_CaretColor; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	[Token(Token = "0x40002AC")]
	private bool m_CustomCaretColor; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x1FC")]
	[SerializeField]
	[Token(Token = "0x40002AD")]
	private Color m_SelectionColor; //Field offset: 0x1FC
	[FieldOffset(Offset = "0x210")]
	[SerializeField]
	[TextArea(5, 10)]
	[Token(Token = "0x40002AE")]
	protected string m_Text; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Range(0, 4)]
	[SerializeField]
	[Token(Token = "0x40002AF")]
	private float m_CaretBlinkRate; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[Range(1, 5)]
	[SerializeField]
	[Token(Token = "0x40002B0")]
	private int m_CaretWidth; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[SerializeField]
	[Token(Token = "0x40002B1")]
	private bool m_ReadOnly; //Field offset: 0x220
	[FieldOffset(Offset = "0x221")]
	[SerializeField]
	[Token(Token = "0x40002B2")]
	private bool m_RichText; //Field offset: 0x221
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x40002B3")]
	protected int m_StringPosition; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x40002B4")]
	protected int m_StringSelectPosition; //Field offset: 0x228
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x40002B5")]
	protected int m_CaretPosition; //Field offset: 0x22C
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x40002B6")]
	protected int m_CaretSelectPosition; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x40002B7")]
	private RectTransform caretRectTrans; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x40002B8")]
	protected UIVertex[] m_CursorVerts; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x40002B9")]
	private CanvasRenderer m_CachedInputRenderer; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x40002BA")]
	private Vector2 m_LastPosition; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40002BB")]
	protected Mesh m_Mesh; //Field offset: 0x258
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40002BC")]
	private bool m_AllowInput; //Field offset: 0x260
	[FieldOffset(Offset = "0x261")]
	[Token(Token = "0x40002BD")]
	private bool m_ShouldActivateNextUpdate; //Field offset: 0x261
	[FieldOffset(Offset = "0x262")]
	[Token(Token = "0x40002BE")]
	private bool m_UpdateDrag; //Field offset: 0x262
	[FieldOffset(Offset = "0x263")]
	[Token(Token = "0x40002BF")]
	private bool m_DragPositionOutOfBounds; //Field offset: 0x263
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x40002C2")]
	protected bool m_CaretVisible; //Field offset: 0x264
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40002C3")]
	private Coroutine m_BlinkCoroutine; //Field offset: 0x268
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x40002C4")]
	private float m_BlinkStartTime; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40002C5")]
	private Coroutine m_DragCoroutine; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40002C6")]
	private string m_OriginalText; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40002C7")]
	private bool m_WasCanceled; //Field offset: 0x288
	[FieldOffset(Offset = "0x289")]
	[Token(Token = "0x40002C8")]
	private bool m_HasDoneFocusTransition; //Field offset: 0x289
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40002C9")]
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40002CA")]
	private bool m_PreventCallback; //Field offset: 0x298
	[FieldOffset(Offset = "0x299")]
	[Token(Token = "0x40002CB")]
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x299
	[FieldOffset(Offset = "0x29A")]
	[Token(Token = "0x40002CC")]
	private bool m_IsTextComponentUpdateRequired; //Field offset: 0x29A
	[FieldOffset(Offset = "0x29B")]
	[Token(Token = "0x40002CD")]
	private bool m_HasTextBeenRemoved; //Field offset: 0x29B
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x40002CE")]
	private float m_PointerDownClickStartTime; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40002CF")]
	private float m_KeyDownStartTime; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A4")]
	[Token(Token = "0x40002D0")]
	private float m_DoubleClickDelay; //Field offset: 0x2A4
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x40002D1")]
	private bool m_IsApplePlatform; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2A9")]
	[Token(Token = "0x40002D4")]
	private bool m_IsCompositionActive; //Field offset: 0x2A9
	[FieldOffset(Offset = "0x2AA")]
	[Token(Token = "0x40002D5")]
	private bool m_ShouldUpdateIMEWindowPosition; //Field offset: 0x2AA
	[FieldOffset(Offset = "0x2AC")]
	[Token(Token = "0x40002D6")]
	private int m_PreviousIMEInsertionLine; //Field offset: 0x2AC
	[FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	[Token(Token = "0x40002D7")]
	protected TMP_FontAsset m_GlobalFontAsset; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[SerializeField]
	[Token(Token = "0x40002D8")]
	protected bool m_OnFocusSelectAll; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2B9")]
	[Token(Token = "0x40002D9")]
	protected bool m_isSelectAll; //Field offset: 0x2B9
	[FieldOffset(Offset = "0x2BA")]
	[SerializeField]
	[Token(Token = "0x40002DA")]
	protected bool m_ResetOnDeActivation; //Field offset: 0x2BA
	[FieldOffset(Offset = "0x2BB")]
	[Token(Token = "0x40002DB")]
	private bool m_SelectionStillActive; //Field offset: 0x2BB
	[FieldOffset(Offset = "0x2BC")]
	[Token(Token = "0x40002DC")]
	private bool m_ReleaseSelection; //Field offset: 0x2BC
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x40002DD")]
	private KeyCode m_LastKeyCode; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x40002DE")]
	private GameObject m_PreviouslySelectedObject; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	[Token(Token = "0x40002DF")]
	private bool m_KeepTextSelectionVisible; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D1")]
	[SerializeField]
	[Token(Token = "0x40002E0")]
	private bool m_RestoreOriginalTextOnEscape; //Field offset: 0x2D1
	[FieldOffset(Offset = "0x2D2")]
	[SerializeField]
	[Token(Token = "0x40002E1")]
	protected bool m_isRichTextEditingAllowed; //Field offset: 0x2D2
	[FieldOffset(Offset = "0x2D4")]
	[SerializeField]
	[Token(Token = "0x40002E2")]
	protected int m_LineLimit; //Field offset: 0x2D4
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x40002E3")]
	public bool isAlert; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[SerializeField]
	[Token(Token = "0x40002E4")]
	protected TMP_InputValidator m_InputValidator; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[SerializeField]
	[Token(Token = "0x40002E5")]
	private bool m_ShouldActivateOnSelect; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2E9")]
	[Token(Token = "0x40002E6")]
	private bool m_isSelected; //Field offset: 0x2E9
	[FieldOffset(Offset = "0x2EA")]
	[Token(Token = "0x40002E7")]
	private bool m_IsStringPositionDirty; //Field offset: 0x2EA
	[FieldOffset(Offset = "0x2EB")]
	[Token(Token = "0x40002E8")]
	private bool m_IsCaretPositionDirty; //Field offset: 0x2EB
	[FieldOffset(Offset = "0x2EC")]
	[Token(Token = "0x40002E9")]
	private bool m_forceRectTransformAdjustment; //Field offset: 0x2EC
	[FieldOffset(Offset = "0x2ED")]
	[Token(Token = "0x40002EA")]
	private bool m_IsKeyboardBeingClosedInHoloLens; //Field offset: 0x2ED
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x40002EB")]
	private Event m_ProcessingEvent; //Field offset: 0x2F0

	[Token(Token = "0x170000C0")]
	public char asteriskChar
	{
		[Address(RVA = "0x18B1480", Offset = "0x18B0680", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600035A")]
		 get { } //Length: 8
		[Address(RVA = "0x18B20E0", Offset = "0x18B12E0", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[Token(Token = "0x600035B")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700009A")]
	public float caretBlinkRate
	{
		[Address(RVA = "0x4761D0", Offset = "0x4753D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000310")]
		 get { } //Length: 9
		[Address(RVA = "0x18B2140", Offset = "0x18B1340", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TMP_InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000311")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170000A1")]
	public Color caretColor
	{
		[Address(RVA = "0x18B1490", Offset = "0x18B0690", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600031E")]
		 get { } //Length: 93
		[Address(RVA = "0x18B21B0", Offset = "0x18B13B0", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600031F")]
		 set { } //Length: 111
	}

	[Token(Token = "0x170000C7")]
	public int caretPosition
	{
		[Address(RVA = "0x18B1530", Offset = "0x18B0730", Length = "0x3B")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000369")]
		 get { } //Length: 59
		[Address(RVA = "0x18B2240", Offset = "0x18B1440", Length = "0x9F")]
		[CalledBy(Type = "Polytoria.UI.UICommandList", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateStringIndexFromCaretPosition", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600036A")]
		 set { } //Length: 159
	}

	[Token(Token = "0x170000C2")]
	protected int caretPositionInternal
	{
		[Address(RVA = "0x18B14F0", Offset = "0x18B06F0", Length = "0x3B")]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000360")]
		 get { } //Length: 59
		[Address(RVA = "0x18B2220", Offset = "0x18B1420", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000361")]
		 set { } //Length: 21
	}

	[Token(Token = "0x170000C4")]
	protected int caretSelectPositionInternal
	{
		[Address(RVA = "0x18B1530", Offset = "0x18B0730", Length = "0x3B")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000364")]
		 get { } //Length: 59
		[Address(RVA = "0x18B22E0", Offset = "0x18B14E0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000365")]
		 set { } //Length: 21
	}

	[Token(Token = "0x1700009B")]
	public int caretWidth
	{
		[Address(RVA = "0x49B740", Offset = "0x49A940", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000312")]
		 get { } //Length: 7
		[Address(RVA = "0x18B2300", Offset = "0x18B1500", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000313")]
		 set { } //Length: 138
	}

	[Token(Token = "0x170000AD")]
	public int characterLimit
	{
		[Address(RVA = "0x18B1570", Offset = "0x18B0770", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000336")]
		 get { } //Length: 7
		[Address(RVA = "0x18B2390", Offset = "0x18B1590", Length = "0xA1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000337")]
		 set { } //Length: 161
	}

	[Token(Token = "0x170000BB")]
	public CharacterValidation characterValidation
	{
		[Address(RVA = "0x18B1580", Offset = "0x18B0780", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000351")]
		 get { } //Length: 7
		[Address(RVA = "0x18B2440", Offset = "0x18B1640", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000352")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170000CD")]
	private static string clipboard
	{
		[Address(RVA = "0x18B1590", Offset = "0x18B0790", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
		[Token(Token = "0x6000381")]
		private get { } //Length: 64
		[Address(RVA = "0x18B24B0", Offset = "0x18B16B0", Length = "0x49")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000382")]
		private set { } //Length: 73
	}

	[Token(Token = "0x17000093")]
	private int compositionLength
	{
		[Address(RVA = "0x18B15D0", Offset = "0x18B07D0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000300")]
		private get { } //Length: 45
	}

	[Token(Token = "0x17000092")]
	private string compositionString
	{
		[Address(RVA = "0x18B1600", Offset = "0x18B0800", Length = "0xA2")]
		[CallerCount(Count = 128)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TMP_InputField), Member = "get_inputSystem", ReturnType = typeof(BaseInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002FF")]
		private get { } //Length: 162
	}

	[Token(Token = "0x170000B5")]
	public ContentType contentType
	{
		[Address(RVA = "0x18B16B0", Offset = "0x18B08B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000346")]
		 get { } //Length: 7
		[Address(RVA = "0x18B2500", Offset = "0x18B1700", Length = "0x210")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustom", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_inputType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_keyboardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboardType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_characterValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_inputValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_InputValidator)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustomIfContentTypeIsNot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "set_textWrappingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWrappingModes)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000347")]
		 set { } //Length: 528
	}

	[Token(Token = "0x170000A2")]
	public bool customCaretColor
	{
		[Address(RVA = "0x18B16C0", Offset = "0x18B08C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000320")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2740", Offset = "0x18B1940", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000321")]
		 set { } //Length: 93
	}

	[Token(Token = "0x170000D3")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E7")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000D0")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E4")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000AF")]
	public TMP_FontAsset fontAsset
	{
		[Address(RVA = "0x1551CC0", Offset = "0x1550EC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600033A")]
		 get { } //Length: 8
		[Address(RVA = "0x18B27A0", Offset = "0x18B19A0", Length = "0x134")]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600033B")]
		 set { } //Length: 308
	}

	[Token(Token = "0x170000C6")]
	private bool hasSelection
	{
		[Address(RVA = "0x18B16E0", Offset = "0x18B08E0", Length = "0x80")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<CaretBlink>d__293), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "GetSelectedString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MoveRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MoveLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000368")]
		private get { } //Length: 128
	}

	[Token(Token = "0x17000091")]
	private BaseInput inputSystem
	{
		[Address(RVA = "0x18B1770", Offset = "0x18B0970", Length = "0xFB")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60002FE")]
		private get { } //Length: 251
	}

	[Token(Token = "0x170000B8")]
	public InputType inputType
	{
		[Address(RVA = "0x18B1870", Offset = "0x18B0A70", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600034C")]
		 get { } //Length: 7
		[Address(RVA = "0x18B28E0", Offset = "0x18B1AE0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[Token(Token = "0x600034D")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170000BC")]
	public TMP_InputValidator inputValidator
	{
		[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000353")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2950", Offset = "0x18B1B50", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000354")]
		 set { } //Length: 106
	}

	[Token(Token = "0x17000099")]
	public bool isFocused
	{
		[Address(RVA = "0x18B1890", Offset = "0x18B0A90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600030F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000B4")]
	public bool isRichTextEditingAllowed
	{
		[Address(RVA = "0x18B18A0", Offset = "0x18B0AA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000344")]
		 get { } //Length: 8
		[Address(RVA = "0x18B29C0", Offset = "0x18B1BC0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000345")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000B2")]
	public bool keepTextSelectionVisible
	{
		[Address(RVA = "0x18B18B0", Offset = "0x18B0AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000340")]
		 get { } //Length: 8
		[Address(RVA = "0x18B29D0", Offset = "0x18B1BD0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000341")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000BA")]
	public TouchScreenKeyboardType keyboardType
	{
		[Address(RVA = "0x18B18C0", Offset = "0x18B0AC0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600034F")]
		 get { } //Length: 7
		[Address(RVA = "0x18B29E0", Offset = "0x18B1BE0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000350")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170000D4")]
	public override int layoutPriority
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E8")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000B7")]
	public int lineLimit
	{
		[Address(RVA = "0x18B18D0", Offset = "0x18B0AD0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600034A")]
		 get { } //Length: 7
		[Address(RVA = "0x18B2A50", Offset = "0x18B1C50", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600034B")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170000B6")]
	public LineType lineType
	{
		[Address(RVA = "0x18B18E0", Offset = "0x18B0AE0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000348")]
		 get { } //Length: 7
		[Address(RVA = "0x18B2AC0", Offset = "0x18B1CC0", Length = "0xD7")]
		[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_IsMultiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000349")]
		 set { } //Length: 215
	}

	[Token(Token = "0x17000094")]
	protected Mesh mesh
	{
		[Address(RVA = "0x18B18F0", Offset = "0x18B0AF0", Length = "0xA3")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000302")]
		 get { } //Length: 163
	}

	[Token(Token = "0x170000D1")]
	public override float minHeight
	{
		[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E5")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000CE")]
	public override float minWidth
	{
		[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E2")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000BF")]
	public bool multiLine
	{
		[Address(RVA = "0x18B19A0", Offset = "0x18B0BA0", Length = "0x17")]
		[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000359")]
		 get { } //Length: 23
	}

	[Token(Token = "0x170000A7")]
	public SelectionEvent onDeselect
	{
		[Address(RVA = "0x189D830", Offset = "0x189CA30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600032A")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2BA0", Offset = "0x18B1DA0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600032B")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000A4")]
	public SubmitEvent onEndEdit
	{
		[Address(RVA = "0x3D6750", Offset = "0x3D5950", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000324")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2BF0", Offset = "0x18B1DF0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000325")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000A9")]
	public TextSelectionEvent onEndTextSelection
	{
		[Address(RVA = "0x18B19C0", Offset = "0x18B0BC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600032E")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2C40", Offset = "0x18B1E40", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600032F")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000B0")]
	public bool onFocusSelectAll
	{
		[Address(RVA = "0x18B19D0", Offset = "0x18B0BD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600033C")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2C90", Offset = "0x18B1E90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600033D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000A6")]
	public SelectionEvent onSelect
	{
		[Address(RVA = "0x497990", Offset = "0x496B90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000328")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2CA0", Offset = "0x18B1EA0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000329")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000A5")]
	public SubmitEvent onSubmit
	{
		[Address(RVA = "0x3D67E0", Offset = "0x3D59E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000326")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2CF0", Offset = "0x18B1EF0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000327")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000A8")]
	public TextSelectionEvent onTextSelection
	{
		[Address(RVA = "0x18B19E0", Offset = "0x18B0BE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600032C")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2D40", Offset = "0x18B1F40", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600032D")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000AB")]
	public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged
	{
		[Address(RVA = "0x18B19F0", Offset = "0x18B0BF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000332")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2D90", Offset = "0x18B1F90", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000333")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000AC")]
	public OnValidateInput onValidateInput
	{
		[Address(RVA = "0x1551D80", Offset = "0x1550F80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000334")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2DE0", Offset = "0x18B1FE0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000335")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000AA")]
	public OnChangeEvent onValueChanged
	{
		[Address(RVA = "0x18B1A00", Offset = "0x18B0C00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000330")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2E30", Offset = "0x18B2030", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000331")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700009E")]
	public Graphic placeholder
	{
		[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000318")]
		 get { } //Length: 8
		[Address(RVA = "0x18B2E80", Offset = "0x18B2080", Length = "0x4C")]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000319")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000AE")]
	public float pointSize
	{
		[Address(RVA = "0x18B1A10", Offset = "0x18B0C10", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000338")]
		 get { } //Length: 9
		[Address(RVA = "0x18B2ED0", Offset = "0x18B20D0", Length = "0x165")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000339")]
		 set { } //Length: 357
	}

	[Token(Token = "0x170000D2")]
	public override float preferredHeight
	{
		[Address(RVA = "0x18B1A20", Offset = "0x18B0C20", Length = "0x16D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
		[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E6")]
		 get { } //Length: 365
	}

	[Token(Token = "0x170000CF")]
	public override float preferredWidth
	{
		[Address(RVA = "0x18B1B90", Offset = "0x18B0D90", Length = "0x16D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
		[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E3")]
		 get { } //Length: 365
	}

	[Token(Token = "0x170000BD")]
	public bool readOnly
	{
		[Address(RVA = "0x18B1D00", Offset = "0x18B0F00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000355")]
		 get { } //Length: 8
		[Address(RVA = "0x18B3040", Offset = "0x18B2240", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000356")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000B1")]
	public bool resetOnDeActivation
	{
		[Address(RVA = "0x18B1D10", Offset = "0x18B0F10", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600033E")]
		 get { } //Length: 8
		[Address(RVA = "0x18B3050", Offset = "0x18B2250", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600033F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000B3")]
	public bool restoreOriginalTextOnEscape
	{
		[Address(RVA = "0x18B1D20", Offset = "0x18B0F20", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000342")]
		 get { } //Length: 8
		[Address(RVA = "0x18B3060", Offset = "0x18B2260", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000343")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000BE")]
	public bool richText
	{
		[Address(RVA = "0x18B1D30", Offset = "0x18B0F30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000357")]
		 get { } //Length: 8
		[Address(RVA = "0x18B3070", Offset = "0x18B2270", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "set_richText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000358")]
		 set { } //Length: 135
	}

	[Token(Token = "0x170000A0")]
	public float scrollSensitivity
	{
		[Address(RVA = "0x18B1D40", Offset = "0x18B0F40", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600031C")]
		 get { } //Length: 9
		[Address(RVA = "0x18B3100", Offset = "0x18B2300", Length = "0x8D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600031D")]
		 set { } //Length: 141
	}

	[Token(Token = "0x170000C8")]
	public int selectionAnchorPosition
	{
		[Address(RVA = "0x18B14F0", Offset = "0x18B06F0", Length = "0x3B")]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600036B")]
		 get { } //Length: 59
		[Address(RVA = "0x18B3190", Offset = "0x18B2390", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600036C")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000A3")]
	public Color selectionColor
	{
		[Address(RVA = "0x18B1D50", Offset = "0x18B0F50", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000322")]
		 get { } //Length: 14
		[Address(RVA = "0x18B31F0", Offset = "0x18B23F0", Length = "0x6F")]
		[CalledBy(Type = "Battlehub.UIControls.UIStyle", Member = "ApplyInputFieldColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Color), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000323")]
		 set { } //Length: 111
	}

	[Token(Token = "0x170000C9")]
	public int selectionFocusPosition
	{
		[Address(RVA = "0x18B1530", Offset = "0x18B0730", Length = "0x3B")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600036D")]
		 get { } //Length: 59
		[Address(RVA = "0x18B3260", Offset = "0x18B2460", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600036E")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000CB")]
	public int selectionStringAnchorPosition
	{
		[Address(RVA = "0x18B1D60", Offset = "0x18B0F60", Length = "0x3B")]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000371")]
		 get { } //Length: 59
		[Address(RVA = "0x18B32C0", Offset = "0x18B24C0", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000372")]
		 set { } //Length: 130
	}

	[Token(Token = "0x170000CC")]
	public int selectionStringFocusPosition
	{
		[Address(RVA = "0x18B1DA0", Offset = "0x18B0FA0", Length = "0x3B")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000373")]
		 get { } //Length: 59
		[Address(RVA = "0x18B3350", Offset = "0x18B2550", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000374")]
		 set { } //Length: 130
	}

	[Token(Token = "0x17000095")]
	public override bool shouldActivateOnSelect
	{
		[Address(RVA = "0x18B1DE0", Offset = "0x18B0FE0", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000304")]
		 get { } //Length: 94
		[Address(RVA = "0xFA13E0", Offset = "0xFA05E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000303")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000096")]
	public bool shouldHideMobileInput
	{
		[Address(RVA = "0x18B1E40", Offset = "0x18B1040", Length = "0x6F")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Token(Token = "0x6000305")]
		 get { } //Length: 111
		[Address(RVA = "0x18B33E0", Offset = "0x18B25E0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000306")]
		 set { } //Length: 160
	}

	[Token(Token = "0x17000097")]
	public bool shouldHideSoftKeyboard
	{
		[Address(RVA = "0x18B1EB0", Offset = "0x18B10B0", Length = "0x8C")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Token(Token = "0x6000307")]
		 get { } //Length: 140
		[Address(RVA = "0x18B3480", Offset = "0x18B2680", Length = "0x141")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000308")]
		 set { } //Length: 321
	}

	[Token(Token = "0x170000CA")]
	public int stringPosition
	{
		[Address(RVA = "0x18B1DA0", Offset = "0x18B0FA0", Length = "0x3B")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600036F")]
		 get { } //Length: 59
		[Address(RVA = "0x18B3620", Offset = "0x18B2820", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateCaretPositionFromStringIndex", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000370")]
		 set { } //Length: 217
	}

	[Token(Token = "0x170000C3")]
	protected int stringPositionInternal
	{
		[Address(RVA = "0x18B1D60", Offset = "0x18B0F60", Length = "0x3B")]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000362")]
		 get { } //Length: 59
		[Address(RVA = "0x18B35D0", Offset = "0x18B27D0", Length = "0x46")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000363")]
		 set { } //Length: 70
	}

	[Token(Token = "0x170000C5")]
	protected int stringSelectPositionInternal
	{
		[Address(RVA = "0x18B1DA0", Offset = "0x18B0FA0", Length = "0x3B")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000366")]
		 get { } //Length: 59
		[Address(RVA = "0x18B3700", Offset = "0x18B2900", Length = "0x46")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000367")]
		 set { } //Length: 70
	}

	[Token(Token = "0x17000098")]
	public string text
	{
		[Address(RVA = "0x408980", Offset = "0x407B80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600030B")]
		 get { } //Length: 8
		[Address(RVA = "0x18B3800", Offset = "0x18B2A00", Length = "0xB")]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemString", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadControls", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.ScreenshotController", Member = "<Start>b__19_0", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.AbuseReportController", Member = "Cancel", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.AbuseReportController", Member = "Return", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemVector3", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemVector2", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadMiscControls", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemNumberRange", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemFloat", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "SendChat", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemInteger", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "HSVPicker.HexColorField", Member = "UpdateHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(TMP_InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600030C")]
		 set { } //Length: 11
	}

	[Token(Token = "0x1700009D")]
	public TMP_Text textComponent
	{
		[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000316")]
		 get { } //Length: 8
		[Address(RVA = "0x18B3750", Offset = "0x18B2950", Length = "0x5B")]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000317")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700009C")]
	public RectTransform textViewport
	{
		[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000314")]
		 get { } //Length: 8
		[Address(RVA = "0x18B37B0", Offset = "0x18B29B0", Length = "0x4C")]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000315")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000B9")]
	public TouchScreenKeyboard touchScreenKeyboard
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700009F")]
	public Scrollbar verticalScrollbar
	{
		[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600031A")]
		 get { } //Length: 8
		[Address(RVA = "0x18B3810", Offset = "0x18B2A10", Length = "0x19D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x600031B")]
		 set { } //Length: 413
	}

	[Token(Token = "0x170000C1")]
	public bool wasCanceled
	{
		[Address(RVA = "0x18B1F40", Offset = "0x18B1140", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600035C")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x18B10A0", Offset = "0x18B02A0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60003EB")]
	private static TMP_InputField() { }

	[Address(RVA = "0x18B1140", Offset = "0x18B0340", Length = "0x33C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SubmitEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectionEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectionEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(OnChangeEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboardEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
	[Token(Token = "0x6000301")]
	protected TMP_InputField() { }

	[Address(RVA = "0x18A32F0", Offset = "0x18A24F0", Length = "0x13C")]
	[CalledBy(Type = "Polytoria.UI.ChatWindow", Member = "set_state", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.UI.ChatWindowState"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "Focus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60003CE")]
	public void ActivateInputField() { }

	[Address(RVA = "0x18A2E10", Offset = "0x18A2010", Length = "0x4D8")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_InputField), Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(int)}, ReturnType = typeof(TouchScreenKeyboard))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_hideInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideMobileInput", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_inputSystem", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideSoftKeyboard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003CF")]
	private void ActivateInputFieldInternal() { }

	[Address(RVA = "0x18A3430", Offset = "0x18A2630", Length = "0x785")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003CC")]
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	[Address(RVA = "0x18A3BC0", Offset = "0x18A2DC0", Length = "0x23F")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnScrollbarValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_Text), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003BA")]
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	[Address(RVA = "0x18A3EB0", Offset = "0x18A30B0", Length = "0x60A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003AA")]
	protected override void Append(char input) { }

	[Address(RVA = "0x18A3E00", Offset = "0x18A3000", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003A9")]
	protected override void Append(string input) { }

	[Address(RVA = "0x18A44C0", Offset = "0x18A36C0", Length = "0x772")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "AdjustTextPositionRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "AdjustRectTransformRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003C7")]
	private void AssignPositioningIfNeeded() { }

	[Address(RVA = "0x18A4C40", Offset = "0x18A3E40", Length = "0x487")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringSelectPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60003A8")]
	private void Backspace() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E0")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E1")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x18A50D0", Offset = "0x18A42D0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<CaretBlink>d__293))]
	[Token(Token = "0x6000378")]
	private IEnumerator CaretBlink() { }

	[Address(RVA = "0x18A5140", Offset = "0x18A4340", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600035F")]
	private int ClampArrayIndex(int index) { }

	[Address(RVA = "0x18A5150", Offset = "0x18A4350", Length = "0x77")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600035E")]
	protected void ClampCaretPos(ref int pos) { }

	[Address(RVA = "0x18A51D0", Offset = "0x18A43D0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600035D")]
	protected void ClampStringPos(ref int pos) { }

	[Address(RVA = "0x18A5210", Offset = "0x18A4410", Length = "0x1B6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003CA")]
	private void CreateCursorVerts() { }

	[Address(RVA = "0x18A53D0", Offset = "0x18A45D0", Length = "0x263")]
	[CalledBy(Type = "Polytoria.UI.ChatWindow", Member = "set_state", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.UI.ChatWindowState"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_InputField), Member = "ReleaseSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_InputField), Member = "get_inputSystem", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60003D4")]
	public void DeactivateInputField(bool clearSelection = false) { }

	[Address(RVA = "0x18A5A10", Offset = "0x18A4C10", Length = "0x3B7")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003A6")]
	private void Delete() { }

	[Address(RVA = "0x18A5640", Offset = "0x18A4840", Length = "0x3C6")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x60003A7")]
	private void DeleteKey() { }

	[Address(RVA = "0x18A5DD0", Offset = "0x18A4FD0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003DF")]
	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	[Address(RVA = "0x18A5E00", Offset = "0x18A5000", Length = "0x1D4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_textWrappingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWrappingModes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003D9")]
	private void EnforceContentType() { }

	[Address(RVA = "0x18A6000", Offset = "0x18A5200", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000396")]
	private int FindNextWordBegin() { }

	[Address(RVA = "0x18A6120", Offset = "0x18A5320", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000398")]
	private int FindPrevWordBegin() { }

	[Address(RVA = "0x18A6230", Offset = "0x18A5430", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Token(Token = "0x60003C1")]
	public void ForceLabelUpdate() { }

	[Address(RVA = "0x18A6240", Offset = "0x18A5440", Length = "0xD56")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_inputSystem", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransformUtility), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(TMP_InputField), Member = "AdjustRectTransformRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003C9")]
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	[Address(RVA = "0x18A6FA0", Offset = "0x18A61A0", Length = "0xA10")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_InputField), Member = "AdjustRectTransformRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60003CB")]
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	[Address(RVA = "0x18B1480", Offset = "0x18B0680", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600035A")]
	public char get_asteriskChar() { }

	[Address(RVA = "0x4761D0", Offset = "0x4753D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000310")]
	public float get_caretBlinkRate() { }

	[Address(RVA = "0x18B1490", Offset = "0x18B0690", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600031E")]
	public Color get_caretColor() { }

	[Address(RVA = "0x18B1530", Offset = "0x18B0730", Length = "0x3B")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000369")]
	public int get_caretPosition() { }

	[Address(RVA = "0x18B14F0", Offset = "0x18B06F0", Length = "0x3B")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000360")]
	protected int get_caretPositionInternal() { }

	[Address(RVA = "0x18B1530", Offset = "0x18B0730", Length = "0x3B")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000364")]
	protected int get_caretSelectPositionInternal() { }

	[Address(RVA = "0x49B740", Offset = "0x49A940", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000312")]
	public int get_caretWidth() { }

	[Address(RVA = "0x18B1570", Offset = "0x18B0770", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000336")]
	public int get_characterLimit() { }

	[Address(RVA = "0x18B1580", Offset = "0x18B0780", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000351")]
	public CharacterValidation get_characterValidation() { }

	[Address(RVA = "0x18B1590", Offset = "0x18B0790", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
	[Token(Token = "0x6000381")]
	private static string get_clipboard() { }

	[Address(RVA = "0x18B15D0", Offset = "0x18B07D0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000300")]
	private int get_compositionLength() { }

	[Address(RVA = "0x18B1600", Offset = "0x18B0800", Length = "0xA2")]
	[CallerCount(Count = 128)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "get_inputSystem", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002FF")]
	private string get_compositionString() { }

	[Address(RVA = "0x18B16B0", Offset = "0x18B08B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000346")]
	public ContentType get_contentType() { }

	[Address(RVA = "0x18B16C0", Offset = "0x18B08C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000320")]
	public bool get_customCaretColor() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E7")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E4")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x1551CC0", Offset = "0x1550EC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033A")]
	public TMP_FontAsset get_fontAsset() { }

	[Address(RVA = "0x18B16E0", Offset = "0x18B08E0", Length = "0x80")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "GetSelectedString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(<CaretBlink>d__293), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000368")]
	private bool get_hasSelection() { }

	[Address(RVA = "0x18B1770", Offset = "0x18B0970", Length = "0xFB")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002FE")]
	private BaseInput get_inputSystem() { }

	[Address(RVA = "0x18B1870", Offset = "0x18B0A70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600034C")]
	public InputType get_inputType() { }

	[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000353")]
	public TMP_InputValidator get_inputValidator() { }

	[Address(RVA = "0x18B1890", Offset = "0x18B0A90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600030F")]
	public bool get_isFocused() { }

	[Address(RVA = "0x18B18A0", Offset = "0x18B0AA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000344")]
	public bool get_isRichTextEditingAllowed() { }

	[Address(RVA = "0x18B18B0", Offset = "0x18B0AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000340")]
	public bool get_keepTextSelectionVisible() { }

	[Address(RVA = "0x18B18C0", Offset = "0x18B0AC0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600034F")]
	public TouchScreenKeyboardType get_keyboardType() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E8")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x18B18D0", Offset = "0x18B0AD0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600034A")]
	public int get_lineLimit() { }

	[Address(RVA = "0x18B18E0", Offset = "0x18B0AE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000348")]
	public LineType get_lineType() { }

	[Address(RVA = "0x18B18F0", Offset = "0x18B0AF0", Length = "0xA3")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000302")]
	protected Mesh get_mesh() { }

	[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E5")]
	public override float get_minHeight() { }

	[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E2")]
	public override float get_minWidth() { }

	[Address(RVA = "0x18B19A0", Offset = "0x18B0BA0", Length = "0x17")]
	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000359")]
	public bool get_multiLine() { }

	[Address(RVA = "0x189D830", Offset = "0x189CA30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600032A")]
	public SelectionEvent get_onDeselect() { }

	[Address(RVA = "0x3D6750", Offset = "0x3D5950", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000324")]
	public SubmitEvent get_onEndEdit() { }

	[Address(RVA = "0x18B19C0", Offset = "0x18B0BC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600032E")]
	public TextSelectionEvent get_onEndTextSelection() { }

	[Address(RVA = "0x18B19D0", Offset = "0x18B0BD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600033C")]
	public bool get_onFocusSelectAll() { }

	[Address(RVA = "0x497990", Offset = "0x496B90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000328")]
	public SelectionEvent get_onSelect() { }

	[Address(RVA = "0x3D67E0", Offset = "0x3D59E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000326")]
	public SubmitEvent get_onSubmit() { }

	[Address(RVA = "0x18B19E0", Offset = "0x18B0BE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600032C")]
	public TextSelectionEvent get_onTextSelection() { }

	[Address(RVA = "0x18B19F0", Offset = "0x18B0BF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000332")]
	public TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	[Address(RVA = "0x1551D80", Offset = "0x1550F80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000334")]
	public OnValidateInput get_onValidateInput() { }

	[Address(RVA = "0x18B1A00", Offset = "0x18B0C00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000330")]
	public OnChangeEvent get_onValueChanged() { }

	[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000318")]
	public Graphic get_placeholder() { }

	[Address(RVA = "0x18B1A10", Offset = "0x18B0C10", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000338")]
	public float get_pointSize() { }

	[Address(RVA = "0x18B1A20", Offset = "0x18B0C20", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003E6")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x18B1B90", Offset = "0x18B0D90", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003E3")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x18B1D00", Offset = "0x18B0F00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000355")]
	public bool get_readOnly() { }

	[Address(RVA = "0x18B1D10", Offset = "0x18B0F10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600033E")]
	public bool get_resetOnDeActivation() { }

	[Address(RVA = "0x18B1D20", Offset = "0x18B0F20", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000342")]
	public bool get_restoreOriginalTextOnEscape() { }

	[Address(RVA = "0x18B1D30", Offset = "0x18B0F30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000357")]
	public bool get_richText() { }

	[Address(RVA = "0x18B1D40", Offset = "0x18B0F40", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600031C")]
	public float get_scrollSensitivity() { }

	[Address(RVA = "0x18B14F0", Offset = "0x18B06F0", Length = "0x3B")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600036B")]
	public int get_selectionAnchorPosition() { }

	[Address(RVA = "0x18B1D50", Offset = "0x18B0F50", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000322")]
	public Color get_selectionColor() { }

	[Address(RVA = "0x18B1530", Offset = "0x18B0730", Length = "0x3B")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600036D")]
	public int get_selectionFocusPosition() { }

	[Address(RVA = "0x18B1D60", Offset = "0x18B0F60", Length = "0x3B")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000371")]
	public int get_selectionStringAnchorPosition() { }

	[Address(RVA = "0x18B1DA0", Offset = "0x18B0FA0", Length = "0x3B")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000373")]
	public int get_selectionStringFocusPosition() { }

	[Address(RVA = "0x18B1DE0", Offset = "0x18B0FE0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000304")]
	public override bool get_shouldActivateOnSelect() { }

	[Address(RVA = "0x18B1E40", Offset = "0x18B1040", Length = "0x6F")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Token(Token = "0x6000305")]
	public bool get_shouldHideMobileInput() { }

	[Address(RVA = "0x18B1EB0", Offset = "0x18B10B0", Length = "0x8C")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Token(Token = "0x6000307")]
	public bool get_shouldHideSoftKeyboard() { }

	[Address(RVA = "0x18B1DA0", Offset = "0x18B0FA0", Length = "0x3B")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600036F")]
	public int get_stringPosition() { }

	[Address(RVA = "0x18B1D60", Offset = "0x18B0F60", Length = "0x3B")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000362")]
	protected int get_stringPositionInternal() { }

	[Address(RVA = "0x18B1DA0", Offset = "0x18B0FA0", Length = "0x3B")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000366")]
	protected int get_stringSelectPositionInternal() { }

	[Address(RVA = "0x408980", Offset = "0x407B80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600030B")]
	public string get_text() { }

	[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000316")]
	public TMP_Text get_textComponent() { }

	[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000314")]
	public RectTransform get_textViewport() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034E")]
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600031A")]
	public Scrollbar get_verticalScrollbar() { }

	[Address(RVA = "0x18B1F40", Offset = "0x18B1140", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600035C")]
	public bool get_wasCanceled() { }

	[Address(RVA = "0x18A79C0", Offset = "0x18A6BC0", Length = "0xBF")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003BB")]
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	[Address(RVA = "0x18A79C0", Offset = "0x18A6BC0", Length = "0xBF")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003BD")]
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	[Address(RVA = "0x18A7A80", Offset = "0x18A6C80", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003BC")]
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	[Address(RVA = "0x18A7B90", Offset = "0x18A6D90", Length = "0x1A9")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateScrollbar", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000394")]
	private float GetScrollPositionRelativeToViewport() { }

	[Address(RVA = "0x18A7D40", Offset = "0x18A6F40", Length = "0xDE")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000395")]
	private string GetSelectedString() { }

	[Address(RVA = "0x18A7E20", Offset = "0x18A7020", Length = "0xA8")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveTextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveTextStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateStringIndexFromCaretPosition", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003BE")]
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C5")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x18A7F50", Offset = "0x18A7150", Length = "0x78")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "isKeyboardUsingEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideMobileInput", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideSoftKeyboard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "isUWP", ReturnType = typeof(bool))]
	[Token(Token = "0x6000383")]
	private bool InPlaceEditing() { }

	[Address(RVA = "0x18A7ED0", Offset = "0x18A70D0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000384")]
	private bool InPlaceEditingChanged() { }

	[Address(RVA = "0x18A7FD0", Offset = "0x18A71D0", Length = "0x17F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003AB")]
	private void Insert(char c) { }

	[Address(RVA = "0x18B1F50", Offset = "0x18B1150", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000309")]
	private bool isKeyboardUsingEvents() { }

	[Address(RVA = "0x18B2050", Offset = "0x18B1250", Length = "0x90")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600030A")]
	private bool isUWP() { }

	[Address(RVA = "0x18A8150", Offset = "0x18A7350", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000390")]
	protected override bool IsValidChar(char c) { }

	[Address(RVA = "0x18A8170", Offset = "0x18A7370", Length = "0x4A0")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveToEndOfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveToStartOfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetSelectedString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600038F")]
	protected EditState KeyPressed(Event evt) { }

	[Address(RVA = "0x18A8640", Offset = "0x18A7840", Length = "0x404")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "ReleaseSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1818A8FF3")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000388")]
	protected override void LateUpdate() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C4")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x18A9080", Offset = "0x18A8280", Length = "0x2E4")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600039B")]
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	[Address(RVA = "0x18A9370", Offset = "0x18A8570", Length = "0x2A6")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600039A")]
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	[Address(RVA = "0x18A9620", Offset = "0x18A8820", Length = "0x49")]
	[CalledBy(Type = typeof(<CaretBlink>d__293), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003C2")]
	private void MarkGeometryAsDirty() { }

	[Address(RVA = "0x18A9670", Offset = "0x18A8870", Length = "0xEA")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideSoftKeyboard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideMobileInput", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000389")]
	private bool MayDrag(PointerEventData eventData) { }

	[Address(RVA = "0x18A9760", Offset = "0x18A8960", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__314))]
	[Token(Token = "0x600038C")]
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	[Address(RVA = "0x18A97F0", Offset = "0x18A89F0", Length = "0x2B3")]
	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600039F")]
	private void MoveDown(bool shift, bool goToLastChar) { }

	[Address(RVA = "0x18A9AB0", Offset = "0x18A8CB0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600039E")]
	private void MoveDown(bool shift) { }

	[Address(RVA = "0x18A9AC0", Offset = "0x18A8CC0", Length = "0x755")]
	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000399")]
	private void MoveLeft(bool shift, bool ctrl) { }

	[Address(RVA = "0x18AA220", Offset = "0x18A9420", Length = "0x42E")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "PageDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textBounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x60003A5")]
	private void MovePageDown(bool shift, bool goToLastChar) { }

	[Address(RVA = "0x18AA650", Offset = "0x18A9850", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003A4")]
	private void MovePageDown(bool shift) { }

	[Address(RVA = "0x18AAA80", Offset = "0x18A9C80", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003A2")]
	private void MovePageUp(bool shift) { }

	[Address(RVA = "0x18AA660", Offset = "0x18A9860", Length = "0x416")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "PageUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textBounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Token(Token = "0x60003A3")]
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	[Address(RVA = "0x18AAA90", Offset = "0x18A9C90", Length = "0x865")]
	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000397")]
	private void MoveRight(bool shift, bool ctrl) { }

	[Address(RVA = "0x18AB300", Offset = "0x18AA500", Length = "0x1E7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600037D")]
	public void MoveTextEnd(bool shift) { }

	[Address(RVA = "0x18AB4F0", Offset = "0x18AA6F0", Length = "0x159")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600037E")]
	public void MoveTextStart(bool shift) { }

	[Address(RVA = "0x18AB650", Offset = "0x18AA850", Length = "0x288")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600037F")]
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	[Address(RVA = "0x18AB8E0", Offset = "0x18AAAE0", Length = "0x2D4")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000380")]
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	[Address(RVA = "0x18ABBD0", Offset = "0x18AADD0", Length = "0x290")]
	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A1")]
	private void MoveUp(bool shift, bool goToFirstChar) { }

	[Address(RVA = "0x18ABBC0", Offset = "0x18AADC0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60003A0")]
	private void MoveUp(bool shift) { }

	[Address(RVA = "0x18ABE70", Offset = "0x18AB070", Length = "0x1E1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateCaretPositionFromStringIndex", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Scrollbar), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetScrollPositionRelativeToViewport", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scrollbar), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000377")]
	private void ON_TEXT_CHANGED(object obj) { }

	[Address(RVA = "0x18AC060", Offset = "0x18AB260", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600038A")]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x18AC090", Offset = "0x18AB290", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60003D7")]
	public override void OnCancel(BaseEventData eventData) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D2")]
	public void OnControlClick() { }

	[Address(RVA = "0x18AC130", Offset = "0x18AB330", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003D5")]
	public virtual void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x18AC1B0", Offset = "0x18AB3B0", Length = "0x366")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000376")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x18AC520", Offset = "0x18AB720", Length = "0x4C4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera), typeof(CaretPosition&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600038B")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x18AC9F0", Offset = "0x18ABBF0", Length = "0x89F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(TMP_InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetAsFirstSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SystemInfo), Member = "get_operatingSystem", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000375")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x18AD290", Offset = "0x18AC490", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600038D")]
	public override void OnEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x18AD2C0", Offset = "0x18AC4C0", Length = "0x2C5")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateStringIndexFromCaretPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`3), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180739630")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnEndTextSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateCaretPositionFromStringIndex", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003C8")]
	private void OnFillVBO(Mesh vbo) { }

	[Address(RVA = "0x18AD590", Offset = "0x18AC790", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Token(Token = "0x600037B")]
	protected void OnFocus() { }

	[Address(RVA = "0x18AD5B0", Offset = "0x18AC7B0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003D8")]
	public virtual void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x18AD5D0", Offset = "0x18AC7D0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003D1")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x18AD600", Offset = "0x18AC800", Length = "0x980")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "FindIntersectingWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringSelectPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera), typeof(CaretPosition&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600038E")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x18ADF90", Offset = "0x18AD190", Length = "0x22A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetScrollPositionRelativeToViewport", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "AdjustTextPositionRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000393")]
	public override void OnScroll(PointerEventData eventData) { }

	[Address(RVA = "0x18AE1C0", Offset = "0x18AD3C0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "AdjustTextPositionRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003B8")]
	private void OnScrollbarValueChange(float value) { }

	[Address(RVA = "0x18AE200", Offset = "0x18AD400", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003D0")]
	public virtual void OnSelect(BaseEventData eventData) { }

	[Address(RVA = "0x18AE280", Offset = "0x18AD480", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60003D6")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x18AE350", Offset = "0x18AD550", Length = "0x203")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "PopEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnSubmit", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000392")]
	public override void OnUpdateSelected(BaseEventData eventData) { }

	[Address(RVA = "0x18AE560", Offset = "0x18AD760", Length = "0x3FE")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600039D")]
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	[Address(RVA = "0x18AE960", Offset = "0x18ADB60", Length = "0x38F")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600039C")]
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	[Address(RVA = "0x18AECF0", Offset = "0x18ADEF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[Token(Token = "0x6000391")]
	public void ProcessEvent(Event e) { }

	[Address(RVA = "0x18AED00", Offset = "0x18ADF00", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "isUWP", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003C3")]
	public override void Rebuild(CanvasUpdate update) { }

	[Address(RVA = "0x18AEDD0", Offset = "0x18ADFD0", Length = "0xB5")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnEndTextSelection", ReturnType = typeof(void))]
	[Token(Token = "0x60003D3")]
	public void ReleaseSelection() { }

	[Address(RVA = "0x18AEE90", Offset = "0x18AE090", Length = "0x76")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFocus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600037C")]
	protected void SelectAll() { }

	[Address(RVA = "0x18AEF10", Offset = "0x18AE110", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003AF")]
	protected void SendOnEndEdit() { }

	[Address(RVA = "0x18AEF70", Offset = "0x18AE170", Length = "0x100")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ReleaseSelection", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEvent`3), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003B4")]
	protected void SendOnEndTextSelection() { }

	[Address(RVA = "0x18AF0E0", Offset = "0x18AE2E0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003B1")]
	protected void SendOnFocus() { }

	[Address(RVA = "0x18AF080", Offset = "0x18AE280", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003B2")]
	protected void SendOnFocusLost() { }

	[Address(RVA = "0x18AF140", Offset = "0x18AE340", Length = "0x54")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003B0")]
	protected void SendOnSubmit() { }

	[Address(RVA = "0x18AF1A0", Offset = "0x18AE3A0", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEvent`3), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003B3")]
	protected void SendOnTextSelection() { }

	[Address(RVA = "0x18AF300", Offset = "0x18AE500", Length = "0x54")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003AE")]
	private void SendOnValueChanged() { }

	[Address(RVA = "0x18AF2A0", Offset = "0x18AE4A0", Length = "0x5B")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003AD")]
	private void SendOnValueChangedAndUpdateLabel() { }

	[Address(RVA = "0x18AF360", Offset = "0x18AE560", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_status", ReturnType = typeof(Status))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Int32Enum>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(void))]
	[Token(Token = "0x60003B5")]
	protected void SendTouchScreenKeyboardStatusChanged() { }

	[Address(RVA = "0x18B20E0", Offset = "0x18B12E0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Token(Token = "0x600035B")]
	public void set_asteriskChar(char value) { }

	[Address(RVA = "0x18B2140", Offset = "0x18B1340", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000311")]
	public void set_caretBlinkRate(float value) { }

	[Address(RVA = "0x18B21B0", Offset = "0x18B13B0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600031F")]
	public void set_caretColor(Color value) { }

	[Address(RVA = "0x18B2240", Offset = "0x18B1440", Length = "0x9F")]
	[CalledBy(Type = "Polytoria.UI.UICommandList", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateStringIndexFromCaretPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600036A")]
	public void set_caretPosition(int value) { }

	[Address(RVA = "0x18B2220", Offset = "0x18B1420", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000361")]
	protected void set_caretPositionInternal(int value) { }

	[Address(RVA = "0x18B22E0", Offset = "0x18B14E0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000365")]
	protected void set_caretSelectPositionInternal(int value) { }

	[Address(RVA = "0x18B2300", Offset = "0x18B1500", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000313")]
	public void set_caretWidth(int value) { }

	[Address(RVA = "0x18B2390", Offset = "0x18B1590", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000337")]
	public void set_characterLimit(int value) { }

	[Address(RVA = "0x18B2440", Offset = "0x18B1640", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000352")]
	public void set_characterValidation(CharacterValidation value) { }

	[Address(RVA = "0x18B24B0", Offset = "0x18B16B0", Length = "0x49")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000382")]
	private static void set_clipboard(string value) { }

	[Address(RVA = "0x18B2500", Offset = "0x18B1700", Length = "0x210")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustomIfContentTypeIsNot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_inputValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_InputValidator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_characterValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_inputType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustom", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_keyboardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboardType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_textWrappingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWrappingModes)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000347")]
	public void set_contentType(ContentType value) { }

	[Address(RVA = "0x18B2740", Offset = "0x18B1940", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000321")]
	public void set_customCaretColor(bool value) { }

	[Address(RVA = "0x18B27A0", Offset = "0x18B19A0", Length = "0x134")]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600033B")]
	public void set_fontAsset(TMP_FontAsset value) { }

	[Address(RVA = "0x18B28E0", Offset = "0x18B1AE0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Token(Token = "0x600034D")]
	public void set_inputType(InputType value) { }

	[Address(RVA = "0x18B2950", Offset = "0x18B1B50", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000354")]
	public void set_inputValidator(TMP_InputValidator value) { }

	[Address(RVA = "0x18B29C0", Offset = "0x18B1BC0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000345")]
	public void set_isRichTextEditingAllowed(bool value) { }

	[Address(RVA = "0x18B29D0", Offset = "0x18B1BD0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000341")]
	public void set_keepTextSelectionVisible(bool value) { }

	[Address(RVA = "0x18B29E0", Offset = "0x18B1BE0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000350")]
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	[Address(RVA = "0x18B2A50", Offset = "0x18B1C50", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600034B")]
	public void set_lineLimit(int value) { }

	[Address(RVA = "0x18B2AC0", Offset = "0x18B1CC0", Length = "0xD7")]
	[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_IsMultiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000349")]
	public void set_lineType(LineType value) { }

	[Address(RVA = "0x18B2BA0", Offset = "0x18B1DA0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600032B")]
	public void set_onDeselect(SelectionEvent value) { }

	[Address(RVA = "0x18B2BF0", Offset = "0x18B1DF0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000325")]
	public void set_onEndEdit(SubmitEvent value) { }

	[Address(RVA = "0x18B2C40", Offset = "0x18B1E40", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600032F")]
	public void set_onEndTextSelection(TextSelectionEvent value) { }

	[Address(RVA = "0x18B2C90", Offset = "0x18B1E90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600033D")]
	public void set_onFocusSelectAll(bool value) { }

	[Address(RVA = "0x18B2CA0", Offset = "0x18B1EA0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000329")]
	public void set_onSelect(SelectionEvent value) { }

	[Address(RVA = "0x18B2CF0", Offset = "0x18B1EF0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000327")]
	public void set_onSubmit(SubmitEvent value) { }

	[Address(RVA = "0x18B2D40", Offset = "0x18B1F40", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600032D")]
	public void set_onTextSelection(TextSelectionEvent value) { }

	[Address(RVA = "0x18B2D90", Offset = "0x18B1F90", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000333")]
	public void set_onTouchScreenKeyboardStatusChanged(TouchScreenKeyboardEvent value) { }

	[Address(RVA = "0x18B2DE0", Offset = "0x18B1FE0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000335")]
	public void set_onValidateInput(OnValidateInput value) { }

	[Address(RVA = "0x18B2E30", Offset = "0x18B2030", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000331")]
	public void set_onValueChanged(OnChangeEvent value) { }

	[Address(RVA = "0x18B2E80", Offset = "0x18B2080", Length = "0x4C")]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000319")]
	public void set_placeholder(Graphic value) { }

	[Address(RVA = "0x18B2ED0", Offset = "0x18B20D0", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000339")]
	public void set_pointSize(float value) { }

	[Address(RVA = "0x18B3040", Offset = "0x18B2240", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000356")]
	public void set_readOnly(bool value) { }

	[Address(RVA = "0x18B3050", Offset = "0x18B2250", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600033F")]
	public void set_resetOnDeActivation(bool value) { }

	[Address(RVA = "0x18B3060", Offset = "0x18B2260", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000343")]
	public void set_restoreOriginalTextOnEscape(bool value) { }

	[Address(RVA = "0x18B3070", Offset = "0x18B2270", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_richText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000358")]
	public void set_richText(bool value) { }

	[Address(RVA = "0x18B3100", Offset = "0x18B2300", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600031D")]
	public void set_scrollSensitivity(float value) { }

	[Address(RVA = "0x18B3190", Offset = "0x18B2390", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600036C")]
	public void set_selectionAnchorPosition(int value) { }

	[Address(RVA = "0x18B31F0", Offset = "0x18B23F0", Length = "0x6F")]
	[CalledBy(Type = "Battlehub.UIControls.UIStyle", Member = "ApplyInputFieldColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Color), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000323")]
	public void set_selectionColor(Color value) { }

	[Address(RVA = "0x18B3260", Offset = "0x18B2460", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600036E")]
	public void set_selectionFocusPosition(int value) { }

	[Address(RVA = "0x18B32C0", Offset = "0x18B24C0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000372")]
	public void set_selectionStringAnchorPosition(int value) { }

	[Address(RVA = "0x18B3350", Offset = "0x18B2550", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000374")]
	public void set_selectionStringFocusPosition(int value) { }

	[Address(RVA = "0xFA13E0", Offset = "0xFA05E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000303")]
	public override void set_shouldActivateOnSelect(bool value) { }

	[Address(RVA = "0x18B33E0", Offset = "0x18B25E0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000306")]
	public void set_shouldHideMobileInput(bool value) { }

	[Address(RVA = "0x18B3480", Offset = "0x18B2680", Length = "0x141")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000308")]
	public void set_shouldHideSoftKeyboard(bool value) { }

	[Address(RVA = "0x18B3620", Offset = "0x18B2820", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateCaretPositionFromStringIndex", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000370")]
	public void set_stringPosition(int value) { }

	[Address(RVA = "0x18B35D0", Offset = "0x18B27D0", Length = "0x46")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000363")]
	protected void set_stringPositionInternal(int value) { }

	[Address(RVA = "0x18B3700", Offset = "0x18B2900", Length = "0x46")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000367")]
	protected void set_stringSelectPositionInternal(int value) { }

	[Address(RVA = "0x18B3800", Offset = "0x18B2A00", Length = "0xB")]
	[CalledBy(Type = "HSVPicker.HexColorField", Member = "UpdateHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemInteger", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "SendChat", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemNumberRange", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemFloat", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemVector2", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemVector3", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.AbuseReportController", Member = "Return", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.AbuseReportController", Member = "Cancel", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController", Member = "<Start>b__19_0", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadControls", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemString", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadMiscControls", ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600030C")]
	public void set_text(string value) { }

	[Address(RVA = "0x18B3750", Offset = "0x18B2950", Length = "0x5B")]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000317")]
	public void set_textComponent(TMP_Text value) { }

	[Address(RVA = "0x18B37B0", Offset = "0x18B29B0", Length = "0x4C")]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000315")]
	public void set_textViewport(RectTransform value) { }

	[Address(RVA = "0x18B3810", Offset = "0x18B2A10", Length = "0x19D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600031B")]
	public void set_verticalScrollbar(Scrollbar value) { }

	[Address(RVA = "0x18AF3D0", Offset = "0x18AE5D0", Length = "0xC3")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_caretBlinkRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetCaretVisible", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600037A")]
	private void SetCaretActive() { }

	[Address(RVA = "0x18AF4A0", Offset = "0x18AE6A0", Length = "0x3D")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	[Token(Token = "0x6000379")]
	private void SetCaretVisible() { }

	[Address(RVA = "0x18AF4E0", Offset = "0x18AE6E0", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003EA")]
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x18AF5D0", Offset = "0x18AE7D0", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003E9")]
	public void SetGlobalPointSize(float pointSize) { }

	[Address(RVA = "0x18AF810", Offset = "0x18AEA10", Length = "0x16C")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600030E")]
	private void SetText(string value, bool sendCallback = true) { }

	[Address(RVA = "0x18AF6C0", Offset = "0x18AE8C0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_richText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003DB")]
	private void SetTextComponentRichTextMode() { }

	[Address(RVA = "0x18AF750", Offset = "0x18AE950", Length = "0xAD")]
	[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_textComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_textWrappingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWrappingModes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003DA")]
	private void SetTextComponentWrapMode() { }

	[Address(RVA = "0x18AF800", Offset = "0x18AEA00", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600030D")]
	public void SetTextWithoutNotify(string input) { }

	[Address(RVA = "0x18AF9F0", Offset = "0x18AEBF0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DD")]
	private void SetToCustom() { }

	[Address(RVA = "0x18AF9F0", Offset = "0x18AEBF0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DE")]
	private void SetToCustom(CharacterValidation characterValidation) { }

	[Address(RVA = "0x18AF980", Offset = "0x18AEB80", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003DC")]
	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	[Address(RVA = "0x18AFA10", Offset = "0x18AEC10", Length = "0x97")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Token(Token = "0x6000385")]
	private bool TouchScreenKeyboardShouldBeUsed() { }

	[Address(RVA = "0x1094810", Offset = "0x1093A10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EC")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x18AFAB0", Offset = "0x18AECB0", Length = "0xC3")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_stringPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60003C0")]
	private void UpdateCaretPositionFromStringIndex() { }

	[Address(RVA = "0x18AFB80", Offset = "0x18AED80", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "isUWP", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003C6")]
	private void UpdateGeometry() { }

	[Address(RVA = "0x18AFC40", Offset = "0x18AEE40", Length = "0x1C0")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canSetSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180538B70")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000386")]
	private void UpdateKeyboardStringPosition() { }

	[Address(RVA = "0x18AFE10", Offset = "0x18AF010", Length = "0x595")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ForceLabelUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveToEndOfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveToStartOfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveTextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_asteriskChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_fontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_pointSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveTextStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetCaretVisible", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TMP_InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60003B6")]
	protected void UpdateLabel() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B9")]
	private void UpdateMaskRegions() { }

	[Address(RVA = "0x18B03B0", Offset = "0x18AF5B0", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Scrollbar), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetScrollPositionRelativeToViewport", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scrollbar), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003B7")]
	private void UpdateScrollbar() { }

	[Address(RVA = "0x18B04B0", Offset = "0x18AF6B0", Length = "0xC5")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_caretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003BF")]
	private void UpdateStringIndexFromCaretPosition() { }

	[Address(RVA = "0x18B0580", Offset = "0x18AF780", Length = "0x1ED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_selection", ReturnType = typeof(RangeInt))]
	[Calls(Type = typeof(RangeInt), Member = "get_end", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000387")]
	private void UpdateStringPositionFromKeyboard() { }

	[Address(RVA = "0x18B0770", Offset = "0x18AF970", Length = "0x49")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003AC")]
	private void UpdateTouchKeyboardFromEditChanges() { }

	[Address(RVA = "0x18B07C0", Offset = "0x18AF9C0", Length = "0x8D4")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringSelectPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003CD")]
	protected char Validate(string text, int pos, char ch) { }

}

