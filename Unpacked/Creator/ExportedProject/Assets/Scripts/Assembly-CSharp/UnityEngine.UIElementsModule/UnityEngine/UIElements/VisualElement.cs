namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[Token(Token = "0x2000371")]
public class VisualElement : Focusable, IResolvedStyle, IStylePropertyAnimations, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler
{
	[CompilerGenerated]
	[Token(Token = "0x200037C")]
	private sealed class <>c__DisplayClass533_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CD0")]
		public VisualElement <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000CD1")]
		public StyleValues to; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B80")]
		public <>c__DisplayClass533_0() { }

		[Address(RVA = "0x1B1DCA0", Offset = "0x1B1CEA0", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "ReadCurrentValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleValues)}, ReturnType = typeof(StyleValues))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B81")]
		internal StyleValues <UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0(VisualElement e) { }

	}

	[Token(Token = "0x2000376")]
	private abstract class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000CC4")]
		private VisualElement <element>k__BackingField; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000CC5")]
		public bool isScheduled; //Field offset: 0x40
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x41")]
		[Token(Token = "0x4000CC6")]
		private bool <isActive>k__BackingField; //Field offset: 0x41
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x42")]
		[Token(Token = "0x4000CC7")]
		private bool <isDetaching>k__BackingField; //Field offset: 0x42
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000CC8")]
		private readonly EventCallback<AttachToPanelEvent> m_OnAttachToPanelCallback; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000CC9")]
		private readonly EventCallback<DetachFromPanelEvent> m_OnDetachFromPanelCallback; //Field offset: 0x50

		[Token(Token = "0x1700075B")]
		public private override VisualElement element
		{
			[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
			[CallerCount(Count = 16)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B56")]
			 get { } //Length: 5
			[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B57")]
			private set { } //Length: 13
		}

		[Token(Token = "0x1700075C")]
		public private override bool isActive
		{
			[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B58")]
			 get { } //Length: 5
			[Address(RVA = "0x16BD1A0", Offset = "0x16BC3A0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B59")]
			private set { } //Length: 4
		}

		[Token(Token = "0x1700075D")]
		public private bool isDetaching
		{
			[Address(RVA = "0x16BD180", Offset = "0x16BC380", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B5A")]
			 get { } //Length: 5
			[Address(RVA = "0x16BD1B0", Offset = "0x16BC3B0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B5B")]
			private set { } //Length: 4
		}

		[Address(RVA = "0x1B088C0", Offset = "0x1B07AC0", Length = "0x101")]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement+VisualElementScheduledItem`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "ActionType"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ScheduledItem), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001B5C")]
		protected BaseVisualElementScheduledItem(VisualElement handler) { }

		[Address(RVA = "0x1B08260", Offset = "0x1B07460", Length = "0x48")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B6B")]
		public bool CanBeActivated() { }

		[Address(RVA = "0x1B082B0", Offset = "0x1B074B0", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001B64")]
		public override IVisualElementScheduledItem Every(long intervalMs) { }

		[Address(RVA = "0x1B08370", Offset = "0x1B07570", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScheduledItem), Member = "ResetStartTime", ReturnType = typeof(void))]
		[Token(Token = "0x6001B68")]
		public override void ExecuteLater(long delayMs) { }

		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B56")]
		public override VisualElement get_element() { }

		[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B58")]
		public override bool get_isActive() { }

		[Address(RVA = "0x16BD180", Offset = "0x16BC380", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B5A")]
		public bool get_isDetaching() { }

		[Address(RVA = "0x1B083B0", Offset = "0x1B075B0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SendActivation", ReturnType = typeof(void))]
		[Token(Token = "0x6001B60")]
		private void OnElementAttachToPanelCallback(AttachToPanelEvent evt) { }

		[Address(RVA = "0x1B083C0", Offset = "0x1B075C0", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SendDeactivation", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6001B61")]
		private void OnElementDetachFromPanelCallback(DetachFromPanelEvent evt) { }

		[Address(RVA = "0x1B08420", Offset = "0x1B07620", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B65")]
		internal virtual void OnItemUnscheduled() { }

		[Address(RVA = "0x1B08460", Offset = "0x1B07660", Length = "0x8D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ScheduledItem), Member = "ResetStartTime", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001B69")]
		public void OnPanelActivate() { }

		[Address(RVA = "0x1B084F0", Offset = "0x1B076F0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001B6A")]
		public void OnPanelDeactivate() { }

		[Address(RVA = "0x1B08580", Offset = "0x1B07780", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001B67")]
		public override void Pause() { }

		[Address(RVA = "0x1B08590", Offset = "0x1B07790", Length = "0xA")]
		[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.IVisualElementScheduler.Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.TimerState>)}, ReturnType = typeof(IVisualElementScheduledItem))]
		[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.IVisualElementScheduler.Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(IVisualElementScheduledItem))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001B66")]
		public override void Resume() { }

		[Address(RVA = "0x1B085A0", Offset = "0x1B077A0", Length = "0xC9")]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "OnElementAttachToPanelCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ScheduledItem), Member = "ResetStartTime", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001B5E")]
		private void SendActivation() { }

		[Address(RVA = "0x1B08670", Offset = "0x1B07870", Length = "0xBC")]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "OnElementDetachFromPanelCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetachFromPanelEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001B5F")]
		private void SendDeactivation() { }

		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B57")]
		private void set_element(VisualElement value) { }

		[Address(RVA = "0x16BD1A0", Offset = "0x16BC3A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B59")]
		private void set_isActive(bool value) { }

		[Address(RVA = "0x16BD1B0", Offset = "0x16BC3B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B5B")]
		private void set_isDetaching(bool value) { }

		[Address(RVA = "0x1B08730", Offset = "0x1B07930", Length = "0xF1")]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "OnItemUnscheduled", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "Resume", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "Pause", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "ExecuteLater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SendDeactivation", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SendActivation", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001B5D")]
		private void SetActive(bool action) { }

		[Address(RVA = "0x1B08830", Offset = "0x1B07A30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001B62")]
		public override IVisualElementScheduledItem StartingIn(long delayMs) { }

		[Address(RVA = "0x1B08840", Offset = "0x1B07A40", Length = "0x78")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001B63")]
		public override IVisualElementScheduledItem Until(Func<Boolean> stopCondition) { }

	}

	[Token(Token = "0x200037A")]
	public class CustomStyleAccess : ICustomStyle
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CCB")]
		private Dictionary<String, StylePropertyValue> m_CustomProperties; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000CCC")]
		private float m_DpiScaling; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B7B")]
		public CustomStyleAccess() { }

		[Address(RVA = "0x1B099B0", Offset = "0x1B08BB0", Length = "0xD3")]
		[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.Single>), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color>), typeof(Color&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StyleValueType), typeof(StylePropertyValue&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B7A")]
		private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp) { }

		[Address(RVA = "0x1B09A90", Offset = "0x1B08C90", Length = "0x2E")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001B71")]
		public void SetContext(Dictionary<String, StylePropertyValue> customProperties, float dpiScaling) { }

		[Address(RVA = "0x1B09EB0", Offset = "0x1B090B0", Length = "0x103")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CustomStyleAccess), Member = "LogCustomPropertyWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StyleValueType), typeof(StylePropertyValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StyleSheet), Member = "TryReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B72")]
		public override bool TryGetValue(CustomStyleProperty<Single> property, out float value) { }

		[Address(RVA = "0x1B09BC0", Offset = "0x1B08DC0", Length = "0x113")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CustomStyleAccess), Member = "LogCustomPropertyWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StyleValueType), typeof(StylePropertyValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StyleSheet), Member = "TryReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B73")]
		public override bool TryGetValue(CustomStyleProperty<Int32> property, out int value) { }

		[Address(RVA = "0x1B09AC0", Offset = "0x1B08CC0", Length = "0xF2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CustomStyleAccess), Member = "LogCustomPropertyWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StyleValueType), typeof(StylePropertyValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StyleSheet), Member = "TryReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Color&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B74")]
		public override bool TryGetValue(CustomStyleProperty<Color> property, out Color value) { }

		[Address(RVA = "0x1B09CE0", Offset = "0x1B08EE0", Length = "0x103")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001B75")]
		public override bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value) { }

		[Address(RVA = "0x1B0A0D0", Offset = "0x1B092D0", Length = "0x103")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001B76")]
		public override bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value) { }

		[Address(RVA = "0x1B09FC0", Offset = "0x1B091C0", Length = "0x103")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001B77")]
		public override bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value) { }

		[Address(RVA = "0x1B0A1E0", Offset = "0x1B093E0", Length = "0xB8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001B78")]
		public override bool TryGetValue(CustomStyleProperty<String> property, out string value) { }

		[Address(RVA = "0x1B09DF0", Offset = "0x1B08FF0", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CustomStyleAccess), Member = "LogCustomPropertyWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StyleValueType), typeof(StylePropertyValue)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B79")]
		private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x2000375")]
	internal struct Hierarchy
	{
		[Token(Token = "0x4000CC2")]
		private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation"; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CC3")]
		private readonly VisualElement m_Owner; //Field offset: 0x0

		[Token(Token = "0x17000759")]
		public int childCount
		{
			[Address(RVA = "0x1B0C490", Offset = "0x1B0B690", Length = "0x47")]
			[CallerCount(Count = 27)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6001B49")]
			 get { } //Length: 71
		}

		[Token(Token = "0x17000758")]
		internal List<VisualElement> children
		{
			[Address(RVA = "0x1B0ADE0", Offset = "0x1B09FE0", Length = "0x1D")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B3E")]
			internal get { } //Length: 29
		}

		[Token(Token = "0x1700075A")]
		public VisualElement Item
		{
			[Address(RVA = "0x1B0B3A0", Offset = "0x1B0A5A0", Length = "0x5C")]
			[CallerCount(Count = 25)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B4A")]
			 get { } //Length: 92
		}

		[Token(Token = "0x17000757")]
		public VisualElement parent
		{
			[Address(RVA = "0x1B0C4E0", Offset = "0x1B0B6E0", Length = "0x1D")]
			[CallerCount(Count = 111)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6001B3D")]
			 get { } //Length: 29
		}

		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B3F")]
		internal Hierarchy(VisualElement element) { }

		[Address(RVA = "0x1B0AC00", Offset = "0x1B09E00", Length = "0xAE")]
		[CallerCount(Count = 42)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B40")]
		public void Add(VisualElement child) { }

		[Address(RVA = "0x1B0ACB0", Offset = "0x1B09EB0", Length = "0x123")]
		[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "set_makeFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B45")]
		internal void BringToFront(VisualElement child) { }

		[Address(RVA = "0x1B0ADE0", Offset = "0x1B09FE0", Length = "0x1D")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B4D")]
		public IEnumerable<VisualElement> Children() { }

		[Address(RVA = "0x1B0AE00", Offset = "0x1B0A000", Length = "0x595")]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "Clear", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "AssignMeasureFunction", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElementListPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "ChangeIMGUIContainerCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "DirtyNextParentWithEventInterests", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElement), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutNode), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_requireMeasureFunction", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(Hierarchy), Member = "ReleaseChildList", ReturnType = typeof(void))]
		[Calls(Type = typeof(WorldSpaceDataStore), Member = "ClearWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(VisualElementListPool), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B44")]
		public void Clear() { }

		[Address(RVA = "0x1B0B3A0", Offset = "0x1B0A5A0", Length = "0x5C")]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B4C")]
		public VisualElement ElementAt(int index) { }

		[Address(RVA = "0x1B0B400", Offset = "0x1B0A600", Length = "0x9F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B53")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x1B0B4A0", Offset = "0x1B0A6A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B52")]
		public bool Equals(Hierarchy other) { }

		[Address(RVA = "0x1B0C490", Offset = "0x1B0B690", Length = "0x47")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B49")]
		public int get_childCount() { }

		[Address(RVA = "0x1B0ADE0", Offset = "0x1B09FE0", Length = "0x1D")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B3E")]
		internal List<VisualElement> get_children() { }

		[Address(RVA = "0x1B0B3A0", Offset = "0x1B0A5A0", Length = "0x5C")]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B4A")]
		public VisualElement get_Item(int key) { }

		[Address(RVA = "0x1B0C4E0", Offset = "0x1B0B6E0", Length = "0x1D")]
		[CallerCount(Count = 111)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B3D")]
		public VisualElement get_parent() { }

		[Address(RVA = "0x1B0B4B0", Offset = "0x1B0A6B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B54")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x1B0B4E0", Offset = "0x1B0A6E0", Length = "0x5E")]
		[CalledBy(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VisualElement), Member = "FindElementInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B4B")]
		public int IndexOf(VisualElement element) { }

		[Address(RVA = "0x1B0B540", Offset = "0x1B0A740", Length = "0x3D6")]
		[CalledBy(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseField`1), Member = "set_label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = "PrepareView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabView), Member = "OnElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(VisualElement), Member = "RemoveMeasureFunction", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Hierarchy), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(Hierarchy), Member = "PutChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(LayoutNode), Member = "get_UsesMeasure", ReturnType = typeof(bool))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElementListPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "ChangeIMGUIContainerCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B41")]
		public void Insert(int index, VisualElement child) { }

		[Address(RVA = "0x1B0B920", Offset = "0x1B0AB20", Length = "0x104")]
		[CalledBy(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "SendToBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "PlaceBehind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(VisualElement), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "RemoveChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "PutChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001B48")]
		private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex) { }

		[Address(RVA = "0x1B0C500", Offset = "0x1B0B700", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B55")]
		public static bool op_Equality(Hierarchy x, Hierarchy y) { }

		[Address(RVA = "0x1B0BA30", Offset = "0x1B0AC30", Length = "0xF1")]
		[CalledBy(Type = typeof(VisualElement), Member = "PlaceBehind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B47")]
		internal void PlaceBehind(VisualElement child, VisualElement over) { }

		[Address(RVA = "0x1B0BB30", Offset = "0x1B0AD30", Length = "0x1DA")]
		[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(LayoutNode), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(LayoutNode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(LayoutNode), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6001B4F")]
		private void PutChildAtIndex(VisualElement child, int index) { }

		[Address(RVA = "0x1B0BD10", Offset = "0x1B0AF10", Length = "0xFC")]
		[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElementListPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B51")]
		private void ReleaseChildList() { }

		[Address(RVA = "0x1B0C1D0", Offset = "0x1B0B3D0", Length = "0x127")]
		[CalledBy(Type = typeof(VisualElement), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B42")]
		public void Remove(VisualElement child) { }

		[Address(RVA = "0x1B0BE10", Offset = "0x1B0B010", Length = "0x33A")]
		[CalledBy(Type = typeof(Hierarchy), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Hierarchy), Member = "ReleaseChildList", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "AssignMeasureFunction", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_requireMeasureFunction", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hierarchy), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(VisualElement), Member = "ChangeIMGUIContainerCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "RemoveChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WorldSpaceDataStore), Member = "ClearWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B43")]
		public void RemoveAt(int index) { }

		[Address(RVA = "0x1B0C150", Offset = "0x1B0B350", Length = "0x78")]
		[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(LayoutNode), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B50")]
		private void RemoveChildAtIndex(int index) { }

		[Address(RVA = "0x1B0C300", Offset = "0x1B0B500", Length = "0x9F")]
		[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "SendToBack", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B46")]
		internal void SendToBack(VisualElement child) { }

		[Address(RVA = "0x1B0C3A0", Offset = "0x1B0B5A0", Length = "0xEF")]
		[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElement), Member = "DirtyNextParentWithEventInterests", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B4E")]
		private void SetParent(VisualElement value) { }

	}

	[Token(Token = "0x2000374")]
	internal enum MeasureMode
	{
		Undefined = 0,
		Exactly = 1,
		AtMost = 2,
	}

	[Token(Token = "0x2000379")]
	private class SimpleScheduledItem : VisualElementScheduledItem<Action>
	{

		[Address(RVA = "0x1B15550", Offset = "0x1B14750", Length = "0x58")]
		[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.IVisualElementScheduler.Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(IVisualElementScheduledItem))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.VisualElement+VisualElementScheduledItem`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "ActionType"}, ReturnType = typeof(void))]
		[Token(Token = "0x6001B6F")]
		public SimpleScheduledItem(VisualElement handler, Action updateEvent) { }

		[Address(RVA = "0x1B15510", Offset = "0x1B14710", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001B70")]
		public virtual void PerformTimerUpdate(TimerState state) { }

	}

	[Token(Token = "0x2000378")]
	private class TimerStateScheduledItem : VisualElementScheduledItem<Action`1<TimerState>>
	{

		[Address(RVA = "0x1B1BAD0", Offset = "0x1B1ACD0", Length = "0x58")]
		[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.IVisualElementScheduler.Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.TimerState>)}, ReturnType = typeof(IVisualElementScheduledItem))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.VisualElement+VisualElementScheduledItem`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "ActionType"}, ReturnType = typeof(void))]
		[Token(Token = "0x6001B6D")]
		public TimerStateScheduledItem(VisualElement handler, Action<TimerState> updateEvent) { }

		[Address(RVA = "0x1B1BA90", Offset = "0x1B1AC90", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001B6E")]
		public virtual void PerformTimerUpdate(TimerState state) { }

	}

	[Token(Token = "0x200037B")]
	public class TypeData
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CCD")]
		private readonly Type <type>k__BackingField; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000CCE")]
		private string m_FullTypeName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000CCF")]
		private string m_TypeName; //Field offset: 0x20

		[Token(Token = "0x1700075F")]
		public string fullTypeName
		{
			[Address(RVA = "0x1B1DB70", Offset = "0x1B1CD70", Length = "0x53")]
			[CalledBy(Type = typeof(VisualElement), Member = "get_fullTypeName", ReturnType = typeof(string))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6001B7E")]
			 get { } //Length: 83
		}

		[Token(Token = "0x1700075E")]
		public Type type
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B7C")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000760")]
		public string typeName
		{
			[Address(RVA = "0x1B1DBD0", Offset = "0x1B1CDD0", Length = "0xC6")]
			[CalledBy(Type = typeof(VisualElement), Member = "get_typeName", ReturnType = typeof(string))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 2)]
			[Token(Token = "0x6001B7F")]
			 get { } //Length: 198
		}

		[Address(RVA = "0x1B1DB00", Offset = "0x1B1CD00", Length = "0x70")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_typeData", ReturnType = typeof(TypeData))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B7D")]
		public TypeData(Type type) { }

		[Address(RVA = "0x1B1DB70", Offset = "0x1B1CD70", Length = "0x53")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_fullTypeName", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001B7E")]
		public string get_fullTypeName() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B7C")]
		public Type get_type() { }

		[Address(RVA = "0x1B1DBD0", Offset = "0x1B1CDD0", Length = "0xC6")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_typeName", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001B7F")]
		public string get_typeName() { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000372")]
	internal class UxmlFactory : UxmlFactory<VisualElement, UxmlTraits>
	{

		[Address(RVA = "0x1B1F110", Offset = "0x1B1E310", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001B38")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000373")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000CB0")]
		protected UxmlStringAttributeDescription m_Name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000CB1")]
		private UxmlBoolAttributeDescription m_EnabledSelf; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000CB2")]
		private UxmlStringAttributeDescription m_ViewDataKey; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000CB3")]
		protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000CB4")]
		private UxmlStringAttributeDescription m_Tooltip; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000CB5")]
		private UxmlEnumAttributeDescription<UsageHints> m_UsageHints; //Field offset: 0x40
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000CB6")]
		private UxmlIntAttributeDescription <focusIndex>k__BackingField; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000CB7")]
		private UxmlIntAttributeDescription m_TabIndex; //Field offset: 0x50
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000CB8")]
		private UxmlBoolAttributeDescription <focusable>k__BackingField; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000CB9")]
		private UxmlStringAttributeDescription m_Class; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000CBA")]
		private UxmlStringAttributeDescription m_ContentContainer; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000CBB")]
		private UxmlStringAttributeDescription m_Style; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000CBC")]
		private UxmlAssetAttributeDescription<Object> m_DataSource; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000CBD")]
		private UxmlStringAttributeDescription m_DataSourcePath; //Field offset: 0x80

		[Token(Token = "0x17000756")]
		protected UxmlBoolAttributeDescription focusable
		{
			[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B3A")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000755")]
		protected UxmlIntAttributeDescription focusIndex
		{
			[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
			[CallerCount(Count = 4)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B39")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1B1F6F0", Offset = "0x1B1E8F0", Length = "0x699")]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlAttributeDescription), Member = "set_obsoleteNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(UxmlAssetAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B3C")]
		public UxmlTraits() { }

		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B3A")]
		protected UxmlBoolAttributeDescription get_focusable() { }

		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B39")]
		protected UxmlIntAttributeDescription get_focusIndex() { }

		[Address(RVA = "0x1B1F150", Offset = "0x1B1E350", Length = "0x593")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(VisualElement), Member = "set_dataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_dataSourcePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "set_enabledSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_viewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B3B")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x2000377")]
	private abstract class VisualElementScheduledItem : BaseVisualElementScheduledItem
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CCA")]
		public ActionType updateEvent; //Field offset: 0x0

		[Address(RVA = "0x92F860", Offset = "0x92EA60", Length = "0x32")]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement+TimerStateScheduledItem", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Action`1<UnityEngine.UIElements.TimerState>)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement+SimpleScheduledItem", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.UIElements.VisualElement+BaseVisualElementScheduledItem", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B6C")]
		public VisualElementScheduledItem`1(VisualElement handler, ActionType upEvent) { }

	}

	[Token(Token = "0x4000C4D")]
	internal static uint s_NextId; //Field offset: 0x0
	[Token(Token = "0x4000C9C")]
	internal const string k_RootVisualContainerName = "rootVisualContainer"; //Field offset: 0x0
	[Token(Token = "0x4000C61")]
	private const VisualElementFlags worldTransformInverseDirtyDependencies = 3; //Field offset: 0x0
	[Token(Token = "0x4000C5F")]
	private const VisualElementFlags worldBoundingBoxDirtyDependencies = 25; //Field offset: 0x0
	[Token(Token = "0x4000C4E")]
	private static List<String> s_EmptyClassList; //Field offset: 0x8
	[Token(Token = "0x4000C4F")]
	internal static readonly PropertyName userDataPropertyKey; //Field offset: 0x10
	[Token(Token = "0x4000C50")]
	public static readonly string disabledUssClassName; //Field offset: 0x18
	[Token(Token = "0x4000C6F")]
	internal static int s_FinalizerCount; //Field offset: 0x20
	[Token(Token = "0x4000C74")]
	private static readonly ProfilerMarker k_GenerateVisualContentMarker; //Field offset: 0x28
	[Token(Token = "0x4000C75")]
	private static Material s_runtimeMaterial; //Field offset: 0x30
	[Token(Token = "0x4000C78")]
	internal static readonly BindingId childCountProperty; //Field offset: 0x38
	[Token(Token = "0x4000C79")]
	internal static readonly BindingId contentRectProperty; //Field offset: 0xD0
	[Token(Token = "0x4000C7A")]
	internal static readonly BindingId dataSourcePathProperty; //Field offset: 0x168
	[Token(Token = "0x4000C7B")]
	internal static readonly BindingId dataSourceProperty; //Field offset: 0x200
	[Token(Token = "0x4000C7C")]
	internal static readonly BindingId disablePlayModeTintProperty; //Field offset: 0x298
	[Token(Token = "0x4000C7D")]
	internal static readonly BindingId enabledInHierarchyProperty; //Field offset: 0x330
	[Token(Token = "0x4000C7E")]
	internal static readonly BindingId enabledSelfProperty; //Field offset: 0x3C8
	[Token(Token = "0x4000C7F")]
	internal static readonly BindingId layoutProperty; //Field offset: 0x460
	[Token(Token = "0x4000C80")]
	internal static readonly BindingId languageDirectionProperty; //Field offset: 0x4F8
	[Token(Token = "0x4000C81")]
	internal static readonly BindingId localBoundProperty; //Field offset: 0x590
	[Token(Token = "0x4000C82")]
	internal static readonly BindingId nameProperty; //Field offset: 0x628
	[Token(Token = "0x4000C83")]
	internal static readonly BindingId panelProperty; //Field offset: 0x6C0
	[Token(Token = "0x4000C84")]
	internal static readonly BindingId pickingModeProperty; //Field offset: 0x758
	[Token(Token = "0x4000C85")]
	internal static readonly BindingId styleSheetsProperty; //Field offset: 0x7F0
	[Token(Token = "0x4000C86")]
	internal static readonly BindingId tooltipProperty; //Field offset: 0x888
	[Token(Token = "0x4000C87")]
	internal static readonly BindingId usageHintsProperty; //Field offset: 0x920
	[Token(Token = "0x4000C88")]
	internal static readonly BindingId userDataProperty; //Field offset: 0x9B8
	[Token(Token = "0x4000C89")]
	internal static readonly BindingId viewDataKeyProperty; //Field offset: 0xA50
	[Token(Token = "0x4000C8A")]
	internal static readonly BindingId visibleProperty; //Field offset: 0xAE8
	[Token(Token = "0x4000C8B")]
	internal static readonly BindingId visualTreeAssetSourceProperty; //Field offset: 0xB80
	[Token(Token = "0x4000C8C")]
	internal static readonly BindingId worldBoundProperty; //Field offset: 0xC18
	[Token(Token = "0x4000C8D")]
	internal static readonly BindingId worldTransformProperty; //Field offset: 0xCB0
	[Token(Token = "0x4000C98")]
	private static uint s_NextParentVersion; //Field offset: 0xD48
	[Token(Token = "0x4000CA4")]
	private static readonly List<VisualElement> s_EmptyList; //Field offset: 0xD50
	[Token(Token = "0x4000CA8")]
	internal static CustomStyleAccess s_CustomStyleAccess; //Field offset: 0xD58
	[Token(Token = "0x4000CAC")]
	private static readonly Regex s_InternalStyleSheetPath; //Field offset: 0xD60
	[Token(Token = "0x4000CAD")]
	internal static readonly PropertyName tooltipPropertyKey; //Field offset: 0xD68
	[Token(Token = "0x4000CAE")]
	private static readonly Dictionary<Type, TypeData> s_TypeData; //Field offset: 0xD70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C4B")]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000C4C")]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C51")]
	private string m_Name; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C52")]
	private List<String> m_ClassList; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C53")]
	private Dictionary<PropertyName, Object> m_PropertyBag; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C54")]
	private VisualElementFlags m_Flags; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000C55")]
	private string m_ViewDataKey; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C56")]
	private RenderHints m_RenderHints; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000C57")]
	internal Rect lastLayout; //Field offset: 0x64
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000C58")]
	internal Rect lastPseudoPadding; //Field offset: 0x74
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000C59")]
	internal RenderData renderData; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000C5A")]
	internal RenderData nestedRenderData; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000C5B")]
	internal int hierarchyDepth; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000C5C")]
	internal int insertionIndex; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000C5D")]
	private Rect m_Layout; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000C5E")]
	private Rect m_BoundingBox; //Field offset: 0xB0
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000C60")]
	private Rect m_WorldBoundingBox; //Field offset: 0xC0
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000C62")]
	private Matrix4x4 m_WorldTransformCache; //Field offset: 0xD0
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000C63")]
	private Matrix4x4 m_WorldTransformInverseCache; //Field offset: 0x110
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000C64")]
	internal PseudoStates triggerPseudoMask; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4000C65")]
	internal PseudoStates dependencyPseudoMask; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000C66")]
	private PseudoStates m_PseudoStates; //Field offset: 0x158
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x4000C67")]
	private int <containedPointerIds>k__BackingField; //Field offset: 0x15C
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000C68")]
	private PickingMode m_PickingMode; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000C69")]
	private LayoutNode m_LayoutNode; //Field offset: 0x168
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000C6A")]
	internal ComputedStyle m_Style; //Field offset: 0x198
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000C6B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleVariableContext variableContext; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000C6C")]
	internal int inheritedStylesHash; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x4000C6D")]
	internal readonly uint controlid; //Field offset: 0x1F4
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000C6E")]
	internal int imguiContainerDescendantCount; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x1FC")]
	[Token(Token = "0x4000C70")]
	private bool m_EnabledSelf; //Field offset: 0x1FC
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000C71")]
	private LanguageDirection m_LanguageDirection; //Field offset: 0x200
	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x4000C72")]
	private LanguageDirection m_LocalLanguageDirection; //Field offset: 0x204
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000C73")]
	private Action<MeshGenerationContext> <generateVisualContent>k__BackingField; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000C76")]
	private Material m_defaultMaterial; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C77")]
	private List<IValueAnimationUpdate> m_RunningAnimations; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C8E")]
	private object m_DataSource; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C8F")]
	private PathRef m_DataSourcePath; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C90")]
	private List<Binding> m_Bindings; //Field offset: 0x230
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000C91")]
	private Type <dataSourceType>k__BackingField; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000C92")]
	private readonly int m_TrickleDownHandleEventCategories; //Field offset: 0x240
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4000C93")]
	private readonly int m_BubbleUpHandleEventCategories; //Field offset: 0x244
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000C94")]
	private int m_BubbleUpEventCallbackCategories; //Field offset: 0x248
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000C95")]
	private int m_TrickleDownEventCallbackCategories; //Field offset: 0x24C
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000C96")]
	private int m_EventInterestSelfCategories; //Field offset: 0x250
	[FieldOffset(Offset = "0x254")]
	[Token(Token = "0x4000C97")]
	private int m_CachedEventInterestParentCategories; //Field offset: 0x254
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000C99")]
	private uint m_NextParentCachedVersion; //Field offset: 0x258
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x4000C9A")]
	private uint m_NextParentRequiredVersion; //Field offset: 0x25C
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000C9B")]
	private VisualElement m_CachedNextParentWithEventInterests; //Field offset: 0x260
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000C9D")]
	private readonly Hierarchy <hierarchy>k__BackingField; //Field offset: 0x268
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000C9E")]
	private bool <isRootVisualContainer>k__BackingField; //Field offset: 0x270
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x271")]
	[Token(Token = "0x4000C9F")]
	private bool <cacheAsBitmap>k__BackingField; //Field offset: 0x271
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000CA0")]
	private VisualElement m_PhysicalParent; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000CA1")]
	private VisualElement m_LogicalParent; //Field offset: 0x280
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000CA2")]
	private Action<VisualElement, Int32> elementAdded; //Field offset: 0x288
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000CA3")]
	private Action<VisualElement> elementRemoved; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000CA5")]
	private List<VisualElement> m_Children; //Field offset: 0x298
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000CA6")]
	private BaseVisualElementPanel <elementPanel>k__BackingField; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000CA7")]
	private VisualTreeAsset m_VisualTreeAssetSource; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000CA9")]
	internal InlineStyleAccess inlineStyleAccess; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000CAA")]
	internal ResolvedStyleAccess resolvedStyleAccess; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000CAB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<StyleSheet> styleSheetList; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000CAF")]
	private TypeData m_TypeData; //Field offset: 0x2C8

	[Token(Token = "0x1400002D")]
	internal event Action<VisualElement, Int32> elementAdded
	{
		[Address(RVA = "0x1B03150", Offset = "0x1B02350", Length = "0xBA")]
		[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001AE7")]
		internal add { } //Length: 186
		[Address(RVA = "0x1B05370", Offset = "0x1B04570", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001AE8")]
		internal remove { } //Length: 186
	}

	[Token(Token = "0x1400002E")]
	internal event Action<VisualElement> elementRemoved
	{
		[Address(RVA = "0x1B03210", Offset = "0x1B02410", Length = "0xBA")]
		[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001AE9")]
		internal add { } //Length: 186
		[Address(RVA = "0x1B05430", Offset = "0x1B04630", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001AEA")]
		internal remove { } //Length: 186
	}

	[Token(Token = "0x170006F5")]
	internal bool areAncestorsAndSelfDisplayed
	{
		[Address(RVA = "0x1B03360", Offset = "0x1B02560", Length = "0x9")]
		[CalledBy(Type = typeof(FocusController), Member = "ReevaluateFocus", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseElementBuilder), Member = "BuildStandardElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Token(Token = "0x6001A1B")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B054F0", Offset = "0x1B046F0", Length = "0x84")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A1C")]
		internal set { } //Length: 132
	}

	[Token(Token = "0x1700070E")]
	internal Rect boundingBox
	{
		[Address(RVA = "0x1B03480", Offset = "0x1B02680", Length = "0x42")]
		[CallerCount(Count = 28)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
		[Token(Token = "0x6001A44")]
		internal get { } //Length: 66
	}

	[Token(Token = "0x17000721")]
	internal bool boundingBoxDirtiedSinceLastLayoutPass
	{
		[Address(RVA = "0x1B03370", Offset = "0x1B02570", Length = "0x9")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6001A61")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B05580", Offset = "0x1B04780", Length = "0x2D")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A62")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x17000711")]
	private Rect boundingBoxInParentSpace
	{
		[Address(RVA = "0x1B03380", Offset = "0x1B02580", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AEF0B0")]
		[Token(Token = "0x6001A47")]
		private get { } //Length: 81
	}

	[Token(Token = "0x1700070F")]
	internal Rect boundingBoxWithoutNested
	{
		[Address(RVA = "0x1B033E0", Offset = "0x1B025E0", Length = "0x9F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A45")]
		internal get { } //Length: 159
	}

	[Token(Token = "0x170006FB")]
	public virtual bool canGrabFocus
	{
		[Address(RVA = "0x1B034D0", Offset = "0x1B026D0", Length = "0x105")]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Focusable), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001A26")]
		 get { } //Length: 261
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000748")]
	public int childCount
	{
		[Address(RVA = "0x1B035E0", Offset = "0x1B027E0", Length = "0x70")]
		[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetPreviousElementDepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "ChildCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "PostDisplaySetup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(TwoPaneSplitViewOrientation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "GetLargestItemWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "UpdateBackground", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnPostDisplaySetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001AFA")]
		 get { } //Length: 112
	}

	[Token(Token = "0x17000726")]
	internal List<String> classList
	{
		[Address(RVA = "0x1B03650", Offset = "0x1B02850", Length = "0xB1")]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "UpdateBackground", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Tab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Background)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ObjectListPool`1), Member = "Get", ReturnType = "System.Collections.Generic.List`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001A6F")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 177
	}

	[Token(Token = "0x1700072A")]
	internal ComputedStyle computedStyle
	{
		[Address(RVA = "0x1B03710", Offset = "0x1B02910", Length = "0x8")]
		[CallerCount(Count = 193)]
		[Token(Token = "0x6001A73")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000723")]
	internal int containedPointerIds
	{
		[Address(RVA = "0x189D630", Offset = "0x189C830", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A65")]
		internal get { } //Length: 7
		[Address(RVA = "0x189D920", Offset = "0x189CB20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A66")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000745")]
	public override VisualElement contentContainer
	{
		[Address(RVA = "0x151EF90", Offset = "0x151E190", Length = "0x6")]
		[CallerCount(Count = 142)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AEF")]
		 get { } //Length: 6
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000706")]
	public Rect contentRect
	{
		[Address(RVA = "0x1B03720", Offset = "0x1B02920", Length = "0x2E1")]
		[CallerCount(Count = 36)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Spacing), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Spacing)}, ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001A38")]
		 get { } //Length: 737
	}

	[Token(Token = "0x17000751")]
	public ICustomStyle customStyle
	{
		[Address(RVA = "0x1B03A10", Offset = "0x1B02C10", Length = "0x8E")]
		[CalledBy(Type = typeof(Image), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T0&", "T1&", "T2&", typeof(BindingId)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CustomStyleResolvedEvent), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitContext", typeof(IProperty)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomStyleAccess), Member = "SetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.StyleSheets.StylePropertyValue>), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B2B")]
		 get { } //Length: 142
	}

	[CreateProperty]
	[Token(Token = "0x17000736")]
	public object dataSource
	{
		[Address(RVA = "0x1B03B70", Offset = "0x1B02D70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001ABD")]
		 get { } //Length: 8
		[Address(RVA = "0x1B05860", Offset = "0x1B04A60", Length = "0xE0")]
		[CalledBy(Type = typeof(BaseListViewController), Member = "SetBindingContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001ABE")]
		 set { } //Length: 224
	}

	[CreateProperty]
	[Token(Token = "0x17000737")]
	public PropertyPath dataSourcePath
	{
		[Address(RVA = "0x1B03AA0", Offset = "0x1B02CA0", Length = "0xC9")]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(DataSourceContext))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PathRef), Member = "get_path", ReturnType = typeof(PropertyPath&))]
		[Token(Token = "0x6001ABF")]
		 get { } //Length: 201
		[Address(RVA = "0x1B055B0", Offset = "0x1B047B0", Length = "0x2A0")]
		[CalledBy(Type = typeof(BaseListViewController), Member = "SetBindingContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(PathRef), Member = "get_path", ReturnType = typeof(PropertyPath&))]
		[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001AC0")]
		 set { } //Length: 672
	}

	[Token(Token = "0x17000735")]
	internal Material defaultMaterial
	{
		[Address(RVA = "0x1B03B80", Offset = "0x1B02D80", Length = "0xA")]
		[CalledBy(Type = typeof(BaseElementBuilder), Member = "BuildStandardElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6001AB2")]
		internal get { } //Length: 10
	}

	[Token(Token = "0x17000740")]
	internal bool disableClipping
	{
		[Address(RVA = "0x1B03B90", Offset = "0x1B02D90", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001AE2")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B05940", Offset = "0x1B04B40", Length = "0x2D")]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001AE3")]
		internal set { } //Length: 45
	}

	[CreateProperty]
	[Token(Token = "0x170006FD")]
	public bool disablePlayModeTint
	{
		[Address(RVA = "0x8D41C0", Offset = "0x8D33C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A28")]
		 get { } //Length: 5
		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A29")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000741")]
	internal bool disableRendering
	{
		[Address(RVA = "0x1B03BA0", Offset = "0x1B02DA0", Length = "0x9")]
		[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnDisableRenderingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6001AE5")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B05970", Offset = "0x1B04B70", Length = "0x56")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001AE6")]
		internal set { } //Length: 86
	}

	[Token(Token = "0x17000743")]
	internal BaseVisualElementPanel elementPanel
	{
		[Address(RVA = "0x1B03BB0", Offset = "0x1B02DB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001AEC")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 8
		[Address(RVA = "0x1B059D0", Offset = "0x1B04BD0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6001AED")]
		private set { } //Length: 19
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x1700072E")]
	public bool enabledInHierarchy
	{
		[Address(RVA = "0x1B03BD0", Offset = "0x1B02DD0", Length = "0x10")]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "Disabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "CutActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextEdition.get_isReadOnly", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NavigateFocusRing), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetFocusChangeDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(FocusChangeDirection))]
		[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "ValidateHierarchyTraversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FocusController), Member = "GetFocusableParentForPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UIElementsUtility), Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUILayoutUtility+LayoutCache", typeof(Event), typeof(IMGUIContainer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicCallbackList), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "AcceptCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Clickable), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Clickable), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Clickable), Member = "OnTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerState)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "CopyActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
		[CalledBy(Type = typeof(TextElement), Member = "PasteActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
		[CallerCount(Count = 22)]
		[Token(Token = "0x6001A86")]
		 get { } //Length: 16
	}

	[CreateProperty]
	[Token(Token = "0x1700072F")]
	public bool enabledSelf
	{
		[Address(RVA = "0x1B03BE0", Offset = "0x1B02DE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001A87")]
		 get { } //Length: 8
		[Address(RVA = "0x1B059F0", Offset = "0x1B04BF0", Length = "0x8E")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001A88")]
		 set { } //Length: 142
	}

	[Token(Token = "0x170006F9")]
	internal bool enableViewDataPersistence
	{
		[Address(RVA = "0x1B03BC0", Offset = "0x1B02DC0", Length = "0x9")]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "IsViewDataKeyEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "GetOrCreateViewData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = "T")]
		[CallerCount(Count = 6)]
		[Token(Token = "0x6001A23")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x1700073A")]
	internal int eventInterestParentCategories
	{
		[Address(RVA = "0x1B03BF0", Offset = "0x1B02DF0", Length = "0x3B")]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateEventInterestParentCategories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateEventInterestParentCategories", ReturnType = typeof(void))]
		[Token(Token = "0x6001ACE")]
		internal get { } //Length: 59
	}

	[Token(Token = "0x1700073C")]
	public IExperimentalFeatures experimental
	{
		[Address(RVA = "0x151EF90", Offset = "0x151E190", Length = "0x6")]
		[CallerCount(Count = 142)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001ADD")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170006F7")]
	internal VisualElementFlags flags
	{
		[Address(RVA = "0x1B03C30", Offset = "0x1B02E30", Length = "0x56")]
		[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyChildrenHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyBoundingBoxHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyParentHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "DirtyBoundingBoxHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "DirtyParentHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
		[CallerCount(Count = 19)]
		[Token(Token = "0x6001A1F")]
		internal get { } //Length: 86
		[Address(RVA = "0x1B05A80", Offset = "0x1B04C80", Length = "0xAA")]
		[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyParentHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyChildrenHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyBoundingBoxHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "DirtyBoundingBoxHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "DirtyParentHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A20")]
		internal set { } //Length: 170
	}

	[Token(Token = "0x170006FC")]
	public virtual FocusController focusController
	{
		[Address(RVA = "0x1B03C90", Offset = "0x1B02E90", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001A27")]
		 get { } //Length: 209
	}

	[Token(Token = "0x17000727")]
	internal string fullTypeName
	{
		[Address(RVA = "0x1B03D70", Offset = "0x1B02F70", Length = "0x23")]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_typeData", ReturnType = typeof(TypeData))]
		[Calls(Type = typeof(TypeData), Member = "get_fullTypeName", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A70")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 35
	}

	[Token(Token = "0x17000733")]
	public Action<MeshGenerationContext> generateVisualContent
	{
		[Address(RVA = "0x5E4B70", Offset = "0x5E3D70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A92")]
		 get { } //Length: 8
		[Address(RVA = "0x1B05B30", Offset = "0x1B04D30", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6001A93")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700074D")]
	private bool has3DRotation
	{
		[Address(RVA = "0x1B03DA0", Offset = "0x1B02FA0", Length = "0xDA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B14")]
		private get { } //Length: 218
	}

	[Token(Token = "0x1700074B")]
	internal bool has3DTransform
	{
		[Address(RVA = "0x1B03E80", Offset = "0x1B03080", Length = "0x142")]
		[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "GetParentMustDirtyFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElementFlags))]
		[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "DirtyBoundingBoxHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ComputedStyle), Member = "get_translate", ReturnType = typeof(Translate))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B12")]
		internal get { } //Length: 322
	}

	[Token(Token = "0x1700074C")]
	private bool has3DTranslation
	{
		[Address(RVA = "0x1B03FD0", Offset = "0x1B031D0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ComputedStyle), Member = "get_translate", ReturnType = typeof(Translate))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B13")]
		private get { } //Length: 53
	}

	[Token(Token = "0x170006F0")]
	internal bool hasCompletedAnimations
	{
		[Address(RVA = "0x1B04010", Offset = "0x1B03210", Length = "0x4E")]
		[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60019F9")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x1700074A")]
	internal bool hasDefaultRotationAndScale
	{
		[Address(RVA = "0x1AEF270", Offset = "0x1AEE470", Length = "0xFA")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+WordSpacingProperty", Member = "get_ussName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBoundsToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRectToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_scale", ReturnType = typeof(Scale))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001B11")]
		internal get { } //Length: 250
	}

	[Token(Token = "0x1700072B")]
	internal bool hasInlineStyle
	{
		[Address(RVA = "0x1B04060", Offset = "0x1B03260", Length = "0xC")]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A74")]
		internal get { } //Length: 12
	}

	[Token(Token = "0x170006F6")]
	internal bool hasOneOrMorePointerCaptures
	{
		[Address(RVA = "0x1B04070", Offset = "0x1B03270", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001A1D")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B05B50", Offset = "0x1B04D50", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A1E")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x170006EF")]
	internal bool hasRunningAnimations
	{
		[Address(RVA = "0x1B04080", Offset = "0x1B03280", Length = "0x4E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60019F8")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x1700073E")]
	public Hierarchy hierarchy
	{
		[Address(RVA = "0x1B040D0", Offset = "0x1B032D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001ADF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700070B")]
	internal bool isBoundingBoxDirty
	{
		[Address(RVA = "0x1B040E0", Offset = "0x1B032E0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001A40")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B05B80", Offset = "0x1B04D80", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A41")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x170006F4")]
	internal bool isCompositeRoot
	{
		[Address(RVA = "0x1B040F0", Offset = "0x1B032F0", Length = "0x9")]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Focusable), Member = "set_excludeFromFocusRing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Focusable), Member = "GetFirstFocusableChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
		[CalledBy(Type = typeof(FocusController), Member = "GetRetargetedFocusedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
		[CalledBy(Type = typeof(FocusController), Member = "GetFocusTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.FocusController+FocusedElement>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Token(Token = "0x6001A19")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B05BB0", Offset = "0x1B04DB0", Length = "0x2D")]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A1A")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x17000738")]
	internal bool isDataSourcePathEmpty
	{
		[Address(RVA = "0x1B04100", Offset = "0x1B03300", Length = "0x28")]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(DataSourceContext))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PathRef), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[Token(Token = "0x6001AC1")]
		internal get { } //Length: 40
	}

	[Token(Token = "0x1700073B")]
	internal bool isEventInterestParentCategoriesDirty
	{
		[Address(RVA = "0x1B04130", Offset = "0x1B03330", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001ACF")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B05BE0", Offset = "0x1B04DE0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001AD0")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x17000702")]
	internal bool isLayoutManual
	{
		[Address(RVA = "0x1B04140", Offset = "0x1B03340", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001A31")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B05C10", Offset = "0x1B04E10", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A32")]
		private set { } //Length: 43
	}

	[Token(Token = "0x17000709")]
	internal bool isLocalBounds3DDirty
	{
		[Address(RVA = "0x1B04150", Offset = "0x1B03350", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A3C")]
		internal get { } //Length: 11
		[Address(RVA = "0x1B05C40", Offset = "0x1B04E40", Length = "0x2D")]
		[CalledBy(Type = typeof(WorldSpaceDataStore), Member = "ClearWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A3D")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x1700070A")]
	internal bool isLocalBoundsWithoutNested3DDirty
	{
		[Address(RVA = "0x1B04160", Offset = "0x1B03360", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A3E")]
		internal get { } //Length: 11
		[Address(RVA = "0x1B05C70", Offset = "0x1B04E70", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A3F")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x1700072D")]
	private bool isParentEnabledInHierarchy
	{
		[Address(RVA = "0x1B04170", Offset = "0x1B03370", Length = "0x67")]
		[CalledBy(Type = typeof(VisualElement), Member = "SetEnabledFromHierarchyPrivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A85")]
		private get { } //Length: 103
	}

	[Token(Token = "0x1700073F")]
	internal bool isRootVisualContainer
	{
		[Address(RVA = "0x404F70", Offset = "0x404170", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AE0")]
		internal get { } //Length: 8
		[Address(RVA = "0x405170", Offset = "0x404370", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AE1")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700070C")]
	internal bool isWorldBoundingBoxDirty
	{
		[Address(RVA = "0x1B05CA0", Offset = "0x1B04EA0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A42")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x1700070D")]
	internal bool isWorldBoundingBoxOrDependenciesDirty
	{
		[Address(RVA = "0x1B041E0", Offset = "0x1B033E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A43")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000718")]
	internal bool isWorldSpaceRootUIDocument
	{
		[Address(RVA = "0x1B041F0", Offset = "0x1B033F0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001A51")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B05CD0", Offset = "0x1B04ED0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A52")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x17000719")]
	internal bool isWorldTransformDirty
	{
		[Address(RVA = "0x138BBF0", Offset = "0x138ADF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A53")]
		internal get { } //Length: 7
		[Address(RVA = "0x1B05D00", Offset = "0x1B04F00", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A54")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x1700071A")]
	internal bool isWorldTransformInverseDirty
	{
		[Address(RVA = "0x1B05D30", Offset = "0x1B04F30", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A55")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x1700071B")]
	internal bool isWorldTransformInverseOrDependenciesDirty
	{
		[Address(RVA = "0x1B04200", Offset = "0x1B03400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A56")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000747")]
	public VisualElement Item
	{
		[Address(RVA = "0x1B032D0", Offset = "0x1B024D0", Length = "0x8B")]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "PostDisplaySetup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "RaiseColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnControlGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(VisualElement), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "IdentifyLeftAndRightPane", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "OnFocusIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReusableMultiColumnTreeViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReusableMultiColumnListViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001AF9")]
		 get { } //Length: 139
	}

	[CreateProperty]
	[Token(Token = "0x17000730")]
	public LanguageDirection languageDirection
	{
		[Address(RVA = "0x499330", Offset = "0x498530", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A8B")]
		 get { } //Length: 7
		[Address(RVA = "0x1B05D60", Offset = "0x1B04F60", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001A8C")]
		 set { } //Length: 137
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000705")]
	public internal Rect layout
	{
		[Address(RVA = "0x1B04220", Offset = "0x1B03420", Length = "0xCD")]
		[CallerCount(Count = 149)]
		[Calls(Type = typeof(LayoutNode), Member = "get_IsUndefined", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutNode), Member = "get_LayoutX", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "get_LayoutY", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "get_LayoutWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "get_LayoutHeight", ReturnType = typeof(float))]
		[Token(Token = "0x6001A35")]
		 get { } //Length: 205
		[Address(RVA = "0x1B05DF0", Offset = "0x1B04FF0", Length = "0x854")]
		[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 11)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A36")]
		internal set { } //Length: 2132
	}

	[Token(Token = "0x17000729")]
	internal LayoutNode layoutNode
	{
		[Address(RVA = "0x1B04210", Offset = "0x1B03410", Length = "0xA")]
		[CallerCount(Count = 92)]
		[Token(Token = "0x6001A72")]
		internal get { } //Length: 10
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000716")]
	public Rect localBound
	{
		[Address(RVA = "0x1B042F0", Offset = "0x1B034F0", Length = "0x83")]
		[CalledBy(Type = typeof(ListViewDragger), Member = "ApplyDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "GetHoverBarTopPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAtElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "<ApplyDragAndDropUI>g__GeometryChangedCallback|31_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AEF0B0")]
		[Token(Token = "0x6001A4F")]
		 get { } //Length: 131
	}

	[Token(Token = "0x17000712")]
	internal Bounds localBounds3D
	{
		[Address(RVA = "0x1B04430", Offset = "0x1B03630", Length = "0xA0")]
		[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
		[Token(Token = "0x6001A4A")]
		internal get { } //Length: 160
	}

	[Token(Token = "0x17000714")]
	internal Bounds localBounds3DWithoutNested3D
	{
		[Address(RVA = "0x1B04380", Offset = "0x1B03580", Length = "0xA1")]
		[CalledBy(Type = typeof(UIDocument), Member = "LocalBoundsFromPivotSource", ReturnType = typeof(Bounds))]
		[CalledBy(Type = typeof(UIDocument), Member = "PivotOffset", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
		[Token(Token = "0x6001A4C")]
		internal get { } //Length: 161
	}

	[Token(Token = "0x17000713")]
	internal Bounds localBoundsPicking3D
	{
		[Address(RVA = "0x1B044D0", Offset = "0x1B036D0", Length = "0xA0")]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "GetPicking3DLocalBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Bounds))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
		[Token(Token = "0x6001A4B")]
		internal get { } //Length: 160
	}

	[Token(Token = "0x17000731")]
	internal LanguageDirection localLanguageDirection
	{
		[Address(RVA = "0x499370", Offset = "0x498570", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A8D")]
		internal get { } //Length: 7
		[Address(RVA = "0x1B06650", Offset = "0x1B05850", Length = "0x103")]
		[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "set_languageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001A8E")]
		internal set { } //Length: 259
	}

	[CreateProperty]
	[Token(Token = "0x17000725")]
	public string name
	{
		[Address(RVA = "0x19AA840", Offset = "0x19A9A40", Length = "0x7")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A6D")]
		 get { } //Length: 7
		[Address(RVA = "0x1B06760", Offset = "0x1B05960", Length = "0xBA")]
		[CallerCount(Count = 70)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001A6E")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000708")]
	internal bool needs3DBounds
	{
		[Address(RVA = "0x1B04570", Offset = "0x1B03770", Length = "0xB")]
		[CalledBy(Type = typeof(PhysicsDocumentPicker), Member = "TryPickWithCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Ray), typeof(float), typeof(int), typeof(Collider&), typeof(UIDocument&), typeof(VisualElement&), typeof(Single&), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(Single&)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "GetPicking3DLocalBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Bounds))]
		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A3A")]
		internal get { } //Length: 11
		[Address(RVA = "0x1B06820", Offset = "0x1B05A20", Length = "0x2D")]
		[CalledBy(Type = typeof(WorldSpaceDataStore), Member = "ClearWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A3B")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x17000739")]
	internal VisualElement nextParentWithEventInterests
	{
		[Address(RVA = "0x1B04580", Offset = "0x1B03780", Length = "0x1D5")]
		[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001ACB")]
		internal get { } //Length: 469
	}

	[Token(Token = "0x17000707")]
	protected Rect paddingRect
	{
		[Address(RVA = "0x1B04760", Offset = "0x1B03960", Length = "0x1BE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Spacing), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Spacing)}, ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001A39")]
		 get { } //Length: 446
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000744")]
	public IPanel panel
	{
		[Address(RVA = "0x1B04920", Offset = "0x1B03B20", Length = "0xA")]
		[CallerCount(Count = 110)]
		[Token(Token = "0x6001AEE")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000742")]
	public VisualElement parent
	{
		[Address(RVA = "0x1B04930", Offset = "0x1B03B30", Length = "0xA")]
		[CallerCount(Count = 50)]
		[Token(Token = "0x6001AEB")]
		 get { } //Length: 10
	}

	[CreateProperty]
	[Token(Token = "0x17000724")]
	public PickingMode pickingMode
	{
		[Address(RVA = "0x189D640", Offset = "0x189C840", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A6B")]
		 get { } //Length: 7
		[Address(RVA = "0x1B06850", Offset = "0x1B05A50", Length = "0xA4")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001A6C")]
		 set { } //Length: 164
	}

	[Token(Token = "0x170006FE")]
	internal Color playModeTintColor
	{
		[Address(RVA = "0x1B04940", Offset = "0x1B03B40", Length = "0x39")]
		[CalledBy(Type = typeof(Image), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001A2A")]
		internal get { } //Length: 57
	}

	[Token(Token = "0x17000749")]
	private Vector3 positionWithLayout
	{
		[Address(RVA = "0x1B04980", Offset = "0x1B03B80", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Token(Token = "0x6001B0F")]
		private get { } //Length: 142
	}

	[Token(Token = "0x17000722")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal PseudoStates pseudoStates
	{
		[Address(RVA = "0x1A32680", Offset = "0x1A31880", Length = "0x9")]
		[CallerCount(Count = 61)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A63")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B06900", Offset = "0x1B05B00", Length = "0x71")]
		[CallerCount(Count = 48)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001A64")]
		internal set { } //Length: 113
	}

	[Token(Token = "0x17000720")]
	internal bool receivesHierarchyGeometryChangedEvents
	{
		[Address(RVA = "0x1B04A10", Offset = "0x1B03C10", Length = "0x9")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6001A5F")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B06980", Offset = "0x1B05B80", Length = "0x2D")]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A60")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x17000717")]
	internal Rect rect
	{
		[Address(RVA = "0x1B04A20", Offset = "0x1B03C20", Length = "0x58")]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RenderData), Member = "GetLocalClippingRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "Order", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "StrictOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "TieBreaker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(ChangeDirection), typeof(VisualElement)}, ReturnType = typeof(Focusable))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "IntersectLocalRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Token(Token = "0x6001A50")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 88
	}

	[Token(Token = "0x17000700")]
	internal RenderHints renderHints
	{
		[Address(RVA = "0x1B04A80", Offset = "0x1B03C80", Length = "0x6")]
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A2D")]
		internal get { } //Length: 6
		[Address(RVA = "0x1B069B0", Offset = "0x1B05BB0", Length = "0x61")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001A2E")]
		internal set { } //Length: 97
	}

	[Token(Token = "0x17000734")]
	internal bool requireMeasureFunction
	{
		[Address(RVA = "0x1B04A90", Offset = "0x1B03C90", Length = "0x9")]
		[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6001A9C")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B06A20", Offset = "0x1B05C20", Length = "0xA0")]
		[CalledBy(Type = typeof(Image), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "get_UsesMeasure", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutNode), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutNode), Member = "set_UsesMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A9D")]
		internal set { } //Length: 160
	}

	[CreateProperty]
	[Token(Token = "0x17000750")]
	public IResolvedStyle resolvedStyle
	{
		[Address(RVA = "0x1B04AA0", Offset = "0x1B03CA0", Length = "0x85")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B2A")]
		 get { } //Length: 133
	}

	[Token(Token = "0x17000703")]
	public float scaledPixelsPerPoint
	{
		[Address(RVA = "0x1B04B30", Offset = "0x1B03D30", Length = "0x9F")]
		[CalledBy(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
		[CalledBy(Type = typeof(UITKTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Material>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextElement), Member = "ElideText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(TextOverflowPosition)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ATGTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ATGMeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(System.Collections.Generic.List`1<UnityEngine.Texture2D>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<System.UInt16>>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphRenderMode>), typeof(System.Collections.Generic.List`1<System.Single>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "ApplyScrollInertia", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "SpringBack", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AlignmentUtils), Member = "RoundToPanelPixelSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetPixelsPerPoint", ReturnType = typeof(float))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
		[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001A33")]
		 get { } //Length: 159
	}

	[Obsolete("scaledPixelsPerPoint_noChecks is deprecated. Use scaledPixelsPerPoint instead.")]
	[Token(Token = "0x17000704")]
	internal float scaledPixelsPerPoint_noChecks
	{
		[Address(RVA = "0x1B04BD0", Offset = "0x1B03DD0", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
		[Token(Token = "0x6001A34")]
		internal get { } //Length: 95
	}

	[Token(Token = "0x1700074E")]
	public IVisualElementScheduler schedule
	{
		[Address(RVA = "0x151EF90", Offset = "0x151E190", Length = "0x6")]
		[CallerCount(Count = 142)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B26")]
		 get { } //Length: 6
	}

	[CreateProperty]
	[Token(Token = "0x1700074F")]
	public IStyle style
	{
		[Address(RVA = "0x1B04C70", Offset = "0x1B03E70", Length = "0x79")]
		[CallerCount(Count = 258)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InlineStyleAccess), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001B29")]
		 get { } //Length: 121
	}

	[Token(Token = "0x170006F3")]
	internal IStylePropertyAnimations styleAnimation
	{
		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019FF")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700072C")]
	internal bool styleInitialized
	{
		[Address(RVA = "0x1B04C30", Offset = "0x1B03E30", Length = "0x9")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Token(Token = "0x6001A75")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B06AD0", Offset = "0x1B05CD0", Length = "0x2D")]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A76")]
		internal set { } //Length: 45
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000752")]
	public VisualElementStyleSheetSet styleSheets
	{
		[Address(RVA = "0x1B04C40", Offset = "0x1B03E40", Length = "0x27")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "AssignStyleSheetFromAssetToElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B2C")]
		 get { } //Length: 39
	}

	[CreateProperty]
	[Token(Token = "0x17000753")]
	public string tooltip
	{
		[Address(RVA = "0x1B04CF0", Offset = "0x1B03EF0", Length = "0x89")]
		[CalledBy(Type = typeof(BaseField`1), Member = "ComputeTooltipRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(BaseField`1), Member = "GetTooltipRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(BaseField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Tab), Member = "UpdateTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "SetTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
		[Token(Token = "0x6001B33")]
		 get { } //Length: 137
		[Address(RVA = "0x1B06B00", Offset = "0x1B05D00", Length = "0x22F")]
		[CalledBy(Type = typeof(MultiColumnListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReusableListViewItem), Member = "SetDragHandleEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UpdateTooltip", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "SetPropertyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B34")]
		 set { } //Length: 559
	}

	[Token(Token = "0x17000754")]
	private TypeData typeData
	{
		[Address(RVA = "0x1B04D80", Offset = "0x1B03F80", Length = "0x156")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_fullTypeName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_typeName", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TypeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B35")]
		private get { } //Length: 342
	}

	[Token(Token = "0x17000728")]
	internal string typeName
	{
		[Address(RVA = "0x1B04EE0", Offset = "0x1B040E0", Length = "0x23")]
		[CalledBy(Type = typeof(AncestorFilter), Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleSelectorHelper), Member = "MatchesSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleSelector)}, ReturnType = typeof(MatchResultInfo))]
		[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FindMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleMatchingContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(VisualElement), Member = "get_typeData", ReturnType = typeof(TypeData))]
		[Calls(Type = typeof(TypeData), Member = "get_typeName", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A71")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 35
	}

	[Token(Token = "0x1700073D")]
	private override ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.animation
	{
		[Address(RVA = "0x151EF90", Offset = "0x151E190", Length = "0x6")]
		[CallerCount(Count = 142)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001ADE")]
		private get { } //Length: 6
	}

	[Token(Token = "0x1700069F")]
	private override Align UnityEngine.UIElements.IResolvedStyle.alignContent
	{
		[Address(RVA = "0x1AFB7E0", Offset = "0x1AFA9E0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019A8")]
		private get { } //Length: 79
	}

	[Token(Token = "0x170006A0")]
	private override Align UnityEngine.UIElements.IResolvedStyle.alignItems
	{
		[Address(RVA = "0x1AFB830", Offset = "0x1AFAA30", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019A9")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006A1")]
	private override Align UnityEngine.UIElements.IResolvedStyle.alignSelf
	{
		[Address(RVA = "0x1AFB890", Offset = "0x1AFAA90", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019AA")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006A2")]
	private override Color UnityEngine.UIElements.IResolvedStyle.backgroundColor
	{
		[Address(RVA = "0x1AFB8F0", Offset = "0x1AFAAF0", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019AB")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006A3")]
	private override Background UnityEngine.UIElements.IResolvedStyle.backgroundImage
	{
		[Address(RVA = "0x1AFB9D0", Offset = "0x1AFABD0", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019AC")]
		private get { } //Length: 217
	}

	[Token(Token = "0x170006A4")]
	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionX
	{
		[Address(RVA = "0x1AFBAB0", Offset = "0x1AFACB0", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019AD")]
		private get { } //Length: 217
	}

	[Token(Token = "0x170006A5")]
	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionY
	{
		[Address(RVA = "0x1AFBB90", Offset = "0x1AFAD90", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019AE")]
		private get { } //Length: 217
	}

	[Token(Token = "0x170006A6")]
	private override BackgroundRepeat UnityEngine.UIElements.IResolvedStyle.backgroundRepeat
	{
		[Address(RVA = "0x1AFBC70", Offset = "0x1AFAE70", Length = "0xCB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60019AF")]
		private get { } //Length: 203
	}

	[Token(Token = "0x170006A7")]
	private override BackgroundSize UnityEngine.UIElements.IResolvedStyle.backgroundSize
	{
		[Address(RVA = "0x1AFBD40", Offset = "0x1AFAF40", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019B0")]
		private get { } //Length: 215
	}

	[Token(Token = "0x170006A8")]
	private override Color UnityEngine.UIElements.IResolvedStyle.borderBottomColor
	{
		[Address(RVA = "0x1AFBE20", Offset = "0x1AFB020", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019B1")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006A9")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius
	{
		[Address(RVA = "0x1AFBF00", Offset = "0x1AFB100", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019B2")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006AA")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius
	{
		[Address(RVA = "0x1AFBF60", Offset = "0x1AFB160", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019B3")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006AB")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomWidth
	{
		[Address(RVA = "0x1AFBFC0", Offset = "0x1AFB1C0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019B4")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006AC")]
	private override Color UnityEngine.UIElements.IResolvedStyle.borderLeftColor
	{
		[Address(RVA = "0x1AFC020", Offset = "0x1AFB220", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019B5")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006AD")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderLeftWidth
	{
		[Address(RVA = "0x1AFC100", Offset = "0x1AFB300", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019B6")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006AE")]
	private override Color UnityEngine.UIElements.IResolvedStyle.borderRightColor
	{
		[Address(RVA = "0x1AFC160", Offset = "0x1AFB360", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019B7")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006AF")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderRightWidth
	{
		[Address(RVA = "0x1AFC240", Offset = "0x1AFB440", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019B8")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006B0")]
	private override Color UnityEngine.UIElements.IResolvedStyle.borderTopColor
	{
		[Address(RVA = "0x1AFC2A0", Offset = "0x1AFB4A0", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019B9")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006B1")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius
	{
		[Address(RVA = "0x1AFC380", Offset = "0x1AFB580", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019BA")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006B2")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius
	{
		[Address(RVA = "0x1AFC3E0", Offset = "0x1AFB5E0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019BB")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006B3")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderTopWidth
	{
		[Address(RVA = "0x1AFC440", Offset = "0x1AFB640", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019BC")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006B4")]
	private override float UnityEngine.UIElements.IResolvedStyle.bottom
	{
		[Address(RVA = "0x1AFC4A0", Offset = "0x1AFB6A0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019BD")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006B5")]
	private override Color UnityEngine.UIElements.IResolvedStyle.color
	{
		[Address(RVA = "0x1AFC500", Offset = "0x1AFB700", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019BE")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006B6")]
	private override DisplayStyle UnityEngine.UIElements.IResolvedStyle.display
	{
		[Address(RVA = "0x1AFC5E0", Offset = "0x1AFB7E0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019BF")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006B7")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.flexBasis
	{
		[Address(RVA = "0x1AFC640", Offset = "0x1AFB840", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019C0")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006B8")]
	private override FlexDirection UnityEngine.UIElements.IResolvedStyle.flexDirection
	{
		[Address(RVA = "0x1AFC6A0", Offset = "0x1AFB8A0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019C1")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006B9")]
	private override float UnityEngine.UIElements.IResolvedStyle.flexGrow
	{
		[Address(RVA = "0x1AFC700", Offset = "0x1AFB900", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019C2")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006BA")]
	private override float UnityEngine.UIElements.IResolvedStyle.flexShrink
	{
		[Address(RVA = "0x1AFC760", Offset = "0x1AFB960", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019C3")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006BB")]
	private override Wrap UnityEngine.UIElements.IResolvedStyle.flexWrap
	{
		[Address(RVA = "0x1AFC7C0", Offset = "0x1AFB9C0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019C4")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006BC")]
	private override float UnityEngine.UIElements.IResolvedStyle.fontSize
	{
		[Address(RVA = "0x1AFC820", Offset = "0x1AFBA20", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019C5")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006BD")]
	private override float UnityEngine.UIElements.IResolvedStyle.height
	{
		[Address(RVA = "0x1AFC880", Offset = "0x1AFBA80", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019C6")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006BE")]
	private override Justify UnityEngine.UIElements.IResolvedStyle.justifyContent
	{
		[Address(RVA = "0x1AFC8E0", Offset = "0x1AFBAE0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019C7")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006BF")]
	private override float UnityEngine.UIElements.IResolvedStyle.left
	{
		[Address(RVA = "0x1AFC940", Offset = "0x1AFBB40", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019C8")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006C0")]
	private override float UnityEngine.UIElements.IResolvedStyle.letterSpacing
	{
		[Address(RVA = "0x1AFC9A0", Offset = "0x1AFBBA0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019C9")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006C1")]
	private override float UnityEngine.UIElements.IResolvedStyle.marginBottom
	{
		[Address(RVA = "0x1AFCA00", Offset = "0x1AFBC00", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019CA")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006C2")]
	private override float UnityEngine.UIElements.IResolvedStyle.marginLeft
	{
		[Address(RVA = "0x1AFCA60", Offset = "0x1AFBC60", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019CB")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006C3")]
	private override float UnityEngine.UIElements.IResolvedStyle.marginRight
	{
		[Address(RVA = "0x1AFCAC0", Offset = "0x1AFBCC0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019CC")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006C4")]
	private override float UnityEngine.UIElements.IResolvedStyle.marginTop
	{
		[Address(RVA = "0x1AFCB20", Offset = "0x1AFBD20", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019CD")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006C5")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.maxHeight
	{
		[Address(RVA = "0x1AFCB80", Offset = "0x1AFBD80", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019CE")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006C6")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.maxWidth
	{
		[Address(RVA = "0x1AFCBE0", Offset = "0x1AFBDE0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019CF")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006C7")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.minHeight
	{
		[Address(RVA = "0x1AFCC40", Offset = "0x1AFBE40", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019D0")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006C8")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.minWidth
	{
		[Address(RVA = "0x1AFCCA0", Offset = "0x1AFBEA0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019D1")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006C9")]
	private override float UnityEngine.UIElements.IResolvedStyle.opacity
	{
		[Address(RVA = "0x1AFCD00", Offset = "0x1AFBF00", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019D2")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006CA")]
	private override float UnityEngine.UIElements.IResolvedStyle.paddingBottom
	{
		[Address(RVA = "0x1AFCD60", Offset = "0x1AFBF60", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019D3")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006CB")]
	private override float UnityEngine.UIElements.IResolvedStyle.paddingLeft
	{
		[Address(RVA = "0x1AFCDC0", Offset = "0x1AFBFC0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019D4")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006CC")]
	private override float UnityEngine.UIElements.IResolvedStyle.paddingRight
	{
		[Address(RVA = "0x1AFCE20", Offset = "0x1AFC020", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019D5")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006CD")]
	private override float UnityEngine.UIElements.IResolvedStyle.paddingTop
	{
		[Address(RVA = "0x1AFCE80", Offset = "0x1AFC080", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019D6")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006CE")]
	private override Position UnityEngine.UIElements.IResolvedStyle.position
	{
		[Address(RVA = "0x1AFCEE0", Offset = "0x1AFC0E0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019D7")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006CF")]
	private override float UnityEngine.UIElements.IResolvedStyle.right
	{
		[Address(RVA = "0x1AFCF40", Offset = "0x1AFC140", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019D8")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006D0")]
	private override Rotate UnityEngine.UIElements.IResolvedStyle.rotate
	{
		[Address(RVA = "0x1AFCFA0", Offset = "0x1AFC1A0", Length = "0xDB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019D9")]
		private get { } //Length: 219
	}

	[Token(Token = "0x170006D1")]
	private override Scale UnityEngine.UIElements.IResolvedStyle.scale
	{
		[Address(RVA = "0x1AFD080", Offset = "0x1AFC280", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019DA")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006D2")]
	private override TextOverflow UnityEngine.UIElements.IResolvedStyle.textOverflow
	{
		[Address(RVA = "0x1AFD160", Offset = "0x1AFC360", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019DB")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006D3")]
	private override float UnityEngine.UIElements.IResolvedStyle.top
	{
		[Address(RVA = "0x1AFD1C0", Offset = "0x1AFC3C0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019DC")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006D4")]
	private override Vector3 UnityEngine.UIElements.IResolvedStyle.transformOrigin
	{
		[Address(RVA = "0x1AFD220", Offset = "0x1AFC420", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019DD")]
		private get { } //Length: 217
	}

	[Token(Token = "0x170006D5")]
	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.transitionDelay
	{
		[Address(RVA = "0x1AFD300", Offset = "0x1AFC500", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019DE")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006D6")]
	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.transitionDuration
	{
		[Address(RVA = "0x1AFD360", Offset = "0x1AFC560", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019DF")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006D7")]
	private override IEnumerable<StylePropertyName> UnityEngine.UIElements.IResolvedStyle.transitionProperty
	{
		[Address(RVA = "0x1AFD3C0", Offset = "0x1AFC5C0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019E0")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006D8")]
	private override IEnumerable<EasingFunction> UnityEngine.UIElements.IResolvedStyle.transitionTimingFunction
	{
		[Address(RVA = "0x1AFD420", Offset = "0x1AFC620", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019E1")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006D9")]
	private override Vector3 UnityEngine.UIElements.IResolvedStyle.translate
	{
		[Address(RVA = "0x1AFD480", Offset = "0x1AFC680", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019E2")]
		private get { } //Length: 217
	}

	[Token(Token = "0x170006DA")]
	private override Color UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor
	{
		[Address(RVA = "0x1AFD560", Offset = "0x1AFC760", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019E3")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006DB")]
	private override EditorTextRenderingMode UnityEngine.UIElements.IResolvedStyle.unityEditorTextRenderingMode
	{
		[Address(RVA = "0x1AFD640", Offset = "0x1AFC840", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019E4")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006DC")]
	private override Font UnityEngine.UIElements.IResolvedStyle.unityFont
	{
		[Address(RVA = "0x1AFD7E0", Offset = "0x1AFC9E0", Length = "0xCB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60019E5")]
		private get { } //Length: 203
	}

	[Token(Token = "0x170006DD")]
	private override FontDefinition UnityEngine.UIElements.IResolvedStyle.unityFontDefinition
	{
		[Address(RVA = "0x1AFD6A0", Offset = "0x1AFC8A0", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019E6")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006DE")]
	private override FontStyle UnityEngine.UIElements.IResolvedStyle.unityFontStyleAndWeight
	{
		[Address(RVA = "0x1AFD780", Offset = "0x1AFC980", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019E7")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006DF")]
	private override float UnityEngine.UIElements.IResolvedStyle.unityParagraphSpacing
	{
		[Address(RVA = "0x1AFD8B0", Offset = "0x1AFCAB0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019E8")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E0")]
	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceBottom
	{
		[Address(RVA = "0x1AFD910", Offset = "0x1AFCB10", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019E9")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E1")]
	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceLeft
	{
		[Address(RVA = "0x1AFD970", Offset = "0x1AFCB70", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019EA")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E2")]
	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceRight
	{
		[Address(RVA = "0x1AFD9D0", Offset = "0x1AFCBD0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019EB")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E3")]
	private override float UnityEngine.UIElements.IResolvedStyle.unitySliceScale
	{
		[Address(RVA = "0x1AFDA30", Offset = "0x1AFCC30", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019EC")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E4")]
	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceTop
	{
		[Address(RVA = "0x1AFDA90", Offset = "0x1AFCC90", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019ED")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E5")]
	private override SliceType UnityEngine.UIElements.IResolvedStyle.unitySliceType
	{
		[Address(RVA = "0x1AFDAF0", Offset = "0x1AFCCF0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019EE")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E6")]
	private override TextAnchor UnityEngine.UIElements.IResolvedStyle.unityTextAlign
	{
		[Address(RVA = "0x1AFDB50", Offset = "0x1AFCD50", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019EF")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E7")]
	private override TextGeneratorType UnityEngine.UIElements.IResolvedStyle.unityTextGenerator
	{
		[Address(RVA = "0x1AFDBB0", Offset = "0x1AFCDB0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019F0")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E8")]
	private override Color UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor
	{
		[Address(RVA = "0x1AFDC10", Offset = "0x1AFCE10", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019F1")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006E9")]
	private override float UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth
	{
		[Address(RVA = "0x1AFDCF0", Offset = "0x1AFCEF0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019F2")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006EA")]
	private override TextOverflowPosition UnityEngine.UIElements.IResolvedStyle.unityTextOverflowPosition
	{
		[Address(RVA = "0x1AFDD50", Offset = "0x1AFCF50", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019F3")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006EB")]
	private override Visibility UnityEngine.UIElements.IResolvedStyle.visibility
	{
		[Address(RVA = "0x1AFDDB0", Offset = "0x1AFCFB0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019F4")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006EC")]
	private override WhiteSpace UnityEngine.UIElements.IResolvedStyle.whiteSpace
	{
		[Address(RVA = "0x1AFDE10", Offset = "0x1AFD010", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019F5")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006ED")]
	private override float UnityEngine.UIElements.IResolvedStyle.width
	{
		[Address(RVA = "0x1AFDE70", Offset = "0x1AFD070", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019F6")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006EE")]
	private override float UnityEngine.UIElements.IResolvedStyle.wordSpacing
	{
		[Address(RVA = "0x1AFDED0", Offset = "0x1AFD0D0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019F7")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006F2")]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60019FC")]
		private get { } //Length: 4
		[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60019FD")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170006F1")]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60019FA")]
		private get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60019FB")]
		private set { } //Length: 4
	}

	[CreateProperty]
	[Token(Token = "0x170006FF")]
	public UsageHints usageHints
	{
		[Address(RVA = "0x1B04F10", Offset = "0x1B04110", Length = "0x2D")]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(StyleValue), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 12)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A2B")]
		 get { } //Length: 45
		[Address(RVA = "0x1B06D30", Offset = "0x1B05F30", Length = "0x218")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(StyleValue), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6001A2C")]
		 set { } //Length: 536
	}

	[CreateProperty]
	[Token(Token = "0x170006FA")]
	public object userData
	{
		[Address(RVA = "0x1B04F40", Offset = "0x1B04140", Length = "0x9E")]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "set_userData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(Object&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6001A24")]
		 get { } //Length: 158
		[Address(RVA = "0x1B06F50", Offset = "0x1B06150", Length = "0x145")]
		[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "InitExpandHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(MenuItem))]
		[CalledBy(Type = typeof(Tab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Background)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_userData", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "SetPropertyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001A25")]
		 set { } //Length: 325
	}

	[Token(Token = "0x17000701")]
	internal bool useRenderTexture
	{
		[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A30")]
		internal get { } //Length: 5
	}

	[CreateProperty]
	[Token(Token = "0x170006F8")]
	public string viewDataKey
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A21")]
		 get { } //Length: 5
		[Address(RVA = "0x1B070A0", Offset = "0x1B062A0", Length = "0xC8")]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scroller), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(System.Action`1<System.Single>), typeof(SliderDirection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = "PrepareView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001A22")]
		 set { } //Length: 200
	}

	[CreateProperty]
	[Token(Token = "0x17000732")]
	public bool visible
	{
		[Address(RVA = "0x1B04FE0", Offset = "0x1B041E0", Length = "0x58")]
		[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabLayout), Member = "GetTabOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TabView), Member = "ReorderTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FocusController), Member = "ReevaluateFocus", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "PerformPick3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "PerformPick2D_LocalPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(BaseElementBuilder), Member = "BuildStandardElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A8F")]
		 get { } //Length: 88
		[Address(RVA = "0x1B07170", Offset = "0x1B06370", Length = "0x1F8")]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "SetToggleVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseCompositeField`3), Member = "GetSpacer", ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A90")]
		 set { } //Length: 504
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000746")]
	public internal VisualTreeAsset visualTreeAssetSource
	{
		[Address(RVA = "0x45FC00", Offset = "0x45EE00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AF0")]
		 get { } //Length: 8
		[Address(RVA = "0x1B07370", Offset = "0x1B06570", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001AF1")]
		internal set { } //Length: 19
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000715")]
	public Rect worldBound
	{
		[Address(RVA = "0x1B05040", Offset = "0x1B04240", Length = "0xFD")]
		[CallerCount(Count = 71)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
		[Token(Token = "0x6001A4E")]
		 get { } //Length: 253
	}

	[Token(Token = "0x17000710")]
	internal Rect worldBoundingBox
	{
		[Address(RVA = "0x1B05140", Offset = "0x1B04340", Length = "0xB1")]
		[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AEF1F0")]
		[Token(Token = "0x6001A46")]
		internal get { } //Length: 177
	}

	[Token(Token = "0x1700071F")]
	internal Rect worldClip
	{
		[Address(RVA = "0x1B05200", Offset = "0x1B04400", Length = "0x4B")]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(RenderData), Member = "get_clippingRect", ReturnType = typeof(Rect))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001A5C")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 75
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x1700071C")]
	public Matrix4x4 worldTransform
	{
		[Address(RVA = "0x1B05300", Offset = "0x1B04500", Length = "0x6B")]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "GetCurrentTransformAndClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMGUIContainer), typeof(Event), typeof(Matrix4x4&), typeof(Rect&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToRenderTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[Token(Token = "0x6001A57")]
		 get { } //Length: 107
	}

	[Token(Token = "0x1700071E")]
	internal Matrix4x4 worldTransformInverse
	{
		[Address(RVA = "0x1B05250", Offset = "0x1B04450", Length = "0x7E")]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray)}, ReturnType = typeof(Ray))]
		[CalledBy(Type = typeof(PickResult), Member = "ComputeCollisionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "get_templateDependencies", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualTreeAsset>))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo_2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo_3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Ray)}, ReturnType = typeof(Ray))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(Matrix4x4), Member = "Inverse3DAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[Token(Token = "0x6001A59")]
		internal get { } //Length: 126
	}

	[Token(Token = "0x1700071D")]
	internal Matrix4x4 worldTransformRef
	{
		[Address(RVA = "0x1B052D0", Offset = "0x1B044D0", Length = "0x30")]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Ray)}, ReturnType = typeof(Ray))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo_3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo_2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray)}, ReturnType = typeof(Ray))]
		[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "get_templateDependencies", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualTreeAsset>))]
		[CalledBy(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "GetPicking3DWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Bounds))]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "PickDocument3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = typeof(PickResult))]
		[CalledBy(Type = typeof(PickResult), Member = "ComputeCollisionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColliderUpdateMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[Token(Token = "0x6001A58")]
		internal get { } //Length: 48
	}

	[Address(RVA = "0x1B017D0", Offset = "0x1B009D0", Length = "0x143D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001B36")]
	private static VisualElement() { }

	[Address(RVA = "0x1B02C10", Offset = "0x1B01E10", Length = "0x537")]
	[CallerCount(Count = 110)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventInterestReflectionUtils), Member = "GetDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32&), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(LayoutManager), Member = "CreateNode", ReturnType = typeof(LayoutNode))]
	[Calls(Type = typeof(LayoutManager), Member = "get_SharedManager", ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InitialStyle), Member = "Acquire", ReturnType = typeof(ComputedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "UpdateEventInterestSelfCategories", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001A78")]
	public VisualElement() { }

	[Address(RVA = "0x1AFB5A0", Offset = "0x1AFA7A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B37")]
	internal static bool <CalculateConservativeBounds>g__IsNaN|748_0(Vector3 v) { }

	[Address(RVA = "0x1AF2670", Offset = "0x1AF1870", Length = "0xCA")]
	[CallerCount(Count = 122)]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AF2")]
	public void Add(VisualElement child) { }

	[Address(RVA = "0x1AF2570", Offset = "0x1AF1770", Length = "0xF3")]
	[CalledBy(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AF3")]
	internal void Add(VisualElement child, bool ignoreContentContainer) { }

	[Address(RVA = "0x1B03150", Offset = "0x1B02350", Length = "0xBA")]
	[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001AE7")]
	internal void add_elementAdded(Action<VisualElement, Int32> value) { }

	[Address(RVA = "0x1B03210", Offset = "0x1B02410", Length = "0xBA")]
	[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001AE9")]
	internal void add_elementRemoved(Action<VisualElement> value) { }

	[Address(RVA = "0x1AF20D0", Offset = "0x1AF12D0", Length = "0x20")]
	[CalledBy(Type = typeof(CallbackEventHandler), Member = "AddEventCategories", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateEventInterestSelfCategories", ReturnType = typeof(void))]
	[Token(Token = "0x6001ACD")]
	internal void AddEventCallbackCategories(int eventCategories, TrickleDown trickleDown) { }

	[Address(RVA = "0x1AF20F0", Offset = "0x1AF12F0", Length = "0x252")]
	[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "AssignStyleSheetFromAssetToElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(Panel), Member = "LoadResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(float)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementStyleSheetSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B2D")]
	internal void AddStyleSheetPath(string sheetPath) { }

	[Address(RVA = "0x1AF2350", Offset = "0x1AF1550", Length = "0x211")]
	[CallerCount(Count = 354)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectListPool`1), Member = "Get", ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AA7")]
	public void AddToClassList(string className) { }

	[Address(RVA = "0x1AF2740", Offset = "0x1AF1940", Length = "0x31")]
	[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_UsesMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A9E")]
	private void AssignMeasureFunction() { }

	[Address(RVA = "0x1AF2780", Offset = "0x1AF1980", Length = "0x1A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AF328D")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001AB9")]
	private static void AssignStyleValues(VisualElement ve, StyleValues src) { }

	[Address(RVA = "0x1AF3450", Offset = "0x1AF2650", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AC7")]
	private void AttachDataSource() { }

	[Address(RVA = "0x1AF3470", Offset = "0x1AF2670", Length = "0x6A")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B01")]
	public void BringToFront() { }

	[Address(RVA = "0x1AF34E0", Offset = "0x1AF26E0", Length = "0x4BC")]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColliderUpdateMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "GetPicking3DWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+WordSpacingProperty", Member = "get_ussName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBoundsToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B1A")]
	internal static Bounds CalculateConservativeBounds(ref Matrix4x4 matrix, Bounds bounds) { }

	[Address(RVA = "0x1AF39A0", Offset = "0x1AF2BA0", Length = "0x379")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+WordSpacingProperty", Member = "get_ussName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRectToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "UpdateDrawBounds_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B19")]
	internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect) { }

	[Address(RVA = "0x1AF3D20", Offset = "0x1AF2F20", Length = "0x49")]
	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Token(Token = "0x6001A77")]
	private void ChangeIMGUIContainerCount(int delta) { }

	[Address(RVA = "0x1AF3D70", Offset = "0x1AF2F70", Length = "0x168")]
	[CalledBy(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ClearProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(PropertyName), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001AAF")]
	private static void CheckUserKeyArgument(PropertyName key) { }

	[Address(RVA = "0x1AF3EE0", Offset = "0x1AF30E0", Length = "0x92")]
	[CalledBy(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AFB")]
	internal int ChildCount(bool ignoreContentContainer) { }

	[Address(RVA = "0x1AF3F80", Offset = "0x1AF3180", Length = "0xBB")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "GetLargestItemWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "Children", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualElement>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "Children", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualElement>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001B00")]
	public IEnumerable<VisualElement> Children() { }

	[Address(RVA = "0x1AF4040", Offset = "0x1AF3240", Length = "0xC1")]
	[CalledBy(Type = typeof(DataBinding), Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "OnNavigationMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "OnNavigationSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationSubmitEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "get_showBorder", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseField`1), Member = "OnAttachToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "AlignLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "GetNavigationState", ReturnType = "UnityEngine.UIElements.MinMaxSlider+DragState")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementUtils+<>c", Member = "<AssignInspectorStyleIfNecessary>b__5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "MatchesSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleSelector)}, ReturnType = typeof(MatchResultInfo))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001AAA")]
	public bool ClassListContains(string cls) { }

	[Address(RVA = "0x1AF4940", Offset = "0x1AF3B40", Length = "0x6A")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AF7")]
	public void Clear() { }

	[Address(RVA = "0x1AF4110", Offset = "0x1AF3310", Length = "0x79B")]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x6001A37")]
	internal void ClearManualLayout() { }

	[Address(RVA = "0x1AF48B0", Offset = "0x1AF3AB0", Length = "0x84")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "set_content", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "DestroyHeaderContent", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001AAE")]
	internal bool ClearProperty(PropertyName key) { }

	[Address(RVA = "0x1AF49B0", Offset = "0x1AF3BB0", Length = "0x201")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001A5E")]
	internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat) { }

	[Address(RVA = "0x1AF4C20", Offset = "0x1AF3E20", Length = "0x77")]
	[CalledBy(Type = typeof(Tab), Member = "EnableTabDragHandles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "EnableTabCloseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "RemoveCloseButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextElementDepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(Tab), Member = "RemoveDragHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "set_label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClickDetector), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Clickable), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tab), Member = "set_closeable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetPreviousElementDepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Token(Token = "0x6001B08")]
	public bool Contains(VisualElement child) { }

	[Address(RVA = "0x1AF4BC0", Offset = "0x1AF3DC0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A9B")]
	public override bool ContainsPoint(Vector2 localPoint) { }

	[Address(RVA = "0x1AF4CA0", Offset = "0x1AF3EA0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "TransferBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AC4")]
	private void CreateBindingRequests() { }

	[Address(RVA = "0x1AF4D40", Offset = "0x1AF3F40", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AC6")]
	private void DetachDataSource() { }

	[Address(RVA = "0x1AF4D70", Offset = "0x1AF3F70", Length = "0x87")]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001AC8")]
	private void DirtyNextParentWithEventInterests() { }

	[Address(RVA = "0x1AF4E00", Offset = "0x1AF4000", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001AA0")]
	protected private override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[Address(RVA = "0x1AF4FE0", Offset = "0x1AF41E0", Length = "0xA")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "OnColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Token(Token = "0x6001AF8")]
	public VisualElement ElementAt(int index) { }

	[Address(RVA = "0x1AF4E20", Offset = "0x1AF4020", Length = "0x1B3")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "HandleFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AFE")]
	internal VisualElement ElementAtTreePath(List<Int32> childIndexes) { }

	[Address(RVA = "0x1AF4FF0", Offset = "0x1AF41F0", Length = "0x22")]
	[CallerCount(Count = 51)]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AA9")]
	public void EnableInClassList(string className, bool enable) { }

	[Address(RVA = "0x1AF5020", Offset = "0x1AF4220", Length = "0x4E")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A5D")]
	internal void EnsureWorldTransformAndClipUpToDate() { }

	[Address(RVA = "0x1AF50D0", Offset = "0x1AF42D0", Length = "0x124")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "get_SharedManager", ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "EnqueueNodeForRecycling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A79")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1AF5070", Offset = "0x1AF4270", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AA2")]
	private void FinalizeLayout() { }

	[Address(RVA = "0x1AF5200", Offset = "0x1AF4400", Length = "0x1A8")]
	[CalledBy(Type = typeof(ClickDetector), Member = "SendClickEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B0A")]
	public VisualElement FindCommonAncestor(VisualElement other) { }

	[Address(RVA = "0x1AF53B0", Offset = "0x1AF45B0", Length = "0x114")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "OnFocusIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AFF")]
	internal bool FindElementInTree(VisualElement element, List<Int32> outChildIndexes) { }

	[Address(RVA = "0x1AF54D0", Offset = "0x1AF46D0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Focusable), Member = "Focus", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A7C")]
	public virtual void Focus() { }

	[Address(RVA = "0x1AF5570", Offset = "0x1AF4770", Length = "0xBF")]
	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B09")]
	private void GatherAllChildren(List<VisualElement> elements) { }

	[Address(RVA = "0x1B03360", Offset = "0x1B02560", Length = "0x9")]
	[CalledBy(Type = typeof(FocusController), Member = "ReevaluateFocus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "BuildStandardElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Token(Token = "0x6001A1B")]
	internal bool get_areAncestorsAndSelfDisplayed() { }

	[Address(RVA = "0x1B03480", Offset = "0x1B02680", Length = "0x42")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[Token(Token = "0x6001A44")]
	internal Rect get_boundingBox() { }

	[Address(RVA = "0x1B03370", Offset = "0x1B02570", Length = "0x9")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001A61")]
	internal bool get_boundingBoxDirtiedSinceLastLayoutPass() { }

	[Address(RVA = "0x1B03380", Offset = "0x1B02580", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AEF0B0")]
	[Token(Token = "0x6001A47")]
	private Rect get_boundingBoxInParentSpace() { }

	[Address(RVA = "0x1B033E0", Offset = "0x1B025E0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A45")]
	internal Rect get_boundingBoxWithoutNested() { }

	[Address(RVA = "0x1B034D0", Offset = "0x1B026D0", Length = "0x105")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Focusable), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A26")]
	public virtual bool get_canGrabFocus() { }

	[Address(RVA = "0x1B035E0", Offset = "0x1B027E0", Length = "0x70")]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnPostDisplaySetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "UpdateBackground", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "GetLargestItemWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(TwoPaneSplitViewOrientation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "PostDisplaySetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "ChildCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetPreviousElementDepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AFA")]
	public int get_childCount() { }

	[Address(RVA = "0x1B03650", Offset = "0x1B02850", Length = "0xB1")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "UpdateBackground", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectListPool`1), Member = "Get", ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001A6F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<String> get_classList() { }

	[Address(RVA = "0x1B03710", Offset = "0x1B02910", Length = "0x8")]
	[CallerCount(Count = 193)]
	[Token(Token = "0x6001A73")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal ComputedStyle get_computedStyle() { }

	[Address(RVA = "0x189D630", Offset = "0x189C830", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A65")]
	internal int get_containedPointerIds() { }

	[Address(RVA = "0x151EF90", Offset = "0x151E190", Length = "0x6")]
	[CallerCount(Count = 142)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AEF")]
	public override VisualElement get_contentContainer() { }

	[Address(RVA = "0x1B03720", Offset = "0x1B02920", Length = "0x2E1")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Spacing), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Spacing)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A38")]
	public Rect get_contentRect() { }

	[Address(RVA = "0x1B03A10", Offset = "0x1B02C10", Length = "0x8E")]
	[CalledBy(Type = typeof(Image), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T0&", "T1&", "T2&", typeof(BindingId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CustomStyleResolvedEvent), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitContext", typeof(IProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CustomStyleAccess), Member = "SetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.StyleSheets.StylePropertyValue>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B2B")]
	public ICustomStyle get_customStyle() { }

	[Address(RVA = "0x1B03B70", Offset = "0x1B02D70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001ABD")]
	public object get_dataSource() { }

	[Address(RVA = "0x1B03AA0", Offset = "0x1B02CA0", Length = "0xC9")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(DataSourceContext))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PathRef), Member = "get_path", ReturnType = typeof(PropertyPath&))]
	[Token(Token = "0x6001ABF")]
	public PropertyPath get_dataSourcePath() { }

	[Address(RVA = "0x1B03B80", Offset = "0x1B02D80", Length = "0xA")]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "BuildStandardElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6001AB2")]
	internal Material get_defaultMaterial() { }

	[Address(RVA = "0x1B03B90", Offset = "0x1B02D90", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001AE2")]
	internal bool get_disableClipping() { }

	[Address(RVA = "0x8D41C0", Offset = "0x8D33C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A28")]
	public bool get_disablePlayModeTint() { }

	[Address(RVA = "0x1B03BA0", Offset = "0x1B02DA0", Length = "0x9")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnDisableRenderingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001AE5")]
	internal bool get_disableRendering() { }

	[Address(RVA = "0x1B03BB0", Offset = "0x1B02DB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001AEC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal BaseVisualElementPanel get_elementPanel() { }

	[Address(RVA = "0x1B03BD0", Offset = "0x1B02DD0", Length = "0x10")]
	[CalledBy(Type = typeof(TextElement), Member = "PasteActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
	[CalledBy(Type = typeof(TextElement), Member = "CopyActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
	[CalledBy(Type = typeof(Clickable), Member = "OnTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Clickable), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Clickable), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "AcceptCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicCallbackList), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsUtility), Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUILayoutUtility+LayoutCache", typeof(Event), typeof(IMGUIContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "GetFocusableParentForPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "ValidateHierarchyTraversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetFocusChangeDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(FocusChangeDirection))]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextEdition.get_isReadOnly", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "CutActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "Disabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 22)]
	[Token(Token = "0x6001A86")]
	public bool get_enabledInHierarchy() { }

	[Address(RVA = "0x1B03BE0", Offset = "0x1B02DE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001A87")]
	public bool get_enabledSelf() { }

	[Address(RVA = "0x1B03BC0", Offset = "0x1B02DC0", Length = "0x9")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "IsViewDataKeyEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetOrCreateViewData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = "T")]
	[CallerCount(Count = 6)]
	[Token(Token = "0x6001A23")]
	internal bool get_enableViewDataPersistence() { }

	[Address(RVA = "0x1B03BF0", Offset = "0x1B02DF0", Length = "0x3B")]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateEventInterestParentCategories", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateEventInterestParentCategories", ReturnType = typeof(void))]
	[Token(Token = "0x6001ACE")]
	internal int get_eventInterestParentCategories() { }

	[Address(RVA = "0x151EF90", Offset = "0x151E190", Length = "0x6")]
	[CallerCount(Count = 142)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ADD")]
	public IExperimentalFeatures get_experimental() { }

	[Address(RVA = "0x1B03C30", Offset = "0x1B02E30", Length = "0x56")]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyChildrenHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyBoundingBoxHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyParentHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "DirtyBoundingBoxHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "DirtyParentHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 19)]
	[Token(Token = "0x6001A1F")]
	internal VisualElementFlags get_flags() { }

	[Address(RVA = "0x1B03C90", Offset = "0x1B02E90", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A27")]
	public virtual FocusController get_focusController() { }

	[Address(RVA = "0x1B03D70", Offset = "0x1B02F70", Length = "0x23")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_typeData", ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(TypeData), Member = "get_fullTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A70")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string get_fullTypeName() { }

	[Address(RVA = "0x5E4B70", Offset = "0x5E3D70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A92")]
	public Action<MeshGenerationContext> get_generateVisualContent() { }

	[Address(RVA = "0x1B03DA0", Offset = "0x1B02FA0", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B14")]
	private bool get_has3DRotation() { }

	[Address(RVA = "0x1B03E80", Offset = "0x1B03080", Length = "0x142")]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "GetParentMustDirtyFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElementFlags))]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "DirtyBoundingBoxHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_translate", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B12")]
	internal bool get_has3DTransform() { }

	[Address(RVA = "0x1B03FD0", Offset = "0x1B031D0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_translate", ReturnType = typeof(Translate))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B13")]
	private bool get_has3DTranslation() { }

	[Address(RVA = "0x1B04010", Offset = "0x1B03210", Length = "0x4E")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60019F9")]
	internal bool get_hasCompletedAnimations() { }

	[Address(RVA = "0x1AEF270", Offset = "0x1AEE470", Length = "0xFA")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+WordSpacingProperty", Member = "get_ussName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBoundsToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRectToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_scale", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B11")]
	internal bool get_hasDefaultRotationAndScale() { }

	[Address(RVA = "0x1B04060", Offset = "0x1B03260", Length = "0xC")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A74")]
	internal bool get_hasInlineStyle() { }

	[Address(RVA = "0x1B04070", Offset = "0x1B03270", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001A1D")]
	internal bool get_hasOneOrMorePointerCaptures() { }

	[Address(RVA = "0x1B04080", Offset = "0x1B03280", Length = "0x4E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60019F8")]
	internal bool get_hasRunningAnimations() { }

	[Address(RVA = "0x1B040D0", Offset = "0x1B032D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001ADF")]
	public Hierarchy get_hierarchy() { }

	[Address(RVA = "0x1B040E0", Offset = "0x1B032E0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001A40")]
	internal bool get_isBoundingBoxDirty() { }

	[Address(RVA = "0x1B040F0", Offset = "0x1B032F0", Length = "0x9")]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Focusable), Member = "set_excludeFromFocusRing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Focusable), Member = "GetFirstFocusableChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(FocusController), Member = "GetRetargetedFocusedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(FocusController), Member = "GetFocusTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.FocusController+FocusedElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Token(Token = "0x6001A19")]
	internal bool get_isCompositeRoot() { }

	[Address(RVA = "0x1B04100", Offset = "0x1B03300", Length = "0x28")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(DataSourceContext))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PathRef), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Token(Token = "0x6001AC1")]
	internal bool get_isDataSourcePathEmpty() { }

	[Address(RVA = "0x1B04130", Offset = "0x1B03330", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001ACF")]
	internal bool get_isEventInterestParentCategoriesDirty() { }

	[Address(RVA = "0x1B04140", Offset = "0x1B03340", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001A31")]
	internal bool get_isLayoutManual() { }

	[Address(RVA = "0x1B04150", Offset = "0x1B03350", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A3C")]
	internal bool get_isLocalBounds3DDirty() { }

	[Address(RVA = "0x1B04160", Offset = "0x1B03360", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A3E")]
	internal bool get_isLocalBoundsWithoutNested3DDirty() { }

	[Address(RVA = "0x1B04170", Offset = "0x1B03370", Length = "0x67")]
	[CalledBy(Type = typeof(VisualElement), Member = "SetEnabledFromHierarchyPrivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A85")]
	private bool get_isParentEnabledInHierarchy() { }

	[Address(RVA = "0x404F70", Offset = "0x404170", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AE0")]
	internal bool get_isRootVisualContainer() { }

	[Address(RVA = "0x1B041E0", Offset = "0x1B033E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A43")]
	internal bool get_isWorldBoundingBoxOrDependenciesDirty() { }

	[Address(RVA = "0x1B041F0", Offset = "0x1B033F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001A51")]
	internal bool get_isWorldSpaceRootUIDocument() { }

	[Address(RVA = "0x138BBF0", Offset = "0x138ADF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A53")]
	internal bool get_isWorldTransformDirty() { }

	[Address(RVA = "0x1B04200", Offset = "0x1B03400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A56")]
	internal bool get_isWorldTransformInverseOrDependenciesDirty() { }

	[Address(RVA = "0x1B032D0", Offset = "0x1B024D0", Length = "0x8B")]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableMultiColumnListViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableMultiColumnTreeViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "IdentifyLeftAndRightPane", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "OnFocusIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnControlGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "RaiseColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "PostDisplaySetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AF9")]
	public VisualElement get_Item(int key) { }

	[Address(RVA = "0x499330", Offset = "0x498530", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A8B")]
	public LanguageDirection get_languageDirection() { }

	[Address(RVA = "0x1B04220", Offset = "0x1B03420", Length = "0xCD")]
	[CallerCount(Count = 149)]
	[Calls(Type = typeof(LayoutNode), Member = "get_IsUndefined", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutX", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutY", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutHeight", ReturnType = typeof(float))]
	[Token(Token = "0x6001A35")]
	public Rect get_layout() { }

	[Address(RVA = "0x1B04210", Offset = "0x1B03410", Length = "0xA")]
	[CallerCount(Count = 92)]
	[Token(Token = "0x6001A72")]
	internal LayoutNode get_layoutNode() { }

	[Address(RVA = "0x1B042F0", Offset = "0x1B034F0", Length = "0x83")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "ApplyDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "GetHoverBarTopPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAtElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "<ApplyDragAndDropUI>g__GeometryChangedCallback|31_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AEF0B0")]
	[Token(Token = "0x6001A4F")]
	public Rect get_localBound() { }

	[Address(RVA = "0x1B04430", Offset = "0x1B03630", Length = "0xA0")]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
	[Token(Token = "0x6001A4A")]
	internal Bounds get_localBounds3D() { }

	[Address(RVA = "0x1B04380", Offset = "0x1B03580", Length = "0xA1")]
	[CalledBy(Type = typeof(UIDocument), Member = "LocalBoundsFromPivotSource", ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(UIDocument), Member = "PivotOffset", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
	[Token(Token = "0x6001A4C")]
	internal Bounds get_localBounds3DWithoutNested3D() { }

	[Address(RVA = "0x1B044D0", Offset = "0x1B036D0", Length = "0xA0")]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "GetPicking3DLocalBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
	[Token(Token = "0x6001A4B")]
	internal Bounds get_localBoundsPicking3D() { }

	[Address(RVA = "0x499370", Offset = "0x498570", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A8D")]
	internal LanguageDirection get_localLanguageDirection() { }

	[Address(RVA = "0x19AA840", Offset = "0x19A9A40", Length = "0x7")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A6D")]
	public string get_name() { }

	[Address(RVA = "0x1B04570", Offset = "0x1B03770", Length = "0xB")]
	[CalledBy(Type = typeof(PhysicsDocumentPicker), Member = "TryPickWithCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Ray), typeof(float), typeof(int), typeof(Collider&), typeof(UIDocument&), typeof(VisualElement&), typeof(Single&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(Single&)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "GetPicking3DLocalBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A3A")]
	internal bool get_needs3DBounds() { }

	[Address(RVA = "0x1B04580", Offset = "0x1B03780", Length = "0x1D5")]
	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001ACB")]
	internal VisualElement get_nextParentWithEventInterests() { }

	[Address(RVA = "0x1B04760", Offset = "0x1B03960", Length = "0x1BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Spacing), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Spacing)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001A39")]
	protected Rect get_paddingRect() { }

	[Address(RVA = "0x1B04920", Offset = "0x1B03B20", Length = "0xA")]
	[CallerCount(Count = 110)]
	[Token(Token = "0x6001AEE")]
	public IPanel get_panel() { }

	[Address(RVA = "0x1B04930", Offset = "0x1B03B30", Length = "0xA")]
	[CallerCount(Count = 50)]
	[Token(Token = "0x6001AEB")]
	public VisualElement get_parent() { }

	[Address(RVA = "0x189D640", Offset = "0x189C840", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A6B")]
	public PickingMode get_pickingMode() { }

	[Address(RVA = "0x1B04940", Offset = "0x1B03B40", Length = "0x39")]
	[CalledBy(Type = typeof(Image), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001A2A")]
	internal Color get_playModeTintColor() { }

	[Address(RVA = "0x1B04980", Offset = "0x1B03B80", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Token(Token = "0x6001B0F")]
	private Vector3 get_positionWithLayout() { }

	[Address(RVA = "0x1A32680", Offset = "0x1A31880", Length = "0x9")]
	[CallerCount(Count = 61)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A63")]
	internal PseudoStates get_pseudoStates() { }

	[Address(RVA = "0x1B04A10", Offset = "0x1B03C10", Length = "0x9")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6001A5F")]
	internal bool get_receivesHierarchyGeometryChangedEvents() { }

	[Address(RVA = "0x1B04A20", Offset = "0x1B03C20", Length = "0x58")]
	[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(ChangeDirection), typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "IntersectLocalRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "StrictOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "Order", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderData), Member = "GetLocalClippingRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "TieBreaker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(int))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Token(Token = "0x6001A50")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Rect get_rect() { }

	[Address(RVA = "0x1B04A80", Offset = "0x1B03C80", Length = "0x6")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A2D")]
	internal RenderHints get_renderHints() { }

	[Address(RVA = "0x1B04A90", Offset = "0x1B03C90", Length = "0x9")]
	[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6001A9C")]
	internal bool get_requireMeasureFunction() { }

	[Address(RVA = "0x1B04AA0", Offset = "0x1B03CA0", Length = "0x85")]
	[CallerCount(Count = 285)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B2A")]
	public IResolvedStyle get_resolvedStyle() { }

	[Address(RVA = "0x1B04B30", Offset = "0x1B03D30", Length = "0x9F")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetPixelsPerPoint", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(AlignmentUtils), Member = "RoundToPanelPixelSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ApplyScrollInertia", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ATGMeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(System.Collections.Generic.List`1<UnityEngine.Texture2D>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<System.UInt16>>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphRenderMode>), typeof(System.Collections.Generic.List`1<System.Single>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "SpringBack", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Material>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "ElideText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(TextOverflowPosition)}, ReturnType = typeof(string))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A33")]
	public float get_scaledPixelsPerPoint() { }

	[Address(RVA = "0x1B04BD0", Offset = "0x1B03DD0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Token(Token = "0x6001A34")]
	internal float get_scaledPixelsPerPoint_noChecks() { }

	[Address(RVA = "0x151EF90", Offset = "0x151E190", Length = "0x6")]
	[CallerCount(Count = 142)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B26")]
	public IVisualElementScheduler get_schedule() { }

	[Address(RVA = "0x1B04C70", Offset = "0x1B03E70", Length = "0x79")]
	[CallerCount(Count = 258)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InlineStyleAccess), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001B29")]
	public IStyle get_style() { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019FF")]
	internal IStylePropertyAnimations get_styleAnimation() { }

	[Address(RVA = "0x1B04C30", Offset = "0x1B03E30", Length = "0x9")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Token(Token = "0x6001A75")]
	internal bool get_styleInitialized() { }

	[Address(RVA = "0x1B04C40", Offset = "0x1B03E40", Length = "0x27")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "AssignStyleSheetFromAssetToElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B2C")]
	public VisualElementStyleSheetSet get_styleSheets() { }

	[Address(RVA = "0x1B04CF0", Offset = "0x1B03EF0", Length = "0x89")]
	[CalledBy(Type = typeof(BaseField`1), Member = "ComputeTooltipRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(BaseField`1), Member = "GetTooltipRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(BaseField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "UpdateTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Token(Token = "0x6001B33")]
	public string get_tooltip() { }

	[Address(RVA = "0x1B04D80", Offset = "0x1B03F80", Length = "0x156")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_fullTypeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_typeName", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TypeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B35")]
	private TypeData get_typeData() { }

	[Address(RVA = "0x1B04EE0", Offset = "0x1B040E0", Length = "0x23")]
	[CalledBy(Type = typeof(AncestorFilter), Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "MatchesSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleSelector)}, ReturnType = typeof(MatchResultInfo))]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FindMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleMatchingContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_typeData", ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(TypeData), Member = "get_typeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A71")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string get_typeName() { }

	[Address(RVA = "0x1B04F10", Offset = "0x1B04110", Length = "0x2D")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(StyleValue), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A2B")]
	public UsageHints get_usageHints() { }

	[Address(RVA = "0x1B04F40", Offset = "0x1B04140", Length = "0x9E")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_userData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(Object&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001A24")]
	public object get_userData() { }

	[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A30")]
	internal bool get_useRenderTexture() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A21")]
	public string get_viewDataKey() { }

	[Address(RVA = "0x1B04FE0", Offset = "0x1B041E0", Length = "0x58")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabLayout), Member = "GetTabOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TabView), Member = "ReorderTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "ReevaluateFocus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "PerformPick3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "PerformPick2D_LocalPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "BuildStandardElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A8F")]
	public bool get_visible() { }

	[Address(RVA = "0x45FC00", Offset = "0x45EE00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AF0")]
	public VisualTreeAsset get_visualTreeAssetSource() { }

	[Address(RVA = "0x1B05040", Offset = "0x1B04240", Length = "0xFD")]
	[CallerCount(Count = 71)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Token(Token = "0x6001A4E")]
	public Rect get_worldBound() { }

	[Address(RVA = "0x1B05140", Offset = "0x1B04340", Length = "0xB1")]
	[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AEF1F0")]
	[Token(Token = "0x6001A46")]
	internal Rect get_worldBoundingBox() { }

	[Address(RVA = "0x1B05200", Offset = "0x1B04400", Length = "0x4B")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderData), Member = "get_clippingRect", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001A5C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Rect get_worldClip() { }

	[Address(RVA = "0x1B05300", Offset = "0x1B04500", Length = "0x6B")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "GetCurrentTransformAndClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMGUIContainer), typeof(Event), typeof(Matrix4x4&), typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToRenderTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Token(Token = "0x6001A57")]
	public Matrix4x4 get_worldTransform() { }

	[Address(RVA = "0x1B05250", Offset = "0x1B04450", Length = "0x7E")]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo_3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo_2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "get_templateDependencies", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualTreeAsset>))]
	[CalledBy(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PickResult), Member = "ComputeCollisionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "Inverse3DAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001A59")]
	internal Matrix4x4 get_worldTransformInverse() { }

	[Address(RVA = "0x1B052D0", Offset = "0x1B044D0", Length = "0x30")]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColliderUpdateMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PickResult), Member = "ComputeCollisionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "PickDocument3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = typeof(PickResult))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "GetPicking3DWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "get_templateDependencies", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualTreeAsset>))]
	[CalledBy(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo_2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo_3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Token(Token = "0x6001A58")]
	internal Matrix4x4 get_worldTransformRef() { }

	[Address(RVA = "0x1AF5630", Offset = "0x1AF4830", Length = "0xA4")]
	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UnregisterRunningAnimations", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "RegisterRunningAnimations", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AB3")]
	private VisualElementAnimationSystem GetAnimationSystem() { }

	[Address(RVA = "0x1AF56E0", Offset = "0x1AF48E0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001ACA")]
	internal bool GetCachedNextParentWithEventInterests(out VisualElement nextParent) { }

	[Address(RVA = "0x19AA890", Offset = "0x19A9A90", Length = "0x7")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AA6")]
	internal List<String> GetClassesForIteration() { }

	[Address(RVA = "0x7D1B20", Offset = "0x7D0D20", Length = "0x9F")]
	[CalledBy(Type = typeof(TabDragger), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B06")]
	public T GetFirstAncestorOfType() { }

	[Address(RVA = "0x1AF5740", Offset = "0x1AF4940", Length = "0x8F")]
	[CalledBy(Type = typeof(VisualElementUtils), Member = "AssignInspectorStyleIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B07")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElement GetFirstAncestorWhere(Predicate<VisualElement> predicate) { }

	[Address(RVA = "0x7D1BC0", Offset = "0x7D0DC0", Length = "0xF4")]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "GetDropTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(DragEventsProcessor))]
	[CalledBy(Type = typeof(UIDocument), Member = "FindRootUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(UIDocument))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B05")]
	public T GetFirstOfType() { }

	[Address(RVA = "0x1AF57D0", Offset = "0x1AF49D0", Length = "0xD5")]
	[CalledBy(Type = typeof(TabView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextField), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A96")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string GetFullHierarchicalViewDataKey() { }

	[Address(RVA = "0x1AF58B0", Offset = "0x1AF4AB0", Length = "0x8D")]
	[CalledBy(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A95")]
	internal void GetFullHierarchicalViewDataKey(StringBuilder key) { }

	[Address(RVA = "0x1AF5940", Offset = "0x1AF4B40", Length = "0x117")]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextElementDepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001B0C")]
	internal VisualElement GetNextElementDepthFirst() { }

	[Address(RVA = "0x7D1CC0", Offset = "0x7D0EC0", Length = "0x3A7")]
	[CalledBy(Type = typeof(TabView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A97")]
	internal T GetOrCreateViewData(object existing, string key) { }

	[Address(RVA = "0x1AF5A60", Offset = "0x1AF4C60", Length = "0x298")]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A18")]
	private Nullable<Single> GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0) { }

	[Address(RVA = "0x1AF5D30", Offset = "0x1AF4F30", Length = "0x39E")]
	[CalledBy(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRUtility), Member = "ComputeTransformMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+WordSpacingProperty", Member = "get_ussName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBoundsToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRectToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_scale", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(Rotate), Member = "ToQuaternion", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Rotate), Member = "Initial", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTransformOrigin", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B10")]
	internal void GetPivotedMatrixWithLayout(out Matrix4x4 result) { }

	[Address(RVA = "0x1AF60D0", Offset = "0x1AF52D0", Length = "0x123")]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetPreviousElementDepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001B0D")]
	internal VisualElement GetPreviousElementDepthFirst() { }

	[Address(RVA = "0x1AF6200", Offset = "0x1AF5400", Length = "0x99")]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(Object&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001AAB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal object GetProperty(PropertyName key) { }

	[Address(RVA = "0x1AF62A0", Offset = "0x1AF54A0", Length = "0x46")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnAttachToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Token(Token = "0x6001B0B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElement GetRootVisualContainer() { }

	[Address(RVA = "0x1AF62F0", Offset = "0x1AF54F0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019FE")]
	private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() { }

	[Address(RVA = "0x1AF6320", Offset = "0x1AF5520", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Token(Token = "0x6001A7A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal override Rect GetTooltipRect() { }

	[Address(RVA = "0x1AF6350", Offset = "0x1AF5550", Length = "0xA")]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001ADA")]
	internal bool HasBubbleUpEventCallbacks(int eventCategories) { }

	[Address(RVA = "0x1AF6360", Offset = "0x1AF5560", Length = "0x12")]
	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AD8")]
	internal bool HasBubbleUpEventInterests(int eventCategories) { }

	[Address(RVA = "0x1AF6380", Offset = "0x1AF5580", Length = "0xA")]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001ADC")]
	internal bool HasBubbleUpHandleEvent(int eventCategories) { }

	[Address(RVA = "0x1AF6390", Offset = "0x1AF5590", Length = "0x43E")]
	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElementAnimationSystem), Member = "RegisterAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PanelChangedEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(IPanel)}, ReturnType = "T")]
	[Calls(Type = typeof(FocusController), Member = "IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "AnyPendingBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetAnimationSystem", ReturnType = typeof(VisualElementAnimationSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(LayoutNode), Member = "SoftReset", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Config", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "GetDefaultConfig", ReturnType = typeof(LayoutConfig))]
	[Calls(Type = typeof(LayoutManager), Member = "get_SharedManager", ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A7F")]
	private void HasChangedPanel(BaseVisualElementPanel prevPanel) { }

	[Address(RVA = "0x1AF6830", Offset = "0x1AF5A30", Length = "0x55")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionRunEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionStartEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionEndEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "SendTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateEventInterestParentCategories", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AD3")]
	internal bool HasParentEventInterests(EventCategory eventCategory) { }

	[Address(RVA = "0x1AF67D0", Offset = "0x1AF59D0", Length = "0x55")]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateEventInterestParentCategories", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AD4")]
	internal bool HasParentEventInterests(int eventCategories) { }

	[Address(RVA = "0x1AF6890", Offset = "0x1AF5A90", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001AAD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool HasProperty(PropertyName key) { }

	[Address(RVA = "0x1AF6920", Offset = "0x1AF5B20", Length = "0x1B")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AD5")]
	internal bool HasSelfEventInterests(EventCategory eventCategory) { }

	[Address(RVA = "0x1AF6940", Offset = "0x1AF5B40", Length = "0xA")]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AD6")]
	internal bool HasSelfEventInterests(int eventCategories) { }

	[Address(RVA = "0x1AF6950", Offset = "0x1AF5B50", Length = "0xA")]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AD9")]
	internal bool HasTrickleDownEventCallbacks(int eventCategories) { }

	[Address(RVA = "0x1AF6960", Offset = "0x1AF5B60", Length = "0x12")]
	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AD7")]
	internal bool HasTrickleDownEventInterests(int eventCategories) { }

	[Address(RVA = "0x1AF6980", Offset = "0x1AF5B80", Length = "0xA")]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001ADB")]
	internal bool HasTrickleDownHandleEvent(int eventCategories) { }

	[Address(RVA = "0x1AF6990", Offset = "0x1AF5B90", Length = "0x27")]
	[CallerCount(Count = 136)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A82")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void IncrementVersion(VersionChangeType changeType) { }

	[Address(RVA = "0x1AF6A60", Offset = "0x1AF5C60", Length = "0xC0")]
	[CalledBy(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Hierarchy), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AFD")]
	internal int IndexOf(VisualElement element, bool ignoreContentContainer) { }

	[Address(RVA = "0x1AF69C0", Offset = "0x1AF5BC0", Length = "0x93")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseBoolField), Member = "InitLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnControlGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Hierarchy), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AFC")]
	public int IndexOf(VisualElement element) { }

	[Address(RVA = "0x1AF6B20", Offset = "0x1AF5D20", Length = "0xB2")]
	[CalledBy(Type = typeof(Tab), Member = "EnableTabDragHandles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "ReorderTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnElementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "AddDragHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GroupBox), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseBoolField), Member = "InitLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "GetOrMakeItemAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableListViewItem), Member = "UpdateDragHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HelpBox), Member = "UpdateIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HelpBoxMessageType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AF4")]
	public void Insert(int index, VisualElement element) { }

	[Address(RVA = "0x1AF6BE0", Offset = "0x1AF5DE0", Length = "0xE4")]
	[CalledBy(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AF5")]
	internal void Insert(int index, VisualElement element, bool ignoreContentContainer) { }

	[Address(RVA = "0x1AF6CD0", Offset = "0x1AF5ED0", Length = "0x12E")]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "BuildStandardElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "InvokeGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A94")]
	internal void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1AF6E00", Offset = "0x1AF6000", Length = "0x2F")]
	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A83")]
	internal void InvokeHierarchyChanged(HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

	[Address(RVA = "0x1AF6E30", Offset = "0x1AF6030", Length = "0xF7")]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateHoverPseudoState", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Token(Token = "0x6001A68")]
	private static bool IsPartOfCapturedChain(VisualElement self, in IEventHandler capturingElement) { }

	[Address(RVA = "0x1AF6F30", Offset = "0x1AF6130", Length = "0x2A")]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateIsWorldSpaceRootFlag", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "MarkWaitingForLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "StartDragging", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "StopDragging", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "StartDragging", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "StopDragging", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_enableRichText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_parseEscapeSequences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_displayTooltipWhenElided", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextEdition.set_placeholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_selectionColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_cursorColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A91")]
	public void MarkDirtyRepaint() { }

	[Address(RVA = "0x1AF6F60", Offset = "0x1AF6160", Length = "0x8")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnRenderHintsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6001A2F")]
	internal void MarkRenderHintsClean() { }

	[Address(RVA = "0x1AF6F70", Offset = "0x1AF6170", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B16")]
	internal static float Max(float a, float b, float c, float d) { }

	[Address(RVA = "0x1AF6F80", Offset = "0x1AF6180", Length = "0x232")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutNode), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(AlignmentUtils), Member = "RoundToPixelGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AA1")]
	internal static void Measure(VisualElement ve, ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, out LayoutSize result) { }

	[Address(RVA = "0x1AF71C0", Offset = "0x1AF63C0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B15")]
	internal static float Min(float a, float b, float c, float d) { }

	[Address(RVA = "0x1AF71D0", Offset = "0x1AF63D0", Length = "0x22E")]
	[CalledBy(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRUtility), Member = "ComputeTransformMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 5)]
	[Token(Token = "0x6001B23")]
	internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res) { }

	[Address(RVA = "0x1AF7470", Offset = "0x1AF6670", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B1F")]
	internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point) { }

	[Address(RVA = "0x1AF7400", Offset = "0x1AF6600", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B20")]
	internal static Vector3 MultiplyMatrix44Point2ToPoint3(ref Matrix4x4 lhs, Vector2 point) { }

	[Address(RVA = "0x1AF74C0", Offset = "0x1AF66C0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B21")]
	internal static Vector2 MultiplyMatrix44Point3ToPoint2(ref Matrix4x4 lhs, Vector3 point) { }

	[Address(RVA = "0x1AF7520", Offset = "0x1AF6720", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B22")]
	internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A9A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal override void OnViewDataReady() { }

	[Address(RVA = "0x1AF7560", Offset = "0x1AF6760", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B1E")]
	internal static void OrderMinMaxBounds(ref Bounds bounds) { }

	[Address(RVA = "0x1AF75A0", Offset = "0x1AF67A0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B1D")]
	internal static void OrderMinMaxRect(ref Rect rect) { }

	[Address(RVA = "0x1AF75F0", Offset = "0x1AF67F0", Length = "0x36B")]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextField), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A98")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void OverwriteFromViewData(object obj, string key) { }

	[Address(RVA = "0x1AF7960", Offset = "0x1AF6B60", Length = "0x15E")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "PlaceBehind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001B03")]
	public void PlaceBehind(VisualElement sibling) { }

	[Address(RVA = "0x1AF7AC0", Offset = "0x1AF6CC0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "AnyPendingBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AC3")]
	private void ProcessBindingRequests() { }

	[Address(RVA = "0x1AF7B80", Offset = "0x1AF6D80", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001ACC")]
	private void PropagateCachedNextParentWithEventInterests(VisualElement nextParent, VisualElement stopParent) { }

	[Address(RVA = "0x1AF7C10", Offset = "0x1AF6E10", Length = "0xBE")]
	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_enabledSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabledFromHierarchyPrivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001A8A")]
	private void PropagateEnabledToChildren(bool value) { }

	[Address(RVA = "0x1AF7CD0", Offset = "0x1AF6ED0", Length = "0x8D0")]
	[CalledBy(Type = typeof(<>c__DisplayClass533_0), Member = "<UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(StyleValues))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleValues), Member = "set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_marginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_marginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_marginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_marginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_paddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_paddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_paddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001B5D0")]
	[Calls(Type = typeof(StyleValues), Member = "set_backgroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(StyleValues), Member = "set_borderBottomLeftRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderBottomRightRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderTopLeftRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderTopRightRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_opacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_unityBackgroundImageTintColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001ABA")]
	private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead) { }

	[Address(RVA = "0x1AF8640", Offset = "0x1AF7840", Length = "0x122")]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Register", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "System.Func`4<T, T, Single, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetAnimationSystem", ReturnType = typeof(VisualElementAnimationSystem))]
	[Calls(Type = typeof(VisualElementAnimationSystem), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001AB4")]
	internal void RegisterAnimation(IValueAnimationUpdate anim) { }

	[Address(RVA = "0x1AF8770", Offset = "0x1AF7970", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "GetAnimationSystem", ReturnType = typeof(VisualElementAnimationSystem))]
	[Calls(Type = typeof(VisualElementAnimationSystem), Member = "RegisterAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AB7")]
	private void RegisterRunningAnimations() { }

	[Address(RVA = "0x1AF89B0", Offset = "0x1AF7BB0", Length = "0x83")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "set_closeable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "RemoveDragHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "EnableTabDragHandles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "RemoveCloseButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "EnableTabCloseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(VisualElement), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AF6")]
	public void Remove(VisualElement element) { }

	[Address(RVA = "0x1B05370", Offset = "0x1B04570", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001AE8")]
	internal void remove_elementAdded(Action<VisualElement, Int32> value) { }

	[Address(RVA = "0x1B05430", Offset = "0x1B04630", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001AEA")]
	internal void remove_elementRemoved(Action<VisualElement> value) { }

	[Address(RVA = "0x1AF87E0", Offset = "0x1AF79E0", Length = "0x129")]
	[CallerCount(Count = 65)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectListPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AA8")]
	public void RemoveFromClassList(string className) { }

	[Address(RVA = "0x1AF8910", Offset = "0x1AF7B10", Length = "0x6A")]
	[CallerCount(Count = 73)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B04")]
	public void RemoveFromHierarchy() { }

	[Address(RVA = "0x1AF8980", Offset = "0x1AF7B80", Length = "0x30")]
	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutNode), Member = "set_UsesMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A9F")]
	private void RemoveMeasureFunction() { }

	[Address(RVA = "0x1AF8A40", Offset = "0x1AF7C40", Length = "0x15A")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxHeight", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxWidth", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minHeight", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minWidth", ReturnType = typeof(StyleFloat))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001B2E")]
	internal StyleFloat ResolveLengthValue(Length length, bool isRow) { }

	[Address(RVA = "0x1AF8BA0", Offset = "0x1AF7DA0", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(Rotate), Member = "Initial", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(Rotate), Member = "ToQuaternion", ReturnType = typeof(Quaternion))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B31")]
	private Quaternion ResolveRotation() { }

	[Address(RVA = "0x1AF8C80", Offset = "0x1AF7E80", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_scale", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B32")]
	private Vector3 ResolveScale() { }

	[Address(RVA = "0x1AF8D70", Offset = "0x1AF7F70", Length = "0x225")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transformOrigin", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transformOrigin", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B30")]
	internal Vector3 ResolveTransformOrigin() { }

	[Address(RVA = "0x1AF8FA0", Offset = "0x1AF81A0", Length = "0x1B1")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+WordSpacingProperty", Member = "get_ussName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_translate", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_positionWithLayout", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBoundsToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRectToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_translate", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B2F")]
	internal Vector3 ResolveTranslate() { }

	[Address(RVA = "0x1AF9160", Offset = "0x1AF8360", Length = "0x97")]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001B0E")]
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	[Address(RVA = "0x1AF9200", Offset = "0x1AF8400", Length = "0x8D")]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001A99")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SaveViewData() { }

	[Address(RVA = "0x1AF9290", Offset = "0x1AF8490", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A80")]
	public virtual void SendEvent(EventBase e) { }

	[Address(RVA = "0x1AF92B0", Offset = "0x1AF84B0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A81")]
	internal virtual void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	[Address(RVA = "0x1AF92D0", Offset = "0x1AF84D0", Length = "0x6A")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "SendToBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B02")]
	public void SendToBack() { }

	[Address(RVA = "0x1B054F0", Offset = "0x1B046F0", Length = "0x84")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A1C")]
	internal void set_areAncestorsAndSelfDisplayed(bool value) { }

	[Address(RVA = "0x1B05580", Offset = "0x1B04780", Length = "0x2D")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A62")]
	internal void set_boundingBoxDirtiedSinceLastLayoutPass(bool value) { }

	[Address(RVA = "0x189D920", Offset = "0x189CB20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A66")]
	internal void set_containedPointerIds(int value) { }

	[Address(RVA = "0x1B05860", Offset = "0x1B04A60", Length = "0xE0")]
	[CalledBy(Type = typeof(BaseListViewController), Member = "SetBindingContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001ABE")]
	public void set_dataSource(object value) { }

	[Address(RVA = "0x1B055B0", Offset = "0x1B047B0", Length = "0x2A0")]
	[CalledBy(Type = typeof(BaseListViewController), Member = "SetBindingContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PathRef), Member = "get_path", ReturnType = typeof(PropertyPath&))]
	[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AC0")]
	public void set_dataSourcePath(PropertyPath value) { }

	[Address(RVA = "0x1B05940", Offset = "0x1B04B40", Length = "0x2D")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AE3")]
	internal void set_disableClipping(bool value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A29")]
	public void set_disablePlayModeTint(bool value) { }

	[Address(RVA = "0x1B05970", Offset = "0x1B04B70", Length = "0x56")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AE6")]
	internal void set_disableRendering(bool value) { }

	[Address(RVA = "0x1B059D0", Offset = "0x1B04BD0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6001AED")]
	private void set_elementPanel(BaseVisualElementPanel value) { }

	[Address(RVA = "0x1B059F0", Offset = "0x1B04BF0", Length = "0x8E")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A88")]
	public void set_enabledSelf(bool value) { }

	[Address(RVA = "0x1B05A80", Offset = "0x1B04C80", Length = "0xAA")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "DirtyParentHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyBoundingBoxHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "DirtyBoundingBoxHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyParentHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyChildrenHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A20")]
	internal void set_flags(VisualElementFlags value) { }

	[Address(RVA = "0x1B05B30", Offset = "0x1B04D30", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6001A93")]
	public void set_generateVisualContent(Action<MeshGenerationContext> value) { }

	[Address(RVA = "0x1B05B50", Offset = "0x1B04D50", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A1E")]
	internal void set_hasOneOrMorePointerCaptures(bool value) { }

	[Address(RVA = "0x1B05B80", Offset = "0x1B04D80", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A41")]
	internal void set_isBoundingBoxDirty(bool value) { }

	[Address(RVA = "0x1B05BB0", Offset = "0x1B04DB0", Length = "0x2D")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A1A")]
	internal void set_isCompositeRoot(bool value) { }

	[Address(RVA = "0x1B05BE0", Offset = "0x1B04DE0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AD0")]
	internal void set_isEventInterestParentCategoriesDirty(bool value) { }

	[Address(RVA = "0x1B05C10", Offset = "0x1B04E10", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A32")]
	private void set_isLayoutManual(bool value) { }

	[Address(RVA = "0x1B05C40", Offset = "0x1B04E40", Length = "0x2D")]
	[CalledBy(Type = typeof(WorldSpaceDataStore), Member = "ClearWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A3D")]
	internal void set_isLocalBounds3DDirty(bool value) { }

	[Address(RVA = "0x1B05C70", Offset = "0x1B04E70", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A3F")]
	internal void set_isLocalBoundsWithoutNested3DDirty(bool value) { }

	[Address(RVA = "0x405170", Offset = "0x404370", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AE1")]
	internal void set_isRootVisualContainer(bool value) { }

	[Address(RVA = "0x1B05CA0", Offset = "0x1B04EA0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A42")]
	internal void set_isWorldBoundingBoxDirty(bool value) { }

	[Address(RVA = "0x1B05CD0", Offset = "0x1B04ED0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A52")]
	internal void set_isWorldSpaceRootUIDocument(bool value) { }

	[Address(RVA = "0x1B05D00", Offset = "0x1B04F00", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A54")]
	internal void set_isWorldTransformDirty(bool value) { }

	[Address(RVA = "0x1B05D30", Offset = "0x1B04F30", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A55")]
	internal void set_isWorldTransformInverseDirty(bool value) { }

	[Address(RVA = "0x1B05D60", Offset = "0x1B04F60", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A8C")]
	public void set_languageDirection(LanguageDirection value) { }

	[Address(RVA = "0x1B05DF0", Offset = "0x1B04FF0", Length = "0x854")]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A36")]
	internal void set_layout(Rect value) { }

	[Address(RVA = "0x1B06650", Offset = "0x1B05850", Length = "0x103")]
	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_languageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A8E")]
	internal void set_localLanguageDirection(LanguageDirection value) { }

	[Address(RVA = "0x1B06760", Offset = "0x1B05960", Length = "0xBA")]
	[CallerCount(Count = 70)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A6E")]
	public void set_name(string value) { }

	[Address(RVA = "0x1B06820", Offset = "0x1B05A20", Length = "0x2D")]
	[CalledBy(Type = typeof(WorldSpaceDataStore), Member = "ClearWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A3B")]
	internal void set_needs3DBounds(bool value) { }

	[Address(RVA = "0x1B06850", Offset = "0x1B05A50", Length = "0xA4")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A6C")]
	public void set_pickingMode(PickingMode value) { }

	[Address(RVA = "0x1B06900", Offset = "0x1B05B00", Length = "0x71")]
	[CallerCount(Count = 48)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A64")]
	internal void set_pseudoStates(PseudoStates value) { }

	[Address(RVA = "0x1B06980", Offset = "0x1B05B80", Length = "0x2D")]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A60")]
	internal void set_receivesHierarchyGeometryChangedEvents(bool value) { }

	[Address(RVA = "0x1B069B0", Offset = "0x1B05BB0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A2E")]
	internal void set_renderHints(RenderHints value) { }

	[Address(RVA = "0x1B06A20", Offset = "0x1B05C20", Length = "0xA0")]
	[CalledBy(Type = typeof(Image), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "get_UsesMeasure", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_UsesMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A9D")]
	internal void set_requireMeasureFunction(bool value) { }

	[Address(RVA = "0x1B06AD0", Offset = "0x1B05CD0", Length = "0x2D")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A76")]
	internal void set_styleInitialized(bool value) { }

	[Address(RVA = "0x1B06B00", Offset = "0x1B05D00", Length = "0x22F")]
	[CalledBy(Type = typeof(MultiColumnListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableListViewItem), Member = "SetDragHandleEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UpdateTooltip", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(VisualElement), Member = "SetPropertyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B34")]
	public void set_tooltip(string value) { }

	[Address(RVA = "0x1B06D30", Offset = "0x1B05F30", Length = "0x218")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(StyleValue), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001A2C")]
	public void set_usageHints(UsageHints value) { }

	[Address(RVA = "0x1B06F50", Offset = "0x1B06150", Length = "0x145")]
	[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "InitExpandHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(MenuItem))]
	[CalledBy(Type = typeof(Tab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Background)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_userData", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "SetPropertyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A25")]
	public void set_userData(object value) { }

	[Address(RVA = "0x1B070A0", Offset = "0x1B062A0", Length = "0xC8")]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "PrepareView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scroller), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(System.Action`1<System.Single>), typeof(SliderDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A22")]
	public void set_viewDataKey(string value) { }

	[Address(RVA = "0x1B07170", Offset = "0x1B06370", Length = "0x1F8")]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "SetToggleVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseCompositeField`3), Member = "GetSpacer", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A90")]
	public void set_visible(bool value) { }

	[Address(RVA = "0x1B07370", Offset = "0x1B06570", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001AF1")]
	internal void set_visualTreeAssetSource(VisualTreeAsset value) { }

	[Address(RVA = "0x1AF9340", Offset = "0x1AF8540", Length = "0xCE")]
	[CalledBy(Type = typeof(PanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001AC9")]
	internal void SetAsNextParentWithEventInterests() { }

	[Address(RVA = "0x1AF9410", Offset = "0x1AF8610", Length = "0x253")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[Calls(Type = typeof(ComputedStyle), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_cursor", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001AA4")]
	internal void SetComputedStyle(ref ComputedStyle newStyle) { }

	[Address(RVA = "0x1AF9A10", Offset = "0x1AF8C10", Length = "0x8")]
	[CalledBy(Type = typeof(MultiColumnListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableListViewItem), Member = "SetDragHandleEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "UpdateArraySizeField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_allowAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_allowRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(MenuItem))]
	[CalledBy(Type = typeof(Scroller), Member = "Adjust", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(VisualElement), Member = "set_enabledSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A89")]
	public void SetEnabled(bool value) { }

	[Address(RVA = "0x1AF9670", Offset = "0x1AF8870", Length = "0x391")]
	[CalledBy(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "BlurImmediately", ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcherGate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(FocusController), Member = "IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_isParentEnabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A84")]
	private bool SetEnabledFromHierarchyPrivate(bool state) { }

	[Address(RVA = "0x1AF9A20", Offset = "0x1AF8C20", Length = "0xA9")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneSetupRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementAsset>>), typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InlineStyleAccess), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetInlineRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AA3")]
	internal void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	[Address(RVA = "0x1AF9AD0", Offset = "0x1AF8CD0", Length = "0x9EE")]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementListPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ClickDetector), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcherGate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GatherAllChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(VisualElementListPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A7D")]
	internal void SetPanel(BaseVisualElementPanel p) { }

	[Address(RVA = "0x1AFA580", Offset = "0x1AF9780", Length = "0x70")]
	[CalledBy(Type = typeof(DataBindingManager), Member = "CreateBindingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "set_isContentBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateHeaderTemplate", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetPropertyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AAC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SetProperty(PropertyName key, object value) { }

	[Address(RVA = "0x1AFA4C0", Offset = "0x1AF96C0", Length = "0xB8")]
	[CalledBy(Type = typeof(VisualElement), Member = "set_userData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AB0")]
	private void SetPropertyInternal(PropertyName key, object value) { }

	[Address(RVA = "0x1AFA5F0", Offset = "0x1AF97F0", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_tooltip", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EventBase), Member = "StopImmediatePropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A7B")]
	internal void SetTooltip(TooltipEvent e) { }

	[Address(RVA = "0x1AFA6E0", Offset = "0x1AF98E0", Length = "0x32")]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "PerformPick3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "PerformPick2D_LocalPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(RenderData), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DetermineSelfClipMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(ClipMethod))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Token(Token = "0x6001AE4")]
	internal bool ShouldClip() { }

	[Address(RVA = "0x1AFA720", Offset = "0x1AF9920", Length = "0x158")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`4<UnityEngine.UIElements.Experimental.StyleValues, UnityEngine.UIElements.Experimental.StyleValues, System.Single, UnityEngine.UIElements.Experimental.StyleValues>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "System.Func`4<T, T, Single, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "StartAnimation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Experimental.ValueAnimation`1<T>", "System.Func`2<VisualElement, T>", "T", typeof(int), "System.Action`2<VisualElement, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001ABC")]
	private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs) { }

	[Address(RVA = "0x7D21B0", Offset = "0x7D13B0", Length = "0xB6")]
	[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValues), typeof(int)}, ReturnType = typeof(UnityEngine.UIElements.Experimental.ValueAnimation`1<UnityEngine.UIElements.Experimental.StyleValues>))]
	[CalledBy(Type = typeof(VisualElement), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues>), typeof(StyleValues), typeof(int)}, ReturnType = typeof(UnityEngine.UIElements.Experimental.ValueAnimation`1<UnityEngine.UIElements.Experimental.StyleValues>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ValueAnimation`1), Member = "set_durationMs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AB8")]
	private static ValueAnimation<T> StartAnimation(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged) { }

	[Address(RVA = "0x1AFA880", Offset = "0x1AF9A80", Length = "0x1BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Rect), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AA5")]
	public virtual string ToString() { }

	[Address(RVA = "0x1AFAA40", Offset = "0x1AF9C40", Length = "0x8F")]
	[CalledBy(Type = typeof(VisualElement), Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_dataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "DetachDataSource", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "AttachDataSource", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataBindingManager), Member = "TrackDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AC5")]
	private void TrackSource(object previous, object current) { }

	[Address(RVA = "0x1AFAC50", Offset = "0x1AF9E50", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[Token(Token = "0x6001B1C")]
	internal static void TransformAlignedBounds(ref Matrix4x4 matrix, ref Bounds bounds) { }

	[Address(RVA = "0x1AFAAD0", Offset = "0x1AF9CD0", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Token(Token = "0x6001B17")]
	internal void TransformAlignedBoundsToParentSpace(ref Bounds bounds) { }

	[Address(RVA = "0x1AFAE30", Offset = "0x1AFA030", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Token(Token = "0x6001B1B")]
	internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect) { }

	[Address(RVA = "0x1AFACF0", Offset = "0x1AF9EF0", Length = "0x13A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Token(Token = "0x6001B18")]
	private void TransformAlignedRectToParentSpace(ref Rect rect) { }

	[Address(RVA = "0x1AFAF40", Offset = "0x1AFA140", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001B24")]
	private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res) { }

	[Address(RVA = "0x1AFAEB0", Offset = "0x1AFA0B0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B25")]
	private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs) { }

	[Address(RVA = "0x1AFB050", Offset = "0x1AFA250", Length = "0xE6")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "ConvertUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BackgroundSize), Member = "get_x", ReturnType = typeof(Length))]
	[Calls(Type = typeof(BackgroundSize), Member = "get_y", ReturnType = typeof(Length))]
	[Calls(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "set_x", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BackgroundSize), Member = "set_y", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A17")]
	internal bool TryConvertBackgroundSizeUnits(ref BackgroundSize from, ref BackgroundSize to) { }

	[Address(RVA = "0x1AFB140", Offset = "0x1AFA340", Length = "0x245")]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertTransformOriginUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin&), typeof(TransformOrigin&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertTranslateUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate&), typeof(Translate&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "ConvertUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length&), typeof(Length&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = "get_Value", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetParentSizeForLengthConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A14")]
	internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0) { }

	[Address(RVA = "0x1AFB390", Offset = "0x1AFA590", Length = "0xAD")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "ConvertUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TransformOrigin&), typeof(TransformOrigin&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001A15")]
	internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to) { }

	[Address(RVA = "0x1AFB440", Offset = "0x1AFA640", Length = "0xAD")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "ConvertUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Translate&), typeof(Translate&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001A16")]
	internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to) { }

	[Address(RVA = "0x1AFB4F0", Offset = "0x1AFA6F0", Length = "0xAB")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "OnPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyChangedEvent), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DataBindingUtility), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingInfo&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001AC2")]
	public bool TryGetBinding(BindingId bindingId, out Binding binding) { }

	[Address(RVA = "0x1AFB5D0", Offset = "0x1AFA7D0", Length = "0x209")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleValues), Member = "Values", ReturnType = typeof(StyleValueCollection))]
	[Calls(Type = typeof(System.Func`4<UnityEngine.UIElements.Experimental.StyleValues, UnityEngine.UIElements.Experimental.StyleValues, System.Single, UnityEngine.UIElements.Experimental.StyleValues>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "System.Func`4<T, T, Single, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "StartAnimation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Experimental.ValueAnimation`1<T>", "System.Func`2<VisualElement, T>", "T", typeof(int), "System.Action`2<VisualElement, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001ABB")]
	private override ValueAnimation<StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(StyleValues to, int durationMs) { }

	[Address(RVA = "0x151EF90", Offset = "0x151E190", Length = "0x6")]
	[CallerCount(Count = 142)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ADE")]
	private override ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation() { }

	[Address(RVA = "0x1AFB7E0", Offset = "0x1AFA9E0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019A8")]
	private override Align UnityEngine.UIElements.IResolvedStyle.get_alignContent() { }

	[Address(RVA = "0x1AFB830", Offset = "0x1AFAA30", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019A9")]
	private override Align UnityEngine.UIElements.IResolvedStyle.get_alignItems() { }

	[Address(RVA = "0x1AFB890", Offset = "0x1AFAA90", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019AA")]
	private override Align UnityEngine.UIElements.IResolvedStyle.get_alignSelf() { }

	[Address(RVA = "0x1AFB8F0", Offset = "0x1AFAAF0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019AB")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor() { }

	[Address(RVA = "0x1AFB9D0", Offset = "0x1AFABD0", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019AC")]
	private override Background UnityEngine.UIElements.IResolvedStyle.get_backgroundImage() { }

	[Address(RVA = "0x1AFBAB0", Offset = "0x1AFACB0", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019AD")]
	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.get_backgroundPositionX() { }

	[Address(RVA = "0x1AFBB90", Offset = "0x1AFAD90", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019AE")]
	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.get_backgroundPositionY() { }

	[Address(RVA = "0x1AFBC70", Offset = "0x1AFAE70", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60019AF")]
	private override BackgroundRepeat UnityEngine.UIElements.IResolvedStyle.get_backgroundRepeat() { }

	[Address(RVA = "0x1AFBD40", Offset = "0x1AFAF40", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019B0")]
	private override BackgroundSize UnityEngine.UIElements.IResolvedStyle.get_backgroundSize() { }

	[Address(RVA = "0x1AFBE20", Offset = "0x1AFB020", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019B1")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor() { }

	[Address(RVA = "0x1AFBF00", Offset = "0x1AFB100", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019B2")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius() { }

	[Address(RVA = "0x1AFBF60", Offset = "0x1AFB160", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019B3")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius() { }

	[Address(RVA = "0x1AFBFC0", Offset = "0x1AFB1C0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019B4")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth() { }

	[Address(RVA = "0x1AFC020", Offset = "0x1AFB220", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019B5")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor() { }

	[Address(RVA = "0x1AFC100", Offset = "0x1AFB300", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019B6")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth() { }

	[Address(RVA = "0x1AFC160", Offset = "0x1AFB360", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019B7")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor() { }

	[Address(RVA = "0x1AFC240", Offset = "0x1AFB440", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019B8")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth() { }

	[Address(RVA = "0x1AFC2A0", Offset = "0x1AFB4A0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019B9")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor() { }

	[Address(RVA = "0x1AFC380", Offset = "0x1AFB580", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019BA")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius() { }

	[Address(RVA = "0x1AFC3E0", Offset = "0x1AFB5E0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019BB")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius() { }

	[Address(RVA = "0x1AFC440", Offset = "0x1AFB640", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019BC")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth() { }

	[Address(RVA = "0x1AFC4A0", Offset = "0x1AFB6A0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019BD")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_bottom() { }

	[Address(RVA = "0x1AFC500", Offset = "0x1AFB700", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019BE")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_color() { }

	[Address(RVA = "0x1AFC5E0", Offset = "0x1AFB7E0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019BF")]
	private override DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	[Address(RVA = "0x1AFC640", Offset = "0x1AFB840", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019C0")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_flexBasis() { }

	[Address(RVA = "0x1AFC6A0", Offset = "0x1AFB8A0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019C1")]
	private override FlexDirection UnityEngine.UIElements.IResolvedStyle.get_flexDirection() { }

	[Address(RVA = "0x1AFC700", Offset = "0x1AFB900", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019C2")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_flexGrow() { }

	[Address(RVA = "0x1AFC760", Offset = "0x1AFB960", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019C3")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_flexShrink() { }

	[Address(RVA = "0x1AFC7C0", Offset = "0x1AFB9C0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019C4")]
	private override Wrap UnityEngine.UIElements.IResolvedStyle.get_flexWrap() { }

	[Address(RVA = "0x1AFC820", Offset = "0x1AFBA20", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019C5")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_fontSize() { }

	[Address(RVA = "0x1AFC880", Offset = "0x1AFBA80", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019C6")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_height() { }

	[Address(RVA = "0x1AFC8E0", Offset = "0x1AFBAE0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019C7")]
	private override Justify UnityEngine.UIElements.IResolvedStyle.get_justifyContent() { }

	[Address(RVA = "0x1AFC940", Offset = "0x1AFBB40", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019C8")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_left() { }

	[Address(RVA = "0x1AFC9A0", Offset = "0x1AFBBA0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019C9")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_letterSpacing() { }

	[Address(RVA = "0x1AFCA00", Offset = "0x1AFBC00", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019CA")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginBottom() { }

	[Address(RVA = "0x1AFCA60", Offset = "0x1AFBC60", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019CB")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginLeft() { }

	[Address(RVA = "0x1AFCAC0", Offset = "0x1AFBCC0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019CC")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginRight() { }

	[Address(RVA = "0x1AFCB20", Offset = "0x1AFBD20", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019CD")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginTop() { }

	[Address(RVA = "0x1AFCB80", Offset = "0x1AFBD80", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019CE")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_maxHeight() { }

	[Address(RVA = "0x1AFCBE0", Offset = "0x1AFBDE0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019CF")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_maxWidth() { }

	[Address(RVA = "0x1AFCC40", Offset = "0x1AFBE40", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019D0")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight() { }

	[Address(RVA = "0x1AFCCA0", Offset = "0x1AFBEA0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019D1")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth() { }

	[Address(RVA = "0x1AFCD00", Offset = "0x1AFBF00", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019D2")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_opacity() { }

	[Address(RVA = "0x1AFCD60", Offset = "0x1AFBF60", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019D3")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingBottom() { }

	[Address(RVA = "0x1AFCDC0", Offset = "0x1AFBFC0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019D4")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingLeft() { }

	[Address(RVA = "0x1AFCE20", Offset = "0x1AFC020", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019D5")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingRight() { }

	[Address(RVA = "0x1AFCE80", Offset = "0x1AFC080", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019D6")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingTop() { }

	[Address(RVA = "0x1AFCEE0", Offset = "0x1AFC0E0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019D7")]
	private override Position UnityEngine.UIElements.IResolvedStyle.get_position() { }

	[Address(RVA = "0x1AFCF40", Offset = "0x1AFC140", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019D8")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_right() { }

	[Address(RVA = "0x1AFCFA0", Offset = "0x1AFC1A0", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019D9")]
	private override Rotate UnityEngine.UIElements.IResolvedStyle.get_rotate() { }

	[Address(RVA = "0x1AFD080", Offset = "0x1AFC280", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019DA")]
	private override Scale UnityEngine.UIElements.IResolvedStyle.get_scale() { }

	[Address(RVA = "0x1AFD160", Offset = "0x1AFC360", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019DB")]
	private override TextOverflow UnityEngine.UIElements.IResolvedStyle.get_textOverflow() { }

	[Address(RVA = "0x1AFD1C0", Offset = "0x1AFC3C0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019DC")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_top() { }

	[Address(RVA = "0x1AFD220", Offset = "0x1AFC420", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019DD")]
	private override Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin() { }

	[Address(RVA = "0x1AFD300", Offset = "0x1AFC500", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019DE")]
	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.get_transitionDelay() { }

	[Address(RVA = "0x1AFD360", Offset = "0x1AFC560", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019DF")]
	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.get_transitionDuration() { }

	[Address(RVA = "0x1AFD3C0", Offset = "0x1AFC5C0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019E0")]
	private override IEnumerable<StylePropertyName> UnityEngine.UIElements.IResolvedStyle.get_transitionProperty() { }

	[Address(RVA = "0x1AFD420", Offset = "0x1AFC620", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019E1")]
	private override IEnumerable<EasingFunction> UnityEngine.UIElements.IResolvedStyle.get_transitionTimingFunction() { }

	[Address(RVA = "0x1AFD480", Offset = "0x1AFC680", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019E2")]
	private override Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate() { }

	[Address(RVA = "0x1AFD560", Offset = "0x1AFC760", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019E3")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor() { }

	[Address(RVA = "0x1AFD640", Offset = "0x1AFC840", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019E4")]
	private override EditorTextRenderingMode UnityEngine.UIElements.IResolvedStyle.get_unityEditorTextRenderingMode() { }

	[Address(RVA = "0x1AFD7E0", Offset = "0x1AFC9E0", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60019E5")]
	private override Font UnityEngine.UIElements.IResolvedStyle.get_unityFont() { }

	[Address(RVA = "0x1AFD6A0", Offset = "0x1AFC8A0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019E6")]
	private override FontDefinition UnityEngine.UIElements.IResolvedStyle.get_unityFontDefinition() { }

	[Address(RVA = "0x1AFD780", Offset = "0x1AFC980", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019E7")]
	private override FontStyle UnityEngine.UIElements.IResolvedStyle.get_unityFontStyleAndWeight() { }

	[Address(RVA = "0x1AFD8B0", Offset = "0x1AFCAB0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019E8")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_unityParagraphSpacing() { }

	[Address(RVA = "0x1AFD910", Offset = "0x1AFCB10", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019E9")]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceBottom() { }

	[Address(RVA = "0x1AFD970", Offset = "0x1AFCB70", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019EA")]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft() { }

	[Address(RVA = "0x1AFD9D0", Offset = "0x1AFCBD0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019EB")]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight() { }

	[Address(RVA = "0x1AFDA30", Offset = "0x1AFCC30", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019EC")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale() { }

	[Address(RVA = "0x1AFDA90", Offset = "0x1AFCC90", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019ED")]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceTop() { }

	[Address(RVA = "0x1AFDAF0", Offset = "0x1AFCCF0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019EE")]
	private override SliceType UnityEngine.UIElements.IResolvedStyle.get_unitySliceType() { }

	[Address(RVA = "0x1AFDB50", Offset = "0x1AFCD50", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019EF")]
	private override TextAnchor UnityEngine.UIElements.IResolvedStyle.get_unityTextAlign() { }

	[Address(RVA = "0x1AFDBB0", Offset = "0x1AFCDB0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019F0")]
	private override TextGeneratorType UnityEngine.UIElements.IResolvedStyle.get_unityTextGenerator() { }

	[Address(RVA = "0x1AFDC10", Offset = "0x1AFCE10", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019F1")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor() { }

	[Address(RVA = "0x1AFDCF0", Offset = "0x1AFCEF0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019F2")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth() { }

	[Address(RVA = "0x1AFDD50", Offset = "0x1AFCF50", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019F3")]
	private override TextOverflowPosition UnityEngine.UIElements.IResolvedStyle.get_unityTextOverflowPosition() { }

	[Address(RVA = "0x1AFDDB0", Offset = "0x1AFCFB0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019F4")]
	private override Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	[Address(RVA = "0x1AFDE10", Offset = "0x1AFD010", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019F5")]
	private override WhiteSpace UnityEngine.UIElements.IResolvedStyle.get_whiteSpace() { }

	[Address(RVA = "0x1AFDE70", Offset = "0x1AFD070", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019F6")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_width() { }

	[Address(RVA = "0x1AFDED0", Offset = "0x1AFD0D0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019F7")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_wordSpacing() { }

	[Address(RVA = "0x1AFDF30", Offset = "0x1AFD130", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A11")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations() { }

	[Address(RVA = "0x1AFE090", Offset = "0x1AFD290", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A10")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(StylePropertyId id) { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60019FC")]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60019FA")]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount() { }

	[Address(RVA = "0x1AFE110", Offset = "0x1AFD310", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A13")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(List<StylePropertyId> outPropertyIds) { }

	[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60019FD")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(int value) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60019FB")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(int value) { }

	[Address(RVA = "0x1AFE8C0", Offset = "0x1AFDAC0", Length = "0x186")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A0B")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFEE90", Offset = "0x1AFE090", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801D2840")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A01")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFE480", Offset = "0x1AFD680", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A02")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFF090", Offset = "0x1AFE290", Length = "0x16A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A03")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFF6A0", Offset = "0x1AFE8A0", Length = "0x182")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A05")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFF390", Offset = "0x1AFE590", Length = "0x16A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A06")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFE340", Offset = "0x1AFD540", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A07")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFF500", Offset = "0x1AFE700", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A08")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFEBA0", Offset = "0x1AFDDA0", Length = "0x16A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A09")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFF200", Offset = "0x1AFE400", Length = "0x186")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A0A")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFED10", Offset = "0x1AFDF10", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A0C")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFE740", Offset = "0x1AFD940", Length = "0x17C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A0D")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFEF50", Offset = "0x1AFE150", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A0E")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFE5C0", Offset = "0x1AFD7C0", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A0F")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFEA50", Offset = "0x1AFDC50", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A00")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFE280", Offset = "0x1AFD480", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801D2840")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A04")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1AFF830", Offset = "0x1AFEA30", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A12")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(StylePropertyId id) { }

	[Address(RVA = "0x1AFF8B0", Offset = "0x1AFEAB0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TimerStateScheduledItem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Action`1<UnityEngine.UIElements.TimerState>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "Resume", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B27")]
	private override IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action<TimerState> timerUpdateEvent) { }

	[Address(RVA = "0x1AFF970", Offset = "0x1AFEB70", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SimpleScheduledItem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "Resume", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B28")]
	private override IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action updateEvent) { }

	[Address(RVA = "0x1AFFA30", Offset = "0x1AFEC30", Length = "0x74")]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Unregister", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "System.Func`4<T, T, Single, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetAnimationSystem", ReturnType = typeof(VisualElementAnimationSystem))]
	[Calls(Type = typeof(VisualElementAnimationSystem), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AB5")]
	internal void UnregisterAnimation(IValueAnimationUpdate anim) { }

	[Address(RVA = "0x1AFFAB0", Offset = "0x1AFECB0", Length = "0x82")]
	[CalledBy(Type = typeof(VisualElement), Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "GetAnimationSystem", ReturnType = typeof(VisualElementAnimationSystem))]
	[Calls(Type = typeof(VisualElementAnimationSystem), Member = "UnregisterAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x6001AB6")]
	private void UnregisterRunningAnimations() { }

	[Address(RVA = "0x1AFFB40", Offset = "0x1AFED40", Length = "0x571")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_boundingBoxWithoutNested", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldBoundingBox", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldBoundingBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AEF0B0")]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "SetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(WorldSpaceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A48")]
	internal void UpdateBoundingBox() { }

	[Address(RVA = "0x1B000C0", Offset = "0x1AFF2C0", Length = "0x6B8")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_localBounds3D", ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_localBoundsPicking3D", ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_localBounds3DWithoutNested3D", ReturnType = typeof(Bounds))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
	[Calls(Type = typeof(VisualElement), Member = "get_localBoundsPicking3D", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(VisualElement), Member = "get_localBounds3D", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AEEF30")]
	[Calls(Type = typeof(VisualElement), Member = "get_localBounds3DWithoutNested3D", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "SetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(WorldSpaceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "ClearLocalBounds3DData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A4D")]
	private void UpdateBounds3D() { }

	[Address(RVA = "0x1B00780", Offset = "0x1AFF980", Length = "0x320")]
	[CalledBy(Type = typeof(MouseCaptureOutEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseOverEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseOutEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "GetCapturingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(IEventHandler))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_cursor", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801D0F70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001AB1")]
	internal void UpdateCursorStyle(long eventType) { }

	[Address(RVA = "0x1B00AB0", Offset = "0x1AFFCB0", Length = "0x267")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_eventInterestParentCategories", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_eventInterestParentCategories", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AD2")]
	private void UpdateEventInterestParentCategories() { }

	[Address(RVA = "0x1B00D20", Offset = "0x1AFFF20", Length = "0x159")]
	[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "AddEventCallbackCategories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AD1")]
	private void UpdateEventInterestSelfCategories() { }

	[Address(RVA = "0x1B00F00", Offset = "0x1B00100", Length = "0x104")]
	[CalledBy(Type = typeof(PointerEnterEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerLeaveEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateHoverPseudoStateAfterCaptureChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "GetCapturingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(IEventHandler))]
	[Calls(Type = typeof(VisualElement), Member = "IsPartOfCapturedChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IEventHandler&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A67")]
	internal void UpdateHoverPseudoState() { }

	[Address(RVA = "0x1B00E80", Offset = "0x1B00080", Length = "0x80")]
	[CalledBy(Type = typeof(PointerCaptureOutEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerCaptureEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateHoverPseudoState", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Token(Token = "0x6001A69")]
	internal void UpdateHoverPseudoStateAfterCaptureChange(int pointerId) { }

	[Address(RVA = "0x1B01010", Offset = "0x1B00210", Length = "0xB2")]
	[CalledBy(Type = typeof(PointerDispatchState), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerDispatchState), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "HasPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A6A")]
	internal void UpdatePointerCaptureFlag() { }

	[Address(RVA = "0x1B010D0", Offset = "0x1B002D0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AEF1F0")]
	[Token(Token = "0x6001A49")]
	internal void UpdateWorldBoundingBox() { }

	[Address(RVA = "0x1B011D0", Offset = "0x1B003D0", Length = "0x315")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldBoundingBox", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldBoundingBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldTransformRef", ReturnType = typeof(Matrix4x4&))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldTransformInverse", ReturnType = typeof(Matrix4x4&))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransformInverse", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "EnsureWorldTransformAndClipUpToDate", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(VisualElement), Member = "MultiplyMatrix34", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformRef", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
	[Token(Token = "0x6001A5A")]
	internal void UpdateWorldTransform() { }

	[Address(RVA = "0x1B01160", Offset = "0x1B00360", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "Inverse3DAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001A5B")]
	internal void UpdateWorldTransformInverse() { }

	[Address(RVA = "0x1B014F0", Offset = "0x1B006F0", Length = "0x2D6")]
	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "RemoveElementFromPointerCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PanelChangedEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(IPanel)}, ReturnType = "T")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ProcessPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "HasPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "CommitElementUnderPointers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(DataBindingManager), Member = "TransferBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "UnregisterRunningAnimations", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A7E")]
	private void WillChangePanel(BaseVisualElementPanel destinationPanel) { }

}

