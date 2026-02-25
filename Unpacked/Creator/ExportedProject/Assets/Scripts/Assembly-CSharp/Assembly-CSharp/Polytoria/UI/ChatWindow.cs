namespace Polytoria.UI;

[Token(Token = "0x20002E5")]
public class ChatWindow : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20002E6")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B43")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000B44")]
		public static Action <>9__28_1; //Field offset: 0x8

		[Address(RVA = "0x418F60", Offset = "0x418160", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B25")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B26")]
		public <>c() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B27")]
		internal void <inactiveFade>b__28_1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002E7")]
	private sealed class <>c__DisplayClass28_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B45")]
		public TMP_Text txt; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B28")]
		public <>c__DisplayClass28_0() { }

		[Address(RVA = "0x418D50", Offset = "0x417F50", Length = "0x101")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6001B29")]
		internal void <inactiveFade>b__0(float val) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002E8")]
	private sealed class <inactiveFade>d__28 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B46")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B47")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B48")]
		public ChatMessageRef t; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B49")]
		private <>c__DisplayClass28_0 <>8__1; //Field offset: 0x28

		[Token(Token = "0x170008CE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B2D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170008CF")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B2F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B2A")]
		public <inactiveFade>d__28(int <>1__state) { }

		[Address(RVA = "0x419E60", Offset = "0x419060", Length = "0x2B0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(WaitForSeconds), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
		[Calls(Type = typeof(LTDescr), Member = "setOnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Single>)}, ReturnType = typeof(LTDescr))]
		[Calls(Type = typeof(LTDescr), Member = "setOnComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(LTDescr))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6001B2C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B2D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B2F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x41A120", Offset = "0x419320", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6001B2E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B2B")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000B42")]
	private const float chatFadeTime = 0.3; //Field offset: 0x0
	[Token(Token = "0x4000B41")]
	private const float chatStayTime = 10; //Field offset: 0x0
	[Token(Token = "0x4000B36")]
	public static ChatWindow instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B31")]
	private Image darken; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B32")]
	private Scrollbar scrollbar; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B33")]
	private Image focusImage; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B34")]
	public TMP_InputField input; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B35")]
	private ScrollRect scrollRect; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B37")]
	private RectTransform chatMessage; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B38")]
	private RectTransform <ChatContainer>k__BackingField; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B39")]
	private ChatWindowState _state; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B3A")]
	private RectTransform PopContainer; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B3B")]
	public Vector2 normalSize; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B3C")]
	public Vector2 focusedSize; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B3D")]
	public float stateChangeCooldown; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000B3E")]
	public float StateChangeRateLimit; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B3F")]
	public UICommandList commandList; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000B40")]
	private List<ChatMessageRef> chatMessages; //Field offset: 0x88

	[Token(Token = "0x170008CB")]
	public private RectTransform ChatContainer
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B0F")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B10")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170008CC")]
	public bool Focused
	{
		[Address(RVA = "0x406200", Offset = "0x405400", Length = "0x1E")]
		[CalledBy(Type = typeof(Player), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B11")]
		 get { } //Length: 30
	}

	[Token(Token = "0x170008CD")]
	public ChatWindowState state
	{
		[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B12")]
		 get { } //Length: 4
		[Address(RVA = "0x4062A0", Offset = "0x4054A0", Length = "0x76A")]
		[CalledBy(Type = typeof(Player), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "ToggleFocused", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "SetInactive", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "PushChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(LeanTween), Member = "size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float)}, ReturnType = typeof(LTDescr))]
		[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
		[Calls(Type = typeof(LTDescr), Member = "setOnComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(LTDescr))]
		[Calls(Type = typeof(UICommandList), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
		[Calls(Type = typeof(LTDescr), Member = "setEase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LeanTweenType)}, ReturnType = typeof(LTDescr))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIController), Member = "SetButtonFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HudButton), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(LTDescr), Member = "setOnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Single>)}, ReturnType = typeof(LTDescr))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B13")]
		 set { } //Length: 1898
	}

	[Address(RVA = "0x406170", Offset = "0x405370", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001B1C")]
	public ChatWindow() { }

	[Address(RVA = "0x405FF0", Offset = "0x4051F0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B1D")]
	private void <set_state>b__22_0(float val) { }

	[Address(RVA = "0x406050", Offset = "0x405250", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B1E")]
	private void <set_state>b__22_1(float val) { }

	[Address(RVA = "0x406080", Offset = "0x405280", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B1F")]
	private void <set_state>b__22_2(float val) { }

	[Address(RVA = "0x406050", Offset = "0x405250", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B20")]
	private void <set_state>b__22_3() { }

	[Address(RVA = "0x406080", Offset = "0x405280", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B21")]
	private void <set_state>b__22_4(float val) { }

	[Address(RVA = "0x4060E0", Offset = "0x4052E0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x6001B22")]
	private void <set_state>b__22_5() { }

	[Address(RVA = "0x405FF0", Offset = "0x4051F0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B23")]
	private void <set_state>b__22_6(float val) { }

	[Address(RVA = "0x405DD0", Offset = "0x404FD0", Length = "0x212")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UICommandList), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UICommandList), Member = "Search", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6001B24")]
	private void <Start>b__25_0(string <p0>) { }

	[Address(RVA = "0x4053C0", Offset = "0x4045C0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001B14")]
	private void Awake() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B0F")]
	public RectTransform get_ChatContainer() { }

	[Address(RVA = "0x406200", Offset = "0x405400", Length = "0x1E")]
	[CalledBy(Type = typeof(Player), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B11")]
	public bool get_Focused() { }

	[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B12")]
	public ChatWindowState get_state() { }

	[Address(RVA = "0x406230", Offset = "0x405430", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<inactiveFade>d__28))]
	[Token(Token = "0x6001B16")]
	private IEnumerator inactiveFade(ChatMessageRef t) { }

	[Address(RVA = "0x405420", Offset = "0x404620", Length = "0x566")]
	[CalledBy(Type = typeof(UIController), Member = "ReceiveChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "ForceRebuildLayoutImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ChatWindow), Member = "set_state", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChatWindowState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B1B")]
	public void PushChat(string username, string message, Color usernameColor) { }

	[Address(RVA = "0x406050", Offset = "0x405250", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B1A")]
	private void scrollViewToBottom() { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B10")]
	private void set_ChatContainer(RectTransform value) { }

	[Address(RVA = "0x4062A0", Offset = "0x4054A0", Length = "0x76A")]
	[CalledBy(Type = typeof(Player), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "ToggleFocused", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "SetInactive", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "PushChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIController), Member = "SetButtonFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HudButton), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(LTDescr), Member = "setOnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Single>)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(LTDescr), Member = "setEase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LeanTweenType)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(UICommandList), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LTDescr), Member = "setOnComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(LeanTween), Member = "size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B13")]
	public void set_state(ChatWindowState value) { }

	[Address(RVA = "0x405990", Offset = "0x404B90", Length = "0x44")]
	[CalledBy(Type = typeof(Player), Member = "SendChat", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ChatWindow), Member = "set_state", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChatWindowState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B19")]
	public void SetInactive() { }

	[Address(RVA = "0x4059E0", Offset = "0x404BE0", Length = "0x371")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ChatWindow), Member = "set_state", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChatWindowState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B15")]
	private void Start() { }

	[Address(RVA = "0x405D60", Offset = "0x404F60", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ChatWindow), Member = "set_state", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChatWindowState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B18")]
	public void ToggleFocused() { }

	[Address(RVA = "0x406110", Offset = "0x405310", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ChatWindow), Member = "set_state", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChatWindowState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B17")]
	private void Update() { }

}

