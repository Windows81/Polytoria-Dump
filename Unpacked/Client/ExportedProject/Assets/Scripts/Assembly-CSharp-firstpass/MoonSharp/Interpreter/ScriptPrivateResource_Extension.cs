namespace MoonSharp.Interpreter;

[Extension]
[Token(Token = "0x200004C")]
internal static class ScriptPrivateResource_Extension
{

	[Address(RVA = "0x309870", Offset = "0x308A70", Length = "0xB2")]
	[CalledBy(Type = typeof(Coroutine), Member = "Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Coroutine), Member = "Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Coroutine), Member = "Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000527")]
	public static void CheckScriptOwnership(IScriptPrivateResource containingResource, DynValue[] values) { }

	[Address(RVA = "0x309810", Offset = "0x308A10", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x6000528")]
	public static void CheckScriptOwnership(IScriptPrivateResource containingResource, DynValue value) { }

	[Address(RVA = "0x309930", Offset = "0x308B30", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000529")]
	public static void CheckScriptOwnership(IScriptPrivateResource resource, Script script) { }

	[Address(RVA = "0x3096A0", Offset = "0x3088A0", Length = "0x16C")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Extension]
	[Token(Token = "0x600052A")]
	public static void CheckScriptOwnership(IScriptPrivateResource containingResource, IScriptPrivateResource itemResource) { }

}

