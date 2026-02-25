namespace System.Reflection;

[Token(Token = "0x20004C7")]
public abstract class Binder
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600214D")]
	protected Binder() { }

	[Token(Token = "0x600214E")]
	public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo culture) { }

	[Token(Token = "0x600214F")]
	public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] names, out object state) { }

	[Token(Token = "0x6002150")]
	public abstract object ChangeType(object value, Type type, CultureInfo culture) { }

	[Token(Token = "0x6002151")]
	public abstract void ReorderArgumentArray(ref Object[] args, object state) { }

	[Token(Token = "0x6002152")]
	public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	[Token(Token = "0x6002153")]
	public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

}

