namespace UnityEngine.UIElements;

[Token(Token = "0x2000218")]
public static class PointerId
{
	[Token(Token = "0x400088C")]
	public static readonly int maxPointers; //Field offset: 0x0
	[Token(Token = "0x400088D")]
	public static readonly int invalidPointerId; //Field offset: 0x4
	[Token(Token = "0x400088E")]
	public static readonly int mousePointerId; //Field offset: 0x8
	[Token(Token = "0x400088F")]
	public static readonly int touchPointerIdBase; //Field offset: 0xC
	[Token(Token = "0x4000890")]
	public static readonly int touchPointerCount; //Field offset: 0x10
	[Token(Token = "0x4000891")]
	public static readonly int penPointerIdBase; //Field offset: 0x14
	[Token(Token = "0x4000892")]
	public static readonly int penPointerCount; //Field offset: 0x18
	[Token(Token = "0x4000893")]
	public static readonly int trackedPointerIdBase; //Field offset: 0x1C
	[Token(Token = "0x4000894")]
	public static readonly int trackedPointerCount; //Field offset: 0x20
	[Token(Token = "0x4000895")]
	internal static readonly Int32[] screenHoveringPointers; //Field offset: 0x28

	[Address(RVA = "0x1C5BAE0", Offset = "0x1C5ACE0", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E89")]
	private static PointerId() { }

}

