namespace System.Reflection;

[Token(Token = "0x20004B7")]
public sealed class AmbiguousMatchException : SystemException
{

	[Address(RVA = "0x13B4F40", Offset = "0x13B4140", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600213D")]
	public AmbiguousMatchException() { }

	[Address(RVA = "0x13B4F20", Offset = "0x13B4120", Length = "0x1E")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "ExactPropertyBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(FieldInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(EventInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostDerivedNewSlotMeth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase[]), typeof(int)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(FieldInfo[]), typeof(object), typeof(CultureInfo)}, ReturnType = typeof(FieldInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Type)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600213E")]
	public AmbiguousMatchException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600213F")]
	internal AmbiguousMatchException(SerializationInfo info, StreamingContext context) { }

}

