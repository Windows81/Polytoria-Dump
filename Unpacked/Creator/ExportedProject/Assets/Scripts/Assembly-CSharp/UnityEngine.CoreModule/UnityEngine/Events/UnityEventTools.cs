namespace UnityEngine.Events;

[Token(Token = "0x20001B9")]
internal class UnityEventTools
{

	[Address(RVA = "0x1993050", Offset = "0x1992250", Length = "0x1D7")]
	[CalledBy(Type = typeof(ArgumentCache), Member = "OnBeforeSerialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArgumentCache), Member = "OnAfterDeserialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PersistentCall), Member = "get_targetAssemblyTypeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(PersistentCall), Member = "OnBeforeSerialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PersistentCall), Member = "OnAfterDeserialize", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000BFB")]
	internal static string TidyAssemblyTypeName(string assemblyTypeName) { }

}

