namespace UnityEngine;

[Token(Token = "0x200000D")]
internal class GCHandlePool
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000021")]
	private GCHandle[] m_handles; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000022")]
	private int m_current; //Field offset: 0x18

	[Address(RVA = "0x1917690", Offset = "0x1916890", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004D")]
	public GCHandlePool() { }

	[Address(RVA = "0x1917590", Offset = "0x1916790", Length = "0xFE")]
	[CalledBy(Type = typeof(AnimationEventBlittable), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GCHandle), Member = "GetTargetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr), typeof(GCHandleType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	public void Free(GCHandle h) { }

}

