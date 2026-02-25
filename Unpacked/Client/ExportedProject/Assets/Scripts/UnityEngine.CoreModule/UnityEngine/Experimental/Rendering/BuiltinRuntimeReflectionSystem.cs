namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
[Token(Token = "0x2000319")]
internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE4")]
	public BuiltinRuntimeReflectionSystem() { }

	[Address(RVA = "0x197B860", Offset = "0x197AA60", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[StaticAccessor("GetReflectionProbes()", Type = StaticAccessorType::Dot (0))]
	[Token(Token = "0x6000EE2")]
	private static bool BuiltinUpdate() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE0")]
	public override void Dispose() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE1")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x197B890", Offset = "0x197AA90", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EE3")]
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	[Address(RVA = "0x197B860", Offset = "0x197AA60", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EDF")]
	public override bool TickRealtimeProbes() { }

}

