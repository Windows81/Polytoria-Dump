namespace System.Reflection;

[Extension]
[Token(Token = "0x20004FC")]
public static class CustomAttributeExtensions
{

	[Address(RVA = "0x13D8E60", Offset = "0x13D8060", Length = "0x8")]
	[CalledBy(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Type)}, ReturnType = typeof(Attribute))]
	[Extension]
	[Token(Token = "0x6002314")]
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[Address(RVA = "0x13D8E70", Offset = "0x13D8070", Length = "0x8")]
	[CalledBy(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[CalledBy(Type = "namudev.PropertyGrid", Member = "AppendProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"U8Xml.XmlNodeList", "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = "DumpAPI", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.ExpressionStringBuilder", Member = "VisitMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.MethodCallExpression"}, ReturnType = "System.Linq.Expressions.Expression")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute))]
	[Extension]
	[Token(Token = "0x6002315")]
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[Address(RVA = "0x68EB90", Offset = "0x68DD90", Length = "0xA9")]
	[CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(UltimateResourceFallbackLocation&)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguageAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(String&), typeof(Int16&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Type)}, ReturnType = typeof(Attribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6002316")]
	public static T GetCustomAttribute(Assembly element) { }

	[Address(RVA = "0x68EC40", Offset = "0x68DE40", Length = "0xA9")]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.CreatorPropertyGrid", Member = "SetPropertyGridItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Instance>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeTraits`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider+<GetPropertyMembers>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "Unity.Burst.BurstCompileAttribute")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6002317")]
	public static T GetCustomAttribute(MemberInfo element) { }

	[Address(RVA = "0x13D8E80", Offset = "0x13D8080", Length = "0x8")]
	[CalledBy(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute))]
	[Extension]
	[Token(Token = "0x6002318")]
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	[Address(RVA = "0x68ECF0", Offset = "0x68DEF0", Length = "0xBA")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementFactoryRegistry", Member = "RegisterFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IUxmlFactory"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6002319")]
	public static T GetCustomAttribute(MemberInfo element, bool inherit) { }

	[Address(RVA = "0x13D8E90", Offset = "0x13D8090", Length = "0x7")]
	[CalledBy(Type = "Unity.Properties.FieldMember", Member = "GetCustomAttributes", ReturnType = "System.Collections.Generic.IEnumerable`1<Attribute>")]
	[CalledBy(Type = "Unity.Properties.PropertyMember", Member = "GetCustomAttributes", ReturnType = "System.Collections.Generic.IEnumerable`1<Attribute>")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "Unity.Burst.BurstCompileAttribute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Attribute[]))]
	[Extension]
	[Token(Token = "0x600231A")]
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element) { }

	[Address(RVA = "0x13D8EA0", Offset = "0x13D80A0", Length = "0x8")]
	[CalledBy(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute[]))]
	[Extension]
	[Token(Token = "0x600231B")]
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[Address(RVA = "0x68EDB0", Offset = "0x68DFB0", Length = "0xA9")]
	[CalledBy(Type = typeof(StackTrace), Member = "ConvertAsyncStateMachineMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase&), typeof(Type&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.PropertyBagStore", Member = "AddPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Attribute>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600231C")]
	public static IEnumerable<T> GetCustomAttributes(MemberInfo element) { }

	[Address(RVA = "0x13D8EB0", Offset = "0x13D80B0", Length = "0x8")]
	[CalledBy(Type = typeof(StackTrace), Member = "GetFullNameForStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MethodBase), typeof(bool), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Attribute), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[Extension]
	[Token(Token = "0x600231D")]
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

}

