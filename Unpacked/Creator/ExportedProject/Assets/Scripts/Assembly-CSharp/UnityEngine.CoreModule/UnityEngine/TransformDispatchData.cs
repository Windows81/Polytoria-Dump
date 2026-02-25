namespace UnityEngine;

[Token(Token = "0x2000104")]
internal struct TransformDispatchData : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004E9")]
	public NativeArray<Int32> transformedID; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004EA")]
	public NativeArray<Int32> parentID; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004EB")]
	public NativeArray<Matrix4x4> localToWorldMatrices; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004EC")]
	public NativeArray<Vector3> positions; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004ED")]
	public NativeArray<Quaternion> rotations; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004EE")]
	public NativeArray<Vector3> scales; //Field offset: 0x50

	[Address(RVA = "0x1972E70", Offset = "0x1972070", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x600084C")]
	public override void Dispose() { }

}

