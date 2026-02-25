namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000641")]
internal class MultiColumnHeaderColumnIcon : Image
{
	[Token(Token = "0x4001752")]
	public static readonly string ussClassName; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4001753")]
	private bool <isImageInline>k__BackingField; //Field offset: 0x318

	[Token(Token = "0x17000B3C")]
	public bool isImageInline
	{
		[Address(RVA = "0x1BF4E80", Offset = "0x1BF4080", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6002C10")]
		 get { } //Length: 8
		[Address(RVA = "0x1BF4E90", Offset = "0x1BF4090", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6002C11")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x1BF4CF0", Offset = "0x1BF3EF0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002C14")]
	private static MultiColumnHeaderColumnIcon() { }

	[Address(RVA = "0x1BF4D90", Offset = "0x1BF3F90", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Image), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C12")]
	public MultiColumnHeaderColumnIcon() { }

	[Address(RVA = "0x1BF4B80", Offset = "0x1BF3D80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnHeaderColumnIcon), Member = "UpdateClassList", ReturnType = typeof(void))]
	[CompilerGenerated]
	[Token(Token = "0x6002C15")]
	private void <.ctor>b__5_0(CustomStyleResolvedEvent evt) { }

	[Address(RVA = "0x1BF4E80", Offset = "0x1BF4080", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6002C10")]
	public bool get_isImageInline() { }

	[Address(RVA = "0x1BF4E90", Offset = "0x1BF4090", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6002C11")]
	public void set_isImageInline(bool value) { }

	[Address(RVA = "0x1BF4B90", Offset = "0x1BF3D90", Length = "0x15E")]
	[CalledBy(Type = typeof(MultiColumnHeaderColumnIcon), Member = "<.ctor>b__5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "DefaultBindHeaderContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C13")]
	public void UpdateClassList() { }

}

