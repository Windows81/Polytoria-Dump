namespace UnityEngine.UIElements;

[Token(Token = "0x2000131")]
public class RadioButtonGroup : BaseField<Int32>, IGroupBox
{
	[CompilerGenerated]
	[Token(Token = "0x2000134")]
	private sealed class <get_choices>d__17 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005E6")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005E7")]
		private string <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40005E8")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40005E9")]
		public RadioButtonGroup <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40005EA")]
		private PooledObject<List`1<RadioButton>> <_>5__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40005EB")]
		private List<RadioButton> <radioButtons>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40005EC")]
		private Enumerator<RadioButton> <>s__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40005ED")]
		private RadioButton <button>5__4; //Field offset: 0x60

		[Token(Token = "0x17000193")]
		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600096F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000194")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000971")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600096A")]
		public <get_choices>d__17(int <>1__state) { }

		[Address(RVA = "0x1C2C370", Offset = "0x1C2B570", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Token(Token = "0x600096D")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1C2C3C0", Offset = "0x1C2B5C0", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600096E")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x1C2BEB0", Offset = "0x1C2B0B0", Length = "0x2D1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(RadioButtonGroup), Member = "GetAllRadioButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.RadioButton>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseBoolField), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C16D70")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600096C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1C2C190", Offset = "0x1C2B390", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000972")]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600096F")]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[Address(RVA = "0x1C2C190", Offset = "0x1C2B390", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000973")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000971")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1C2C230", Offset = "0x1C2B430", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000970")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1C2C270", Offset = "0x1C2B470", Length = "0xF9")]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C16D20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C16D80")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[Token(Token = "0x600096B")]
		private override void System.IDisposable.Dispose() { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000132")]
	internal class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits>
	{

		[Address(RVA = "0x1C2C490", Offset = "0x1C2B690", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000967")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000133")]
	internal class UxmlTraits : BaseFieldTraits<Int32, UxmlIntAttributeDescription>
	{
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40005E5")]
		private UxmlStringAttributeDescription m_Choices; //Field offset: 0xA0

		[Address(RVA = "0x1C2FBC0", Offset = "0x1C2EDC0", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseFieldTraits`2<System.Int32, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000969")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C2E820", Offset = "0x1C2DA20", Length = "0x14C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlUtility), Member = "ParseStringListAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
		[Calls(Type = typeof(RadioButtonGroup), Member = "set_choices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000968")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40005D8")]
	internal static readonly BindingId choicesProperty; //Field offset: 0x0
	[Token(Token = "0x40005D9")]
	public static readonly string ussClassName; //Field offset: 0x98
	[Token(Token = "0x40005DA")]
	public static readonly string containerUssClassName; //Field offset: 0xA0
	[Token(Token = "0x40005DB")]
	internal static readonly string containerName; //Field offset: 0xA8
	[Token(Token = "0x40005DC")]
	internal static readonly string choicesContainerName; //Field offset: 0xB0
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x40005DD")]
	private VisualElement m_ChoiceRadioButtonContainer; //Field offset: 0x360
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x40005DE")]
	private VisualElement m_ContentContainer; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x40005DF")]
	private UQueryBuilder<RadioButton> m_GetAllRadioButtonsQuery; //Field offset: 0x370
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x40005E0")]
	private readonly List<RadioButton> m_RegisteredRadioButtons; //Field offset: 0x3A0
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x40005E1")]
	private RadioButton m_SelectedRadioButton; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x3B0")]
	[Token(Token = "0x40005E2")]
	private EventCallback<ChangeEvent`1<Boolean>> m_RadioButtonValueChangedCallback; //Field offset: 0x3B0
	[FieldOffset(Offset = "0x3B8")]
	[Token(Token = "0x40005E3")]
	private bool m_UpdatingButtons; //Field offset: 0x3B8
	[FieldOffset(Offset = "0x3C0")]
	[Token(Token = "0x40005E4")]
	private List<String> m_Choices; //Field offset: 0x3C0

	[CreateProperty]
	[Token(Token = "0x17000190")]
	public IEnumerable<String> choices
	{
		[Address(RVA = "0x1C1B960", Offset = "0x1C1AB60", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[IteratorStateMachine(typeof(<get_choices>d__17))]
		[Token(Token = "0x6000954")]
		 get { } //Length: 113
		[Address(RVA = "0x1C1BA10", Offset = "0x1C1AC10", Length = "0x142")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RadioButtonGroup), Member = "set_choicesList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RadioButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(RadioButtonGroup), Member = "<set_choices>g__AreListEqual|18_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000955")]
		 set { } //Length: 322
	}

	[Token(Token = "0x17000191")]
	internal List<String> choicesList
	{
		[Address(RVA = "0x1C1BA00", Offset = "0x1C1AC00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RadioButtonGroup), Member = "set_choices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000957")]
		internal set { } //Length: 8
	}

	[Token(Token = "0x17000192")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x1C1B9E0", Offset = "0x1C1ABE0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000958")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x1C1B2D0", Offset = "0x1C1A4D0", Length = "0x25C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000964")]
	private static RadioButtonGroup() { }

	[Address(RVA = "0x1C1B530", Offset = "0x1C1A730", Length = "0x412")]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RadioButtonGroup), Member = "set_choices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryExtensions), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_delegatesFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600095A")]
	public RadioButtonGroup(string label, List<String> radioButtonChoices = null) { }

	[Address(RVA = "0x1C1B950", Offset = "0x1C1AB50", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadioButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000959")]
	public RadioButtonGroup() { }

	[Address(RVA = "0x1C1A710", Offset = "0x1C19910", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadioButtonGroup), Member = "UpdateRadioButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[Token(Token = "0x6000966")]
	private void <ScheduleRadioButtons>b__31_0() { }

	[Address(RVA = "0x1C1A720", Offset = "0x1C19920", Length = "0x375")]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "set_choices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[Token(Token = "0x6000965")]
	internal static bool <set_choices>g__AreListEqual|18_0(List<String> list1, IEnumerable<String> list2) { }

	[Address(RVA = "0x1C1B960", Offset = "0x1C1AB60", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<get_choices>d__17))]
	[Token(Token = "0x6000954")]
	public IEnumerable<String> get_choices() { }

	[Address(RVA = "0x1C1B9E0", Offset = "0x1C1ABE0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000958")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x1C19CD0", Offset = "0x1C18ED0", Length = "0xC0")]
	[CalledBy(Type = typeof(<get_choices>d__17), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600095D")]
	private void GetAllRadioButtons(List<RadioButton> radioButtons) { }

	[Address(RVA = "0x1C19DA0", Offset = "0x1C18FA0", Length = "0x25A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600095B")]
	private void RadioButtonValueChangedCallback(ChangeEvent<Boolean> evt) { }

	[Address(RVA = "0x1C1A000", Offset = "0x1C19200", Length = "0x2DC")]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "set_choices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RadioButtonGroup), Member = "ScheduleRadioButtons", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseBoolField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RadioButton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(VisualElement), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000956")]
	private void RebuildRadioButtonsFromChoices() { }

	[Address(RVA = "0x1C1A2E0", Offset = "0x1C194E0", Length = "0x302")]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "UnityEngine.UIElements.IGroupBox.OnOptionAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGroupBoxOption)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RadioButtonGroup), Member = "ScheduleRadioButtons", ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "RegisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000960")]
	private void RegisterRadioButton(RadioButton radioButton) { }

	[Address(RVA = "0x1C1A5F0", Offset = "0x1C197F0", Length = "0xB9")]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RegisterRadioButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadioButton)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600095F")]
	private void ScheduleRadioButtons() { }

	[Address(RVA = "0x1C1BA10", Offset = "0x1C1AC10", Length = "0x142")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "set_choicesList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RadioButtonGroup), Member = "<set_choices>g__AreListEqual|18_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000955")]
	public void set_choices(IEnumerable<String> value) { }

	[Address(RVA = "0x1C1BA00", Offset = "0x1C1AC00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadioButtonGroup), Member = "set_choices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000957")]
	internal void set_choicesList(List<String> value) { }

	[Address(RVA = "0x1C1A6B0", Offset = "0x1C198B0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RadioButtonGroup), Member = "UpdateRadioButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600095C")]
	public virtual void SetValueWithoutNotify(int newValue) { }

	[Address(RVA = "0x1C1AAA0", Offset = "0x1C19CA0", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RadioButtonGroup), Member = "RegisterRadioButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadioButton)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000962")]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	[Address(RVA = "0x1C1AB60", Offset = "0x1C19D60", Length = "0x197")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "UnregisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RadioButtonGroup), Member = "UpdateRadioButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000963")]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	[Address(RVA = "0x1C1AD00", Offset = "0x1C19F00", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "UnregisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RadioButtonGroup), Member = "UpdateRadioButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000961")]
	private void UnregisterRadioButton(RadioButton radioButton) { }

	[Address(RVA = "0x1C1ADC0", Offset = "0x1C19FC0", Length = "0x50A")]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "UnregisterRadioButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadioButton)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "UnityEngine.UIElements.IGroupBox.OnOptionRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGroupBoxOption)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "<ScheduleRadioButtons>b__31_0", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600095E")]
	private void UpdateRadioButtons(bool notify) { }

}

