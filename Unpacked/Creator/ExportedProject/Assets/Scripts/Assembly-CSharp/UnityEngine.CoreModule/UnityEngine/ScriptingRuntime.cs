namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/ScriptingRuntime.h")]
[Token(Token = "0x2000158")]
[VisibleToOtherModules]
internal class ScriptingRuntime
{

	[Address(RVA = "0x196F050", Offset = "0x196E250", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlObjectFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009EF")]
	public static String[] GetAllUserAssemblies() { }

}

