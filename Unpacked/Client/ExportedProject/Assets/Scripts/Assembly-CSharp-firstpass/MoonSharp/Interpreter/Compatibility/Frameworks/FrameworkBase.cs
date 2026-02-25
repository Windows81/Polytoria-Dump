namespace MoonSharp.Interpreter.Compatibility.Frameworks;

[Token(Token = "0x2000197")]
public abstract class FrameworkBase
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F0B")]
	protected FrameworkBase() { }

	[Token(Token = "0x6000EF9")]
	public abstract MethodInfo GetAddMethod(EventInfo ei) { }

	[Token(Token = "0x6000EED")]
	public abstract Assembly GetAssembly(Type t) { }

	[Token(Token = "0x6000F03")]
	public abstract Type[] GetAssemblyTypes(Assembly asm) { }

	[Token(Token = "0x6000EEE")]
	public abstract Type GetBaseType(Type t) { }

	[Token(Token = "0x6000F02")]
	public abstract ConstructorInfo[] GetConstructors(Type type) { }

	[Token(Token = "0x6000EF6")]
	public abstract Attribute[] GetCustomAttributes(Type t, Type at, bool inherit) { }

	[Token(Token = "0x6000EF5")]
	public abstract Attribute[] GetCustomAttributes(Type t, bool inherit) { }

	[Token(Token = "0x6000F01")]
	public abstract EventInfo[] GetEvents(Type type) { }

	[Token(Token = "0x6000F05")]
	public abstract FieldInfo[] GetFields(Type t) { }

	[Token(Token = "0x6000F07")]
	public abstract Type[] GetGenericArguments(Type t) { }

	[Token(Token = "0x6000EFB")]
	public abstract MethodInfo GetGetMethod(PropertyInfo pi) { }

	[Token(Token = "0x6000EFD")]
	public abstract Type GetInterface(Type type, string name) { }

	[Token(Token = "0x6000EF7")]
	public abstract Type[] GetInterfaces(Type t) { }

	[Token(Token = "0x6000F06")]
	public abstract MethodInfo GetMethod(Type type, string name) { }

	[Token(Token = "0x6000F0A")]
	public abstract MethodInfo GetMethod(Type resourcesType, string v, Type[] type) { }

	[Token(Token = "0x6000F04")]
	public abstract MethodInfo[] GetMethods(Type type) { }

	[Token(Token = "0x6000F00")]
	public abstract Type[] GetNestedTypes(Type type) { }

	[Token(Token = "0x6000EFE")]
	public abstract PropertyInfo[] GetProperties(Type type) { }

	[Token(Token = "0x6000EFF")]
	public abstract PropertyInfo GetProperty(Type type, string name) { }

	[Token(Token = "0x6000EFA")]
	public abstract MethodInfo GetRemoveMethod(EventInfo ei) { }

	[Token(Token = "0x6000EFC")]
	public abstract MethodInfo GetSetMethod(PropertyInfo pi) { }

	[Token(Token = "0x6000EF3")]
	public abstract bool IsAbstract(Type t) { }

	[Token(Token = "0x6000F08")]
	public abstract bool IsAssignableFrom(Type current, Type toCompare) { }

	[Token(Token = "0x6000F09")]
	public abstract bool IsDbNull(object o) { }

	[Token(Token = "0x6000EF1")]
	public abstract bool IsEnum(Type t) { }

	[Token(Token = "0x6000EEF")]
	public abstract bool IsGenericType(Type t) { }

	[Token(Token = "0x6000EF0")]
	public abstract bool IsGenericTypeDefinition(Type t) { }

	[Token(Token = "0x6000EF8")]
	public abstract bool IsInstanceOfType(Type t, object o) { }

	[Token(Token = "0x6000EF4")]
	public abstract bool IsInterface(Type t) { }

	[Token(Token = "0x6000EF2")]
	public abstract bool IsNestedPublic(Type t) { }

	[Token(Token = "0x6000EEC")]
	public abstract bool IsValueType(Type t) { }

	[Token(Token = "0x6000EEB")]
	public abstract bool StringContainsChar(string str, char chr) { }

}

