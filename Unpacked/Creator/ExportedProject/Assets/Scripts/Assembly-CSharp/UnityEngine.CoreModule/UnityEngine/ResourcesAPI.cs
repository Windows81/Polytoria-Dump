namespace UnityEngine;

[Token(Token = "0x200011B")]
public class ResourcesAPI
{
	[Token(Token = "0x4000508")]
	private static ResourcesAPI s_DefaultAPI; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000509")]
	private static ResourcesAPI <overrideAPI>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000172")]
	internal static ResourcesAPI ActiveAPI
	{
		[Address(RVA = "0x196E850", Offset = "0x196DA50", Length = "0xA7")]
		[CalledBy(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
		[CalledBy(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Object))]
		[CalledBy(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60008A9")]
		internal get { } //Length: 167
	}

	[Token(Token = "0x17000173")]
	public static ResourcesAPI overrideAPI
	{
		[Address(RVA = "0x196E900", Offset = "0x196DB00", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x60008AA")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x196E7E0", Offset = "0x196D9E0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008AF")]
	private static ResourcesAPI() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008AB")]
	protected private ResourcesAPI() { }

	[Address(RVA = "0x196E770", Offset = "0x196D970", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008AC")]
	protected private override Object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	[Address(RVA = "0x196E7B0", Offset = "0x196D9B0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResourcesAPIInternal), Member = "FindShaderByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Token(Token = "0x60008AD")]
	protected private override Shader FindShaderByName(string name) { }

	[Address(RVA = "0x196E850", Offset = "0x196DA50", Length = "0xA7")]
	[CalledBy(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[CalledBy(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Object))]
	[CalledBy(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60008A9")]
	internal static ResourcesAPI get_ActiveAPI() { }

	[Address(RVA = "0x196E900", Offset = "0x196DB00", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x60008AA")]
	public static ResourcesAPI get_overrideAPI() { }

	[Address(RVA = "0x196E7C0", Offset = "0x196D9C0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResourcesAPIInternal), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
	[Token(Token = "0x60008AE")]
	protected private override object Load(string path, Type systemTypeInstance) { }

}

