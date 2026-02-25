namespace UnityEngine;

[Token(Token = "0x2000103")]
internal struct TypeDispatchData : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004E6")]
	public Object[] changed; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004E7")]
	public NativeArray<Int32> changedID; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004E8")]
	public NativeArray<Int32> destroyedID; //Field offset: 0x18

	[Address(RVA = "0x1976DF0", Offset = "0x1975FF0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x600084B")]
	public override void Dispose() { }

}

