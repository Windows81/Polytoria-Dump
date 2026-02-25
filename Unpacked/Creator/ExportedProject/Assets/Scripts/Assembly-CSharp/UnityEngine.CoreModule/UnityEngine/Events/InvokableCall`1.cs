namespace UnityEngine.Events;

[Token(Token = "0x20001BD")]
internal class InvokableCall : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400064D")]
	private UnityAction<T1> Delegate; //Field offset: 0x0

	[Token(Token = "0x14000009")]
	protected event UnityAction<T1> Delegate
	{
		[Address(RVA = "0xCBCC10", Offset = "0xCBBE10", Length = "0xC0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C12")]
		 add { } //Length: 192
		[Address(RVA = "0xCBCCE0", Offset = "0xCBBEE0", Length = "0xC0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C13")]
		 remove { } //Length: 192
	}

	[Address(RVA = "0xCBC9D0", Offset = "0xCBBBD0", Length = "0xE3")]
	[CalledBy(Type = typeof(CachedInvokableCall`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(MethodInfo), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`1), Member = "GetDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(BaseInvokableCall))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseInvokableCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800C9940")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C14")]
	public InvokableCall`1(object target, MethodInfo theFunction) { }

	[Address(RVA = "0xCBC980", Offset = "0xCBBB80", Length = "0x48")]
	[CalledBy(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`1), Member = "GetDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(BaseInvokableCall))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800C9940")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C15")]
	public InvokableCall`1(UnityAction<T1> action) { }

	[Address(RVA = "0xCBCC10", Offset = "0xCBBE10", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C12")]
	protected void add_Delegate(UnityAction<T1> value) { }

	[Address(RVA = "0xCBBC00", Offset = "0xCBAE00", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C18")]
	public virtual bool Find(object targetObj, MethodInfo method) { }

	[Address(RVA = "0xCBC590", Offset = "0xCBB790", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInvokableCall), Member = "ThrowOnInvalidArg", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseInvokableCall), Member = "AllowInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C16")]
	public virtual void Invoke(Object[] args) { }

	[Address(RVA = "0xCBBFD0", Offset = "0xCBB1D0", Length = "0x4A")]
	[CalledBy(Type = typeof(CachedInvokableCall`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CachedInvokableCall`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseInvokableCall), Member = "AllowInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C17")]
	public override void Invoke(T1 args0) { }

	[Address(RVA = "0xCBCCE0", Offset = "0xCBBEE0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C13")]
	protected void remove_Delegate(UnityAction<T1> value) { }

}

