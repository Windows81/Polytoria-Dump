namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200001A")]
public class FastAction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007C")]
	private LinkedList<Action`1<A>> delegates; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007D")]
	private Dictionary<Action`1<A>, LinkedListNode`1<Action`1<A>>> lookup; //Field offset: 0x0

	[Address(RVA = "0xC316D0", Offset = "0xC308D0", Length = "0xD1")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	public FastAction`1() { }

}

