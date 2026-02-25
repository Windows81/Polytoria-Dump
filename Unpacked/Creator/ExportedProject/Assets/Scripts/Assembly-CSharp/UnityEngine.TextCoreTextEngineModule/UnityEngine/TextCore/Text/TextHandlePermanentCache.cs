namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200005C")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class TextHandlePermanentCache
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000361")]
	internal LinkedList<TextInfo> s_TextInfoPool; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000362")]
	private object syncRoot; //Field offset: 0x18

	[Address(RVA = "0x1A64F10", Offset = "0x1A64110", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60002BC")]
	public TextHandlePermanentCache() { }

	[Address(RVA = "0x1A64B60", Offset = "0x1A63D60", Length = "0x280")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LinkedList`1), Member = "get_Last", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveLast", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextHandle), Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002BA")]
	public override void AddTextInfoToCache(TextHandle textHandle) { }

	[Address(RVA = "0x1A64DF0", Offset = "0x1A63FF0", Length = "0x11E")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60002BB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	public void RemoveTextInfoFromCache(TextHandle textHandle) { }

}

