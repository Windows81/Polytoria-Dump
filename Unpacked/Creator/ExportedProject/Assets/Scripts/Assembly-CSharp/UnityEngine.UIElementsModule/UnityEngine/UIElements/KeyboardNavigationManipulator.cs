namespace UnityEngine.UIElements;

[Token(Token = "0x2000290")]
public class KeyboardNavigationManipulator : Manipulator
{
	[CompilerGenerated]
	[Token(Token = "0x2000291")]
	private struct <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A31")]
		public KeyDownEvent evt; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A30")]
	private readonly Action<KeyboardNavigationOperation, EventBase> m_Action; //Field offset: 0x18

	[Address(RVA = "0x13847D0", Offset = "0x13839D0", Length = "0x31")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011DC")]
	public KeyboardNavigationManipulator(Action<KeyboardNavigationOperation, EventBase> action) { }

	[Address(RVA = "0x1C86DF0", Offset = "0x1C85FF0", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KeyboardEventBase`1), Member = "get_actionKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x60011E4")]
	internal static KeyboardNavigationOperation <OnKeyDown>g__GetOperation|4_0(ref <>c__DisplayClass4_0 unnamed_param_0) { }

	[Address(RVA = "0x1C11300", Offset = "0x1C10500", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E3")]
	private void Invoke(KeyboardNavigationOperation operation, EventBase evt) { }

	[Address(RVA = "0x1C869D0", Offset = "0x1C85BD0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KeyboardEventBase`1), Member = "get_actionKey", ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60011DF")]
	internal void OnKeyDown(KeyDownEvent evt) { }

	[Address(RVA = "0x1C86AE0", Offset = "0x1C85CE0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011E0")]
	private void OnNavigationCancel(NavigationCancelEvent evt) { }

	[Address(RVA = "0x1C86B10", Offset = "0x1C85D10", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60011E2")]
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	[Address(RVA = "0x1C86BE0", Offset = "0x1C85DE0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011E1")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x1C86C10", Offset = "0x1C85E10", Length = "0x1DA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60011DD")]
	protected virtual void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x1C86EF0", Offset = "0x1C860F0", Length = "0x1DA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x60011DE")]
	protected virtual void UnregisterCallbacksFromTarget() { }

}

