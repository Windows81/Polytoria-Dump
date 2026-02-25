namespace UnityEngine;

[IsReadOnly]
[NativeClass("GfxBufferID")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[Token(Token = "0x20000B9")]
public struct GraphicsBufferHandle : IEquatable<GraphicsBufferHandle>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000209")]
	public readonly uint value; //Field offset: 0x0

	[Address(RVA = "0x192B3E0", Offset = "0x192A5E0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000489")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x192B3D0", Offset = "0x192A5D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600048A")]
	public override bool Equals(GraphicsBufferHandle other) { }

	[Address(RVA = "0x192B460", Offset = "0x192A660", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000488")]
	public virtual int GetHashCode() { }

}

