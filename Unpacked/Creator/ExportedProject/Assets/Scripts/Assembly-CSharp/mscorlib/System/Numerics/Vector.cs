namespace System.Numerics;

[Intrinsic]
[Token(Token = "0x200052D")]
public static class Vector
{

	[Token(Token = "0x17000540")]
	public static bool IsHardwareAccelerated
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Intrinsic]
		[Token(Token = "0x600253D")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x7D09A0", Offset = "0x7CFBA0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Vector`1), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(System.Numerics.Vector`1<System.UInt64>))]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x600253E")]
	public static Vector<UInt64> AsVectorUInt64(Vector<T> value) { }

	[Address(RVA = "0x7D0AE0", Offset = "0x7CFCE0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CA510")]
	[DeduplicatedMethod]
	[Token(Token = "0x600253C")]
	public static Vector<T> Equals(Vector<T> left, Vector<T> right) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Intrinsic]
	[Token(Token = "0x600253D")]
	public static bool get_IsHardwareAccelerated() { }

}

