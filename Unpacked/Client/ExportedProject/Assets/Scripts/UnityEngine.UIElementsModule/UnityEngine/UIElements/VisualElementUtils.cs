namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x2000525")]
internal static class VisualElementUtils
{
	[CompilerGenerated]
	[Token(Token = "0x2000526")]
	private sealed class <>c
	{
		[Token(Token = "0x4001100")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001101")]
		public static Predicate<VisualElement> <>9__5_0; //Field offset: 0x8

		[Address(RVA = "0x1B67B60", Offset = "0x1B66D60", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002558")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002559")]
		public <>c() { }

		[Address(RVA = "0x1B677C0", Offset = "0x1B669C0", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "ClassListContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600255A")]
		internal bool <AssignInspectorStyleIfNecessary>b__5_0(VisualElement i) { }

	}

	[Token(Token = "0x40010FD")]
	private static readonly HashSet<String> s_usedNames; //Field offset: 0x0
	[Token(Token = "0x40010FE")]
	private static readonly Type s_FoldoutType; //Field offset: 0x8
	[Token(Token = "0x40010FF")]
	private static readonly string s_InspectorElementUssClassName; //Field offset: 0x10

	[Address(RVA = "0x1B76020", Offset = "0x1B75220", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x6002557")]
	private static VisualElementUtils() { }

	[Address(RVA = "0x1B75CF0", Offset = "0x1B74EF0", Length = "0x129")]
	[CalledBy(Type = typeof(Foldout), Member = "OnAttachToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "GetFirstAncestorWhere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6002556")]
	internal static void AssignInspectorStyleIfNecessary(VisualElement element, string classNameToEnable) { }

	[Address(RVA = "0x1B75E20", Offset = "0x1B75020", Length = "0xEB")]
	[CalledBy(Type = typeof(Foldout), Member = "OnAttachToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "SetFoldoutDepthClass", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6002555")]
	internal static int GetFoldoutDepth(VisualElement element) { }

	[Address(RVA = "0x1B75F10", Offset = "0x1B75110", Length = "0x108")]
	[CalledBy(Type = typeof(PanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002554")]
	public static string GetUniqueName(string nameBase) { }

}

