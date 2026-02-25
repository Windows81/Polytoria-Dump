namespace UnityEngine.UIElements;

[Token(Token = "0x200052D")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StyleCache
{
	[Token(Token = "0x400111C")]
	private static Dictionary<Int64, ComputedStyle> s_ComputedStyleCache; //Field offset: 0x0
	[Token(Token = "0x400111D")]
	private static Dictionary<Int32, StyleVariableContext> s_StyleVariableContextCache; //Field offset: 0x8
	[Token(Token = "0x400111E")]
	private static Dictionary<Int32, ComputedTransitionProperty[]> s_ComputedTransitionsCache; //Field offset: 0x10

	[Address(RVA = "0x1B67360", Offset = "0x1B66560", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002581")]
	private static StyleCache() { }

	[Address(RVA = "0x1B66FD0", Offset = "0x1B661D0", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, UnityEngine.UIElements.ComputedStyle>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600257C")]
	public static void SetValue(long hash, ref ComputedStyle data) { }

	[Address(RVA = "0x1B67090", Offset = "0x1B66290", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600257E")]
	public static void SetValue(int hash, StyleVariableContext data) { }

	[Address(RVA = "0x1B67120", Offset = "0x1B66320", Length = "0x86")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetOrComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(ComputedTransitionProperty[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002580")]
	public static void SetValue(int hash, ComputedTransitionProperty[] data) { }

	[Address(RVA = "0x1B672D0", Offset = "0x1B664D0", Length = "0x87")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, UnityEngine.UIElements.ComputedStyle>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600257B")]
	public static bool TryGetValue(long hash, out ComputedStyle data) { }

	[Address(RVA = "0x1B671B0", Offset = "0x1B663B0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600257D")]
	public static bool TryGetValue(int hash, out StyleVariableContext data) { }

	[Address(RVA = "0x1B67240", Offset = "0x1B66440", Length = "0x86")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetOrComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(ComputedTransitionProperty[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600257F")]
	public static bool TryGetValue(int hash, out ComputedTransitionProperty[] data) { }

}

