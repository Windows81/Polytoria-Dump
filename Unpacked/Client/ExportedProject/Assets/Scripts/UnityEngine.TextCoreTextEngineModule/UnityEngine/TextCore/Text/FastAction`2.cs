namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200001B")]
public class FastAction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007E")]
	private LinkedList<Action`2<A, B>> delegates; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007F")]
	private Dictionary<Action`2<A, B>, LinkedListNode`1<Action`2<A, B>>> lookup; //Field offset: 0x0

	[Address(RVA = "0xC321E0", Offset = "0xC313E0", Length = "0xD2")]
	[CalledBy(Type = typeof(TextEventManager), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	public FastAction`2() { }

	[Address(RVA = "0xC31E70", Offset = "0xC31070", Length = "0x87")]
	[CalledBy(Type = typeof(TextEventManager), Member = "ON_FONT_PROPERTY_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LinkedListNode`1), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000037")]
	public void Call(A a, B b) { }

}

