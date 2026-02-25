namespace Battlehub.UIControls;

[Token(Token = "0x2000016")]
public class Repeater
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000027")]
	private float m_firstDelay; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000028")]
	private float m_delay; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000029")]
	private float m_nextT; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002A")]
	private Action m_callback; //Field offset: 0x20

	[Address(RVA = "0x5D24F0", Offset = "0x5D16F0", Length = "0x71")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000080")]
	public Repeater(float t, float initDelay, float firstDelay, float delay, Action callback) { }

	[Address(RVA = "0x5D2480", Offset = "0x5D1680", Length = "0x63")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000081")]
	public void Repeat(float t) { }

}

