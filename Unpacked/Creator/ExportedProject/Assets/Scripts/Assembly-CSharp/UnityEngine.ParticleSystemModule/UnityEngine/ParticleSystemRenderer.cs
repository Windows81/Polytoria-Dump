namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000014")]
public sealed class ParticleSystemRenderer : Renderer
{

	[Address(RVA = "0x19DDEB0", Offset = "0x19DD0B0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = True)]
	[RequiredByNativeCode]
	[Token(Token = "0x600006D")]
	public int GetMeshes(out Mesh[] meshes) { }

	[Address(RVA = "0x19DDE60", Offset = "0x19DD060", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006E")]
	private static int GetMeshes_Injected(IntPtr _unity_self, out Mesh[] meshes) { }

}

