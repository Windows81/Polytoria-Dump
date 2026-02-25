namespace MoonSharp.Interpreter.Compatibility.Frameworks;

[Token(Token = "0x2000198")]
internal abstract class FrameworkClrBase : FrameworkReflectionBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000629")]
	private BindingFlags BINDINGFLAGS_MEMBER; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400062A")]
	private BindingFlags BINDINGFLAGS_INNERCLASS; //Field offset: 0x14

	[Address(RVA = "0x396410", Offset = "0x395610", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F1E")]
	protected FrameworkClrBase() { }

	[Address(RVA = "0x395F50", Offset = "0x395150", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F0C")]
	public virtual MethodInfo GetAddMethod(EventInfo ei) { }

	[Address(RVA = "0x395F80", Offset = "0x395180", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F1D")]
	public virtual Type[] GetAssemblyTypes(Assembly asm) { }

	[Address(RVA = "0x395FB0", Offset = "0x3951B0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F0D")]
	public virtual ConstructorInfo[] GetConstructors(Type type) { }

	[Address(RVA = "0x396000", Offset = "0x395200", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F0E")]
	public virtual EventInfo[] GetEvents(Type type) { }

	[Address(RVA = "0x396050", Offset = "0x395250", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F0F")]
	public virtual FieldInfo[] GetFields(Type type) { }

	[Address(RVA = "0x3960A0", Offset = "0x3952A0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F10")]
	public virtual Type[] GetGenericArguments(Type type) { }

	[Address(RVA = "0x3960E0", Offset = "0x3952E0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F11")]
	public virtual MethodInfo GetGetMethod(PropertyInfo pi) { }

	[Address(RVA = "0x396110", Offset = "0x395310", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F12")]
	public virtual Type[] GetInterfaces(Type t) { }

	[Address(RVA = "0x396150", Offset = "0x395350", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F13")]
	public virtual MethodInfo GetMethod(Type type, string name) { }

	[Address(RVA = "0x396190", Offset = "0x395390", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F1C")]
	public virtual MethodInfo GetMethod(Type resourcesType, string name, Type[] types) { }

	[Address(RVA = "0x3961E0", Offset = "0x3953E0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F14")]
	public virtual MethodInfo[] GetMethods(Type type) { }

	[Address(RVA = "0x396230", Offset = "0x395430", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F15")]
	public virtual Type[] GetNestedTypes(Type type) { }

	[Address(RVA = "0x396280", Offset = "0x395480", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F16")]
	public virtual PropertyInfo[] GetProperties(Type type) { }

	[Address(RVA = "0x3962D0", Offset = "0x3954D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F17")]
	public virtual PropertyInfo GetProperty(Type type, string name) { }

	[Address(RVA = "0x396310", Offset = "0x395510", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F18")]
	public virtual MethodInfo GetRemoveMethod(EventInfo ei) { }

	[Address(RVA = "0x396340", Offset = "0x395540", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F19")]
	public virtual MethodInfo GetSetMethod(PropertyInfo pi) { }

	[Address(RVA = "0x396370", Offset = "0x395570", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F1A")]
	public virtual bool IsAssignableFrom(Type current, Type toCompare) { }

	[Address(RVA = "0x3963C0", Offset = "0x3955C0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F1B")]
	public virtual bool IsInstanceOfType(Type t, object o) { }

}

