namespace UnityEngine.UIElements;

[Token(Token = "0x20002A9")]
internal sealed class HierarchyEvent : MulticastDelegate
{

	[Address(RVA = "0x17CD5F0", Offset = "0x17CC7F0", Length = "0x125")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001229")]
	public HierarchyEvent(object object, IntPtr method) { }

	[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600122A")]
	public override void Invoke(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

}

