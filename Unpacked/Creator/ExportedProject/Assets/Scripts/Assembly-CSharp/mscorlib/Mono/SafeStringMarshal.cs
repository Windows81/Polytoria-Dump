namespace Mono;

[Token(Token = "0x2000046")]
internal struct SafeStringMarshal : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013D")]
	private readonly string str; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400013E")]
	private IntPtr marshaled_string; //Field offset: 0x8

	[Token(Token = "0x1700000F")]
	public IntPtr Value
	{
		[Address(RVA = "0x12DE360", Offset = "0x12DD560", Length = "0x3C")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeMethodInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertiesByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimePropertyInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType)}, ReturnType = typeof(RuntimeType[]))]
		[CalledBy(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A350")]
		[Token(Token = "0x600007D")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x12DE340", Offset = "0x12DD540", Length = "0x1F")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeMethodInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertiesByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimePropertyInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType)}, ReturnType = typeof(RuntimeType[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600007C")]
	public SafeStringMarshal(string str) { }

	[Address(RVA = "0x12DE2D0", Offset = "0x12DD4D0", Length = "0x27")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeMethodInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertiesByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimePropertyInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType)}, ReturnType = typeof(RuntimeType[]))]
	[CalledBy(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_free")]
	[Token(Token = "0x600007E")]
	public override void Dispose() { }

	[Address(RVA = "0x12DE360", Offset = "0x12DD560", Length = "0x3C")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeMethodInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertiesByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimePropertyInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType)}, ReturnType = typeof(RuntimeType[]))]
	[CalledBy(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A350")]
	[Token(Token = "0x600007D")]
	public IntPtr get_Value() { }

	[Address(RVA = "0x12DE300", Offset = "0x12DD500", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_free")]
	[Token(Token = "0x600007B")]
	public static void GFree(IntPtr ptr) { }

	[Address(RVA = "0x12DE320", Offset = "0x12DD520", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A350")]
	[Token(Token = "0x600007A")]
	public static IntPtr StringToUtf8(string str) { }

	[Address(RVA = "0x12DE310", Offset = "0x12DD510", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A350")]
	[Token(Token = "0x6000079")]
	private static IntPtr StringToUtf8_icall(ref string str) { }

}

