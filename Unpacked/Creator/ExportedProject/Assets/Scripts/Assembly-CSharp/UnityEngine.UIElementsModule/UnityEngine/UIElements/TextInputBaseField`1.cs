namespace UnityEngine.UIElements;

[Token(Token = "0x20000ED")]
public abstract class TextInputBaseField : BaseField<TValueType>, IDelayedField
{
	[Token(Token = "0x20000EF")]
	private abstract class TextInputBase : VisualElement
	{
		[Token(Token = "0x40004AD")]
		public static readonly string verticalHorizontalVariantInnerTextElementUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004A8")]
		public static readonly string innerComponentsModifierName; //Field offset: 0x0
		[Token(Token = "0x40004A9")]
		public static readonly string innerTextElementUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004AA")]
		internal static readonly string innerTextElementWithScrollViewUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004AB")]
		public static readonly string horizontalVariantInnerTextElementUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004AC")]
		public static readonly string verticalVariantInnerTextElementUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004AE")]
		public static readonly string innerScrollviewUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004AF")]
		public static readonly string innerViewportUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004B0")]
		public static readonly string innerContentContainerUssClassName; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B3")]
		private bool m_ScrollViewWasClamped; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B2")]
		internal Vector2 scrollOffset; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B1")]
		private bool <isDragging>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A5")]
		private TextElement <textElement>k__BackingField; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A7")]
		internal VisualElement multilineContainer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A6")]
		internal ScrollView scrollView; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B4")]
		private Vector2 lastCursorPos; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B5")]
		internal ScrollerVisibility verticalScrollerVisibility; //Field offset: 0x0

		[Token(Token = "0x17000130")]
		internal bool isDragging
		{
			[Address(RVA = "0xFA13E0", Offset = "0xFA05E0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000774")]
			internal set { } //Length: 7
		}

		[Token(Token = "0x17000132")]
		internal string originalText
		{
			[Address(RVA = "0xFA1340", Offset = "0xFA0540", Length = "0x21")]
			[CalledBy(Type = typeof(DoubleField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
			[CalledBy(Type = typeof(FloatField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
			[CalledBy(Type = typeof(IntegerField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(LongField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
			[CalledBy(Type = typeof(UnsignedIntegerField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
			[CalledBy(Type = typeof(UnsignedLongField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ulong))]
			[CallerCount(Count = 6)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000777")]
			internal get { } //Length: 33
		}

		[Token(Token = "0x17000131")]
		public string text
		{
			[Address(RVA = "0xFA13B0", Offset = "0xFA05B0", Length = "0x2D")]
			[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(float)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.TextField+TextInput", Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TextInputBaseField`1), Member = "get_text", ReturnType = typeof(string))]
			[CalledBy(Type = typeof(TextInputBaseField`1), Member = "UpdateValueFromText", ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(long)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(ulong)}, ReturnType = typeof(void))]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000775")]
			 get { } //Length: 45
			[Address(RVA = "0xFA1410", Offset = "0xFA0610", Length = "0x73")]
			[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(float)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.TextField+TextInput", Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TextInputBaseField`1), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(long)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(ulong)}, ReturnType = typeof(void))]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000776")]
			 set { } //Length: 115
		}

		[Token(Token = "0x1700012F")]
		public ITextEdition textEdition
		{
			[Address(RVA = "0xFA1370", Offset = "0xFA0570", Length = "0x20")]
			[CallerCount(Count = 16)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000773")]
			 get { } //Length: 32
		}

		[Token(Token = "0x1700012D")]
		internal TextElement textElement
		{
			[Address(RVA = "0xFA13A0", Offset = "0xFA05A0", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600076F")]
			internal get { } //Length: 8
			[Address(RVA = "0xFA13F0", Offset = "0xFA05F0", Length = "0x13")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000770")]
			private set { } //Length: 19
		}

		[Token(Token = "0x1700012E")]
		public ITextSelection textSelection
		{
			[Address(RVA = "0xFA1370", Offset = "0xFA0570", Length = "0x20")]
			[CallerCount(Count = 16)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000772")]
			 get { } //Length: 32
		}

		[Address(RVA = "0xF9F250", Offset = "0xF9E450", Length = "0x88E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[Token(Token = "0x600078C")]
		private static TextInputBase() { }

		[Address(RVA = "0xFA0B20", Offset = "0xF9FD20", Length = "0x817")]
		[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TextElement), Member = "set_enableRichText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Focusable), Member = "set_delegatesFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000771")]
		internal TextInputBase() { }

		[Address(RVA = "0xF96550", Offset = "0xF95750", Length = "0x72")]
		[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "AcceptCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000783")]
		internal override bool AcceptCharacter(char c) { }

		[Address(RVA = "0xFA1340", Offset = "0xFA0540", Length = "0x21")]
		[CalledBy(Type = typeof(DoubleField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
		[CalledBy(Type = typeof(FloatField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(IntegerField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(LongField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(UnsignedIntegerField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
		[CalledBy(Type = typeof(UnsignedLongField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ulong))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000777")]
		internal string get_originalText() { }

		[Address(RVA = "0xFA13B0", Offset = "0xFA05B0", Length = "0x2D")]
		[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextField+TextInput", Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "get_text", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "UpdateValueFromText", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(ulong)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000775")]
		public string get_text() { }

		[Address(RVA = "0xFA1370", Offset = "0xFA0570", Length = "0x20")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000773")]
		public ITextEdition get_textEdition() { }

		[Address(RVA = "0xFA13A0", Offset = "0xFA05A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600076F")]
		internal TextElement get_textElement() { }

		[Address(RVA = "0xFA1370", Offset = "0xFA0570", Length = "0x20")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000772")]
		public ITextSelection get_textSelection() { }

		[Address(RVA = "0xF96700", Offset = "0xF95900", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000782")]
		private string GetDefaultValueType() { }

		[Address(RVA = "0xF96760", Offset = "0xF95960", Length = "0x481")]
		[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
		[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000786")]
		private Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged) { }

		[Address(RVA = "0xF97510", Offset = "0xF96710", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600077C")]
		private void MakeSureScrollViewDoesNotLeakEvents(ChangeEvent<Single> evt) { }

		[Address(RVA = "0xF97690", Offset = "0xF96890", Length = "0x152")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077B")]
		internal void MoveFocusToCompositeRoot() { }

		[Address(RVA = "0xF97C30", Offset = "0xF96E30", Length = "0x2DC")]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "OnFieldCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CustomStyleResolvedEvent), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(TextElement), Member = "set_selectionColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = "set_cursorColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FEF40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000781")]
		internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e) { }

		[Address(RVA = "0xF981F0", Offset = "0xF973F0", Length = "0x5E0")]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "UnregisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StyleTranslate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StyleTranslate))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600078A")]
		private void RemoveMultilineComponents() { }

		[Address(RVA = "0xF993C0", Offset = "0xF985C0", Length = "0x1AE")]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000789")]
		private void RemoveSingleLineComponents() { }

		[Address(RVA = "0xF99960", Offset = "0xF98B60", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600077F")]
		private void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e) { }

		[Address(RVA = "0xFA13E0", Offset = "0xFA05E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000774")]
		internal void set_isDragging(bool value) { }

		[Address(RVA = "0xFA1410", Offset = "0xFA0610", Length = "0x73")]
		[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextField+TextInput", Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(ulong)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000776")]
		public void set_text(string value) { }

		[Address(RVA = "0xFA13F0", Offset = "0xFA05F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000770")]
		private void set_textElement(TextElement value) { }

		[Address(RVA = "0xF9A670", Offset = "0xF99870", Length = "0x7F6")]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetVerticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
		[Calls(Type = typeof(VisualElement), Member = "get_classList", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
		[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "RegisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FEF40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScrollView), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TextInputBase), Member = "RemoveMultilineComponents", ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "RemoveSingleLineComponents", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077E")]
		internal void SetMultiline() { }

		[Address(RVA = "0xF99D20", Offset = "0xF98F20", Length = "0x14F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000788")]
		private void SetMultilineContainerStyle() { }

		[Address(RVA = "0xF9BE10", Offset = "0xF9B010", Length = "0x3C3")]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(ScrollView), Member = "set_mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000787")]
		internal void SetScrollViewMode() { }

		[Address(RVA = "0xF9C7A0", Offset = "0xF9B9A0", Length = "0x2D1")]
		[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "RemoveMultilineComponents", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600077D")]
		internal void SetSingleLine() { }

		[Address(RVA = "0xF9CC40", Offset = "0xF9BE40", Length = "0xDC")]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600078B")]
		internal bool SetVerticalScrollerVisibility(ScrollerVisibility sv) { }

		[Address(RVA = "0x9674E0", Offset = "0x9666E0", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000778")]
		protected override TValueType StringToValue(string str) { }

		[Address(RVA = "0xF9CE60", Offset = "0xF9C060", Length = "0xFC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000780")]
		private void TextElementOnGeometryChangedEvent(GeometryChangedEvent e) { }

		[Address(RVA = "0xF9D060", Offset = "0xF9C260", Length = "0x1A")]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000784")]
		internal void UpdateScrollOffset(bool isBackspace = false) { }

		[Address(RVA = "0xF9D0A0", Offset = "0xF9C2A0", Length = "0x508")]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "ScrollViewOnGeometryChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "TextElementOnGeometryChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(StyleTranslate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StyleTranslate))]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TextInputBase), Member = "GetScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D8B0")]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000785")]
		internal void UpdateScrollOffset(bool isBackspace, bool widthChanged) { }

		[Address(RVA = "0xF9DFF0", Offset = "0xF9D1F0", Length = "0x94")]
		[CalledBy(Type = typeof(Hash128Field), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077A")]
		internal void UpdateTextFromValue() { }

		[Address(RVA = "0xF9E090", Offset = "0xF9D290", Length = "0x94")]
		[CalledBy(Type = typeof(Hash128Field), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "StopDragging", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "StopDragging", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000779")]
		internal void UpdateValueFromText() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000EE")]
	internal class UxmlTraits : BaseFieldTraits<String, UxmlStringAttributeDescription>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000495")]
		private UxmlIntAttributeDescription m_MaxLength; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000496")]
		private UxmlBoolAttributeDescription m_Password; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000497")]
		private UxmlStringAttributeDescription m_MaskCharacter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000498")]
		private UxmlStringAttributeDescription m_PlaceholderText; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000499")]
		private UxmlBoolAttributeDescription m_HidePlaceholderOnFocus; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049A")]
		private UxmlBoolAttributeDescription m_IsReadOnly; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049B")]
		private UxmlBoolAttributeDescription m_IsDelayed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049C")]
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049D")]
		private UxmlBoolAttributeDescription m_SelectAllOnMouseUp; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049E")]
		private UxmlBoolAttributeDescription m_SelectAllOnFocus; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049F")]
		private UxmlBoolAttributeDescription m_SelectWordByDoubleClick; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A0")]
		private UxmlBoolAttributeDescription m_SelectLineByTripleClick; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A1")]
		private UxmlBoolAttributeDescription m_EmojiFallbackSupport; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A2")]
		private UxmlBoolAttributeDescription m_HideMobileInput; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A3")]
		private UxmlEnumAttributeDescription<TouchScreenKeyboardType> m_KeyboardType; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A4")]
		private UxmlBoolAttributeDescription m_AutoCorrection; //Field offset: 0x0

		[Address(RVA = "0x84E950", Offset = "0x84DB50", Length = "0x779")]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(UxmlAttributeDescription), Member = "set_obsoleteNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseFieldTraits`2<System.Object, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600076E")]
		public UxmlTraits() { }

		[Address(RVA = "0x84D280", Offset = "0x84C480", Length = "0x7F5")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_tripleClickSelectsLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_placeholderText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_maskChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_autoCorrection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_keyboardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboardType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_hideMobileInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TextInputBaseField`1), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_doubleClickSelectsWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_hidePlaceholderOnFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_isDelayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_readOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_maxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(BaseFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600076D")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000473")]
	internal static readonly BindingId autoCorrectionProperty; //Field offset: 0x0
	[Token(Token = "0x4000492")]
	public static readonly string textInputUssName; //Field offset: 0x0
	[Token(Token = "0x4000491")]
	internal static readonly string multilineInputWithScrollViewUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000490")]
	public static readonly string placeholderUssClassName; //Field offset: 0x0
	[Token(Token = "0x400048F")]
	public static readonly string multilineInputUssClassName; //Field offset: 0x0
	[Token(Token = "0x400048E")]
	public static readonly string singleLineInputUssClassName; //Field offset: 0x0
	[Token(Token = "0x400048D")]
	internal static readonly string multilineContainerClassName; //Field offset: 0x0
	[Token(Token = "0x400048C")]
	public static readonly string inputUssClassName; //Field offset: 0x0
	[Token(Token = "0x400048B")]
	public static readonly string labelUssClassName; //Field offset: 0x0
	[Token(Token = "0x400048A")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000489")]
	private static CustomStyleProperty<Color> s_CursorColorProperty; //Field offset: 0x0
	[Token(Token = "0x4000488")]
	private static CustomStyleProperty<Color> s_SelectionColorProperty; //Field offset: 0x0
	[Token(Token = "0x4000487")]
	internal static readonly BindingId verticalScrollerVisibilityProperty; //Field offset: 0x0
	[Token(Token = "0x4000486")]
	internal static readonly BindingId maskCharProperty; //Field offset: 0x0
	[Token(Token = "0x4000485")]
	internal static readonly BindingId isDelayedProperty; //Field offset: 0x0
	[Token(Token = "0x4000484")]
	internal static readonly BindingId emojiFallbackSupportProperty; //Field offset: 0x0
	[Token(Token = "0x4000483")]
	internal static readonly BindingId tripleClickSelectsLineProperty; //Field offset: 0x0
	[Token(Token = "0x4000482")]
	internal static readonly BindingId doubleClickSelectsWordProperty; //Field offset: 0x0
	[Token(Token = "0x4000474")]
	internal static readonly BindingId hideMobileInputProperty; //Field offset: 0x0
	[Token(Token = "0x4000475")]
	internal static readonly BindingId hidePlaceholderOnFocusProperty; //Field offset: 0x0
	[Token(Token = "0x4000476")]
	internal static readonly BindingId keyboardTypeProperty; //Field offset: 0x0
	[Token(Token = "0x4000477")]
	internal static readonly BindingId isReadOnlyProperty; //Field offset: 0x0
	[Token(Token = "0x4000478")]
	internal static readonly BindingId isPasswordFieldProperty; //Field offset: 0x0
	[Token(Token = "0x4000479")]
	internal static readonly BindingId textSelectionProperty; //Field offset: 0x0
	[Token(Token = "0x400047A")]
	internal static readonly BindingId textEditionProperty; //Field offset: 0x0
	[Token(Token = "0x400047C")]
	internal static readonly BindingId cursorIndexProperty; //Field offset: 0x0
	[Token(Token = "0x400047D")]
	internal static readonly BindingId cursorPositionProperty; //Field offset: 0x0
	[Token(Token = "0x400047E")]
	internal static readonly BindingId selectIndexProperty; //Field offset: 0x0
	[Token(Token = "0x400047F")]
	internal static readonly BindingId selectAllOnFocusProperty; //Field offset: 0x0
	[Token(Token = "0x4000480")]
	internal static readonly BindingId selectAllOnMouseUpProperty; //Field offset: 0x0
	[Token(Token = "0x4000481")]
	internal static readonly BindingId maxLengthProperty; //Field offset: 0x0
	[Token(Token = "0x400047B")]
	internal static readonly BindingId placeholderTextProperty; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000493")]
	private TextInputBase<TValueType> m_TextInputBase; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000494")]
	internal bool m_UpdateTextFromValue; //Field offset: 0x0

	[CreateProperty]
	[Token(Token = "0x1700011C")]
	public bool autoCorrection
	{
		[Address(RVA = "0xFA8220", Offset = "0xFA7420", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000743")]
		 get { } //Length: 103
		[Address(RVA = "0xFA9360", Offset = "0xFA8560", Length = "0x141")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000744")]
		 set { } //Length: 321
	}

	[Token(Token = "0x1700012C")]
	virtual bool canSwitchToMixedValue
	{
		[Address(RVA = "0xFA8300", Offset = "0xFA7500", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000765")]
		 get { } //Length: 47
	}

	[CreateProperty]
	[Token(Token = "0x17000122")]
	public int cursorIndex
	{
		[Address(RVA = "0xFA8360", Offset = "0xFA7560", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074F")]
		 get { } //Length: 103
		[Address(RVA = "0xFA9750", Offset = "0xFA8950", Length = "0x145")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000750")]
		 set { } //Length: 325
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000123")]
	public Vector2 cursorPosition
	{
		[Address(RVA = "0xFA8440", Offset = "0xFA7640", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000751")]
		 get { } //Length: 103
	}

	[CreateProperty]
	[Token(Token = "0x17000127")]
	public bool doubleClickSelectsWord
	{
		[Address(RVA = "0xFA8520", Offset = "0xFA7720", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000758")]
		 get { } //Length: 103
		[Address(RVA = "0xFA99F0", Offset = "0xFA8BF0", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000759")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x1700012A")]
	public bool emojiFallbackSupport
	{
		[Address(RVA = "0xFA8600", Offset = "0xFA7800", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600075E")]
		 get { } //Length: 45
		[Address(RVA = "0xFA9B40", Offset = "0xFA8D40", Length = "0x107")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TextElement), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600075F")]
		 set { } //Length: 263
	}

	[CreateProperty]
	[Token(Token = "0x1700011D")]
	public bool hideMobileInput
	{
		[Address(RVA = "0xFA86D0", Offset = "0xFA78D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000745")]
		 get { } //Length: 103
		[Address(RVA = "0xFA9D60", Offset = "0xFA8F60", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000746")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x17000115")]
	internal bool hidePlaceholderOnFocus
	{
		[Address(RVA = "0xFA8740", Offset = "0xFA7940", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000737")]
		internal get { } //Length: 103
		[Address(RVA = "0xFAA000", Offset = "0xFA9200", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000738")]
		internal set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x17000120")]
	public override bool isDelayed
	{
		[Address(RVA = "0xFA8890", Offset = "0xFA7A90", Length = "0x67")]
		[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "StopDragging", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "StopDragging", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074B")]
		 get { } //Length: 103
		[Address(RVA = "0xFAA2A0", Offset = "0xFA94A0", Length = "0x148")]
		[CalledBy(Type = typeof(TextValueFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074C")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x1700011B")]
	public bool isPasswordField
	{
		[Address(RVA = "0xFA8900", Offset = "0xFA7B00", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000741")]
		 get { } //Length: 103
		[Address(RVA = "0xFAA540", Offset = "0xFA9740", Length = "0x165")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000742")]
		 set { } //Length: 357
	}

	[CreateProperty]
	[Token(Token = "0x1700011A")]
	public bool isReadOnly
	{
		[Address(RVA = "0xFA89E0", Offset = "0xFA7BE0", Length = "0x67")]
		[CalledBy(Type = typeof(TextValueField`1), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDraggerType"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600073F")]
		 get { } //Length: 103
		[Address(RVA = "0xFAA970", Offset = "0xFA9B70", Length = "0x148")]
		[CalledBy(Type = typeof(TextValueFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000740")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x1700011E")]
	public TouchScreenKeyboardType keyboardType
	{
		[Address(RVA = "0xFA8AC0", Offset = "0xFA7CC0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000747")]
		 get { } //Length: 103
		[Address(RVA = "0xFAAC10", Offset = "0xFA9E10", Length = "0x145")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000748")]
		 set { } //Length: 325
	}

	[CreateProperty]
	[Token(Token = "0x17000121")]
	public char maskChar
	{
		[Address(RVA = "0xFA8BA0", Offset = "0xFA7DA0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074D")]
		 get { } //Length: 103
		[Address(RVA = "0xFAAD60", Offset = "0xFA9F60", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074E")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x1700011F")]
	public int maxLength
	{
		[Address(RVA = "0xFA8CF0", Offset = "0xFA7EF0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000749")]
		 get { } //Length: 103
		[Address(RVA = "0xFAB1D0", Offset = "0xFAA3D0", Length = "0x1BF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074A")]
		 set { } //Length: 447
	}

	[Token(Token = "0x17000119")]
	protected Action<Boolean> onIsReadOnlyChanged
	{
		[Address(RVA = "0xFA8D90", Offset = "0xFA7F90", Length = "0x2D")]
		[CalledBy(Type = typeof(TextValueField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<TValueType>+TextValueInput<TValueType>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600073D")]
		 get { } //Length: 45
		[Address(RVA = "0xFAB390", Offset = "0xFAA590", Length = "0x38")]
		[CalledBy(Type = typeof(TextValueField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<TValueType>+TextValueInput<TValueType>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600073E")]
		 set { } //Length: 56
	}

	[Token(Token = "0x17000112")]
	internal bool password
	{
		[Address(RVA = "0xFAB410", Offset = "0xFAA610", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000733")]
		internal set { } //Length: 119
	}

	[CreateProperty]
	[Token(Token = "0x17000114")]
	internal string placeholderText
	{
		[Address(RVA = "0xFA8E30", Offset = "0xFA8030", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000735")]
		internal get { } //Length: 103
		[Address(RVA = "0xFAB670", Offset = "0xFAA870", Length = "0x154")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000736")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 340
	}

	[Token(Token = "0x17000113")]
	internal bool readOnly
	{
		[Address(RVA = "0xFAB7D0", Offset = "0xFAA9D0", Length = "0x154")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000734")]
		internal set { } //Length: 340
	}

	[CreateProperty]
	[Token(Token = "0x17000125")]
	public bool selectAllOnFocus
	{
		[Address(RVA = "0xFA8EA0", Offset = "0xFA80A0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000754")]
		 get { } //Length: 103
		[Address(RVA = "0xFABBE0", Offset = "0xFAADE0", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000755")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x17000126")]
	public bool selectAllOnMouseUp
	{
		[Address(RVA = "0xFA8FF0", Offset = "0xFA81F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000756")]
		 get { } //Length: 103
		[Address(RVA = "0xFABE80", Offset = "0xFAB080", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000757")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x17000124")]
	public int selectIndex
	{
		[Address(RVA = "0xFA9060", Offset = "0xFA8260", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000752")]
		 get { } //Length: 103
		[Address(RVA = "0xFABFD0", Offset = "0xFAB1D0", Length = "0x145")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000753")]
		 set { } //Length: 325
	}

	[Token(Token = "0x17000129")]
	public private string text
	{
		[Address(RVA = "0xFA91E0", Offset = "0xFA83E0", Length = "0x30")]
		[CalledBy(Type = "UnityEngine.UIElements.BaseCompositeField`3+<>c__DisplayClass18_0", Member = "<.ctor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<TFieldValue>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FloatField), Member = "UpdateValueFromText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextField), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "UpdateValueFromText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600075C")]
		 get { } //Length: 48
		[Address(RVA = "0xFAC2B0", Offset = "0xFAB4B0", Length = "0x30")]
		[CalledBy(Type = typeof(TextField), Member = "OnViewDataReady", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "UpdateTextFromValue", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextInputBase), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600075D")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		private set { } //Length: 48
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000118")]
	public ITextEdition textEdition
	{
		[Address(RVA = "0xFA9140", Offset = "0xFA8340", Length = "0x2C")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600073C")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000116")]
	protected private TextInputBase<TValueType> textInputBase
	{
		[Address(RVA = "0x826C60", Offset = "0x825E60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600073A")]
		private get { } //Length: 8
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000117")]
	public ITextSelection textSelection
	{
		[Address(RVA = "0xFA9140", Offset = "0xFA8340", Length = "0x2C")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600073B")]
		 get { } //Length: 44
	}

	[CreateProperty]
	[Token(Token = "0x17000128")]
	public bool tripleClickSelectsLine
	{
		[Address(RVA = "0xFA9290", Offset = "0xFA8490", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600075A")]
		 get { } //Length: 103
		[Address(RVA = "0xFAC2F0", Offset = "0xFAB4F0", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600075B")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x1700012B")]
	public ScrollerVisibility verticalScrollerVisibility
	{
		[Address(RVA = "0xFA9330", Offset = "0xFA8530", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000760")]
		 get { } //Length: 32
		[Address(RVA = "0xFAC590", Offset = "0xFAB790", Length = "0xC4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextInputBase), Member = "SetVerticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000761")]
		 set { } //Length: 196
	}

	[Address(RVA = "0xFA5230", Offset = "0xFA4430", Length = "0x27CE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CustomStyleProperty`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x600076C")]
	private static TextInputBaseField`1() { }

	[Address(RVA = "0xFA7A00", Offset = "0xFA6C00", Length = "0x400")]
	[CalledBy(Type = typeof(TextValueField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<TValueType>+TextValueInput<TValueType>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Focusable), Member = "set_delegatesFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Double>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000739")]
	protected TextInputBaseField`1(string label, int maxLength, char maskChar, TextInputBase<TValueType> textInputBase) { }

	[Address(RVA = "0xFA8220", Offset = "0xFA7420", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000743")]
	public bool get_autoCorrection() { }

	[Address(RVA = "0xFA8300", Offset = "0xFA7500", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000765")]
	virtual bool get_canSwitchToMixedValue() { }

	[Address(RVA = "0xFA8360", Offset = "0xFA7560", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600074F")]
	public int get_cursorIndex() { }

	[Address(RVA = "0xFA8440", Offset = "0xFA7640", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000751")]
	public Vector2 get_cursorPosition() { }

	[Address(RVA = "0xFA8520", Offset = "0xFA7720", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000758")]
	public bool get_doubleClickSelectsWord() { }

	[Address(RVA = "0xFA8600", Offset = "0xFA7800", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600075E")]
	public bool get_emojiFallbackSupport() { }

	[Address(RVA = "0xFA86D0", Offset = "0xFA78D0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000745")]
	public bool get_hideMobileInput() { }

	[Address(RVA = "0xFA8740", Offset = "0xFA7940", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000737")]
	internal bool get_hidePlaceholderOnFocus() { }

	[Address(RVA = "0xFA8890", Offset = "0xFA7A90", Length = "0x67")]
	[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "StopDragging", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "StopDragging", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600074B")]
	public override bool get_isDelayed() { }

	[Address(RVA = "0xFA8900", Offset = "0xFA7B00", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000741")]
	public bool get_isPasswordField() { }

	[Address(RVA = "0xFA89E0", Offset = "0xFA7BE0", Length = "0x67")]
	[CalledBy(Type = typeof(TextValueField`1), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDraggerType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600073F")]
	public bool get_isReadOnly() { }

	[Address(RVA = "0xFA8AC0", Offset = "0xFA7CC0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000747")]
	public TouchScreenKeyboardType get_keyboardType() { }

	[Address(RVA = "0xFA8BA0", Offset = "0xFA7DA0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600074D")]
	public char get_maskChar() { }

	[Address(RVA = "0xFA8CF0", Offset = "0xFA7EF0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000749")]
	public int get_maxLength() { }

	[Address(RVA = "0xFA8D90", Offset = "0xFA7F90", Length = "0x2D")]
	[CalledBy(Type = typeof(TextValueField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<TValueType>+TextValueInput<TValueType>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600073D")]
	protected Action<Boolean> get_onIsReadOnlyChanged() { }

	[Address(RVA = "0xFA8E30", Offset = "0xFA8030", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000735")]
	internal string get_placeholderText() { }

	[Address(RVA = "0xFA8EA0", Offset = "0xFA80A0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000754")]
	public bool get_selectAllOnFocus() { }

	[Address(RVA = "0xFA8FF0", Offset = "0xFA81F0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000756")]
	public bool get_selectAllOnMouseUp() { }

	[Address(RVA = "0xFA9060", Offset = "0xFA8260", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000752")]
	public int get_selectIndex() { }

	[Address(RVA = "0xFA91E0", Offset = "0xFA83E0", Length = "0x30")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseCompositeField`3+<>c__DisplayClass18_0", Member = "<.ctor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<TFieldValue>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FloatField), Member = "UpdateValueFromText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextField), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "UpdateValueFromText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600075C")]
	public string get_text() { }

	[Address(RVA = "0xFA9140", Offset = "0xFA8340", Length = "0x2C")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600073C")]
	public ITextEdition get_textEdition() { }

	[Address(RVA = "0x826C60", Offset = "0x825E60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600073A")]
	protected private TextInputBase<TValueType> get_textInputBase() { }

	[Address(RVA = "0xFA9140", Offset = "0xFA8340", Length = "0x2C")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600073B")]
	public ITextSelection get_textSelection() { }

	[Address(RVA = "0xFA9290", Offset = "0xFA8490", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600075A")]
	public bool get_tripleClickSelectsLine() { }

	[Address(RVA = "0xFA9330", Offset = "0xFA8530", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000760")]
	public ScrollerVisibility get_verticalScrollerVisibility() { }

	[Address(RVA = "0xFA18B0", Offset = "0xFA0AB0", Length = "0x41C")]
	[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Double>), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInputBaseField`1), Member = "UpdatePlaceholderClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<TValueType>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationSubmitEvent), typeof(FocusInEvent), typeof(FocusEvent), typeof(FocusOutEvent), typeof(BlurEvent)})]
	[Token(Token = "0x6000762")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0xFA1CD0", Offset = "0xFA0ED0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600076B")]
	private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e) { }

	[Address(RVA = "0xFA1EE0", Offset = "0xFA10E0", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInputBaseField`1), Member = "UpdatePlaceholderClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<TValueType>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000767")]
	internal void OnPlaceholderChanged() { }

	[Address(RVA = "0xFA9360", Offset = "0xFA8560", Length = "0x141")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000744")]
	public void set_autoCorrection(bool value) { }

	[Address(RVA = "0xFA9750", Offset = "0xFA8950", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000750")]
	public void set_cursorIndex(int value) { }

	[Address(RVA = "0xFA99F0", Offset = "0xFA8BF0", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000759")]
	public void set_doubleClickSelectsWord(bool value) { }

	[Address(RVA = "0xFA9B40", Offset = "0xFA8D40", Length = "0x107")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextElement), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600075F")]
	public void set_emojiFallbackSupport(bool value) { }

	[Address(RVA = "0xFA9D60", Offset = "0xFA8F60", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000746")]
	public void set_hideMobileInput(bool value) { }

	[Address(RVA = "0xFAA000", Offset = "0xFA9200", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000738")]
	internal void set_hidePlaceholderOnFocus(bool value) { }

	[Address(RVA = "0xFAA2A0", Offset = "0xFA94A0", Length = "0x148")]
	[CalledBy(Type = typeof(TextValueFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600074C")]
	public void set_isDelayed(bool value) { }

	[Address(RVA = "0xFAA540", Offset = "0xFA9740", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000742")]
	public void set_isPasswordField(bool value) { }

	[Address(RVA = "0xFAA970", Offset = "0xFA9B70", Length = "0x148")]
	[CalledBy(Type = typeof(TextValueFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000740")]
	public void set_isReadOnly(bool value) { }

	[Address(RVA = "0xFAAC10", Offset = "0xFA9E10", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000748")]
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	[Address(RVA = "0xFAAD60", Offset = "0xFA9F60", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600074E")]
	public void set_maskChar(char value) { }

	[Address(RVA = "0xFAB1D0", Offset = "0xFAA3D0", Length = "0x1BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600074A")]
	public void set_maxLength(int value) { }

	[Address(RVA = "0xFAB390", Offset = "0xFAA590", Length = "0x38")]
	[CalledBy(Type = typeof(TextValueField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<TValueType>+TextValueInput<TValueType>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600073E")]
	protected void set_onIsReadOnlyChanged(Action<Boolean> value) { }

	[Address(RVA = "0xFAB410", Offset = "0xFAA610", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000733")]
	internal void set_password(bool value) { }

	[Address(RVA = "0xFAB670", Offset = "0xFAA870", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000736")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_placeholderText(string value) { }

	[Address(RVA = "0xFAB7D0", Offset = "0xFAA9D0", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000734")]
	internal void set_readOnly(bool value) { }

	[Address(RVA = "0xFABBE0", Offset = "0xFAADE0", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000755")]
	public void set_selectAllOnFocus(bool value) { }

	[Address(RVA = "0xFABE80", Offset = "0xFAB080", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000757")]
	public void set_selectAllOnMouseUp(bool value) { }

	[Address(RVA = "0xFABFD0", Offset = "0xFAB1D0", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000753")]
	public void set_selectIndex(int value) { }

	[Address(RVA = "0xFAC2B0", Offset = "0xFAB4B0", Length = "0x30")]
	[CalledBy(Type = typeof(TextField), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "UpdateTextFromValue", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextInputBase), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600075D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	protected private void set_text(string value) { }

	[Address(RVA = "0xFAC2F0", Offset = "0xFAB4F0", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600075B")]
	public void set_tripleClickSelectsLine(bool value) { }

	[Address(RVA = "0xFAC590", Offset = "0xFAB790", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputBase), Member = "SetVerticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000761")]
	public void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	[Token(Token = "0x6000764")]
	protected abstract TValueType StringToValue(string str) { }

	[Address(RVA = "0xFA2380", Offset = "0xFA1580", Length = "0x30B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000766")]
	protected virtual void UpdateMixedValueContent() { }

	[Address(RVA = "0xFA27F0", Offset = "0xFA19F0", Length = "0x15D")]
	[CalledBy(Type = typeof(TextInputBaseField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBaseField`1), Member = "OnPlaceholderChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "UpdateValueFromText", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextElement), Member = "get_showPlaceholderText", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000768")]
	internal void UpdatePlaceholderClassList(ChangeEvent<TValueType> evt = null) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600076A")]
	internal override void UpdateTextFromValue() { }

	[Address(RVA = "0xFA2950", Offset = "0xFA1B50", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000769")]
	internal override void UpdateValueFromText() { }

	[Token(Token = "0x6000763")]
	protected abstract string ValueToString(TValueType value) { }

}

