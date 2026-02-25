namespace UnityEngine.InputForUI;

[Token(Token = "0x200002B")]
internal class NavigationEventRepeatHelper
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D4")]
	private int m_ConsecutiveMoveCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000D5")]
	private Direction m_LastDirection; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D6")]
	private DiscreteTime m_PrevActionTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D7")]
	private readonly DiscreteTime m_InitialRepeatDelay; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D8")]
	private readonly DiscreteTime m_ConsecutiveRepeatDelay; //Field offset: 0x28

	[Address(RVA = "0x19D7390", Offset = "0x19D6590", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000D4")]
	public NavigationEventRepeatHelper() { }

	[Address(RVA = "0x19D7230", Offset = "0x19D6430", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000D2")]
	public void Reset() { }

	[Address(RVA = "0x19D7290", Offset = "0x19D6490", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000D3")]
	public bool ShouldSendMoveEvent(DiscreteTime timestamp, Direction direction, bool axisButtonsWherePressedThisFrame) { }

}

