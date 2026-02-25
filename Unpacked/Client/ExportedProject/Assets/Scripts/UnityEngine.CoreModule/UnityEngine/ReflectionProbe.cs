namespace UnityEngine;

[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
[Token(Token = "0x2000087")]
public sealed class ReflectionProbe : Behaviour
{
	[Token(Token = "0x2000088")]
	internal enum ReflectionProbeEvent
	{
		ReflectionProbeAdded = 0,
		ReflectionProbeRemoved = 1,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000194")]
	private static Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged; //Field offset: 0x0
	[Token(Token = "0x4000195")]
	private static Dictionary<Int32, Action`1<Texture>> registeredDefaultReflectionSetActions; //Field offset: 0x8
	[Token(Token = "0x4000196")]
	private static List<Action`1<Texture>> registeredDefaultReflectionTextureActions; //Field offset: 0x10

	[Address(RVA = "0x193C730", Offset = "0x193B930", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000241")]
	private static ReflectionProbe() { }

	[Address(RVA = "0x193C560", Offset = "0x193B760", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600023F")]
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	[Address(RVA = "0x193C5E0", Offset = "0x193B7E0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000240")]
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

}

