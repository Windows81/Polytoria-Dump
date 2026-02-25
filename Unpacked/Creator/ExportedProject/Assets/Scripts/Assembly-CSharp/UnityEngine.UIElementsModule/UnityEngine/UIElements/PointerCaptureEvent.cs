namespace UnityEngine.UIElements;

[Token(Token = "0x20001AB")]
public class PointerCaptureEvent : PointerCaptureEventBase<PointerCaptureEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001AC")]
	private sealed class <>c
	{
		[Token(Token = "0x40007D2")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C61FD0", Offset = "0x1C611D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000C40")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C41")]
		public <>c() { }

		[Address(RVA = "0x1C604C0", Offset = "0x1C5F6C0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PointerCaptureEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000C42")]
		internal PointerCaptureEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C59640", Offset = "0x1C58840", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C3D")]
	private static PointerCaptureEvent() { }

	[Address(RVA = "0x1C59720", Offset = "0x1C58920", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerCaptureEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000C3F")]
	public PointerCaptureEvent() { }

	[Address(RVA = "0x1C595E0", Offset = "0x1C587E0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "UpdateHoverPseudoStateAfterCaptureChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C3E")]
	protected private virtual void PreDispatch(IPanel panel) { }

}

