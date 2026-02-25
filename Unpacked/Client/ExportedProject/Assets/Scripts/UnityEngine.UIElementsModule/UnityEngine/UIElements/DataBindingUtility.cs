namespace UnityEngine.UIElements;

[Token(Token = "0x200003E")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class DataBindingUtility
{
	[CompilerGenerated]
	[Token(Token = "0x200003F")]
	private sealed class <>c
	{
		[Token(Token = "0x400013F")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1ACD930", Offset = "0x1ACCB30", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001F5")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F6")]
		public <>c() { }

		[Address(RVA = "0x1ACD7E0", Offset = "0x1ACC9E0", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001F7")]
		internal TypePathVisitor <.cctor>b__23_0() { }

		[Address(RVA = "0x1ACD830", Offset = "0x1ACCA30", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TypePathVisitor), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001F8")]
		internal void <.cctor>b__23_1(TypePathVisitor v) { }

		[Address(RVA = "0x1ACD850", Offset = "0x1ACCA50", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(AutoCompletePathVisitor), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60001F9")]
		internal AutoCompletePathVisitor <.cctor>b__23_2() { }

		[Address(RVA = "0x1ACD8A0", Offset = "0x1ACCAA0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AutoCompletePathVisitor), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001FA")]
		internal void <.cctor>b__23_3(AutoCompletePathVisitor v) { }

	}

	[Token(Token = "0x400013C")]
	private static readonly ObjectPool<TypePathVisitor> k_TypeVisitors; //Field offset: 0x0
	[Token(Token = "0x400013D")]
	private static readonly ObjectPool<AutoCompletePathVisitor> k_AutoCompleteVisitors; //Field offset: 0x8
	[Token(Token = "0x400013E")]
	private static readonly Regex s_ReplaceIndices; //Field offset: 0x10

	[Address(RVA = "0x1AAF740", Offset = "0x1AAE940", Length = "0x318")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60001F4")]
	private static DataBindingUtility() { }

	[Address(RVA = "0x1AAF0C0", Offset = "0x1AAE2C0", Length = "0x675")]
	[CalledBy(Type = typeof(VisualElement), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Binding&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BindingId), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(BindingInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.DataBindingManager+BindingDataCollection", Member = "TryGetBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingRequest>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.UIElements.DataBindingManager+BindingRequest")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F3")]
	public static bool TryGetBinding(VisualElement element, in BindingId bindingId, out BindingInfo bindingInfo) { }

}

