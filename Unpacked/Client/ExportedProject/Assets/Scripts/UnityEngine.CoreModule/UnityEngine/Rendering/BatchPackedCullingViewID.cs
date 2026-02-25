namespace UnityEngine.Rendering;

[Token(Token = "0x20002D5")]
public struct BatchPackedCullingViewID : IEquatable<BatchPackedCullingViewID>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400083E")]
	internal ulong handle; //Field offset: 0x0

	[Address(RVA = "0xF67EA0", Offset = "0xF670A0", Length = "0x9")]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E21")]
	public override bool Equals(BatchPackedCullingViewID other) { }

	[Address(RVA = "0x197B1C0", Offset = "0x197A3C0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E22")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x197B250", Offset = "0x197A450", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6000E20")]
	public virtual int GetHashCode() { }

}

