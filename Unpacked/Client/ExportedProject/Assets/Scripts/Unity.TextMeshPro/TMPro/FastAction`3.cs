namespace TMPro;

[Token(Token = "0x2000008")]
public class FastAction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000011")]
	private LinkedList<Action`3<A, B, C>> delegates; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000012")]
	private Dictionary<Action`3<A, B, C>, LinkedListNode`1<Action`3<A, B, C>>> lookup; //Field offset: 0x0

	[Address(RVA = "0xC327F0", Offset = "0xC319F0", Length = "0xD8")]
	[CalledBy(Type = typeof(TMPro_EventManager), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000012")]
	public FastAction`3() { }

	[Address(RVA = "0xC31150", Offset = "0xC30350", Length = "0x9E")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	public void Add(Action<A, B, C> rhs) { }

	[Address(RVA = "0xC32660", Offset = "0xC31860", Length = "0xA8")]
	[CalledBy(Type = typeof(TMPro_EventManager), Member = "ON_DRAG_AND_DROP_MATERIAL_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LinkedListNode`1), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000011")]
	public void Call(A a, B b, C c) { }

	[Address(RVA = "0xC31630", Offset = "0xC30830", Length = "0x9E")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000010")]
	public void Remove(Action<A, B, C> rhs) { }

}

