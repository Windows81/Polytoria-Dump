namespace UnityEngine;

[NativeHeader("Runtime/Export/Graphics/Graphics.bindings.h")]
[Token(Token = "0x20000AC")]
public sealed class LightProbes : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40001EA")]
	private static Action lightProbesUpdated; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40001EB")]
	private static Action tetrahedralizationCompleted; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40001EC")]
	private static Action needsRetetrahedralization; //Field offset: 0x10

	[Address(RVA = "0x192CDA0", Offset = "0x192BFA0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000398")]
	private static void Internal_CallLightProbesUpdatedFunction() { }

	[Address(RVA = "0x192CDF0", Offset = "0x192BFF0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600039A")]
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }

	[Address(RVA = "0x192CE50", Offset = "0x192C050", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000399")]
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

}

