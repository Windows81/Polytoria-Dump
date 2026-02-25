namespace System;

[Token(Token = "0x200019E")]
internal sealed class TypeNameParser
{

	[Address(RVA = "0x1505EB0", Offset = "0x15050B0", Length = "0x60")]
	[CalledBy(Type = typeof(Type), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeSpec), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TypeSpec))]
	[Calls(Type = typeof(TypeSpec), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFA")]
	internal static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, String, Boolean, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark) { }

}

