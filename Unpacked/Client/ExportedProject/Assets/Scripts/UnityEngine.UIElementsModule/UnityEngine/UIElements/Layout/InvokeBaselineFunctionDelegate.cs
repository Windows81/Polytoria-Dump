namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005C5")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class InvokeBaselineFunctionDelegate : MulticastDelegate
{

	[Address(RVA = "0x1BA8200", Offset = "0x1BA7400", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002954")]
	public InvokeBaselineFunctionDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x1BA81E0", Offset = "0x1BA73E0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002955")]
	public override float Invoke(ref LayoutNode node, float width, float height) { }

}

