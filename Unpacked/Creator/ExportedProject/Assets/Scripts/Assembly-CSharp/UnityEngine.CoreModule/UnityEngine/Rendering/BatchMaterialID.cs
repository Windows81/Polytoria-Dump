namespace UnityEngine.Rendering;

[NativeClass("BatchMaterialID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x20002CE")]
public struct BatchMaterialID : IEquatable<BatchMaterialID>
{
	[Token(Token = "0x400081D")]
	public static readonly BatchMaterialID Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400081E")]
	public uint value; //Field offset: 0x0

	[Address(RVA = "0x197B0A0", Offset = "0x197A2A0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000E1B")]
	private static BatchMaterialID() { }

	[Address(RVA = "0x197B000", Offset = "0x197A200", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E19")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x192B3D0", Offset = "0x192A5D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1A")]
	public override bool Equals(BatchMaterialID other) { }

	[Address(RVA = "0x192B460", Offset = "0x192A660", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E18")]
	public virtual int GetHashCode() { }

}

