namespace UnityEngine.InputForUI;

[Token(Token = "0x200002D")]
internal struct EventSanitizer
{
	[Token(Token = "0x200002E")]
	private interface IEventSanitizer
	{

		[Token(Token = "0x60000EE")]
		public void AfterProviderUpdate() { }

		[Token(Token = "0x60000ED")]
		public void BeforeProviderUpdate() { }

		[Token(Token = "0x60000EF")]
		public void Inspect(in Event ev) { }

		[Token(Token = "0x60000EC")]
		public void Reset() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E1")]
	private IEventSanitizer[] _sanitizers; //Field offset: 0x0

	[Address(RVA = "0x19D1490", Offset = "0x19D0690", Length = "0x120")]
	[CalledBy(Type = typeof(EventProvider), Member = "NotifyUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventSanitizer), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000EA")]
	public void AfterProviderUpdate() { }

	[Address(RVA = "0x19D15C0", Offset = "0x19D07C0", Length = "0x11F")]
	[CalledBy(Type = typeof(EventProvider), Member = "NotifyUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventSanitizer), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E9")]
	public void BeforeProviderUpdate() { }

	[Address(RVA = "0x19D16E0", Offset = "0x19D08E0", Length = "0x124")]
	[CalledBy(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventSanitizer), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000EB")]
	public void Inspect(in Event ev) { }

	[Address(RVA = "0x19D1810", Offset = "0x19D0A10", Length = "0x13B")]
	[CalledBy(Type = typeof(EventProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSanitizer), Member = "BeforeProviderUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSanitizer), Member = "AfterProviderUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSanitizer), Member = "Inspect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E8")]
	public void Reset() { }

}

