namespace UnityEngine.UIElements;

[Token(Token = "0x20001AE")]
public class MouseCaptureOutEvent : MouseCaptureEventBase<MouseCaptureOutEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001AF")]
	private sealed class <>c
	{
		[Token(Token = "0x40007D3")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C623C0", Offset = "0x1C615C0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000C47")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C48")]
		public <>c() { }

		[Address(RVA = "0x1C60110", Offset = "0x1C5F310", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MouseCaptureEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000C49")]
		internal MouseCaptureOutEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C56D10", Offset = "0x1C55F10", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C44")]
	private static MouseCaptureOutEvent() { }

	[Address(RVA = "0x1C56DF0", Offset = "0x1C55FF0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseCaptureEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000C46")]
	public MouseCaptureOutEvent() { }

	[Address(RVA = "0x1C56CB0", Offset = "0x1C55EB0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateCursorStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000C45")]
	protected private virtual void PreDispatch(IPanel panel) { }

}

