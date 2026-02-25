namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200005D")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class TextHandleTemporaryCache
{
	[Token(Token = "0x4000364")]
	internal const int s_MinFramesInCache = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000363")]
	internal LinkedList<TextInfo> s_TextInfoPool; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000365")]
	internal int currentFrame; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000366")]
	private object syncRoot; //Field offset: 0x20

	[Address(RVA = "0x1A65BD0", Offset = "0x1A64DD0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60002C3")]
	public TextHandleTemporaryCache() { }

	[Address(RVA = "0x1A64FC0", Offset = "0x1A641C0", Length = "0x624")]
	[CalledBy(Type = typeof(TextHandle), Member = "AddTextInfoToTemporaryCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextHandleTemporaryCache), Member = "RecycleTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LinkedList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextInfo), Member = "RemoveFromCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "get_Last", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002BE")]
	public void AddTextInfoToCache(TextHandle textHandle, int hashCode) { }

	[Address(RVA = "0x1A655F0", Offset = "0x1A647F0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextInfo), Member = "RemoveFromCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002BD")]
	public void ClearTemporaryCache() { }

	[Address(RVA = "0x1A656B0", Offset = "0x1A648B0", Length = "0x23D")]
	[CalledBy(Type = typeof(TextHandleTemporaryCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(LinkedList`1), Member = "get_Last", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(TextInfo), Member = "RemoveFromCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveLast", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002C1")]
	private void RecycleTextInfoFromCache(TextHandle textHandle) { }

	[Address(RVA = "0x1A658F0", Offset = "0x1A64AF0", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002C0")]
	private void RefreshCaching(TextHandle textHandle) { }

	[Address(RVA = "0x1A659E0", Offset = "0x1A64BE0", Length = "0x1CE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60002BF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	public override void RemoveTextInfoFromCache(TextHandle textHandle) { }

	[Address(RVA = "0x1A65BB0", Offset = "0x1A64DB0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Token(Token = "0x60002C2")]
	public void UpdateCurrentFrame() { }

}

