namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
[Token(Token = "0x20001EA")]
public struct PlayerLoopSystem
{
	[Token(Token = "0x20001EB")]
	internal sealed class UpdateFunction : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CCB")]
		public UpdateFunction(object object, IntPtr method) { }

		[Address(RVA = "0x2BC000", Offset = "0x2BB200", Length = "0x16A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CCC")]
		public override void Invoke() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400069A")]
	public Type type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400069B")]
	public PlayerLoopSystem[] subSystemList; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400069C")]
	public UpdateFunction updateDelegate; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400069D")]
	public IntPtr updateFunction; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400069E")]
	public IntPtr loopConditionFunction; //Field offset: 0x20

	[Address(RVA = "0x1989420", Offset = "0x1988620", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CCA")]
	public virtual string ToString() { }

}

