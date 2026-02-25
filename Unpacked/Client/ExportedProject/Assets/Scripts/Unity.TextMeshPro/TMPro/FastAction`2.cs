namespace TMPro;

[Token(Token = "0x2000007")]
public class FastAction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000F")]
	private LinkedList<Action`2<A, B>> delegates; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000010")]
	private Dictionary<Action`2<A, B>, LinkedListNode`1<Action`2<A, B>>> lookup; //Field offset: 0x0

	[Address(RVA = "0xC32020", Offset = "0xC31220", Length = "0xD8")]
	[CalledBy(Type = typeof(TMPro_EventManager), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000E")]
	public FastAction`2() { }

	[Address(RVA = "0xC31150", Offset = "0xC30350", Length = "0x9E")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	public void Add(Action<A, B> rhs) { }

	[Address(RVA = "0xC31F90", Offset = "0xC31190", Length = "0x8A")]
	[CalledBy(Type = typeof(TMPro_EventManager), Member = "ON_MATERIAL_PROPERTY_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMPro_EventManager), Member = "ON_FONT_PROPERTY_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMPro_EventManager), Member = "ON_SPRITE_ASSET_PROPERTY_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMPro_EventManager), Member = "ON_TEXTMESHPRO_PROPERTY_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMPro_EventManager), Member = "ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(LinkedListNode`1), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	public void Call(A a, B b) { }

	[Address(RVA = "0xC31630", Offset = "0xC30830", Length = "0x9E")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600000C")]
	public void Remove(Action<A, B> rhs) { }

}

