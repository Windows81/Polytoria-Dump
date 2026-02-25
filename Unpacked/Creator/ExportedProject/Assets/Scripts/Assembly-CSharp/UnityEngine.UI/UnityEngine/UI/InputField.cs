namespace UnityEngine.UI;

[AddComponentMenu("UI/Legacy/Input Field", 103)]
[Token(Token = "0x200002E")]
public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
{
	[CompilerGenerated]
	[Token(Token = "0x2000038")]
	private sealed class <CaretBlink>d__170 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000121")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000122")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000123")]
		public InputField <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000095")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000241")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000096")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000243")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600023E")]
		public <CaretBlink>d__170(int <>1__state) { }

		[Address(RVA = "0x1CC7260", Offset = "0x1CC6460", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
		[Calls(Type = typeof(InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000240")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000241")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000243")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1CC73B0", Offset = "0x1CC65B0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000242")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600023F")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000039")]
	private sealed class <MouseDragOutsideRect>d__194 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000124")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000125")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000126")]
		public PointerEventData eventData; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000127")]
		public InputField <>4__this; //Field offset: 0x28

		[Token(Token = "0x17000097")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000247")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000098")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000249")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000244")]
		public <MouseDragOutsideRect>d__194(int <>1__state) { }

		[Address(RVA = "0x1CC74C0", Offset = "0x1CC66C0", Length = "0x3B7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(WaitForSecondsRealtime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Vector2&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[Token(Token = "0x6000246")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000247")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000249")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1CC7880", Offset = "0x1CC6A80", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000248")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000245")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000031")]
	internal enum CharacterValidation
	{
		None = 0,
		Integer = 1,
		Decimal = 2,
		Alphanumeric = 3,
		Name = 4,
		EmailAddress = 5,
	}

	[Token(Token = "0x200002F")]
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

	[Token(Token = "0x2000037")]
	internal enum EditState
	{
		Continue = 0,
		Finish = 1,
	}

	[Token(Token = "0x2000035")]
	internal class EndEditEvent : UnityEvent<String>
	{

		[Address(RVA = "0x1CB3130", Offset = "0x1CB2330", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600023C")]
		public EndEditEvent() { }

	}

	[Token(Token = "0x2000030")]
	internal enum InputType
	{
		Standard = 0,
		AutoCorrect = 1,
		Password = 2,
	}

	[Token(Token = "0x2000032")]
	internal enum LineType
	{
		SingleLine = 0,
		MultiLineSubmit = 1,
		MultiLineNewline = 2,
	}

	[Token(Token = "0x2000036")]
	internal class OnChangeEvent : UnityEvent<String>
	{

		[Address(RVA = "0x1CC71E0", Offset = "0x1CC63E0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600023D")]
		public OnChangeEvent() { }

	}

	[Token(Token = "0x2000033")]
	internal sealed class OnValidateInput : MulticastDelegate
	{

		[Address(RVA = "0x18DE3F0", Offset = "0x18DD5F0", Length = "0xB5")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000237")]
		public OnValidateInput(object object, IntPtr method) { }

		[Address(RVA = "0x18DE350", Offset = "0x18DD550", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000239")]
		public override IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

		[Address(RVA = "0x18DE3C0", Offset = "0x18DD5C0", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600023A")]
		public override char EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000238")]
		public override char Invoke(string text, int charIndex, char addedChar) { }

	}

	[Token(Token = "0x2000034")]
	internal class SubmitEvent : UnityEvent<String>
	{

		[Address(RVA = "0x1CC7220", Offset = "0x1CC6420", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600023B")]
		public SubmitEvent() { }

	}

	[Token(Token = "0x4000103")]
	private const int k_MaxTextLength = 16382; //Field offset: 0x0
	[Token(Token = "0x40000CE")]
	private static readonly Char[] kSeparators; //Field offset: 0x0
	[Token(Token = "0x4000101")]
	private const string kOculusQuestDeviceModel = "Oculus Quest"; //Field offset: 0x0
	[Token(Token = "0x4000100")]
	private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~"; //Field offset: 0x0
	[Token(Token = "0x40000F3")]
	private const float kVScrollSpeed = 0.1; //Field offset: 0x0
	[Token(Token = "0x40000F2")]
	private const float kHScrollSpeed = 0.05; //Field offset: 0x0
	[Token(Token = "0x40000CF")]
	private static bool s_IsQuestDevice; //Field offset: 0x8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40000CD")]
	protected TouchScreenKeyboard m_Keyboard; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[FormerlySerializedAs("text")]
	[SerializeField]
	[Token(Token = "0x40000D0")]
	protected Text m_TextComponent; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40000D1")]
	protected Graphic m_Placeholder; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x40000D2")]
	private ContentType m_ContentType; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[FormerlySerializedAs("inputType")]
	[SerializeField]
	[Token(Token = "0x40000D3")]
	private InputType m_InputType; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[FormerlySerializedAs("asteriskChar")]
	[SerializeField]
	[Token(Token = "0x40000D4")]
	private char m_AsteriskChar; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[FormerlySerializedAs("keyboardType")]
	[SerializeField]
	[Token(Token = "0x40000D5")]
	private TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x40000D6")]
	private LineType m_LineType; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[FormerlySerializedAs("hideMobileInput")]
	[SerializeField]
	[Token(Token = "0x40000D7")]
	private bool m_HideMobileInput; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[FormerlySerializedAs("validation")]
	[SerializeField]
	[Token(Token = "0x40000D8")]
	private CharacterValidation m_CharacterValidation; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[FormerlySerializedAs("characterLimit")]
	[SerializeField]
	[Token(Token = "0x40000D9")]
	private int m_CharacterLimit; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[FormerlySerializedAs("onSubmit")]
	[FormerlySerializedAs("m_OnSubmit")]
	[FormerlySerializedAs("m_EndEdit")]
	[FormerlySerializedAs("m_OnEndEdit")]
	[SerializeField]
	[Token(Token = "0x40000DA")]
	private SubmitEvent m_OnSubmit; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x40000DB")]
	private EndEditEvent m_OnDidEndEdit; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[FormerlySerializedAs("onValueChange")]
	[FormerlySerializedAs("m_OnValueChange")]
	[SerializeField]
	[Token(Token = "0x40000DC")]
	private OnChangeEvent m_OnValueChanged; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[FormerlySerializedAs("onValidateInput")]
	[SerializeField]
	[Token(Token = "0x40000DD")]
	private OnValidateInput m_OnValidateInput; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[FormerlySerializedAs("selectionColor")]
	[SerializeField]
	[Token(Token = "0x40000DE")]
	private Color m_CaretColor; //Field offset: 0x158
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x40000DF")]
	private bool m_CustomCaretColor; //Field offset: 0x168
	[FieldOffset(Offset = "0x16C")]
	[SerializeField]
	[Token(Token = "0x40000E0")]
	private Color m_SelectionColor; //Field offset: 0x16C
	[FieldOffset(Offset = "0x180")]
	[FormerlySerializedAs("mValue")]
	[Multiline]
	[SerializeField]
	[Token(Token = "0x40000E1")]
	protected string m_Text; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Range(0, 4)]
	[SerializeField]
	[Token(Token = "0x40000E2")]
	private float m_CaretBlinkRate; //Field offset: 0x188
	[FieldOffset(Offset = "0x18C")]
	[Range(1, 5)]
	[SerializeField]
	[Token(Token = "0x40000E3")]
	private int m_CaretWidth; //Field offset: 0x18C
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	[Token(Token = "0x40000E4")]
	private bool m_ReadOnly; //Field offset: 0x190
	[FieldOffset(Offset = "0x191")]
	[SerializeField]
	[Token(Token = "0x40000E5")]
	private bool m_ShouldActivateOnSelect; //Field offset: 0x191
	[FieldOffset(Offset = "0x194")]
	[Token(Token = "0x40000E6")]
	protected int m_CaretPosition; //Field offset: 0x194
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40000E7")]
	protected int m_CaretSelectPosition; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40000E8")]
	private RectTransform caretRectTrans; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40000E9")]
	protected UIVertex[] m_CursorVerts; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40000EA")]
	private TextGenerator m_InputTextCache; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40000EB")]
	private CanvasRenderer m_CachedInputRenderer; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40000EC")]
	private bool m_PreventFontCallback; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40000ED")]
	protected Mesh m_Mesh; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x40000EE")]
	private bool m_AllowInput; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D1")]
	[Token(Token = "0x40000EF")]
	private bool m_ShouldActivateNextUpdate; //Field offset: 0x1D1
	[FieldOffset(Offset = "0x1D2")]
	[Token(Token = "0x40000F0")]
	private bool m_UpdateDrag; //Field offset: 0x1D2
	[FieldOffset(Offset = "0x1D3")]
	[Token(Token = "0x40000F1")]
	private bool m_DragPositionOutOfBounds; //Field offset: 0x1D3
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x40000F4")]
	protected bool m_CaretVisible; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40000F5")]
	private Coroutine m_BlinkCoroutine; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x40000F6")]
	private float m_BlinkStartTime; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x40000F7")]
	protected int m_DrawStart; //Field offset: 0x1E4
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x40000F8")]
	protected int m_DrawEnd; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x40000F9")]
	private Coroutine m_DragCoroutine; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x40000FA")]
	private string m_OriginalText; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x40000FB")]
	private bool m_WasCanceled; //Field offset: 0x200
	[FieldOffset(Offset = "0x201")]
	[Token(Token = "0x40000FC")]
	private bool m_HasDoneFocusTransition; //Field offset: 0x201
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x40000FD")]
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x40000FE")]
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x210
	[FieldOffset(Offset = "0x211")]
	[Token(Token = "0x40000FF")]
	private bool m_IsCompositionActive; //Field offset: 0x211
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000102")]
	private Event m_ProcessingEvent; //Field offset: 0x218

	[Token(Token = "0x17000085")]
	public char asteriskChar
	{
		[Address(RVA = "0x1CBECF0", Offset = "0x1CBDEF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001C8")]
		 get { } //Length: 8
		[Address(RVA = "0x1CBF670", Offset = "0x1CBE870", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[Token(Token = "0x60001C9")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700006B")]
	protected TextGenerator cachedInputTextGenerator
	{
		[Address(RVA = "0x1CBED00", Offset = "0x1CBDF00", Length = "0x75")]
		[CalledBy(Type = typeof(InputField), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 29)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000196")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000070")]
	public float caretBlinkRate
	{
		[Address(RVA = "0x1CBED80", Offset = "0x1CBDF80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001A0")]
		 get { } //Length: 9
		[Address(RVA = "0x1CBF6D0", Offset = "0x1CBE8D0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
		[Token(Token = "0x60001A1")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000074")]
	public Color caretColor
	{
		[Address(RVA = "0x1CBED90", Offset = "0x1CBDF90", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 93
		[Address(RVA = "0x1CBF740", Offset = "0x1CBE940", Length = "0x6F")]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001A9")]
		 set { } //Length: 111
	}

	[Token(Token = "0x1700008A")]
	public int caretPosition
	{
		[Address(RVA = "0x1CBEE20", Offset = "0x1CBE020", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D1")]
		 get { } //Length: 40
		[Address(RVA = "0x1CBF800", Offset = "0x1CBEA00", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001D2")]
		 set { } //Length: 181
	}

	[Token(Token = "0x17000087")]
	protected int caretPositionInternal
	{
		[Address(RVA = "0x1CBEDF0", Offset = "0x1CBDFF0", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CC")]
		 get { } //Length: 40
		[Address(RVA = "0x1CBF7B0", Offset = "0x1CBE9B0", Length = "0x46")]
		[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001CD")]
		 set { } //Length: 70
	}

	[Token(Token = "0x17000088")]
	protected int caretSelectPositionInternal
	{
		[Address(RVA = "0x1CBEE20", Offset = "0x1CBE020", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CE")]
		 get { } //Length: 40
		[Address(RVA = "0x1CBF8C0", Offset = "0x1CBEAC0", Length = "0x46")]
		[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001CF")]
		 set { } //Length: 70
	}

	[Token(Token = "0x17000071")]
	public int caretWidth
	{
		[Address(RVA = "0x1CBEE50", Offset = "0x1CBE050", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001A2")]
		 get { } //Length: 7
		[Address(RVA = "0x1CBF910", Offset = "0x1CBEB10", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001A3")]
		 set { } //Length: 138
	}

	[Token(Token = "0x1700007C")]
	public int characterLimit
	{
		[Address(RVA = "0x17F8710", Offset = "0x17F7910", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B8")]
		 get { } //Length: 7
		[Address(RVA = "0x1CBF9A0", Offset = "0x1CBEBA0", Length = "0xA1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001B9")]
		 set { } //Length: 161
	}

	[Token(Token = "0x17000082")]
	public CharacterValidation characterValidation
	{
		[Address(RVA = "0x1890B10", Offset = "0x188FD10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C3")]
		 get { } //Length: 7
		[Address(RVA = "0x1CBFA50", Offset = "0x1CBEC50", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001C4")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700008D")]
	private static string clipboard
	{
		[Address(RVA = "0x1CBEE60", Offset = "0x1CBE060", Length = "0x40")]
		[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
		[Token(Token = "0x60001E2")]
		private get { } //Length: 64
		[Address(RVA = "0x1CBFAC0", Offset = "0x1CBECC0", Length = "0x49")]
		[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001E3")]
		private set { } //Length: 73
	}

	[Token(Token = "0x17000069")]
	private string compositionString
	{
		[Address(RVA = "0x1CBEEA0", Offset = "0x1CBE0A0", Length = "0xA2")]
		[CallerCount(Count = 112)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000193")]
		private get { } //Length: 162
	}

	[Token(Token = "0x1700007D")]
	public ContentType contentType
	{
		[Address(RVA = "0x426C40", Offset = "0x425E40", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BA")]
		 get { } //Length: 7
		[Address(RVA = "0x1CBFB10", Offset = "0x1CBED10", Length = "0x210")]
		[CalledBy(Type = typeof(InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "set_inputType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "set_keyboardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboardType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "set_characterValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "SetToCustomIfContentTypeIsNot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "SetToCustom", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Text), Member = "set_horizontalOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalWrapMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001BB")]
		 set { } //Length: 528
	}

	[Token(Token = "0x17000075")]
	public bool customCaretColor
	{
		[Address(RVA = "0x1CBEF50", Offset = "0x1CBE150", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001AA")]
		 get { } //Length: 8
		[Address(RVA = "0x1CBFD50", Offset = "0x1CBEF50", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001AB")]
		 set { } //Length: 93
	}

	[Token(Token = "0x17000093")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000233")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000090")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000230")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000089")]
	private bool hasSelection
	{
		[Address(RVA = "0x1CBEF60", Offset = "0x1CBE160", Length = "0x5B")]
		[CalledBy(Type = typeof(<CaretBlink>d__170), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001D0")]
		private get { } //Length: 91
	}

	[Token(Token = "0x17000068")]
	private BaseInput input
	{
		[Address(RVA = "0x1CBEFD0", Offset = "0x1CBE1D0", Length = "0xFB")]
		[CalledBy(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000192")]
		private get { } //Length: 251
	}

	[Token(Token = "0x1700007F")]
	public InputType inputType
	{
		[Address(RVA = "0x1CBEFC0", Offset = "0x1CBE1C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001BE")]
		 get { } //Length: 7
		[Address(RVA = "0x1CBFDB0", Offset = "0x1CBEFB0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001BF")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700006F")]
	public bool isFocused
	{
		[Address(RVA = "0x1CBF0D0", Offset = "0x1CBE2D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600019F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000081")]
	public TouchScreenKeyboardType keyboardType
	{
		[Address(RVA = "0x1CBF0E0", Offset = "0x1CBE2E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001C1")]
		 get { } //Length: 7
		[Address(RVA = "0x1CBFE20", Offset = "0x1CBF020", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001C2")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000094")]
	public override int layoutPriority
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000234")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700007E")]
	public LineType lineType
	{
		[Address(RVA = "0x1A821A0", Offset = "0x1A813A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BC")]
		 get { } //Length: 7
		[Address(RVA = "0x1CBFE90", Offset = "0x1CBF090", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60001BD")]
		 set { } //Length: 215
	}

	[Token(Token = "0x1700006A")]
	protected Mesh mesh
	{
		[Address(RVA = "0x1CBF0F0", Offset = "0x1CBE2F0", Length = "0xA3")]
		[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000195")]
		 get { } //Length: 163
	}

	[Token(Token = "0x17000091")]
	public override float minHeight
	{
		[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000231")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700008E")]
	public override float minWidth
	{
		[Address(RVA = "0x1CBF1A0", Offset = "0x1CBE3A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600022E")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000084")]
	public bool multiLine
	{
		[Address(RVA = "0x1CBF1B0", Offset = "0x1CBE3B0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001C7")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000077")]
	public EndEditEvent onEndEdit
	{
		[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AE")]
		 get { } //Length: 8
		[Address(RVA = "0x1CBFF70", Offset = "0x1CBF170", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001AF")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000078")]
	public SubmitEvent onSubmit
	{
		[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B0")]
		 get { } //Length: 8
		[Address(RVA = "0x1CBFFC0", Offset = "0x1CBF1C0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001B1")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700007B")]
	public OnValidateInput onValidateInput
	{
		[Address(RVA = "0x3D66C0", Offset = "0x3D58C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B6")]
		 get { } //Length: 8
		[Address(RVA = "0x1CC0010", Offset = "0x1CBF210", Length = "0x4C")]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001B7")]
		 set { } //Length: 76
	}

	[Obsolete("onValueChange has been renamed to onValueChanged")]
	[Token(Token = "0x17000079")]
	public OnChangeEvent onValueChange
	{
		[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B2")]
		 get { } //Length: 8
		[Address(RVA = "0x1CC0060", Offset = "0x1CBF260", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B3")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700007A")]
	public OnChangeEvent onValueChanged
	{
		[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B4")]
		 get { } //Length: 8
		[Address(RVA = "0x1CC0060", Offset = "0x1CBF260", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B5")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000073")]
	public Graphic placeholder
	{
		[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A6")]
		 get { } //Length: 8
		[Address(RVA = "0x1CC00B0", Offset = "0x1CBF2B0", Length = "0x4C")]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001A7")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000092")]
	public override float preferredHeight
	{
		[Address(RVA = "0x1CBF1D0", Offset = "0x1CBE3D0", Length = "0x1D6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
		[Calls(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000232")]
		 get { } //Length: 470
	}

	[Token(Token = "0x1700008F")]
	public override float preferredWidth
	{
		[Address(RVA = "0x1CBF3B0", Offset = "0x1CBE5B0", Length = "0x1DA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
		[Calls(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600022F")]
		 get { } //Length: 474
	}

	[Token(Token = "0x17000083")]
	public bool readOnly
	{
		[Address(RVA = "0x17F8AC0", Offset = "0x17F7CC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C5")]
		 get { } //Length: 8
		[Address(RVA = "0x17F9600", Offset = "0x17F8800", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C6")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700008B")]
	public int selectionAnchorPosition
	{
		[Address(RVA = "0x1CBEDF0", Offset = "0x1CBDFF0", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D3")]
		 get { } //Length: 40
		[Address(RVA = "0x1CC0100", Offset = "0x1CBF300", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001D4")]
		 set { } //Length: 107
	}

	[Token(Token = "0x17000076")]
	public Color selectionColor
	{
		[Address(RVA = "0x1CBF590", Offset = "0x1CBE790", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001AC")]
		 get { } //Length: 14
		[Address(RVA = "0x1CC0170", Offset = "0x1CBF370", Length = "0x6F")]
		[CalledBy(Type = "Battlehub.UIControls.UIStyle", Member = "ApplyInputFieldColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Color), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001AD")]
		 set { } //Length: 111
	}

	[Token(Token = "0x1700008C")]
	public int selectionFocusPosition
	{
		[Address(RVA = "0x1CBEE20", Offset = "0x1CBE020", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D5")]
		 get { } //Length: 40
		[Address(RVA = "0x1CC01E0", Offset = "0x1CBF3E0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001D6")]
		 set { } //Length: 107
	}

	[Token(Token = "0x1700006D")]
	public override bool shouldActivateOnSelect
	{
		[Address(RVA = "0x1CBF5A0", Offset = "0x1CBE7A0", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600019A")]
		 get { } //Length: 94
		[Address(RVA = "0x1CC0250", Offset = "0x1CBF450", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000199")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700006C")]
	public bool shouldHideMobileInput
	{
		[Address(RVA = "0x1CBF600", Offset = "0x1CBE800", Length = "0x5F")]
		[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Token(Token = "0x6000198")]
		 get { } //Length: 95
		[Address(RVA = "0x1CC0260", Offset = "0x1CBF460", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000197")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700006E")]
	public string text
	{
		[Address(RVA = "0x3D67D0", Offset = "0x3D59D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600019B")]
		 get { } //Length: 8
		[Address(RVA = "0x1CC0550", Offset = "0x1CBF750", Length = "0xB")]
		[CallerCount(Count = 51)]
		[Calls(Type = typeof(InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600019C")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000072")]
	public Text textComponent
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A4")]
		 get { } //Length: 8
		[Address(RVA = "0x1CC02B0", Offset = "0x1CBF4B0", Length = "0x29A")]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
		[Calls(Type = typeof(Graphic), Member = "RegisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Graphic), Member = "RegisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 7)]
		[Token(Token = "0x60001A5")]
		 set { } //Length: 666
	}

	[Token(Token = "0x17000080")]
	public TouchScreenKeyboard touchScreenKeyboard
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000086")]
	public bool wasCanceled
	{
		[Address(RVA = "0x1CBF660", Offset = "0x1CBE860", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001CA")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1CBEA10", Offset = "0x1CBDC10", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000235")]
	private static InputField() { }

	[Address(RVA = "0x1CBEAB0", Offset = "0x1CBDCB0", Length = "0x23E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000194")]
	protected InputField() { }

	[Address(RVA = "0x1CB54D0", Offset = "0x1CB46D0", Length = "0x13F")]
	[CalledBy(Type = typeof(InputField), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserRenamedItem", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color), typeof(Sprite), "SimpleFileBrowser.FileBrowserRenamedItem+OnRenameCompleted"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000220")]
	public void ActivateInputField() { }

	[Address(RVA = "0x1CB5070", Offset = "0x1CB4270", Length = "0x450")]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(int)}, ReturnType = typeof(TouchScreenKeyboard))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_hideInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "get_shouldHideMobileInput", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000221")]
	private void ActivateInputFieldInternal() { }

	[Address(RVA = "0x1CB5990", Offset = "0x1CB4B90", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600020D")]
	protected override void Append(string input) { }

	[Address(RVA = "0x1CB5610", Offset = "0x1CB4810", Length = "0x373")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InputField), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020E")]
	protected override void Append(char input) { }

	[Address(RVA = "0x1CB5A40", Offset = "0x1CB4C40", Length = "0x772")]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600021A")]
	private void AssignPositioningIfNeeded() { }

	[Address(RVA = "0x1CB61C0", Offset = "0x1CB53C0", Length = "0x1B3")]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InputField), Member = "set_caretPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_caretSelectPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000206")]
	private void Backspace() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600022C")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600022D")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x1CB6380", Offset = "0x1CB5580", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<CaretBlink>d__170))]
	[Token(Token = "0x60001DA")]
	private IEnumerator CaretBlink() { }

	[Address(RVA = "0x1CB63F0", Offset = "0x1CB55F0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001CB")]
	protected void ClampPos(ref int pos) { }

	[Address(RVA = "0x1CB6430", Offset = "0x1CB5630", Length = "0x1B6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600021D")]
	private void CreateCursorVerts() { }

	[Address(RVA = "0x1CB65F0", Offset = "0x1CB57F0", Length = "0x247")]
	[CalledBy(Type = typeof(InputField), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserRenamedItem", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000224")]
	public void DeactivateInputField() { }

	[Address(RVA = "0x1CB6840", Offset = "0x1CB5A40", Length = "0x320")]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000204")]
	private void Delete() { }

	[Address(RVA = "0x1CB6B70", Offset = "0x1CB5D70", Length = "0x114")]
	[CalledBy(Type = typeof(InputField), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FD")]
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	[Address(RVA = "0x1CB6C90", Offset = "0x1CB5E90", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600022B")]
	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	[Address(RVA = "0x1CB6CC0", Offset = "0x1CB5EC0", Length = "0x1D8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "set_horizontalOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000227")]
	private void EnforceContentType() { }

	[Address(RVA = "0x1CB6EC0", Offset = "0x1CB60C0", Length = "0xAA")]
	[CalledBy(Type = typeof(InputField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "set_horizontalOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000228")]
	private void EnforceTextHOverflow() { }

	[Address(RVA = "0x1CB6F70", Offset = "0x1CB6170", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001F9")]
	private int FindtNextWordBegin() { }

	[Address(RVA = "0x1CB7070", Offset = "0x1CB6270", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001FB")]
	private int FindtPrevWordBegin() { }

	[Address(RVA = "0x1CB7160", Offset = "0x1CB6360", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Token(Token = "0x6000214")]
	public void ForceLabelUpdate() { }

	[Address(RVA = "0x1CB7170", Offset = "0x1CB6370", Length = "0x151")]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000205")]
	private void ForwardSpace() { }

	[Address(RVA = "0x1CB72D0", Offset = "0x1CB64D0", Length = "0xAB2")]
	[CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransformUtility), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B110")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800216A0")]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600021C")]
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	[Address(RVA = "0x1CB7D90", Offset = "0x1CB6F90", Length = "0x749")]
	[CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B110")]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800216A0")]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextGenerator), Member = "get_characterCount", ReturnType = typeof(int))]
	[Token(Token = "0x600021E")]
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	[Address(RVA = "0x1CBECF0", Offset = "0x1CBDEF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001C8")]
	public char get_asteriskChar() { }

	[Address(RVA = "0x1CBED00", Offset = "0x1CBDF00", Length = "0x75")]
	[CalledBy(Type = typeof(InputField), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000196")]
	protected TextGenerator get_cachedInputTextGenerator() { }

	[Address(RVA = "0x1CBED80", Offset = "0x1CBDF80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001A0")]
	public float get_caretBlinkRate() { }

	[Address(RVA = "0x1CBED90", Offset = "0x1CBDF90", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A8")]
	public Color get_caretColor() { }

	[Address(RVA = "0x1CBEE20", Offset = "0x1CBE020", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D1")]
	public int get_caretPosition() { }

	[Address(RVA = "0x1CBEDF0", Offset = "0x1CBDFF0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CC")]
	protected int get_caretPositionInternal() { }

	[Address(RVA = "0x1CBEE20", Offset = "0x1CBE020", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CE")]
	protected int get_caretSelectPositionInternal() { }

	[Address(RVA = "0x1CBEE50", Offset = "0x1CBE050", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001A2")]
	public int get_caretWidth() { }

	[Address(RVA = "0x17F8710", Offset = "0x17F7910", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B8")]
	public int get_characterLimit() { }

	[Address(RVA = "0x1890B10", Offset = "0x188FD10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C3")]
	public CharacterValidation get_characterValidation() { }

	[Address(RVA = "0x1CBEE60", Offset = "0x1CBE060", Length = "0x40")]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
	[Token(Token = "0x60001E2")]
	private static string get_clipboard() { }

	[Address(RVA = "0x1CBEEA0", Offset = "0x1CBE0A0", Length = "0xA2")]
	[CallerCount(Count = 112)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000193")]
	private string get_compositionString() { }

	[Address(RVA = "0x426C40", Offset = "0x425E40", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BA")]
	public ContentType get_contentType() { }

	[Address(RVA = "0x1CBEF50", Offset = "0x1CBE150", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001AA")]
	public bool get_customCaretColor() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000233")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000230")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x1CBEF60", Offset = "0x1CBE160", Length = "0x5B")]
	[CalledBy(Type = typeof(<CaretBlink>d__170), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D0")]
	private bool get_hasSelection() { }

	[Address(RVA = "0x1CBEFD0", Offset = "0x1CBE1D0", Length = "0xFB")]
	[CalledBy(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000192")]
	private BaseInput get_input() { }

	[Address(RVA = "0x1CBEFC0", Offset = "0x1CBE1C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001BE")]
	public InputType get_inputType() { }

	[Address(RVA = "0x1CBF0D0", Offset = "0x1CBE2D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600019F")]
	public bool get_isFocused() { }

	[Address(RVA = "0x1CBF0E0", Offset = "0x1CBE2E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001C1")]
	public TouchScreenKeyboardType get_keyboardType() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000234")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x1A821A0", Offset = "0x1A813A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BC")]
	public LineType get_lineType() { }

	[Address(RVA = "0x1CBF0F0", Offset = "0x1CBE2F0", Length = "0xA3")]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000195")]
	protected Mesh get_mesh() { }

	[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000231")]
	public override float get_minHeight() { }

	[Address(RVA = "0x1CBF1A0", Offset = "0x1CBE3A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600022E")]
	public override float get_minWidth() { }

	[Address(RVA = "0x1CBF1B0", Offset = "0x1CBE3B0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001C7")]
	public bool get_multiLine() { }

	[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AE")]
	public EndEditEvent get_onEndEdit() { }

	[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B0")]
	public SubmitEvent get_onSubmit() { }

	[Address(RVA = "0x3D66C0", Offset = "0x3D58C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B6")]
	public OnValidateInput get_onValidateInput() { }

	[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B2")]
	public OnChangeEvent get_onValueChange() { }

	[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B4")]
	public OnChangeEvent get_onValueChanged() { }

	[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A6")]
	public Graphic get_placeholder() { }

	[Address(RVA = "0x1CBF1D0", Offset = "0x1CBE3D0", Length = "0x1D6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000232")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x1CBF3B0", Offset = "0x1CBE5B0", Length = "0x1DA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600022F")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x17F8AC0", Offset = "0x17F7CC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C5")]
	public bool get_readOnly() { }

	[Address(RVA = "0x1CBEDF0", Offset = "0x1CBDFF0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D3")]
	public int get_selectionAnchorPosition() { }

	[Address(RVA = "0x1CBF590", Offset = "0x1CBE790", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001AC")]
	public Color get_selectionColor() { }

	[Address(RVA = "0x1CBEE20", Offset = "0x1CBE020", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D5")]
	public int get_selectionFocusPosition() { }

	[Address(RVA = "0x1CBF5A0", Offset = "0x1CBE7A0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600019A")]
	public override bool get_shouldActivateOnSelect() { }

	[Address(RVA = "0x1CBF600", Offset = "0x1CBE800", Length = "0x5F")]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Token(Token = "0x6000198")]
	public bool get_shouldHideMobileInput() { }

	[Address(RVA = "0x3D67D0", Offset = "0x3D59D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019B")]
	public string get_text() { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A4")]
	public Text get_textComponent() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C0")]
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	[Address(RVA = "0x1CBF660", Offset = "0x1CBE860", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001CA")]
	public bool get_wasCanceled() { }

	[Address(RVA = "0x1CB84E0", Offset = "0x1CB76E0", Length = "0x244")]
	[CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800216A0")]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputField), Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B110")]
	[Token(Token = "0x60001ED")]
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	[Address(RVA = "0x1CB8730", Offset = "0x1CB7930", Length = "0xFD")]
	[CalledBy(Type = typeof(InputField), Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001E7")]
	private RangeInt GetInternalSelection() { }

	[Address(RVA = "0x1CB8830", Offset = "0x1CB7A30", Length = "0xB9")]
	[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B110")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000212")]
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	[Address(RVA = "0x1CB88F0", Offset = "0x1CB7AF0", Length = "0x115")]
	[CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000211")]
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	[Address(RVA = "0x1CB8A10", Offset = "0x1CB7C10", Length = "0xF4")]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001F8")]
	private string GetSelectedString() { }

	[Address(RVA = "0x1CB8B10", Offset = "0x1CB7D10", Length = "0x27C")]
	[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001EC")]
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000218")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x1CB8E10", Offset = "0x1CB8010", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Token(Token = "0x60001E5")]
	private bool InPlaceEditing() { }

	[Address(RVA = "0x1CB8D90", Offset = "0x1CB7F90", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001E6")]
	private bool InPlaceEditingChanged() { }

	[Address(RVA = "0x1CB8E40", Offset = "0x1CB8040", Length = "0x195")]
	[CalledBy(Type = typeof(InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000207")]
	private void Insert(char c) { }

	[Address(RVA = "0x1CB8FE0", Offset = "0x1CB81E0", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000210")]
	private bool IsSelectionVisible() { }

	[Address(RVA = "0x1CB90B0", Offset = "0x1CB82B0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(Font), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001F5")]
	private bool IsValidChar(char c) { }

	[Address(RVA = "0x1CB9110", Offset = "0x1CB8310", Length = "0x4F4")]
	[CalledBy(Type = typeof(InputField), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "get_clipboard", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "MoveLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "MoveRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "GetSelectedString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Font), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001F4")]
	protected EditState KeyPressed(Event evt) { }

	[Address(RVA = "0x1CB9630", Offset = "0x1CB8830", Length = "0x6DD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canGetSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnSubmit", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_caretSelectPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_caretPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "GetInternalSelection", ReturnType = typeof(RangeInt))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canSetSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InputField), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_status", ReturnType = typeof(Status))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001EA")]
	protected override void LateUpdate() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000217")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x1CB9D10", Offset = "0x1CB8F10", Length = "0x2A5")]
	[CalledBy(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800216A0")]
	[Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B110")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001FF")]
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	[Address(RVA = "0x1CB9FC0", Offset = "0x1CB91C0", Length = "0x211")]
	[CalledBy(Type = typeof(InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800216A0")]
	[Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B110")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001FE")]
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	[Address(RVA = "0x1CBA1E0", Offset = "0x1CB93E0", Length = "0x49")]
	[CalledBy(Type = typeof(<CaretBlink>d__170), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000215")]
	private void MarkGeometryAsDirty() { }

	[Address(RVA = "0x1CBA230", Offset = "0x1CB9430", Length = "0xE4")]
	[CalledBy(Type = typeof(InputField), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001EE")]
	private bool MayDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CBA320", Offset = "0x1CB9520", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__194))]
	[Token(Token = "0x60001F1")]
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	[Address(RVA = "0x1CBA3B0", Offset = "0x1CB95B0", Length = "0x211")]
	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__194), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000201")]
	private void MoveDown(bool shift, bool goToLastChar) { }

	[Address(RVA = "0x1CBA5D0", Offset = "0x1CB97D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000200")]
	private void MoveDown(bool shift) { }

	[Address(RVA = "0x1CBA5E0", Offset = "0x1CB97E0", Length = "0x279")]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001FC")]
	private void MoveLeft(bool shift, bool ctrl) { }

	[Address(RVA = "0x1CBA860", Offset = "0x1CB9A60", Length = "0x2AD")]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001FA")]
	private void MoveRight(bool shift, bool ctrl) { }

	[Address(RVA = "0x1CBAB10", Offset = "0x1CB9D10", Length = "0x112")]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001E0")]
	public void MoveTextEnd(bool shift) { }

	[Address(RVA = "0x1CBAC30", Offset = "0x1CB9E30", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001E1")]
	public void MoveTextStart(bool shift) { }

	[Address(RVA = "0x1CBAD20", Offset = "0x1CB9F20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000202")]
	private void MoveUp(bool shift) { }

	[Address(RVA = "0x1CBAD30", Offset = "0x1CB9F30", Length = "0x1D7")]
	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__194), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000203")]
	private void MoveUp(bool shift, bool goToFirstChar) { }

	[Address(RVA = "0x1CBAF10", Offset = "0x1CBA110", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60001EF")]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CBAF40", Offset = "0x1CBA140", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000225")]
	public virtual void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x1CBAF70", Offset = "0x1CBA170", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001D9")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1CBAFD0", Offset = "0x1CBA1D0", Length = "0x271")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "DisableCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60001D8")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CBB250", Offset = "0x1CBA450", Length = "0x2D9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputField), Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F0")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CBB530", Offset = "0x1CBA730", Length = "0x272")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D7")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CBB7B0", Offset = "0x1CBA9B0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60001F2")]
	public override void OnEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CBB7E0", Offset = "0x1CBA9E0", Length = "0x1FE")]
	[CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Graphic), Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600021B")]
	private void OnFillVBO(Mesh vbo) { }

	[Address(RVA = "0x1CBB9E0", Offset = "0x1CBABE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Token(Token = "0x60001DE")]
	protected void OnFocus() { }

	[Address(RVA = "0x1CBB9F0", Offset = "0x1CBABF0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000223")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x1CBBA20", Offset = "0x1CBAC20", Length = "0x2A0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InputField), Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001F3")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x1CBBCD0", Offset = "0x1CBAED0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000222")]
	public virtual void OnSelect(BaseEventData eventData) { }

	[Address(RVA = "0x1CBBD10", Offset = "0x1CBAF10", Length = "0x50")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000226")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x1CBBD60", Offset = "0x1CBAF60", Length = "0x1CE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[Calls(Type = typeof(InputField), Member = "SendOnSubmit", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "PopEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F7")]
	public override void OnUpdateSelected(BaseEventData eventData) { }

	[Address(RVA = "0x1CBBF30", Offset = "0x1CBB130", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[Token(Token = "0x60001F6")]
	public void ProcessEvent(Event e) { }

	[Address(RVA = "0x1CBBF40", Offset = "0x1CBB140", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[Token(Token = "0x6000216")]
	public override void Rebuild(CanvasUpdate update) { }

	[Address(RVA = "0x1CBBF50", Offset = "0x1CBB150", Length = "0x4F2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[ContainsUnimplementedInstructions]
	[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
	[Token(Token = "0x60001EB")]
	public Vector2 ScreenToLocal(Vector2 screen) { }

	[Address(RVA = "0x1CBC450", Offset = "0x1CBB650", Length = "0x80")]
	[CalledBy(Type = typeof(InputField), Member = "OnFocus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001DF")]
	protected void SelectAll() { }

	[Address(RVA = "0x1CBC4E0", Offset = "0x1CBB6E0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600020B")]
	protected void SendOnEndEdit() { }

	[Address(RVA = "0x1CBC560", Offset = "0x1CBB760", Length = "0x72")]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600020C")]
	protected void SendOnSubmit() { }

	[Address(RVA = "0x1CBC600", Offset = "0x1CBB800", Length = "0x72")]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600020A")]
	private void SendOnValueChanged() { }

	[Address(RVA = "0x1CBC5E0", Offset = "0x1CBB7E0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Token(Token = "0x6000209")]
	private void SendOnValueChangedAndUpdateLabel() { }

	[Address(RVA = "0x1CBF670", Offset = "0x1CBE870", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Token(Token = "0x60001C9")]
	public void set_asteriskChar(char value) { }

	[Address(RVA = "0x1CBF6D0", Offset = "0x1CBE8D0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	[Token(Token = "0x60001A1")]
	public void set_caretBlinkRate(float value) { }

	[Address(RVA = "0x1CBF740", Offset = "0x1CBE940", Length = "0x6F")]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001A9")]
	public void set_caretColor(Color value) { }

	[Address(RVA = "0x1CBF800", Offset = "0x1CBEA00", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001D2")]
	public void set_caretPosition(int value) { }

	[Address(RVA = "0x1CBF7B0", Offset = "0x1CBE9B0", Length = "0x46")]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001CD")]
	protected void set_caretPositionInternal(int value) { }

	[Address(RVA = "0x1CBF8C0", Offset = "0x1CBEAC0", Length = "0x46")]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001CF")]
	protected void set_caretSelectPositionInternal(int value) { }

	[Address(RVA = "0x1CBF910", Offset = "0x1CBEB10", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001A3")]
	public void set_caretWidth(int value) { }

	[Address(RVA = "0x1CBF9A0", Offset = "0x1CBEBA0", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001B9")]
	public void set_characterLimit(int value) { }

	[Address(RVA = "0x1CBFA50", Offset = "0x1CBEC50", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001C4")]
	public void set_characterValidation(CharacterValidation value) { }

	[Address(RVA = "0x1CBFAC0", Offset = "0x1CBECC0", Length = "0x49")]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001E3")]
	private static void set_clipboard(string value) { }

	[Address(RVA = "0x1CBFB10", Offset = "0x1CBED10", Length = "0x210")]
	[CalledBy(Type = typeof(InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_inputType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_keyboardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboardType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_characterValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SetToCustomIfContentTypeIsNot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SetToCustom", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "set_horizontalOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BB")]
	public void set_contentType(ContentType value) { }

	[Address(RVA = "0x1CBFD50", Offset = "0x1CBEF50", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001AB")]
	public void set_customCaretColor(bool value) { }

	[Address(RVA = "0x1CBFDB0", Offset = "0x1CBEFB0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001BF")]
	public void set_inputType(InputType value) { }

	[Address(RVA = "0x1CBFE20", Offset = "0x1CBF020", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001C2")]
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	[Address(RVA = "0x1CBFE90", Offset = "0x1CBF090", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001BD")]
	public void set_lineType(LineType value) { }

	[Address(RVA = "0x1CBFF70", Offset = "0x1CBF170", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001AF")]
	public void set_onEndEdit(EndEditEvent value) { }

	[Address(RVA = "0x1CBFFC0", Offset = "0x1CBF1C0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001B1")]
	public void set_onSubmit(SubmitEvent value) { }

	[Address(RVA = "0x1CC0010", Offset = "0x1CBF210", Length = "0x4C")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001B7")]
	public void set_onValidateInput(OnValidateInput value) { }

	[Address(RVA = "0x1CC0060", Offset = "0x1CBF260", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B3")]
	public void set_onValueChange(OnChangeEvent value) { }

	[Address(RVA = "0x1CC0060", Offset = "0x1CBF260", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B5")]
	public void set_onValueChanged(OnChangeEvent value) { }

	[Address(RVA = "0x1CC00B0", Offset = "0x1CBF2B0", Length = "0x4C")]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001A7")]
	public void set_placeholder(Graphic value) { }

	[Address(RVA = "0x17F9600", Offset = "0x17F8800", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C6")]
	public void set_readOnly(bool value) { }

	[Address(RVA = "0x1CC0100", Offset = "0x1CBF300", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001D4")]
	public void set_selectionAnchorPosition(int value) { }

	[Address(RVA = "0x1CC0170", Offset = "0x1CBF370", Length = "0x6F")]
	[CalledBy(Type = "Battlehub.UIControls.UIStyle", Member = "ApplyInputFieldColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Color), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001AD")]
	public void set_selectionColor(Color value) { }

	[Address(RVA = "0x1CC01E0", Offset = "0x1CBF3E0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001D6")]
	public void set_selectionFocusPosition(int value) { }

	[Address(RVA = "0x1CC0250", Offset = "0x1CBF450", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000199")]
	public override void set_shouldActivateOnSelect(bool value) { }

	[Address(RVA = "0x1CC0260", Offset = "0x1CBF460", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000197")]
	public void set_shouldHideMobileInput(bool value) { }

	[Address(RVA = "0x1CC0550", Offset = "0x1CBF750", Length = "0xB")]
	[CallerCount(Count = 51)]
	[Calls(Type = typeof(InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600019C")]
	public void set_text(string value) { }

	[Address(RVA = "0x1CC02B0", Offset = "0x1CBF4B0", Length = "0x29A")]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x60001A5")]
	public void set_textComponent(Text value) { }

	[Address(RVA = "0x1CBC680", Offset = "0x1CBB880", Length = "0xBD")]
	[CalledBy(Type = typeof(InputField), Member = "set_caretBlinkRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SetCaretVisible", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001DC")]
	private void SetCaretActive() { }

	[Address(RVA = "0x1CBC740", Offset = "0x1CBB940", Length = "0x3D")]
	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	[Token(Token = "0x60001DB")]
	private void SetCaretVisible() { }

	[Address(RVA = "0x1CBC780", Offset = "0x1CBB980", Length = "0x856")]
	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800216A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B110")]
	[Calls(Type = typeof(InputField), Member = "GetLineStartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = typeof(TextGenerator), Member = "get_rectExtents", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InputField), Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000213")]
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	[Address(RVA = "0x1CBCFF0", Offset = "0x1CBC1F0", Length = "0x444")]
	[CalledBy(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600019E")]
	private void SetText(string value, bool sendCallback = true) { }

	[Address(RVA = "0x1CBCFE0", Offset = "0x1CBC1E0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600019D")]
	public void SetTextWithoutNotify(string input) { }

	[Address(RVA = "0x1CBD4B0", Offset = "0x1CBC6B0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Token(Token = "0x600022A")]
	private void SetToCustom() { }

	[Address(RVA = "0x1CBD440", Offset = "0x1CBC640", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000229")]
	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	[Address(RVA = "0x1CBD4D0", Offset = "0x1CBC6D0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Token(Token = "0x60001E4")]
	private bool TouchScreenKeyboardShouldBeUsed() { }

	[Address(RVA = "0x1094810", Offset = "0x1093A10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000236")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x1CBD580", Offset = "0x1CBC780", Length = "0x125")]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_selection", ReturnType = typeof(RangeInt))]
	[Calls(Type = typeof(RangeInt), Member = "get_end", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001E9")]
	private void UpdateCaretFromKeyboard() { }

	[Address(RVA = "0x1CBD6B0", Offset = "0x1CBC8B0", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DD")]
	private void UpdateCaretMaterial() { }

	[Address(RVA = "0x1CBD7C0", Offset = "0x1CBC9C0", Length = "0x4CE")]
	[CalledBy(Type = typeof(InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetAsFirstSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000219")]
	private void UpdateGeometry() { }

	[Address(RVA = "0x1CBDC90", Offset = "0x1CBCE90", Length = "0xCD")]
	[CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canSetSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(InputField), Member = "GetInternalSelection", ReturnType = typeof(RangeInt))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001E8")]
	private void UpdateKeyboardCaret() { }

	[Address(RVA = "0x1CBDD60", Offset = "0x1CBCF60", Length = "0x4F6")]
	[CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ForceLabelUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "MoveTextStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "MoveTextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_asteriskChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__194), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings), typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InputField), Member = "SetCaretVisible", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600020F")]
	protected void UpdateLabel() { }

	[Address(RVA = "0x1CBE260", Offset = "0x1CBD460", Length = "0x52")]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000208")]
	private void UpdateTouchKeyboardFromEditChanges() { }

	[Address(RVA = "0x1CBE2C0", Offset = "0x1CBD4C0", Length = "0x74F")]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600021F")]
	protected char Validate(string text, int pos, char ch) { }

}

