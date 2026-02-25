namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000019")]
public class FastAction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007A")]
	private LinkedList<Action> delegates; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007B")]
	private Dictionary<Action, LinkedListNode`1<Action>> lookup; //Field offset: 0x18

	[Address(RVA = "0x1A23FD0", Offset = "0x1A231D0", Length = "0xBD")]
	[CalledBy(Type = typeof(TextEventManager), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000035")]
	public FastAction() { }

}

