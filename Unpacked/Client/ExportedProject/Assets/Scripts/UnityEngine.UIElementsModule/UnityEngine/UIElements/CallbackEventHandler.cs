namespace UnityEngine.UIElements;

[Token(Token = "0x20001CD")]
public abstract class CallbackEventHandler : IEventHandler
{
	[Token(Token = "0x4000826")]
	internal const string HandleEventBubbleUpName = "HandleEventBubbleUp"; //Field offset: 0x0
	[Token(Token = "0x4000827")]
	internal const string HandleEventTrickleDownName = "HandleEventTrickleDown"; //Field offset: 0x0
	[Token(Token = "0x4000828")]
	internal const string ExecuteDefaultActionName = "ExecuteDefaultAction"; //Field offset: 0x0
	[Token(Token = "0x4000829")]
	internal const string ExecuteDefaultActionAtTargetName = "ExecuteDefaultActionAtTarget"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000824")]
	internal bool isIMGUIContainer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000825")]
	internal EventCallbackRegistry m_CallbackRegistry; //Field offset: 0x18

	[Address(RVA = "0x1C49280", Offset = "0x1C48480", Length = "0xB")]
	[CalledBy(Type = typeof(Focusable), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D24")]
	protected CallbackEventHandler() { }

	[Address(RVA = "0x6856B0", Offset = "0x6848B0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddEventCallbackCategories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D0E")]
	private void AddEventCategories(TrickleDown useTrickleDown) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUp. Before proceeding, make sure you understand the latest changes to UIToolkit event propagation rules by visiting Unity's manual page https://docs.unity3d.com/Manual/UIE-Events-Dispatching.html")]
	[Token(Token = "0x6000D1C")]
	protected override void ExecuteDefaultAction(EventBase evt) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUp. Before proceeding, make sure you understand the latest changes to UIToolkit event propagation rules by visiting Unity's manual page https://docs.unity3d.com/Manual/UIE-Events-Dispatching.html")]
	[Token(Token = "0x6000D15")]
	protected override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	[Address(RVA = "0x1136070", Offset = "0x1135270", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D21")]
	internal void ExecuteDefaultActionAtTargetInternal(EventBase evt) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUpDisabled.")]
	[Token(Token = "0x6000D1E")]
	internal override void ExecuteDefaultActionDisabled(EventBase evt) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUpDisabled.")]
	[Token(Token = "0x6000D1D")]
	internal override void ExecuteDefaultActionDisabledAtTarget(EventBase evt) { }

	[Address(RVA = "0x1C49050", Offset = "0x1C48250", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D22")]
	internal void ExecuteDefaultActionDisabledAtTargetInternal(EventBase evt) { }

	[Address(RVA = "0x1C49070", Offset = "0x1C48270", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D20")]
	internal void ExecuteDefaultActionDisabledInternal(EventBase evt) { }

	[Address(RVA = "0x1C49090", Offset = "0x1C48290", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D1F")]
	internal void ExecuteDefaultActionInternal(EventBase evt) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Token(Token = "0x6000D16")]
	protected override void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Token(Token = "0x6000D17")]
	internal override void HandleEventBubbleUpDisabled(EventBase evt) { }

	[Address(RVA = "0x166E740", Offset = "0x166D940", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D18")]
	internal void HandleEventBubbleUpInternal(EventBase evt) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Token(Token = "0x6000D19")]
	protected override void HandleEventTrickleDown(EventBase evt) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Token(Token = "0x6000D1A")]
	internal override void HandleEventTrickleDownDisabled(EventBase evt) { }

	[Address(RVA = "0x1C490B0", Offset = "0x1C482B0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D1B")]
	internal void HandleEventTrickleDownInternal(EventBase evt) { }

	[Address(RVA = "0x1C490D0", Offset = "0x1C482D0", Length = "0x1AD")]
	[CallerCount(Count = 204)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyChangedEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(PropertyChangedEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D23")]
	protected void NotifyPropertyChanged(in BindingId property) { }

	[Address(RVA = "0x685A90", Offset = "0x684C90", Length = "0xCF")]
	[CalledBy(Type = typeof(Clickable), Member = "RegisterCallbacksOnTarget", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnAttachToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventCallbackRegistry), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D10")]
	internal void RegisterCallback(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = 0) { }

	[Address(RVA = "0x685960", Offset = "0x684B60", Length = "0x122")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "StartTrackingBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "IncreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B90")]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventCallbackRegistry), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D0F")]
	public void RegisterCallback(EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown = 0) { }

	[Address(RVA = "0x685B60", Offset = "0x684D60", Length = "0x119")]
	[CallerCount(Count = 186)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventCallbackRegistry), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D0D")]
	public void RegisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

	[Token(Token = "0x6000D14")]
	internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	[Token(Token = "0x6000D13")]
	public abstract void SendEvent(EventBase e) { }

	[Address(RVA = "0x685D30", Offset = "0x684F30", Length = "0xA1")]
	[CallerCount(Count = 130)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D12")]
	public void UnregisterCallback(EventCallback<TEventType, TUserArgsType> callback, TrickleDown useTrickleDown = 0) { }

	[Address(RVA = "0x685D30", Offset = "0x684F30", Length = "0xA1")]
	[CallerCount(Count = 130)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D11")]
	public void UnregisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

}

