namespace Mono;

[Token(Token = "0x2000031")]
internal struct RuntimeClassHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010D")]
	private MonoClass* value; //Field offset: 0x0

	[Token(Token = "0x17000005")]
	internal MonoClass* Value
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000056")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000054")]
	internal RuntimeClassHandle(MonoClass* value) { }

	[Address(RVA = "0x9E2BC0", Offset = "0x9E1DC0", Length = "0x1F")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000055")]
	internal RuntimeClassHandle(IntPtr ptr) { }

	[Address(RVA = "0x12DD730", Offset = "0x12DC930", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000057")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	internal MonoClass* get_Value() { }

	[Address(RVA = "0x12DD820", Offset = "0x12DCA20", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000058")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x12DD850", Offset = "0x12DCA50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_type")]
	[Token(Token = "0x6000059")]
	internal static IntPtr GetTypeFromClass(MonoClass* klass) { }

	[Address(RVA = "0x12DD860", Offset = "0x12DCA60", Length = "0x8")]
	[CalledBy(Type = typeof(TransparentProxy), Member = "GetProxyType", ReturnType = typeof(RuntimeType))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "get_IsContextBoundObject", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "InCurrentContext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "StoreRemoteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_type")]
	[Token(Token = "0x600005A")]
	internal RuntimeTypeHandle GetTypeHandle() { }

}

