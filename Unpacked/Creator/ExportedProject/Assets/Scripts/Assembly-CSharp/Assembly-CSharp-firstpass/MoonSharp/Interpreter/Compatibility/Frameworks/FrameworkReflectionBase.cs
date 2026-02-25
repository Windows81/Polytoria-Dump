namespace MoonSharp.Interpreter.Compatibility.Frameworks;

[Token(Token = "0x2000199")]
internal abstract class FrameworkReflectionBase : FrameworkBase
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F2B")]
	protected FrameworkReflectionBase() { }

	[Address(RVA = "0x3964F0", Offset = "0x3956F0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F20")]
	public virtual Assembly GetAssembly(Type t) { }

	[Address(RVA = "0x396530", Offset = "0x395730", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F21")]
	public virtual Type GetBaseType(Type t) { }

	[Address(RVA = "0x396630", Offset = "0x395830", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F29")]
	public virtual Attribute[] GetCustomAttributes(Type t, bool inherit) { }

	[Address(RVA = "0x396570", Offset = "0x395770", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F2A")]
	public virtual Attribute[] GetCustomAttributes(Type t, Type at, bool inherit) { }

	[Token(Token = "0x6000F1F")]
	public abstract Type GetTypeInfoFromType(Type t) { }

	[Address(RVA = "0x3966E0", Offset = "0x3958E0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F25")]
	public virtual bool IsAbstract(Type t) { }

	[Address(RVA = "0x396710", Offset = "0x395910", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F26")]
	public virtual bool IsEnum(Type t) { }

	[Address(RVA = "0x396790", Offset = "0x395990", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F28")]
	public virtual bool IsGenericType(Type t) { }

	[Address(RVA = "0x396750", Offset = "0x395950", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F27")]
	public virtual bool IsGenericTypeDefinition(Type t) { }

	[Address(RVA = "0x3967D0", Offset = "0x3959D0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F23")]
	public virtual bool IsInterface(Type t) { }

	[Address(RVA = "0x396800", Offset = "0x395A00", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F24")]
	public virtual bool IsNestedPublic(Type t) { }

	[Address(RVA = "0x396830", Offset = "0x395A30", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F22")]
	public virtual bool IsValueType(Type t) { }

}

