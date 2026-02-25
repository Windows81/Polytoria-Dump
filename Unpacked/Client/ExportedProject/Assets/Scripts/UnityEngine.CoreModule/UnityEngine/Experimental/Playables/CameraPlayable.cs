namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
[NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("CameraPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000315")]
public struct CameraPlayable : IEquatable<CameraPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F6")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x197B8F0", Offset = "0x197AAF0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EDA")]
	public override bool Equals(CameraPlayable other) { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED9")]
	public override PlayableHandle GetHandle() { }

}

