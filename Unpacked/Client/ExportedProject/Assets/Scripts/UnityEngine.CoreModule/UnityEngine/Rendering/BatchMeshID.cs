namespace UnityEngine.Rendering;

[NativeClass("BatchMeshID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x20002CF")]
public struct BatchMeshID : IEquatable<BatchMeshID>
{
	[Token(Token = "0x400081F")]
	public static readonly BatchMeshID Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000820")]
	public uint value; //Field offset: 0x0

	[Address(RVA = "0x197B180", Offset = "0x197A380", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000E1F")]
	private static BatchMeshID() { }

	[Address(RVA = "0x197B0E0", Offset = "0x197A2E0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E1D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x192B3D0", Offset = "0x192A5D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1E")]
	public override bool Equals(BatchMeshID other) { }

	[Address(RVA = "0x192B460", Offset = "0x192A660", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1C")]
	public virtual int GetHashCode() { }

}

